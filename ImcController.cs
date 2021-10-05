
 /* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 1: Calcular el IMC de una persona
    Nombre del alumno: Brahim Eduardo Aldana Chuc
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
using Microsoft.AspNetCore.Http;
using System.Xml.Serialization;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalcularImc.Controllers;
using CalcularImc.Entities;


namespace CalcularImc.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ImcController : ControllerBase
    {
         [HttpPost]
        public string Calcular( IMC persona )
        {    
            String mensaje="";
             double Resultado;

            Resultado = (persona.peso / Math.Pow((persona.altura/100), 2));

           
            if(Resultado < 18.5)
            {
                 mensaje= "  es inferior a lo normal";
            }
            else
            {
                if(Resultado>= 18.5  && Resultado <=24.9)
                {
                     mensaje="normal";
                }
                else
                {
                    if(Resultado>=25.00 && Resultado <= 29.9)
                    {
                         mensaje="esta mas alto de lo normal";
                    }
                    else
                    {
                         mensaje=" obesidad";
                    }
                }
                
            }
          return "El imc de esta persona es: "+ Convert.ToString(Resultado)+ "\n" + "peso:"+ mensaje;
           
        
        }

    }
    
}