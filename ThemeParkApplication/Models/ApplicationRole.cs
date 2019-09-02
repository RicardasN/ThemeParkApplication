using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public class ApplicationRole : IdentityRole
	{
		public ApplicationRole():base(){}
		public ApplicationRole(string rolename):base(rolename){}
		public ApplicationRole(string roleName, string description, DateTime creationDate):base(roleName)
		{
			this.CreationDate = creationDate;
			this.Description = description;
		}
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
