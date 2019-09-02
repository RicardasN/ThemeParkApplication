using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Models;

namespace ThemeParkApplication.Data
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			DateTime date = DateTime.Now;
			modelBuilder.Entity<WorkingHours>().HasData(
				new WorkingHours()
				{
					Id = 2,
					StartingHours = date.Add(new TimeSpan(36, 0, 0, 0)),
					ClosingHours = date.Add(new TimeSpan(36, 0, 0, 0)),
					DayOfWeek = date.ToString("dddd")

				},
				new WorkingHours()
				{
					Id = 3,
					StartingHours = date.Add(new TimeSpan(36, 0, 0, 0)),
					ClosingHours = date.Add(new TimeSpan(36, 0, 0, 0)),
					DayOfWeek = date.ToString("dddd")

				}
				);
			modelBuilder.Entity<Attraction>().HasData(
				new Attraction()
				{
					AttractionID = 1,
					Name = "Kraken",
					Location = "SW",
					Rating = (float)3.4,
					ImageSrc = "https://cdn.pixabay.com/photo/2014/09/17/03/19/roller-coaster-449137_960_720.jpg",
					Description = "This attraction offers amazing experience for a good price!",
					IsOpen = false
				},
				new Attraction()
				{
					AttractionID = 2,
					Name = "DeathRide",
					Location = "NW",
					Rating = (float)4.4,
					ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/3/39/Adlabs_Imagica_2013_%2810364145606%29.jpg",
					Description = "This attraction has a well balanced mix of scary twists and speed, are you ready for that?",
					IsOpen = false
				},
				new Attraction()
				{
					AttractionID = 3,
					Name = "Loop",
					Location = "SE",
					Rating = (float)4.9,
					ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/d/d4/Dorney_Park_Steel_Force_Thunderhawk.jpg",
					Description = "This attraction offers amazing experience for a good price!",
					IsOpen = false
				}
				);
		}
	}
}
