using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaBackend.Dtos;
using PruebaTecnicaBackend.Models;
using System.Reflection.Metadata.Ecma335;

namespace PruebaTecnicaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly PruebaTecnicaDBContext _context;

        public ClienteController(PruebaTecnicaDBContext context) { 
            _context = context;
         }

        [HttpGet]
        public ActionResult Clients()
        {
            try
            {
                var clientes = _context.Clientes.ToList();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpGet("{idCliente}")]
        public ActionResult Cliente(int idCliente) {

            try
            {
                var cliente = _context.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);

                if (cliente == null)
                {
                    return NotFound(new { mesagge="Cliente no encontrado"}); 
                }

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " +ex.Message);
            }

        }

        [HttpPost]
        public ActionResult Cliente([FromBody] ClienteDto cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cliente clienteDb = new Cliente
                    {
                        NombreCliente = cliente.NombreCliente,
                        CorreoCliente = cliente.CorreoCliente
                    };

                    _context.Add(clienteDb);
                    _context.SaveChanges();

                    return Ok(clienteDb);
                }
                else
                {
                    return BadRequest(ModelState); 
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: "+ex.Message);
            }
        }
        [HttpPut]
        public ActionResult ActualizarCliente([FromBody] ClienteDto cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Cliente clienteDb = _context.Clientes.Find(cliente.IdCliente);
                if (clienteDb == null)
                {
                    return NotFound("Cliente no encontrado");
                }
                clienteDb.NombreCliente = cliente.NombreCliente;
                clienteDb.CorreoCliente = cliente.CorreoCliente;
                _context.SaveChanges();

                return Ok(new {message="Cliente actualizado con éxito!", data = clienteDb});
            }catch(Exception ex)
            {
                return StatusCode(500,"Error interno del servidor: " +ex.Message);
            }
        }
        [HttpDelete("{idCliente}")]
        public ActionResult EliminarCliente(int idCliente)
        {
            try
            {
                Cliente clienteDb = _context.Clientes.Find(idCliente);
                if (clienteDb == null)
                {
                    return NotFound("No se pudo eliminar,cliente no encontrado");
                }
                _context.Remove(clienteDb);
                return Ok(new { message = "Cliente eliminado con éxito!", data = idCliente });
            }catch(Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
            
        }
    }
}
