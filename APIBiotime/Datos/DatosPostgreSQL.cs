using Npgsql;
using Npgsql.NodaTime;
using Microsoft.Extensions.Configuration;
using APIBiotime.Clases;
using System.Data;

namespace APIBiotime.Datos
{
    public class DatosPostgreSQL
    {
        public NpgsqlConnection conn;
        public DatosPostgreSQL()
        {
            using IHost host = Host.CreateDefaultBuilder().Build();

            IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

            string con = config.GetValue<string>("ConnectionStrings:WebApiDatabase");

            //string connectionString = config["ConnectionStrings:conn1"];
            //string servidor="", usuario="", password="", baseDatos="", puerto="";


            try
            {
                conn = new NpgsqlConnection();

                //conn.ConnectionString = string.Format("Host = {0}; Username = {1}; Password = {2}; Database ={3}; Port={4}", servidor, usuario, password, baseDatos, puerto);

                conn.ConnectionString= con;

                conn.Open();
            }
            catch (NpgsqlException ex)
            {
                int nro = ex.ErrorCode;

                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //IDictionary nro = ex.Data;

                throw new Exception(ex.Message);
            }
        }


        public DataTable Buscar(string fecha)
        {

            string sql = "select lpad(it2.id::text, 3, '0') as reloj, " +
                "lpad(it.emp_code, 8,'0') as rut, " +
                "to_char(it.punch_time, 'DD/MM/yyyy') as fecha, " +
                "to_char(timezone('CLST', it.punch_time), 'HH24:MI:SS') as hora, " +
                "case " +
                    "when it.punch_state = '0' then 'IN' " +
                    "when it.punch_state = '1' then 'OT' " +
                "end as estado, " +
                "it.punch_time, " +
                "extract(timezone from it.punch_time)/3600 as zona " +
                "from iclock_transaction it " +
                "join iclock_terminal it2 ON it.terminal_id =it2.id " +
                "where DATE(timezone('CLST', it.punch_time)) = to_date('" + fecha + "', 'YYYY-MM-DD') " +
                "order by it.emp_code, it.punch_time asc";


            DataSet dataset = new DataSet();
            dataset.Tables.Add("datos");
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(sql, conn);
            adaptador.Fill(dataset, "datos");
            return dataset.Tables["datos"];

        }
    }
}
