using calculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculadora.Controllers
{
    [ApiController]
    [Route("calculadora")]
    public class CalculadoraController
    {
        [HttpPost]
        [Route("sumar")]
        public dynamic calcSumar(CalculadoraRequest calculadoraRequest)
        {
            CalculadoraResponse calculadoraResponse = new CalculadoraResponse();
            calculadoraResponse.resultado = 0;
            calculadoraResponse.resultado = calculadoraRequest.numero1 + calculadoraRequest.numero2;

            return calculadoraResponse;
        }

        [HttpPost]
        [Route("restar")]
        public dynamic calcRestar(CalculadoraRequest calculadoraRequest)
        {
            CalculadoraResponse calculadoraResponse = new CalculadoraResponse();
            calculadoraResponse.resultado = 0;
            calculadoraResponse.resultado = calculadoraRequest.numero1 - calculadoraRequest.numero2;

            return calculadoraResponse;
        }

        [HttpPost]
        [Route("multiplicar")]
        public dynamic calcMultiplicar(CalculadoraRequest calculadoraRequest)
        {
            CalculadoraResponse calculadoraResponse = new CalculadoraResponse();
            calculadoraResponse.resultado = 0;
            calculadoraResponse.resultado = calculadoraRequest.numero1 * calculadoraRequest.numero2;

            return calculadoraResponse;
        }

        [HttpPost]
        [Route("dividir")]
        public dynamic calcDividir(CalculadoraRequest calculadoraRequest)
        {
            CalculadoraResponse calculadoraResponse = new CalculadoraResponse();
            calculadoraResponse.resultado = 0;
            calculadoraResponse.resultado = calculadoraRequest.numero1 / calculadoraRequest.numero2;

            return calculadoraResponse;
        }
    }
}
