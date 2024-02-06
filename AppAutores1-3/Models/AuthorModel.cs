using System;
using SQLite;
namespace AppAutores1_3.Models
{


	[Table ("Author")]
	public class AuthorModel


	{
        [PrimaryKey, Unique, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(75), NotNull]
        public string Nombre { get; set; }

        [MaxLength(75), NotNull]
        public string  Pais { get; set; }


        public AuthorModel()
		{
		}
	}
}

