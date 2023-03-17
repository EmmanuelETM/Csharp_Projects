using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaPolicial
{
    public class Delito
    {
        private int IdDelito, CantidadFichas;
        private string NombreDelito, GradoDelito, TipoDelito;
        private bool Activo;
        public Delito()
        {
        }
        public Delito(int iddelito, int cantidadfichas, string nombreDelito, string tipodelito, string gradoDelito, bool activo)
        {
            this.IdDelito = iddelito;
            this.NombreDelito = nombreDelito;
            this.TipoDelito= tipodelito;
            this.GradoDelito = gradoDelito;
            this.CantidadFichas = cantidadfichas;
            this.Activo = activo;
        }
        //Metodos de Acceso
        //Get
        public int GetIdDelito()
        {
            return IdDelito;
        }
        public int GetCantidadFichas()
        {
            return CantidadFichas;
        }
        public string GetNombreDelito()
        {
            return NombreDelito;
        }
        public string GetTipoDelito()
        {
            return TipoDelito;
        }
        public string GetGradoDelito()
        {
            return GradoDelito;
        }
        public bool GetActivo()
        {
            return Activo;
        }

        //Set
        public void SetIDdelito(int iddelito)
        {
            this.IdDelito = iddelito;
        }
        public void SetCantidadFichas(int cantidadfichas)
        {
            this.CantidadFichas = cantidadfichas;
        }
        public void SetNombreDelito(string nombreDelito)
        {
            this.NombreDelito = nombreDelito;
        }
        public void SetTipoDelito(string tipodelito)
        {
            this.TipoDelito = tipodelito;
        }
        public void SetGradoDelito(string gradoDelito)
        {
            this.GradoDelito = gradoDelito;
        }
        public void SetActivo(bool activo)
        {
            this.Activo = activo;
        }

        //Metodos Adicionales

        //agregar fichas
        //Agregar Ciudadanos
        
    }
}