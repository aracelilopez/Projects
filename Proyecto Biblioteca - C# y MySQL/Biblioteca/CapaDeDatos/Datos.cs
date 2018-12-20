using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class Datos
    {
        static MySqlDataAdapter da = null;
        static MySqlCommand cmd = null;
        static DataSet ds = null;
        static MySqlConnection con = null;
        static string strCon = "server=localhost;database=biblioteca;user id=root;password=;Allow zero Datetime=false;Convert Zero Datetime=true;";



        //public static void setRutaExe(string ruta)
        //{
        //    strCon = ruta + @"\Biblioteca.accdb";
        //}

        //public Datos()
        //{

        //}

        // CLIENTE--------------------------------------------------------------------------------------------------------------------------

        public static void guardaCliente(ArrayList datos)
        {
            int codigo = int.Parse(datos[0].ToString());
            int dni = int.Parse(datos[1].ToString());
            string nombre = datos[2].ToString();
            string apellido = datos[3].ToString();
            string localidad = datos[4].ToString();
            bool variable = bool.Parse(datos[5].ToString());

            //bool todoBien = false;
            string consulta = "INSERT INTO Cliente Values (" + codigo + "," + dni + ",'" + nombre + "','" + apellido + "','" + localidad + "'," + variable + ");";

            try
            {
                Datos.con = new MySqlConnection(strCon);
                Datos.con.Open();
                Datos.cmd = new MySqlCommand(consulta, Datos.con);
                Datos.cmd.ExecuteNonQuery();
                Datos.cmd.Dispose();
                Datos.con.Close();
                //todoBien = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            //return todoBien;
        }

        public ArrayList RecuperaCliente()
        {
            con = new MySqlConnection(strCon);

            ds = new DataSet();
            ArrayList Cliente = new ArrayList();
            try
            {
                con.Open();
                string consulta = "SELECT * FROM Cliente";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ArrayList datoscli = new ArrayList();
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                    datoscli.Add(ds.Tables[0].Rows[i].ItemArray[5]);

                    Cliente.Add(datoscli);
                }
                da.Dispose();
            }
            catch (Exception error)
            {
                string s = error.Message;
            }
            finally
            {
                con.Close();
            }
            return Cliente;
        }


        public static void modificarClienteBD(int codigoCli, int dni, string nombre, string apellido, string localidad)
        {



            string consulta = "UPDATE Cliente SET Dni=" + dni + ",Nombre='" + nombre + "',Apellido='" + apellido + "', Localidad='" + localidad + "' WHERE Codigo=" + codigoCli + ";";



            try
            {
                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public static void eliminarCliente(int id)
        {
            string consulta = "DELETE FROM Cliente WHERE Cozdigo= " + id + ";";
            try
            {

                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }


        // LIBRO--------------------------------------------------------------------------------------------------------------------------

        public static void guardaLibro(ArrayList datos)
        {
            int isbn = int.Parse(datos[0].ToString());
            int ejemplar = int.Parse(datos[1].ToString());
            string titulo = datos[2].ToString();
            string autor = datos[3].ToString();
            string editorial = datos[4].ToString();
            string genero = datos[5].ToString();
            string estado = datos[6].ToString();

            //bool todoBien = false;
            string consulta = "INSERT INTO Libro Values (" + isbn + "," + ejemplar + ",'" + titulo + "','" + autor + "','" + editorial + "','" + genero + "','" + estado + "');"; ;

            try
            {
                Datos.con = new MySqlConnection(strCon);
                Datos.con.Open();
                Datos.cmd = new MySqlCommand(consulta, Datos.con);
                Datos.cmd.ExecuteNonQuery();
                Datos.cmd.Dispose();
                Datos.con.Close();

                //todoBien = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            //return todoBien;
        }

        public ArrayList RecuperarLibro()
        {
            con = new MySqlConnection(strCon);

            ds = new DataSet();
            ArrayList Libro = new ArrayList();
            try
            {
                con.Open();
                string consulta = "SELECT * FROM Libro";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ArrayList datosLib = new ArrayList();
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[5]);
                    datosLib.Add(ds.Tables[0].Rows[i].ItemArray[6]);

                    Libro.Add(datosLib);
                }
                da.Dispose();
            }
            catch (Exception error)
            {
                string s = error.Message;
            }
            finally
            {
                con.Close();
            }
            return Libro;
        }

        public static void modificarLibroBD(string estado, int isbn, int ejemplar)
        {



            string consulta = "UPDATE Libro SET Estado='" + estado + "' WHERE Isbn=" + isbn + "and Ejemplar=" + ejemplar + ";";
            //string consulta = "UPDATE Prestamo SET FechaDevolucion= '" + fecha + "' WHERE Codigo=" + codigo + ";";


            try
            {
                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public static void eliminarLibro(int isbn,int ejemplar)
        {
            string consulta = "DELETE FROM Libro WHERE Isbn= " + isbn + " and Ejemplar=" + ejemplar + ";";
            try
            {

                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        // PRESTAMO--------------------------------------------------------------------------------------------------------------------------

        public static void guardaPrestamo(ArrayList datos)
        {

            int codigo = int.Parse(datos[0].ToString());
            int codigocliente = int.Parse(datos[1].ToString());
            int isbn = int.Parse(datos[2].ToString());
            int ejemplar = int.Parse(datos[3].ToString());
            DateTime fechahoy = DateTime.Parse(datos[4].ToString());
            DateTime fechadevolu = DateTime.Parse(datos[5].ToString());

            //bool todoBien = false;
            string consulta = "INSERT INTO Prestamo Values (" + codigo + "," + codigocliente + "," + isbn + "," + ejemplar + ",'" + fechahoy + "','" + fechadevolu + "');"; ;

            try
            {
                Datos.con = new MySqlConnection(strCon);
                Datos.con.Open();
                Datos.cmd = new MySqlCommand(consulta, Datos.con);
                Datos.cmd.ExecuteNonQuery();
                Datos.cmd.Dispose();
                Datos.con.Close();

                //todoBien = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            //return todoBien;
        }

        public ArrayList RecuperarPrestamo()
        {
            con = new MySqlConnection(strCon);

            ds = new DataSet();
            ArrayList Prestamo = new ArrayList();
            try
            {
                con.Open();
                string consulta = "SELECT * FROM Prestamo";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ArrayList datosPres = new ArrayList();
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[4]);
                    datosPres.Add(ds.Tables[0].Rows[i].ItemArray[5]);

                    Prestamo.Add(datosPres);
                }
                da.Dispose();
            }
            catch (Exception error)
            {
                string s = error.Message;
            }
            finally
            {
                con.Close();
            }
            return Prestamo;
        }

        public static void modificarPrestamoBD(int codigo, DateTime fecha)
        {

            string consulta = "UPDATE Prestamo SET FechaDevolucion= '" + fecha + "' WHERE Codigo=" + codigo + ";";


            try
            {
                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public static void eliminarPrestamo(int id)
        {
            string consulta = "DELETE FROM Prestamo WHERE Codigo= " + id + ";";
            try
            {

                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        // Reserva--------------------------------------------------------------------------------------------------------------------------

        public static void guardaReserva(ArrayList datos)
        {

            int codigo = int.Parse(datos[0].ToString());
            int codigocliente = int.Parse(datos[1].ToString());
            int isbn = int.Parse(datos[2].ToString());
            int ejemplar = int.Parse(datos[3].ToString());
            DateTime fechaDisponibilidad = DateTime.Parse(datos[4].ToString());


            //bool todoBien = false;
            string consulta = "INSERT INTO Reserva Values (" + codigo + "," + codigocliente + "," + isbn + "," + ejemplar + ",'" + fechaDisponibilidad + "');"; ;

            try
            {
                Datos.con = new MySqlConnection(strCon);
                Datos.con.Open();
                Datos.cmd = new MySqlCommand(consulta, Datos.con);
                Datos.cmd.ExecuteNonQuery();
                Datos.cmd.Dispose();
                Datos.con.Close();

                //todoBien = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            //return todoBien;
        }

        public ArrayList RecuperarReserva()
        {
            con = new MySqlConnection(strCon + "");

            ds = new DataSet();
            ArrayList Reserva = new ArrayList();
            try
            {
                con.Open();
                string consulta = "SELECT * FROM Reserva";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ArrayList datosRes = new ArrayList();
                    datosRes.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                    datosRes.Add(ds.Tables[0].Rows[i].ItemArray[1]);
                    datosRes.Add(ds.Tables[0].Rows[i].ItemArray[2]);
                    datosRes.Add(ds.Tables[0].Rows[i].ItemArray[3]);
                    datosRes.Add(ds.Tables[0].Rows[i].ItemArray[4]);


                    Reserva.Add(datosRes);
                }
                da.Dispose();
            }
            catch (Exception error)
            {
                string s = error.Message;
            }
            finally
            {
                con.Close();
            }
            return Reserva;
        }

        public static void eliminarReserva(int id)
        {
            string consulta = "DELETE FROM Reserva WHERE Codigo= " + id + ";";
            try
            {

                con = new MySqlConnection(strCon);
                con.Open();
                cmd = new MySqlCommand(consulta, con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}
