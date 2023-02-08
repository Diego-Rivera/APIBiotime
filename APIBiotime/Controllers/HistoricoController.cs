using APIBiotime.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace APIBiotime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoController : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> getHistorico(string? rut, DateTime? fechaInicio, DateTime? fechaTermino, int page = 1, int pageSize = 10 )
        {
            try
            {
                using (BiotimeContext contexto = new BiotimeContext())
                {

                    //Sólo rut
                    if (rut != null && fechaInicio == null && fechaTermino == null)
                    {
                        var lista = await (from h in contexto.Historicos
                                           where h.Rut == rut
                                           select new
                                           {
                                               rut = h.Rut,
                                               nombre = h.Nombre,
                                               fecha = h.Fecha,
                                               horaEntrada = h.Entrada,
                                               horaSalida = h.Salida,
                                               nombreReloj = h.Procedencia

                                           }).ToListAsync();

                        lista=lista.OrderBy(x=>x.fecha).ThenBy(n=>n.horaEntrada).ToList();


                        var data = lista.Skip((page - 1) * pageSize).Take(pageSize);
                        var totalItems = lista.Count();

                        var response = new 
                        {
                            Data = data,
                            PageNumber = page,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                            TotalItems = totalItems
                        };

                        return Ok(response);

                        //return Ok(lista);
                    }

                    //Rut e Inicio
                    if (rut != null && fechaInicio != null && fechaTermino == null)
                    {
                        //DateOnly lala = DateOnly.ParseExact(fechaInicio.ToString(),"dd-MM-yyyy h:mm:ss");                        

                        var lista = await (from h in contexto.Historicos
                                           
                                           where h.Rut == rut && h.Fecha >= fechaInicio
                                           select new
                                           {
                                               rut = h.Rut,
                                               nombre = h.Nombre,
                                               fecha = h.Fecha,
                                               horaEntrada = h.Entrada,
                                               horaSalida = h.Salida,
                                               nombreReloj = h.Procedencia

                                           }).ToListAsync();
                        lista=lista.OrderBy(n=>n.fecha).ThenBy(x=>x.horaEntrada).ToList();

                        var data = lista.Skip((page - 1) * pageSize).Take(pageSize);
                        var totalItems = lista.Count();

                        var response = new
                        {
                            Data = data,
                            PageNumber = page,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                            TotalItems = totalItems
                        };

                        return Ok(response);
                        //return Ok(lista);
                    }


                    //Rut, Inicio, Fin
                    if (rut != null && fechaInicio != null && fechaTermino != null)
                    {

                        //DateOnly lala = DateOnly.ParseExact(fechaInicio.ToString(), "dd-MM-yyyy");
                        //DateOnly lolo = DateOnly.ParseExact(fechaTermino.ToString(), "dd-MM-yyyy");


                        var lista = await (from h in contexto.Historicos
                                           
                                           where h.Rut == rut && h.Fecha >= fechaInicio && h.Fecha<=fechaTermino
                                           select new
                                           {
                                               rut = h.Rut,
                                               nombre = h.Nombre,
                                               fecha = h.Fecha,
                                               horaEntrada = h.Entrada,
                                               horaSalida = h.Salida,
                                               nombreReloj = h.Procedencia

                                           }).ToListAsync();
                        lista = lista.OrderBy(x => x.fecha).ThenBy(n => n.horaEntrada).ToList();

                        var data = lista.Skip((page - 1) * pageSize).Take(pageSize);
                        var totalItems = lista.Count();

                        var response = new
                        {
                            Data = data,
                            PageNumber = page,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                            TotalItems = totalItems
                        };

                        return Ok(response);
                        //return Ok(lista);
                    }

                    //Sólo Inicio
                    if (rut == null && fechaInicio != null && fechaTermino == null)
                    {
                        //DateOnly lala = DateOnly.ParseExact(fechaInicio.ToString(),"dd-MM-yyyy");

                        var lista = await (from h in contexto.Historicos                                           
                                           where h.Fecha >= fechaInicio
                                           select new
                                           {
                                               rut = h.Rut,
                                               nombre = h.Nombre,
                                               fecha= h.Fecha,
                                               horaEntrada = h.Entrada,
                                               horaSalida = h.Salida,
                                               nombreReloj = h.Procedencia

                                           }).ToListAsync();

                        lista = lista.OrderBy(x => x.rut).ThenBy(n => n.fecha).ThenBy(p => p.horaEntrada).ToList();

                        var data = lista.Skip((page - 1) * pageSize).Take(pageSize);
                        var totalItems = lista.Count();

                        var response = new
                        {
                            Data = data,
                            PageNumber = page,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                            TotalItems = totalItems
                        };

                        return Ok(response);
                        //return Ok(lista);
                    }


                    //Sólo Inicio y fin
                    if (rut == null && fechaInicio != null && fechaTermino != null)
                    {
                        //DateOnly lala = DateOnly.ParseExact(fechaInicio.ToString(), "dd-MM-yyyy");
                        //DateOnly lolo = DateOnly.ParseExact(fechaTermino.ToString(), "dd-MM-yyyy");

                        



                        var lista = await (from h in contexto.Historicos
                                           where h.Fecha >= fechaInicio && h.Fecha <= fechaTermino
                                           select new
                                           {
                                               rut = h.Rut,
                                               nombre = h.Nombre,
                                               fecha=h.Fecha,
                                               horaEntrada = h.Entrada,
                                               horaSalida = h.Salida,
                                               nombreReloj = h.Procedencia

                                           }).ToListAsync();

                        lista = lista.OrderBy(n => n.rut).ThenBy(x => x.fecha).ThenBy(x => x.horaEntrada).ToList();

                        var data = lista.Skip((page - 1) * pageSize).Take(pageSize);
                        var totalItems = lista.Count();

                        var response = new
                        {
                            Data = data,
                            PageNumber = page,
                            PageSize = pageSize,
                            TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
                            TotalItems = totalItems
                        };

                        return Ok(response);
                        //return Ok(lista);
                    }


                    return BadRequest(new { message = "Se debe pasar algún parámetro" });

                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }


        }


        //[HttpGet]
        //public async Task<ActionResult<PaginatedResponse<Historico>>> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        //{
        //    var data = _yourDataSource.Skip((page - 1) * pageSize).Take(pageSize);
        //    var totalItems = await _yourDataSource.CountAsync();

        //    var response = new PaginatedResponse<YourModel>
        //    {
        //        Data = data,
        //        PageNumber = page,
        //        PageSize = pageSize,
        //        TotalPages = (int)Math.Ceiling((double)totalItems / pageSize),
        //        TotalItems = totalItems
        //    };

        //    return Ok(response);
        //}



    }
}
