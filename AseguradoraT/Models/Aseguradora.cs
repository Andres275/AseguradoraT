using AseguradoraT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AseguradoraT.Models
{
    public class Aseguradora
    {
        public int Id { get; set; } = 0;

        public string Primernombre { get; set; } = "";
        public string Segundonombre { get; set; } = "";
        public string Primerapellido { get; set; } = "";
        public string Segundoapellido { get; set; } = "";
        public int Telefono { get; set; } = 0;

        public string Email { get; set; } = "";

        public string Fnacimiento { get; set; } = "";

        public float Moneda { get; set; } = 0;

        public void Save(Aseguradora oAseguradora)
        {
           Conexion oConexion = new Conexion();
           oConexion.Save(oAseguradora);
        }
    }
}