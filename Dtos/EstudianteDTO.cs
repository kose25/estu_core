using System;
using System.Collections.Generic;
using System.Text;
using EstudiantesCore1.Entidades;

namespace EstudiantesCore1.Dtos
{
    public class EstudianteDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public DateTime fechaRetiro { get; set; }
        public EstadoEstudiante estado { get; set; }
    }
}
