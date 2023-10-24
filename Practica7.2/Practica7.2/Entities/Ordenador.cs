using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7._2.Entities
{
    internal class Ordenador
    {
        public List<Palabra> palabrasIngresadas = new List<Palabra>();
        public List<Palabra> palabrasInvertidas = new List<Palabra>();

        public void AgregarPalabra(string palabra)
        {
            Palabra nueva = new Palabra(palabra);

            palabrasIngresadas.Add(nueva);
        }
        public void InvertirPalabra(string palabra)
        {
            Palabra nueva = new Palabra(palabra);

            char[] palabraChars = palabra.ToCharArray();
            Array.Reverse(palabraChars);
            string palabraInvertida = new string(palabraChars);

            nueva._Palabra = palabraInvertida;

            palabrasInvertidas.Add(nueva);
        }
        public bool EsPalindromo(string palabra)
        {
            palabra = palabra.Trim().ToLower().Replace(" ", "");

            int i = 0, j = palabra.Length - 1;

            while (i < j)
            {
                if (palabra[i] != palabra[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true; 
        }
    }
}
