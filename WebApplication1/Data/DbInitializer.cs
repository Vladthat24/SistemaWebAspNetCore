using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initializer (SistemaContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si exiten registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacion",Descripcion="Cursos de Programacion",Estado=true},
                new Categoria{Nombre="Diseño Grafico",Descripcion="Cursos de Programacion",Estado=true}
            };

            //Recorrer la base de datos y almacenarlo 
            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
