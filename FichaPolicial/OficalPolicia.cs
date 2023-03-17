using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPolicial
{
    public class OficialPolicia
    {
        private int IdPolicia, NumeroPlaca, Edad;
        private string Nombre, Apellidos, Rango;
        private bool Activo;

        public OficialPolicia() { }//Constructor Vacio
        public OficialPolicia(int idpolicia, int numeroplaca, int edad, string nombre, string apellidos, string rango, bool activo)
        {
            this.IdPolicia = idpolicia;
            this.NumeroPlaca = numeroplaca;
            this.Edad = edad;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Rango = rango;
            this.Activo = activo;
        }

        //Metodos de Acceso

        //Get
        public int GetIdPolicia() { return IdPolicia; }
        public int GetNumeroPlaca() { return NumeroPlaca; }
        public int GetEdad() { return Edad; }
        public string GetNombre() { return Nombre; }
        public string GetApellidos() { return Apellidos; }
        public string GetRango() { return Rango; }
        public bool GetActivo() { return Activo; }


        //Set
        public void SetIdPolicia(int idpolicia) { this.IdPolicia = idpolicia; }
        public void SetNumeroPlaca(int numeroplaca) { this.NumeroPlaca = numeroplaca; }
        public void SetEdad(int edad) { this.Edad = edad; }
        public void SetNumeroPlaca(string nombre) { this.Nombre = nombre; }
        public void SetApellidos(string apellidos) { this.Apellidos = apellidos; }
        public void SetRango(string rango) { this.Rango = rango; }
        public void SetActivo(bool activo) { this.Activo = activo; }

        //Metodos Adicionales
        //Agregar Ficha

    }
}
