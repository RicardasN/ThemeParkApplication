using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class MockAttractionRepository : IAttractionRepository
	{
		private List<Attraction> _attractionList;
		public MockAttractionRepository()
		{
			_attractionList = new List<Attraction>()
			{
				new Attraction(){AttractionID = 1, Name = "Kraken", Location="SW", Rating=(float)3.4,
					ImageSrc ="https://cdn.pixabay.com/photo/2014/09/17/03/19/roller-coaster-449137_960_720.jpg",
					Description ="This attraction offers amazing experience for a good price!"},
				new Attraction(){AttractionID = 2, Name = "DeathRide", Location="NW", Rating=(float)4.4,
					ImageSrc ="https://upload.wikimedia.org/wikipedia/commons/3/39/Adlabs_Imagica_2013_%2810364145606%29.jpg",
					Description="This attraction has a well balanced mix of scary twists and speed, are you ready for that?"},
				new Attraction(){AttractionID = 3, Name = "Loop", Location="SE", Rating=(float)4.9,
					ImageSrc ="https://upload.wikimedia.org/wikipedia/commons/d/d4/Dorney_Park_Steel_Force_Thunderhawk.jpg",
					Description="This attraction offers amazing experience for a good price!"}
			};
		}

		public Attraction Add(Attraction attraction)
		{
			if (attraction.ImageSrc == "" || attraction.ImageSrc == null) attraction.ImageSrc = "~/images/noimage.png";
			attraction.AttractionID = _attractionList.Max(e => e.AttractionID) + 1;
			_attractionList.Add(attraction);
			return attraction;
		}

		public Attraction Delete(int id)
		{
			Attraction attraction = _attractionList.FirstOrDefault(e => e.AttractionID == id);
			if (attraction != null)
			{
				_attractionList.Remove(attraction);
			}
			return attraction;
		}

		public void Destroy()
		{
			GC.SuppressFinalize(this);
		}

		public IEnumerable<Attraction> GetAllAttractions()
		{
			return _attractionList;
		}

		public Attraction GetAttraction(int id)
		{
			return _attractionList.FirstOrDefault(e => e.AttractionID == id);
		}

		public IEnumerable<Attraction> GetAttractionList()
		{
			throw new NotImplementedException();
		}

		public Attraction Update(Attraction changedAttraction)
		{
			Attraction attraction = _attractionList.FirstOrDefault(e => e.AttractionID == changedAttraction.AttractionID);
			if (attraction != null)
			{
				attraction.Name = changedAttraction.Name;
				attraction.Location = changedAttraction.Location;
				attraction.Rating = changedAttraction.Rating;
				attraction.ImageSrc = changedAttraction.ImageSrc;
				attraction.Description = changedAttraction.Description;
			}
			return attraction;
		}
	}
}
