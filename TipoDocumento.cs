using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary1
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public static string C_C= "C";
        public static string Nit= "N";
        public static string NN= "X";
        public static string Pasaporte= "P";
        public static string C_Extranjera= "E";
        public static string T_identidad= "T";
        public static string NUIP= "U";
        public static string C_Diplomatico= "D";
    }
}
