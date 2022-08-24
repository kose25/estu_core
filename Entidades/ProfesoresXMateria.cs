using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EstudiantesCore1.Entidades
{
    [Table("ProfesoresXMateria", Schema = "GET")]
    public class ProfesoresXMateria
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Profesor profesor { get; set; }
        public Materia materia { get; set; }

    }
}
