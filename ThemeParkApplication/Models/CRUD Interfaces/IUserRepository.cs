using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models.CRUD_Interfaces
{
	public interface IUserRepository
	{
		ApplicationUser Get(int id);
		IEnumerable<ApplicationUser> GetAllUsers();
		ApplicationUser Add(ApplicationUser message);
		ApplicationUser Update(ApplicationUser changedMessage);
		ApplicationUser Delete(int id);
	}
}
