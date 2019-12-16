using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Bimestral_First
{//♪
    public class Index
    {
        public static void ImprimeMenu()
        {
            int count=0,op = 9;
            while (op != 0) {
            //aqui o usuário ira escolher uma opção
            Console.WriteLine(" Selecione uma opção:");
            Console.WriteLine("\t1. Novo Cadastro.");
            Console.WriteLine("\t2. Buscar um álbum.");
            Console.WriteLine("\t3. Listar álbuns com o lançamento para o próximo mês.");//metade das composições precisam ser do mesmo artista!!!
            Console.WriteLine("\t4. Listar os cantores que compõe as suas músicas.");//precisam ter  mais de 10 canções compostas em álbuns já lançados e três álbuns na carreira como cantor
            Console.WriteLine("\t5. E-mails dos empresários.");
            Console.WriteLine("\t6. Buscar cachês mais caros.");

            Console.WriteLine("\t0. Fechar Programa.");

            op = Convert.ToInt32(Console.ReadLine());

            //função que irá selecionar a opção do usuário
            Index.Opcao(op,count);
            }
        }

        public static void Opcao(int OpSel,int count)
        {
            Console.Clear(); 

            switch(OpSel)
            {
                //novo  cadastro
                case 1:
                    Cadastro.Resigtro(count);
                    count++;
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 0:
                    Console.WriteLine  ("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine("\n                     ██ ♫      O PROGRAMA SERÁ ENCERRADO        ♫ ██");
                    Console.WriteLine("\n                     ██ ♫ ATÉ MAIS, E OBRIGADO PELA PREFERÊNCIA ♫ ██");
                    Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Environment.Exit(1000);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }
}
