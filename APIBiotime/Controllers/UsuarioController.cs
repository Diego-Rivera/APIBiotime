using APIBiotime.Clases;
using APIBiotime.Models;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.IO;

namespace APIBiotime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> postUsuario(UsuarioWeb nuevo)
        {
            try
            {
                using (BiotimeContext contexto = new BiotimeContext())
                {

                    var existe = (from u in contexto.UsuarioWebs where u.Email == nuevo.Email select u).FirstOrDefault();

                    if(existe != null)
                    {
                        return BadRequest(new { message = "No se puede crear el usuario, el email no se puede repetir" });
                    }


                    contexto.UsuarioWebs.Add(nuevo);
                    try
                    {
                        await contexto.SaveChangesAsync();
                    }
                    catch(DbUpdateException ex)
                    {
                        
                        return BadRequest(new { message = "Error el guardar el usuario " + ex.InnerException.Message });
                    }

                    return Ok("Usuario creado exitosamente");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

            
        }


        [HttpGet("getUsuario/{rut},{password}")]
        public async Task<IActionResult> getUsuario(string rut, string password)
        {

            try
            {
                using (BiotimeContext contexto = new BiotimeContext())
                {


                    var res = await (from u in contexto.UsuarioWebs where u.Rut == rut && u.Pass == password select u).FirstOrDefaultAsync();

                    if (res != null)
                    {
                        return Ok(res);
                    }
                    else
                    {
                        return BadRequest(new { message = "El nombre de usuario o el password no corresponden" });
                    }

                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> putUsuario(UsuarioWeb cambiado)
        {
            try
            {
                using(BiotimeContext contexto=new BiotimeContext())
                {
                    var usu = (from u in contexto.UsuarioWebs where u.Rut == cambiado.Rut select u).FirstOrDefault();
                    if (usu != null)
                    {
                        usu.Nombre= cambiado.Nombre;
                        usu.Email= cambiado.Email;
                        usu.Pass= cambiado.Pass;
                        await contexto.SaveChangesAsync();
                        return Ok(new {message="datos modificados correctamente"});
                    }
                    else
                    {
                        return BadRequest(new { message = "No se pudo encontrar al usuario seleccionado" });
                    }
                }
                
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = "No se pudo actualizar el usuario" });
            }
            
        }


        [HttpPost("content/upload-file")]
        public IActionResult Upload(IFormFile file)
        {
            List<Usuario> lista= new List<Usuario>();

            using (TextReader reader = new StreamReader(file.OpenReadStream()))
            {
                var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";" };
                CsvReader csv = new CsvReader(reader, config);
                
                while (csv.Read())
                {
                    Usuario usu=csv.GetRecord<Usuario>();
                    lista.Add(usu); 
                }

                if (lista.Count > 0)
                {
                    using (BiotimeContext contexto = new BiotimeContext())
                    {
                        foreach (Usuario usu in lista)
                        {
                            UsuarioWeb nuevito = new UsuarioWeb();
                            nuevito.Rut = usu.ID;
                            nuevito.Nombre = usu.NOMBRE + " " + usu.APELLIDO;
                            nuevito.Email = usu.EMAIL;
                            if (usu.ID.Length >= 3)
                            {
                                nuevito.Pass = usu.ID.Substring(0, 3);
                            }
                            else
                                nuevito.Pass = usu.ID;

                            nuevito.Pass  += usu.APELLIDO.Substring(Math.Max(0, usu.APELLIDO.Length - 5)) + usu.NOMBRE.Substring(2, 2);
                            
                            contexto.UsuarioWebs.Add(nuevito);
                            
                        }
                        contexto.SaveChanges();
                    }
                    return Ok();
                }
                else
                    return BadRequest();
            }

            

            
        }

    }
}
