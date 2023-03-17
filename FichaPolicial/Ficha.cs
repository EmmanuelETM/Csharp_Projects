using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPolicial
{
    public class Ficha
    {
        private Ciudadano Ciudadano;
        private Delito Delito;
        private OficialPolicia OficialPolicia;
        private string Fecha;
        private int IdFicha;

        public Ficha() { } //Constructor Vacio

        public Ficha(Ciudadano ciudadano, Delito delito, OficialPolicia oficialPolicia, string fecha, int idFicha)
        {
            Ciudadano = ciudadano;
            Delito = delito;
            OficialPolicia = oficialPolicia;
            Fecha = fecha;
            IdFicha = idFicha;
        }

        //Metodos de Acceso

        //Get
        public Ciudadano GetCiudadano() { return Ciudadano; }
        public Delito GetDelito() { return Delito; }
        public OficialPolicia GetOficialPolicia() { return OficialPolicia; }
        public string GetFecha() { return Fecha; }
        public int GetIdFicha() { return IdFicha; }

        //Set
        public void SetCiudadano(Ciudadano ciudadano) { this.Ciudadano = ciudadano; }
        public void SetDelito(Delito delito) { this.Delito = delito; }
        public void SetOficialPolicia(Delito delito) { this.Delito = delito; }
        public void SetFecha(string fecha) { this.Fecha = fecha; }
        public void SetIdFicha(int idficha) { this.IdFicha = idficha; }


        //Metodos Adicionales
        public string GetNombreCiudadano()
        {
            string nombreCiudadano = this.Ciudadano.GetNombres() + " " + this.Ciudadano.GetApellidos();
            return nombreCiudadano;
        }
        public string GetNombreDelito()
        {
            string nombreDelito = this.Delito.GetNombreDelito();
            return nombreDelito;
        }
        public string GetNombrePolicia()
        {
            string nombrePolicia = this.OficialPolicia.GetRango() + " " + this.OficialPolicia.GetApellidos();
            return nombrePolicia;
            

        }

    }
}
