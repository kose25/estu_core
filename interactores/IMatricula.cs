using System;
using System.Collections.Generic;
using System.Text;
using EstudiantesCore1.Entidades;

namespace EstudiantesCore1.interactores
{
    public interface IMatricula
    {
        void MatricularEstudiante(Estudiante estudiante);
        void ActualizarEstudiante(Estudiante estudiante);
        Estudiante ObtenerEstudiante(int idEstudiante);
        List<Estudiante> ObtenerTodosEstudiantes(bool getall, int take, int skip);

        List<EstudiantesXMateria> ObtenerMateriasEstudiante(int idEstudiante);
        List<TipoDocumento> GetDocumentos();

        List<EstadoEstudiante> GetEstadoEstudiantes();

        bool VerificarEstudianteByDocumento(int idTipoDocumento,string documento);
        List<Materia> GetMaterias();

        List<EstadoMateriaEstudiante> GetEstadoMaterias();

        bool VerificarCodigoUnicoMateria(string codigo);

        void CrearNuevaMateria(Materia materia);

        Materia GetMateriaById(int id);
        void ActualizarMateria(Materia materia);

        //List<Profesor> ObtenerTodosProfesores();
        //Profesor GetProfesorbyId(int id);

        //void ActualizarProfesor(Profesor profesor);
        //List<EstadoProfesor> getEstadoProfesores();
        //bool VerificarProfesorByDocumento(int idTipoDocumento, string documento);

        //List<ProfesoresXMateria> ObtenerMateriasProfesores(int idEstudiante);


        //void CrearNuevoProfesor(Profesor profesor);
    }
}
