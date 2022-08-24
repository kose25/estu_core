using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstudiantesCore1.Entidades
{
    [Table("Materia", Schema = "GET")]
    public class Materia
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }

        [Required]
        public virtual EstadoMateriaEstudiante estado { get; set; }

        [Required]
        public int year { get; set; }   

    }
}
