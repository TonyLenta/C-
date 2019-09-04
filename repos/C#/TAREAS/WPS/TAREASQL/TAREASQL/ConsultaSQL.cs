using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;


namespace TAREASQL
{
    class ConsultaSQL
    {
        // crea la concecion
        private SqlConnection Coneccion = new SqlConnection("Data Soucer = DESKTOP-CDQTB3O; Initial Catalog = Laboratorios; Integrated Security= true");
        // data set es la que guarda varias tablas y sirve para mostrar las tablas
        private DataSet ds;
        public DataTable MostrarDatos()
        {
            Coneccion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tabla_Laboratorios", Coneccion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds,"tabla");
            Coneccion.Close();
            return ds.Tables["tabla"];
                 
        }
        public DataTable Buscar(String nombre)
        {
            Coneccion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Select * from Tabla_Laboratorios where Nombre like'%{0}%'",nombre), Coneccion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            Coneccion.Close();
            return ds.Tables["tabla"];

        }

        public bool Insertar(string id, string nombre, string apellido)
        {
            Coneccion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Tabla_Laboratorio values {0},'{1},'{2}'",new string[] {id, nombre,apellido }),Coneccion);
            int filasafectadas = cmd.ExecuteNonQuery();
            Coneccion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }


        public bool Eliminar(string id)
        {
            Coneccion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Tabla_Laboratorios where ID={0}",id),Coneccion);
            int filasafectadas = cmd.ExecuteNonQuery();
            Coneccion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id,string nombre,string apellido,string precio)
        {
            Coneccion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Tabla_laboratorios set Nombre={0},Precio={1} where ID={2}", new string[] { nombre,precio,id }), Coneccion);
            int filasafectadas = cmd.ExecuteNonQuery();
            Coneccion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

    }
}
