using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstudiantesCore1.Entidades
{
    [Table("EstudiantesMateria", Schema = "GET")]
    public class EstudiantesXMateria
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Estudiante estudiante { get; set; }
        public Materia materia { get; set; }
        public EstadoMateriaEstudiante estado { get; set; }

        public float resultado { get; set; }

    }
}
