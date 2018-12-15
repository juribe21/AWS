using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using AccesosDLL.Seguridad;

namespace AccesosDLL.ConexionBD
{
    public class Conexion
    {
        private static string cc = null;

        private static void DC()
        {
            StreamReader sr = new StreamReader(@".\cnx");
            try
            {                
                string cdc = null;               
                cdc = sr.ReadLine();
                cc = Cadena.Des(cdc);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                if (cc == null)
                {
                    DC();
                }
                SqlConnection conexion = new SqlConnection(cc);
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
                return null;
            }
        }
    }
}
