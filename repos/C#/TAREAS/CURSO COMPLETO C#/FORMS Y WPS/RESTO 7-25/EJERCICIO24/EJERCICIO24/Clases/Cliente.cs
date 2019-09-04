using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente:Persona
    {
        //Atributos propios
        private String categoria;
        private String codigo;

        //Propiedades
        public string Categoria { get => categoria; set => categoria = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //Operacion
        public void generarCodigo()
        {
            this.Codigo = "C" + this.Apellidos.Substring(0, 3) + "16";
        }
    }
}
