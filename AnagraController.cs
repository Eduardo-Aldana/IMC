using Microsoft.AspNetCore.Mvc;
using AnagramaPalabras.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;



namespace AnagramaPalabras.Controllers
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 3: Anagrama de Palabras
    Nombre del alumno: Brahim Eduardo Aldana Chuc
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */

    [ApiController]
    [Route("Api/[controller]")]
    public class AnagraController : ControllerBase
    {
        public string Post (AnagramaPa palabras)

        {

            string ana = "Si es un anagrama";

            string linda = "No es un anagrama";



            string num1 = String.Concat(palabras.dato1.OrderBy(c=>c));

            string num2 = String.Concat(palabras.dato2.OrderBy(c=>c));

            if (num1 == num2)

            {

                return ana;

            }

            else

            {

                return linda;

            }

        }

    }

}