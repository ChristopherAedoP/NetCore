using System.Runtime.InteropServices;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            using(var db = new AppVentaCursosContext()){

                #region 1.listar cursos
                //1.listar cursos
                // var cursos = db.Curso.AsNoTracking();

                // foreach (var curso in cursos)
                // {
                //     Console.WriteLine(curso.Titulo);
                // }
                #endregion

                #region 2.listar cursos y precio
                //2.listar cursos y precio
                // var cursos = db.Curso.Include(p => p.Precio).AsNoTracking();
                
                // foreach (var curso in cursos)
                // {
                //     Console.WriteLine($"{curso.Titulo} , Precio: {curso.Precio.PrecioActual }" );
                // }
                #endregion

                #region 3.listar comentarios
                //3.listar comentarios
                // var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();
                
                // foreach (var curso in cursos)
                // {
                //     Console.WriteLine($"> {curso.Titulo}" );

                //     foreach (var comentario in curso.ComentarioLista)
                //     {
                //         Console.WriteLine($" -- {comentario.ComentarioTexto} , de: {comentario.Alumno }" );
                //     }
                    
                // }
                #endregion 3.listar comentarios

                #region 4.listar cursos y profesores
                // 4.listar cursos y profesores
                var cursos = db.Curso.Include(c => c.InstructorLink)
                                    .ThenInclude(ci => ci.Instructor);
                
                foreach (var curso in cursos)
                {
                    Console.WriteLine($"> {curso.Titulo}" );

                    foreach (var intLink in curso.InstructorLink)
                    {
                        Console.WriteLine($" -- {intLink.Instructor.Nombre} {intLink.Instructor.Apellido } , Grado: '{intLink.Instructor.Grado}'" );
                    }
                    
                }  

                #endregion              
            }
        }
    }
}
