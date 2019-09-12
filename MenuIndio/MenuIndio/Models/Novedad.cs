using System;
using System.Collections.Generic;
using System.Text;

namespace MenuIndio.Models
{
    public class Novedad
    {
        public Novedad( string pTitulo, string pTexto, string pFoto, string pURL)
        {
            Titulo = pTitulo;
            Texto = pTexto;
            Foto = pFoto;
            URL = pURL;
        }

        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Foto { get; set; }

        public string URL { get; set; }

    }
}
