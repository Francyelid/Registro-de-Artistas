using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Bimestral_First
{
    public class Album
    {
        public int CodigoAlbum { get; set; }

        public string TituloAlbum { get; set; }

        public int [] ListaMusicas { get; set; }  

        public DateTime DataLancamento { get; set; }

        public int CopiasVendidas { get; set; }

        public string[] ListaParticipantes { get; set; }

        public Cancoes Musicas = new Cancoes();
    }
}
