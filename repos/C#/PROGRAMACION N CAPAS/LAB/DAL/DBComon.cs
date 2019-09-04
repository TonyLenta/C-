using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class DBComon
    {
        //CADENA DE CONEXCION
        private static string Conn = @"Data Source=DESKTOP-CDQTB3O;Initial Catalog=Laboratorios;Integrated Security=True";
        //

        //CONEXION
        public static IDbConnection Conexion()
        {
            return new SqlConnection(Conn);
        }
        //UTILIZACION DE LOS PROCEDIMIENTOS ALMACENADOS
        public static IDbCommand ObtenerComando(string pComando, IDbConnection pCnn)
        {
            return new SqlCommand(pComando, pCnn as SqlConnection);
        }
    }
}
