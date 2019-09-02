using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Models.DB_Classes
{
	public class MySqlMessageRepository : IMessageRepository
	{
		public Message Add(Message message)
		{
			using (var context = ApplicationDbContext.Get)
			{
				context.Messages.Add(message);
				context.SaveChanges();
				return message;
			}
		}

		public Message Delete(int id)
		{
			using (var context = ApplicationDbContext.Get)
			{
				Message message = context.Messages.Find(id);
				if (message != null)
				{
					context.Messages.Remove(message);
					context.SaveChanges();
				}
				return message;
			}
		}

		public Message Get(int id)
		{
			using (var context = ApplicationDbContext.Get)
			{
				return context.Messages.Find(id);
			}
		}

		public IEnumerable<Message> GetAllMessages(String user)
		{
			using (var context = ApplicationDbContext.Get)
			{
				IEnumerable<Message> messages = context.Messages;
				IEnumerable<Message> messagesToReturn = messages.Where(message => message.Username.Equals(user));

				return messagesToReturn;
			}
		}

		public Message Update(Message changedMessage)
		{
			using (var context = ApplicationDbContext.Get)
			{
				var message = context.Messages.Attach(changedMessage);
				message.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
				context.SaveChanges();
				return changedMessage;
			}
		}
	}
}
