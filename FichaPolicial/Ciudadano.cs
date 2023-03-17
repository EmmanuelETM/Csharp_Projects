using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPolicial
{
    public class Ciudadano
    {
        private int IDCiudadano, Edad;
        private string Nombres, Apellidos, Cedula, Nacionalidad;
        private ArrayList Fichas;
        private char Sexo;
        private bool Activo;

        public Ciudadano() { }//Constructor Vacio

        public Ciudadano(int iDCiudadano, int edad, int cantidaddelitos, string nombres, string apellidos, string cedula, string nacionalidad, char sexo, bool activo)
        {
            this.IDCiudadano = iDCiudadano;
            this.Edad = edad;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Cedula = cedula;
            this.Sexo = sexo;
            this.Nacionalidad = nacionalidad;
            this.Fichas= new ArrayList();
            this.Activo = activo;
            
        }//Constructor de 6 parametros

        //Metodos de Acceso

        //Get
        public int GetIDCiudadano() { return IDCiudadano; }
        public int GetEdad() { return Edad; }
        public string GetNombres() { return Nombres; }
        public string GetApellidos()
        {
            return Apellidos;
        }
        public string GetCedula()
        {
            return Cedula;
        }
        public string GetNacionalidad()
        {
            return Nacionalidad;
        }
        public bool GetActivo()
        {
            return Activo;
        }
        public char GetSexo()
        {
            return Sexo;
        }
        public ArrayList GetAficha()
        {
            return Fichas;
        }

        //Set
        public void SetIDCiudadano(int idciudadano)
        {
            this.IDCiudadano = idciudadano;
        }
        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }
        public void SetNombres(string nombres)
        {
            this.Nombres = nombres;
        }
        public void SetApellidos(string apellidos)
        {
            this.Apellidos = apellidos;
        }
        public void SetCedula(string cedula)
        {
            this.Cedula = cedula;
        }
        public void SetNacionalidad(string nacionalidad)
        {
            this.Nacionalidad = nacionalidad;
        }
        public void SetActivo(bool activo)
        {
            this.Activo = activo;
        }
        public void SetSexo(char sexo)
        {
            this.Sexo = sexo;
        }
        public void SetAfichas(ArrayList fichas)
        {
            this.Fichas = fichas;
        }


        //Metodos Adicionales

        public void AgregarFicha(ArrayList fichas, int idficha)
        {
            foreach(Ficha f in fichas)
            {
                if (f.GetIdFicha() == idficha)
                {
                    this.Fichas.Add(f);
                }
                else
                    continue;
            }
        }

        public int ContarFichas(ArrayList fichas)
        {
            string condicion;
            int total = 0;

            condicion = this.Nombres + " " + this.Apellidos;

            foreach(Ficha f in fichas)
            {
                if (f.GetNombreCiudadano() == condicion)
                {
                    total++;


                }
            }
            return total;
        }
    }
}
