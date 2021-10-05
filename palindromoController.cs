using System.Security.AccessControl;
 /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 2: Palíndromo de palabras
    Nombre del alumno:Brahim Eduardo Aldana Chuc
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Palindromo.Entities;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace Palindromo.Controllers
{

    [ApiController]
    [Route("Api/[controller]")]
    public class palindromosController : ControllerBase

    {

      [HttpPost]
        public string POST(Enunciado f)
        {
            string Enunciado = f.frase.Replace(" ", String.Empty).ToLower();
            string caracter;
            string inverso = "";
            string mensaje;

            int i = Enunciado.Length;
            MatchCollection wordColl = Regex.Matches(f.frase, @"[\W]+");
            for(int x = (i - 1); x >= 0; x--)
            {
                caracter = Enunciado.Substring(x, 1);
                inverso = inverso + caracter;
            }

            if (Enunciado == inverso) //si mi enunciado es igual a lo inverso mando mensaje de que si es, si no es igual se pasa a else 
            {
                mensaje = "Esta frase es palindromo";
            }
            else
            {
                mensaje = " Esta frase no es palindromo";
            }

        //Se creo mi constructor pa 
            Palindromo pa = new Palindromo() 
            {
                Enunciado = f.frase, Resultado = mensaje, 
                Cantidad_Palabras = (wordColl.Count + 1)
            };

            string json = JsonSerializer.Serialize(pa);
            return json;

        }

    }

}