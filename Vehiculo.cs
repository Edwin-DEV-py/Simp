using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set;}
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Combustible { get; set; }
        public string Colores { get; set; }
        public string Modelo { get; set; }
        public string Cilindraje { get; set; }
        public string Capacidad { get; set; }
        public string Blindaje { get; set; }
        public string Potencia { get; set; }
        public Clase_vehiculo Tipo_vehiculo { get; set; }

    }
}
