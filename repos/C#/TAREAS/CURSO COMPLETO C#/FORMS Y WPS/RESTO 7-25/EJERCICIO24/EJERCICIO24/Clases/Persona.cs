using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        //Atributos
        private String apellidos;
        private String nombres;
        private String documento;
        private String tipo;
        //Propiedades
        public string Tipo { get => tipo; set => tipo = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
