using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstudiantesCore1.Entidades
{
    [Table("EstadoMateriaEstudiante", Schema = "GET")]
    public class EstadoMateriaEstudiante
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }

    }
}
