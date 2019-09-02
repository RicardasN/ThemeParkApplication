using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models.CRUD_Interfaces
{
	public interface IMessageRepository
	{
		Message Get(int id);
		IEnumerable<Message> GetAllMessages(String user);
		Message Add(Message message);
		Message Update(Message changedMessage);
		Message Delete(int id);
	}
}
