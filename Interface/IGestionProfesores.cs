using EstudiantesCore1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiantesCore1.Interface
{
    public interface IGestionProfesores
    {
        List<Profesor> ObtenerTodosProfesores();
        Profesor GetProfesorbyId(int id);

        void ActualizarProfesor(Profesor profesor);
        List<EstadoProfesor> getEstadoProfesores();
        bool VerificarProfesorByDocumento(int idTipoDocumento, string documento);

        List<ProfesoresXMateria> ObtenerMateriasProfesores(int idEstudiante);


        void CrearNuevoProfesor(Profesor profesor);
        List<TipoDocumento> GetDocumentos();
    }
}
