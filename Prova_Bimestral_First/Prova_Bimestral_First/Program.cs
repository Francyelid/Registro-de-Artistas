using System;

namespace Prova_Bimestral_First
{
    class Program
    {
        static void Main(string[] args)
        {
            //para inicializar o programa
            Console.WriteLine ("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("\n                     ██ ♫ SEJA BEM-VINDO AO NOSSO APLICATIVO ♫ ██");
            Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("\n\n\tÉ a primeira vez que você está aqui. \n\tPor favor, digite o número de artistas quue serão cadastrados.");


            //determinar o tamanho dos vetores
            int tamanho = Convert.ToInt32(Console.ReadLine());

            Artista[] Musico = new Artista[tamanho];

            Console.Clear();

            Index.ImprimeMenu();
        }
    }
}
