using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace MenuIndio.Models
{
    class PuntoDeInteres
    {
        public PuntoDeInteres(string pNombre, string pDescripcion, string pIcono ,Position pPosition){
            Nombre = pNombre;
            Descripcion = pDescripcion;
            Icono = pIcono;
            Posicion = pPosition;
        }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Icono { get; set; }
        public Position Posicion { get; set; }
    }
}
