using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class Servicios
    {
        public int Id { get; set; }
        public string servicio { get; set; }

        public static string Particular = "PARTICULAR";
        public static string Publico = "PUBLICO";
        public static string Diplomatico = "DIPLOMATICO";
        public static string Oficial = "OFICIAL";
        public static string Especial = "ESPECIAL";
        public static string Otro = "OTRO";
    }
}
