using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            string valorImportante = "teste";
            Console.WriteLine(valorImportante.Length);

            string valorNulo = null;
            Console.WriteLine(valorNulo?.Length);
        }
    }
}