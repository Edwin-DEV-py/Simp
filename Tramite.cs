using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class Tramite
    {
        public int Id { get; set; }
        public string Tipo_tramite { get; set; }
        public Comprador comprador { get; set; }
        public Propietario propietario { get; set; }
        public Vehiculo vehiculo { get; set; }
        public Servicios servicio { get; set; }
    }
}
