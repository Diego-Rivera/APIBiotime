using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIBiotime.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace APIBiotime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaReporte : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> getMarcas(string? rut, DateTime? fechaInicio, DateTime? fechaTermino)
        {
            try
            {
                using (BiotimeContext contexto = new BiotimeContext())
                {
                    
                    //Sólo rut
                    if (rut != null && fechaInicio==null && fechaTermino==null)
                    {
                        var lista = await (from ic in contexto.IclockTransactions
                                           join
                                        t in contexto.IclockTerminals on ic.TerminalId equals t.Id
                                           join
                                        pe in contexto.PersonnelEmployees on ic.EmpCode equals pe.EmpCode
                                        where (ic.EmpCode == rut) && (ic.PunchState == "0" || ic.PunchState == "1")
                                           select new
                                           {
                                               rut = ic.EmpCode,
                                               nombre = pe.FirstName + " " + pe.LastName,
                                               tipoMarca=ic.PunchState,
                                               fechahora=ic.PunchTime,
                                               serial=ic.TerminalSn,
                                               nombreReloj=ic.TerminalAlias

                                           }).ToListAsync();
                        return Ok(lista);
                    }

                    //Rut e Inicio
                    if (rut != null && fechaInicio != null && fechaTermino == null)
                    {
                        DateTime lala = DateTime.Parse(fechaInicio.ToString());

                        fechaInicio = DateTime.SpecifyKind(lala, DateTimeKind.Utc);
                        


                        var lista = await (from ic in contexto.IclockTransactions
                                           join
                                        t in contexto.IclockTerminals on ic.TerminalId equals t.Id
                                           join
                                        pe in contexto.PersonnelEmployees on ic.EmpCode equals pe.EmpCode
                                           where ic.EmpCode == rut && ic.PunchTime>fechaInicio
                                           select new
                                           {
                                               rut = ic.EmpCode,
                                               nombre = pe.FirstName + " " + pe.LastName,
                                               tipoMarca = ic.PunchState,
                                               fechahora = ic.PunchTime,
                                               serial = ic.TerminalSn,
                                               nombreReloj = ic.TerminalAlias

                                           }).ToListAsync();
                        return Ok(lista);
                    }


                    //Rut, Inicio, Fin
                    if (rut != null && fechaInicio != null && fechaTermino != null)
                    {
                        DateTime lala = DateTime.Parse(fechaInicio.ToString());

                        fechaInicio = DateTime.SpecifyKind(lala, DateTimeKind.Utc);

                        DateTime lolo = DateTime.Parse(fechaTermino.ToString());

                        fechaTermino = DateTime.SpecifyKind(lolo, DateTimeKind.Utc);



                        var lista = await (from ic in contexto.IclockTransactions
                                           join
                                        
                                        pe in contexto.PersonnelEmployees on ic.EmpCode equals pe.EmpCode
                                           where ic.EmpCode == rut && ic.PunchTime >= fechaInicio && ic.PunchTime<=fechaTermino
                                           select new
                                           {
                                               rut = ic.EmpCode,
                                               nombre = pe.FirstName + " " + pe.LastName,
                                               tipoMarca = ic.PunchState,
                                               fechahora = ic.PunchTime,
                                               serial = ic.TerminalSn,
                                               nombreReloj = ic.TerminalAlias

                                           }).ToListAsync();
                        return Ok(lista);
                    }

                    //Sólo Inicio
                    if (rut == null && fechaInicio != null && fechaTermino == null)
                    {
                        DateTime lala = DateTime.Parse(fechaInicio.ToString());

                        fechaInicio = DateTime.SpecifyKind(lala, DateTimeKind.Utc);



                        var lista = await (from ic in contexto.IclockTransactions
                                           join
                                        t in contexto.IclockTerminals on ic.TerminalId equals t.Id
                                           join
                                        pe in contexto.PersonnelEmployees on ic.EmpCode equals pe.EmpCode
                                           where ic.PunchTime > fechaInicio
                                           select new
                                           {
                                               rut = ic.EmpCode,
                                               nombre = pe.FirstName + " " + pe.LastName,
                                               tipoMarca = ic.PunchState,
                                               fechahora = ic.PunchTime,
                                               serial = ic.TerminalSn,
                                               nombreReloj = ic.TerminalAlias

                                           }).ToListAsync();
                        return Ok(lista);
                    }


                    //Sólo Inicio y fin
                    if (rut == null && fechaInicio != null && fechaTermino != null)
                    {
                        DateTime lala = DateTime.Parse(fechaInicio.ToString());

                        fechaInicio = DateTime.SpecifyKind(lala, DateTimeKind.Utc);

                        DateTime lolo = DateTime.Parse(fechaTermino.ToString());

                        fechaTermino = DateTime.SpecifyKind(lolo, DateTimeKind.Utc);



                        var lista = await (from ic in contexto.IclockTransactions
                                           join
                                        t in contexto.IclockTerminals on ic.TerminalId equals t.Id
                                           join
                                        pe in contexto.PersonnelEmployees on ic.EmpCode equals pe.EmpCode
                                           where ic.PunchTime > fechaInicio && ic.PunchTime<=fechaTermino
                                           select new
                                           {
                                               rut = ic.EmpCode,
                                               nombre = pe.FirstName + " " + pe.LastName,
                                               tipoMarca = ic.PunchState,
                                               fechahora = ic.PunchTime,
                                               serial = ic.TerminalSn,
                                               nombreReloj = ic.TerminalAlias

                                           }).ToListAsync();
                        return Ok(lista);
                    }


                    return BadRequest(new { message = "Se debe pasar algún parámetro" });
                    
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            
        }






    }
}
