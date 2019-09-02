using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;

namespace ThemeParkApplication.Models
{
	public class MySqlAttractionRepository : IAttractionRepository
	{
		private readonly ApplicationDbContext context;
		public MySqlAttractionRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public Attraction Add(Attraction attraction)
		{
			context.Attractions.Add(attraction);
			context.SaveChanges();
			return attraction;
		}

		public Attraction Delete(int id)
		{
			Attraction attraction = context.Attractions.Find(id);
			if (attraction != null)
			{
				context.Attractions.Remove(attraction);
				context.SaveChanges();
			}
			return attraction;
		}

		public void Destroy()
		{
			GC.SuppressFinalize(this);
		}

		public IEnumerable<Attraction> GetAttractionList()
		{
			return context.Attractions;
		}

		public Attraction GetAttraction(int id)
		{
			return context.Attractions.Find(id);
		}

		public Attraction Update(Attraction changedAttraction)
		{
			var attraction = context.Attractions.Attach(changedAttraction);
			attraction.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
			return changedAttraction;
		}
	}
}
