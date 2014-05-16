using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Conexion;

namespace Logica
{
    public class Alumno
    {
        int idAlumno, edad, idNivelAcademico;
        string nombre, apellidoPaterno, apellidoMaterno, direccion, telefono;
        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Idgrado
        {
            get { return IdNivelAcademico; }
            set { IdNivelAcademico = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int IdNivelAcademico
        {
            get { return idNivelAcademico; }
            set { idNivelAcademico = value; }
        }

        public void agregar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaseDatos.conn;
            cmd.Connection.Open();
            string sql = "SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno,Edad,FechaDeNacimiento,Direccion,Telefono,IdNivelAcademico FROM WHERE Id=@Id, Nombre=@Nombre,ApellidoPaterno=@ApellidoPaterno,ApellidoMaterno=@ApellidoMaterno,Edad=@Edad,FechaDeNacimiento=@FechaDeNacimiento,Direccion=@Direccion,Telefono=@Telefono,IdNivelAcademico=@IdNivelAcademico";
            cmd.Parameters.AddWithValue("@IdAlumno", IdAlumno);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
            cmd.Parameters.AddWithValue("@Edad", Edad);
            cmd.Parameters.AddWithValue("@FechaDeNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@IdNivelAcademico", IdNivelAcademico);
            cmd.Connection.Close();


        }

        public void Eliminar()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaseDatos.conn;
            cmd.Connection.Open();
            string sql = "DELET FROM WHERE IdAlumno = IdAumno";

            cmd.Connection.Close();


        }


    }
}

