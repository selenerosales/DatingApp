using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // DbContext representa una sesion con la base de datos y se utiliza para consultar y guardar instancias de nuestras entidades
    // Estamos heredando  DbContext lo que significa que podemos reutilizar cualquier metodo de esta clase 
    public class DataContext : DbContext
    {
        //constructor con el nombre de nuestra clase
        public DataContext(DbContextOptions<DataContext> options): base (options){}

        //En este metodo debemos decirle al marco de entidad sobre nuestras tablas 
        // utilizamos una tabla de menu de solucion rapida
        public DbSet<Value> Values { get; set; }
    }
}