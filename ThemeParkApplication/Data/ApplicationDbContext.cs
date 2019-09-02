using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThemeParkApplication.Models;

namespace ThemeParkApplication.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
	{
		#region singleton

		public static ApplicationDbContext _instance;

		public static ApplicationDbContext Get
		{
			get
			{
				if (_instance == null)
				{
					throw new Exception("$ ApplicationDbContext was not assigned.");
				}
				return _instance;
			}
		}

		#endregion // singleton

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Attraction> Attractions { get; set; }
		public DbSet<WorkingHours> WorkingHours { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Route> Routes { get; set; }
		public DbSet<RouteAttraction> RouteAttractions { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_instance = this;
			base.OnModelCreating(modelBuilder);
			modelBuilder.Seed();
			modelBuilder.Entity<RouteAttraction>().HasKey(sc => new { sc.AtractionId, sc.RouteId });

			modelBuilder.Entity<RouteAttraction>()
			.HasOne<Route>(sc => sc.Route)
			.WithMany(s => s.RouteAttractions)
			.HasForeignKey(sc => sc.RouteId);

			/*modelBuilder.Entity<RouteAttraction>()
			.HasOne<Attraction>(sc => sc.Attraction)
			.WithMany(s => s.)
			.HasForeignKey(sc => sc.RouteId);*/
		}

	}
}
