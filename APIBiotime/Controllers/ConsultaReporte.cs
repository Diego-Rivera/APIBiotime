using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIBiotime.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using APIBiotime.Datos;
using System;
using Npgsql;
using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Any;
using System.Globalization;
using System.Security.Cryptography;

namespace APIBiotime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaReporte : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> getMarcas(string? rut, DateTime? fechaInicio, DateTime? fechaTermino)
        {

            DatosPostgreSQL dp = new DatosPostgreSQL();

            string sql = "";
            string añoI="", añoT="", mesI="", mesT="", diaI="", diaT="";
            if (fechaInicio != null)
            {
                añoI= fechaInicio.Value.Year.ToString();
                mesI= fechaInicio.Value.Month.ToString();
                if (mesI.Length == 1)
                    mesI = "0" + mesI;

                diaI=fechaInicio.Value.Day.ToString();
                if(diaI.Length==1)
                    diaI= "0" + diaI;
            }

            if (fechaTermino != null)
            {
                añoT = fechaTermino.Value.Year.ToString();
                mesT = fechaTermino.Value.Month.ToString();
                if (mesT.Length == 1)
                    mesT = "0" + mesT;

                diaT = fechaTermino.Value.Day.ToString();
                if (diaT.Length == 1)
                    diaT = "0" + diaT;
            }



            try
            {
                //Sólo rut
                if (rut != null && fechaInicio == null && fechaTermino == null)
                {
                    sql = "select lpad(it.emp_code, 8, '0') as rut,pe.First_Name || ' ' || pe.Last_Name as nombre,it.punch_state as tipoMarca,to_char(timezone('CLST', it.punch_time), 'yyyy-MM-DD') || 'T' || to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') || 'Z' as fechaHora, it.terminal_sn serial, it.terminal_alias, it.punch_time marca, (extract(timezone from it.punch_time)/3600) as zona from iclock_transaction it join personnel_employee pe on it.emp_id = pe.id where  it.emp_code = '" + rut+ "' and (it.punch_state ='1' or it.punch_state ='0') order by it.emp_code, it.punch_time desc";


                }

                //Rut y fecha Inicio
                if(rut!=null && fechaInicio!=null && fechaTermino==null)
                {
                    sql = "select lpad(it.emp_code, 8, '0') as rut,pe.First_Name || ' ' || pe.Last_Name as nombre,it.punch_state as tipoMarca,to_char(timezone('CLST', it.punch_time), 'yyyy-MM-DD') || 'T' || to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') || 'Z' as fechaHora, it.terminal_sn serial, it.terminal_alias, it.punch_time marca, (extract(timezone from it.punch_time)/3600) as zona from iclock_transaction it join personnel_employee pe on it.emp_id = pe.id where DATE(timezone('CLST', it.punch_time)) >= to_date('" + añoI + "-" + mesI + "-" + diaI + "', 'YYYY-MM-DD') and it.emp_code = '" + rut+ "' and (it.punch_state ='1' or it.punch_state ='0') order by it.emp_code, it.punch_time desc";

                }

                //Rut fechaInicio y FechaTermino
                if (rut != null && fechaInicio != null && fechaTermino != null)
                {
                    sql = "select lpad(it.emp_code, 8, '0') as rut,pe.First_Name || ' ' || pe.Last_Name as nombre,it.punch_state as tipoMarca,to_char(timezone('CLST', it.punch_time), 'yyyy-MM-DD') || 'T' || to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') || 'Z' as fechaHora, it.terminal_sn serial, it.terminal_alias,it.punch_time marca, (extract(timezone from it.punch_time)/3600) as zona from iclock_transaction it join personnel_employee pe on it.emp_id = pe.id where DATE(timezone('CLST', it.punch_time)) >= to_date('" + añoI + "-" + mesI + "-" + diaI + "', 'YYYY-MM-DD') and DATE(timezone('CLST', it.punch_time)) <= to_date('" + añoT + "-" + mesT + "-" + diaT + "', 'YYYY-MM-DD') and it.emp_code = '" + rut+ "' and (it.punch_state ='1' or it.punch_state ='0') order by it.emp_code, it.punch_time desc";

                }

                //Sin rut, sólo fecha inicio
                if (rut == null && fechaInicio != null && fechaTermino == null)
                {
                    sql = "select lpad(it.emp_code, 8, '0') as rut,pe.First_Name || ' ' || pe.Last_Name as nombre,it.punch_state as tipoMarca,to_char(timezone('CLST', it.punch_time), 'yyyy-MM-DD') || 'T' || to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') || 'Z' as fechaHora, it.terminal_sn serial, it.terminal_alias, it.punch_time marca, (extract(timezone from it.punch_time)/3600) as zona from iclock_transaction it join personnel_employee pe on it.emp_id = pe.id where DATE(timezone('CLST', it.punch_time)) >= to_date('" + añoI + "-" + mesI + "-" + diaI + "', 'YYYY-MM-DD') and (it.punch_state ='1' or it.punch_state ='0') order by it.emp_code, it.punch_time desc";

                }


                //Sin rut, sólo fecha inicio y término
                if (rut == null && fechaInicio != null && fechaTermino != null)
                {
                    sql = "select lpad(it.emp_code, 8, '0') as rut,pe.First_Name || ' ' || pe.Last_Name as nombre,it.punch_state as tipoMarca,to_char(timezone('CLST', it.punch_time), 'yyyy-MM-DD') || 'T' || to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') || 'Z' as fechaHora, it.terminal_sn serial, it.terminal_alias, it.punch_time marca, (extract(timezone from it.punch_time)/3600) as zona from iclock_transaction it join personnel_employee pe on it.emp_code = pe.emp_code where DATE(timezone('CLST', it.punch_time)) >= to_date('" + añoI + "-" + mesI + "-" + diaI + "', 'YYYY-MM-DD') and DATE(timezone('CLST', it.punch_time)) <= to_date('" + añoT + "-" + mesT + "-" + diaT + "', 'YYYY-MM-DD') and (it.punch_state ='1' or it.punch_state ='0') order by it.emp_code, it.punch_time desc";

                }



                if(sql.Length> 0)
                {
                    DataSet dataset = new DataSet();
                    dataset.Tables.Add("datos");
                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sql, dp.conn);
                    adaptador.Fill(dataset, "datos");
                    if (dataset.Tables["datos"].Rows.Count > 0)
                    {
                        DataTable resultado = dataset.Tables["datos"];

                        List<Resultado> lista = new List<Resultado>();


                        foreach (DataRow fila in resultado.Rows)
                        {
                            string zona = fila[3].ToString();
                            string hora = fila[6].ToString();

                            DateTime fechita = DateTime.Parse(hora, System.Globalization.CultureInfo.CurrentCulture);
                            zona = zona.Replace("Z", "");

                            DateTimeOffset dto = DateTimeOffset.ParseExact(zona,
                                "yyyy-MM-dd'T'HH:mm:ss",
                                CultureInfo.InvariantCulture);
                            //Console.WriteLine(dto);
                            zona = dto.Offset.Hours.ToString();

                            if (int.Parse(zona) == -4)
                            {
                                fechita = fechita.AddHours(-1);
                            }

                            string h = fechita.Hour.ToString();
                            if (h.Length == 1)
                                h = "0" + h;
                            string m = fechita.Minute.ToString();
                            if (m.Length == 1)
                                m = "0" + m;

                            Resultado r=new Resultado();
                            r.rut = fila[0].ToString();
                            r.nombre= fila[1].ToString();
                            r.tipoMarca = fila[2].ToString();
                            r.fechahora = fechita.ToString();
                            r.serial = fila[4].ToString();
                            r.nombreReloj = fila[5].ToString();

                            lista.Add(r);

                        }

                        return Ok(lista);


                    }
                    else
                        return BadRequest(new { message = "No hay datos para mostrar" });                  

                    
                }
                else
                {
                    return BadRequest(new { message = "No hay datos para mostrar" });
                }


                
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            
        }






    }
}
