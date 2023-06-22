using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            do
            {
                Console.WriteLine("Informe o Sexo, (F) para Feminino, (M) para Mascolino: ");
                sexo = char.Parse(Console.ReadLine());
            }
            while (sexo != 'M' && sexo != 'F');
            Console.WriteLine("Sexo {0}", sexo);
        }
    }
}
