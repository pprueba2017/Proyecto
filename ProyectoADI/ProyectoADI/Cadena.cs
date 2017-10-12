using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoADI
{
    class Cadena
    {
        public SqlConnection Conector;
        public new SqlCommand Ejecutar;
        public SqlDataReader Lector;
        public SqlDataAdapter Adapter;





        //Metodo que abre la coneccion del sistema a la base de datos
        public void Conectar()
        {
            try
            {
                Conector = new SqlConnection("Data Source=DIEGO\\SQLEXPRESS;Initial Catalog=Proyecto_ADI;Persist Security Info=True;User ID=ADI;Password=123456");
                Conector.Open();
            }
            catch { }
        }

        //Metodo que desconecta el sistema de la base de cados
        public void Desconectar()
        {
            Conector.Close();
        }

        //Metodo para modificar la base de datos con los datos que se envian desde el sistema
        //Con este metodo se Inserta, elimina y modifica los datos de la base de datos
        //Nada mas recive la sentenia SQL y la ejecuta con el ExecuteNonQuery
        public void Modificar(string SQL)
        {
            Ejecutar = new SqlCommand(SQL, Conector);
            Ejecutar.ExecuteNonQuery();
        }

        //Metodo de busqueda que debuelve una busqueda en especifico o solo un objeto
        public SqlDataReader Buscar(string SQL)
        {
            try
            {
                Ejecutar = new SqlCommand(SQL, Conector);
                Lector = Ejecutar.ExecuteReader();
            }
            catch { }
            return Lector;
        }

        //Metodo utilizado para obtener toda la tabla solicitada para llenar un DataGriedView
        public SqlDataAdapter DataAdapter(string SQL)
        {
            Conectar();
            Adapter = new SqlDataAdapter(SQL, Conector);
            return Adapter;
        }

    }
}

