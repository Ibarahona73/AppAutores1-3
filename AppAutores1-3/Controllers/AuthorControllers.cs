using System;
using SQLite;
using AppAutores1_3.Models;
namespace AppAutores1_3.Controllers
{
	public class AuthorControllers
		
	{
		readonly SQLiteAsyncConnection _connection;
		
		public AuthorControllers()
		{
            SQLite.SQLiteOpenFlags extensiones = SQLite.SQLiteOpenFlags.ReadWrite |
                                                SQLite.SQLiteOpenFlags.Create |
                                                SQLite.SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "DBAutores.db3"), extensiones);

            _connection.CreateTableAsync<AuthorModel>();


        }

        // Crear los metodos Crud para la clase Personas
        // Create  // Update
        public async Task<int> StoreAuthor(AuthorModel author)
        {

            if (author.Id== 0)
            {
                return await _connection.InsertAsync(author);
            }
            else
            {
                return await _connection.UpdateAsync(author);
            }
        }

        public async Task<List<Models.AuthorModel>> GetListAuthor()
        {

            return await _connection.Table<AuthorModel>().ToListAsync();
        }

        // Read Element
        public async Task<Models.AuthorModel> GetAuthor(int pid)
        {

            return await _connection.Table<AuthorModel>().Where(i => i.Id == pid).FirstOrDefaultAsync();
        }

        // Delete Element
        public async Task<int> DeleteAuthor(AuthorModel author)
        {

            return await _connection.DeleteAsync(author);
        }

    }

}


