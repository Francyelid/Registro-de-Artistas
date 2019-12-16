using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Bimestral_First
{
    public enum TipoTrabalho {Cantor=1, Compositor, Ambos }

    public class Artista
    {
        public int CodigoArtista { get; set; }

        public string NomeVerdadeiro { get; set; }

        public string NomeArtistico { get; set; }

        public DateTime Nascimento { get; set; }

        public bool Banda { get; set; }

        public string NomeBanda { get; set; }

        public string EmailArtista { get; set; }

        public string Telefone { get; set; }

        public string NomeEmrpesario { get; set; }

        public string EmailEmpresario { get; set; }

        TipoTrabalho TipoTrabalho { get; set; }

        public int QtdAlbuns { get; set; }

        public int QtdComposicoes { get; set; }

        public int MinCache { get; set; }

        public Album Albuns = new Album();
    }
}
