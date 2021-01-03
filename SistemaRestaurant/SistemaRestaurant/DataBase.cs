using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //BASE DE DATOS ///


namespace SistemaRestaurant
{
    // Conexíon a BD - José Z
    public static class BD
    {
        public static string connetionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Restaurante;User ID=sa;Password=admin";
        public static SqlConnection cnn = new SqlConnection(connetionString);
        public static SqlConnection cnn2 = new SqlConnection(connetionString);
        public static string nombreUser;


        public static string g_tipo = "tipoEmpleado";
        public static string tipo
        {
            get { return g_tipo; }
            set { g_tipo = value; }
        }
    }
    // ---------------------

    class DataBase
    {
    }
}
