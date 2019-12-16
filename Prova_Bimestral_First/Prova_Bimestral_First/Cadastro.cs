using System;

namespace Prova_Bimestral_First
{
    public class Cadastro
    {
        //adicionar dados
        public static Artista Resigtro(int count)
        {
            int qtdalbuns=1,qtdcancoes=1, a=3, b=3;

            Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄DADOS DO ARTISTA▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");

            Artista Artista = new Artista();

            Artista.CodigoArtista = count;

            Artista.NomeVerdadeiro = "Ana";

            Artista.NomeArtistico = "Banana";

            Artista.Nascimento = new DateTime(2000, 07, 18);

            Artista.Banda = true;

            Artista.NomeBanda = "Bananas de Pijama";

            Artista.EmailArtista = "girlsjustwanna@have.fun";

            Artista.Telefone = "4002-8922";

            Artista.NomeEmrpesario = "Ednaldo Pereira";

            Artista.EmailEmpresario = "ednaldo.pereira@hotmail.com";

            //Artista.TipoTrabalho=

            Artista.QtdAlbuns = 4;

            Artista.QtdComposicoes = 11;

            Artista.MinCache = 666;

            Console.Clear();
            

            do
            {
                Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄DADOS DO ÁLBUM▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                
                var codigoalbum = qtdalbuns;

                var tituloalbum = "Tutti-Frutti";

                var copiasvendidas = 500;

                do {
                    Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄DADOS DAS MÚSICAS▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");



                } while (b != 2);
                
            } while (a != 2);
        
            return Artista; 
    }
    }
}
