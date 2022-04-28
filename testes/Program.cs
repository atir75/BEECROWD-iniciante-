using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int cod, horas;
            float vlrecebido, salario;

            Console.Write("Digite o código do funcionário: ");
            cod = int.Parse(Console.ReadLine());

            Console.Write("Digite o tempo de horas trabalhado: ");
            horas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor recebido por hora: ");
            vlrecebido = float.Parse(Console.ReadLine());

            salario = horas * vlrecebido;

            Console.WriteLine("O salário é de: "+salario);
            Console.ReadKey();
        }
    }
}
