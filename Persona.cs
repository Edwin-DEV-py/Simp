using System;

namespace WinFormsLibrary1
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Primer_apellido { get; set; }
        public string Segundo_apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public TipoDocumento Documento { get; set; }
        public int N_documento { get; set; }

    }
}
