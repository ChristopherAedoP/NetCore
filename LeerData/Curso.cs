using System.Collections.Generic;

namespace LeerData
{
    public class Curso
    {
        //campos tabla -->
        public int CursoId { get; set; }
        public string  Titulo { get; set; } 
        public string Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }

        //referencia a nivel de objetos -->
        public Precio Precio { get; set; }
        public ICollection<Comentario> ComentarioLista { get; set; }
        public ICollection<CursoInstructor> InstructorLink { get; set; }
    }
}