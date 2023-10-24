using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7._2.Entities
{
    internal class Palabra
    {
        public string _Palabra {  get; set; }
        public Palabra (string palabra)
        {
            _Palabra = palabra;
        }
    }
}

//Práctica 7. Un palíndromo es una palabra, número o frase que se lee igual hacia adelante que hacia
//atrás, algunos ejemplos de palíndromos son las palabras “ana”, arenera, arepera, anilina, Malayalam,
//Realiza un programa que lea una palabra e indique si se trata de un palíndromo o no.