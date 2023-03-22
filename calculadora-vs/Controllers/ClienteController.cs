using calculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculadora.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {

            //codigo fuente

            List<Cliente> listaCliente = new List<Cliente> 
            { 
                new Cliente { 
                    id = 1,
                    nombre = "juliopari",
                    edad = 35,
                    correo = "info@juliopari.com"
                },
                new Cliente
                {
                    id = 2,
                    nombre = "aprendeibm",
                    edad = 5,
                    correo = "info@aprendeibm.com"
                }
            };

            return listaCliente;

        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            cliente.id = 3;

            return new 
            { 
                success = true,
                message = "cliente registrado",
                result = cliente
            };
        }

        [HttpGet]
        [Route("listar1")]
        public dynamic listarUnCliente() {

            //codigo fuente

            return new
            {
                nombre = "juliopari",
                edad = "36",
            };
        }

        [HttpGet]
        [Route("holamundo")]
        public dynamic holaMundo()
        {

            //codigo fuente

            return new { 
                msg = "Hola mundo 2023"
            };
        }


        /*
        
        */

    }
}
