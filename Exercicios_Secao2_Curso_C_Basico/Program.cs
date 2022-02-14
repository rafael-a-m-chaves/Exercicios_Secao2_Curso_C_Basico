using System;

namespace Exercicios_Secao2_Curso_C_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa para solicitar o nome de usuario e a idade.

            Console.WriteLine("Olá, Digite seu nome:");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine(nomeUsuario + ", Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            
            int anoNascimentoAproximado = DateTime.Now.Year - idade;
            
            Console.WriteLine(nomeUsuario + ", o ano aproximado do seu nascimento é: " + anoNascimentoAproximado);

            Console.ReadKey();
        }
    }
}
