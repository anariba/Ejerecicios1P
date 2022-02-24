using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicios1Parcial.Models;
using System.Threading.Tasks;

namespace Ejercicios1Parcial.Models
{
   public class DataBase
    {
      readonly SQLiteAsyncConnection db;

        public DataBase() { }

        //constructor de clase vacio

        public DataBase(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);
            // creacion d tablas de la base de datos
            db.CreateTableAsync<Contact2>();
        }

        //procedimientos y funciones
        //retorna la tabla empleado con una lista
        public Task<List<Contact2>> listaempleados()
        {
            return db.Table<Contact2>().ToListAsync();
        }
        //buscar un empleado
        public Task<Contact2> obtenercontacto(Int32 codigo)
        {
            return db.Table<Contact2>()
                .Where(i => i.codigo == codigo)
                .FirstOrDefaultAsync();

        }
        //guardar un empleado
        public Task<Int32> guardar(Contact2 contacto)
        {

            if(contacto.codigo != 0)
            {
                return db.UpdateAsync(contacto);
            }
            else
            {
                return db.InsertAsync(contacto);
            }

        }
        public Task<Int32> borrar(Contact2 contacto)
        {
            return db.DeleteAsync(contacto);

        }


    }
}
