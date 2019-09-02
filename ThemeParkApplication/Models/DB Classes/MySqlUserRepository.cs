using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Models.DB_Classes
{
	public class MySqlUserRepository : IUserRepository
	{
		private readonly ApplicationDbContext context;
		public MySqlUserRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public ApplicationUser Add(ApplicationUser message)
		{
			throw new NotImplementedException();
		}

		public ApplicationUser Delete(int id)
		{
			throw new NotImplementedException();
		}

		public ApplicationUser Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ApplicationUser> GetAllUsers()
		{
			return context.Users;
		}

		public ApplicationUser Update(ApplicationUser changedMessage)
		{
			throw new NotImplementedException();
		}
	}
}
