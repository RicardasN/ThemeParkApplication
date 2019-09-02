using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Models;

namespace ThemeParkApplication.Data
{
	public class InitialUserData
	{
		public static async Task Initialize(ApplicationDbContext context,
								 UserManager<ApplicationUser> userManager,
								 RoleManager<ApplicationRole> roleManager)
		{
			context.Database.EnsureCreated();

			String adminId1 = "";
			String adminId2 = "";

			string role1 = "Admin";
			string desc1 = "This is the administrator role";

			string role2 = "Employee";
			string desc2 = "This is the employee role";

			string role3 = "Member";
			string desc3 = "This is the members role";

			string password = "P@$$w0rd";

			if (await roleManager.FindByNameAsync(role1) == null)
			{
				await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
			}
			if (await roleManager.FindByNameAsync(role2) == null)
			{
				await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
			}
			if (await roleManager.FindByNameAsync(role3) == null)
			{
				await roleManager.CreateAsync(new ApplicationRole(role3, desc3, DateTime.Now));
			}

			if (await userManager.FindByNameAsync("aa@aa.aa") == null)
			{
				var user = new ApplicationUser
				{
					UserName = "aa@aa.aa",
					Email = "aa@aa.aa",
					FirstName = "Adam",
					LastName = "Aldridge",
					Nickname = "aa",
					PhoneNumber = "6902341234"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role1);
				}
				adminId1 = user.Id;
			}

			if (await userManager.FindByNameAsync("bb@bb.bb") == null)
			{
				var user = new ApplicationUser
				{
					UserName = "bb@bb.bb",
					Email = "bb@bb.bb",
					FirstName = "Bob",
					LastName = "Barker",
					Nickname = "bbb",
					PhoneNumber = "7788951456"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role1);
				}
				adminId2 = user.Id;
			}

			if (await userManager.FindByNameAsync("mm@mm.mm") == null)
			{
				var user = new ApplicationUser
				{
					UserName = "mm@mm.mm",
					Email = "mm@mm.mm",
					FirstName = "Mike",
					LastName = "Myers",
					Nickname = "mmm",
					PhoneNumber = "6572136821"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role2);
				}
			}

			if (await userManager.FindByNameAsync("dd@dd.dd") == null)
			{
				var user = new ApplicationUser
				{
					UserName = "dd@dd.dd",
					Email = "dd@dd.dd",
					FirstName = "Donald",
					LastName = "Duck",
					Nickname = "ddd",
					PhoneNumber = "6041234567"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role3);
				}
			}
		}
	}
}
