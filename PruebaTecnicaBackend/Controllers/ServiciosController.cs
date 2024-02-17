using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaBackend.Dtos;
using PruebaTecnicaBackend.Models;

namespace PruebaTecnicaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : Controller
    {
        private readonly PruebaTecnicaDBContext _context;

        public ServiciosController(PruebaTecnicaDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Servicios()
        {
            try
            {
                var servicios = _context.Servicios.ToList();
                return Ok(servicios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpGet("{idServicio}")]
        public ActionResult Servicio(int idServicio)
        {

            try
            {
                var servicio = _context.Servicios.FirstOrDefault(servicio => servicio.IdServicio == idServicio);

                if (servicio == null)
                {
                    return NotFound(new { mesagge = "Servicio no encontrado" });
                }

                return Ok(servicio);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }

        }

        [HttpPost]
        public ActionResult Servicio([FromBody] ServicioDto servicio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Servicio servicioDb = new Servicio
                    {
                        NombreServicio = servicio.NombreServicio,
                        DescripcionServicio = servicio.DescripcionServicio
                    };

                    _context.Add(servicioDb);
                    _context.SaveChanges();

                    return Ok(servicioDb);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpPut]
        public ActionResult ActualizarServicio([FromBody] ServicioDto servicio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Servicio servicioDb = _context.Servicios.Find(servicio.IdServicio);
                if (servicioDb == null)
                {
                    return NotFound("Servicio no encontrado");
                }
                servicioDb.NombreServicio = servicio.NombreServicio;
                servicioDb.DescripcionServicio = servicio.DescripcionServicio;

                _context.SaveChanges();

                return Ok(new { message = "Servicio actualizado con éxito!", data = servicioDb });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpDelete("{idServicio}")]
        public ActionResult EliminarServicio(int idServicio)
        {
            try
            {
                Servicio servicioDb = _context.Servicios.Find(idServicio);
                if (servicioDb == null)
                {
                    return NotFound("No se pudo eliminar,servicio no encontrado");
                }
                _context.Remove(servicioDb);
                return Ok(new { message = "Servicio eliminado con éxito!", data = idServicio });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }

        }
    }
    }
