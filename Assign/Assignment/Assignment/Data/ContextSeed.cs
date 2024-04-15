using Assignment.Areas.BookingManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Data
{
    public class ContextSeed
    {

        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Enum.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enum.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enum.Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enum.Roles.Guest.ToString()));

        }
        public static async Task SuperSeedRoleAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var superUser = new ApplicationUser
            {
                UserName = "SuperAdmin",
                Email = "adminsupport@domain.com",
                FirstName = "Super",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != superUser.Id))
            {
                var user = await userManager.FindByEmailAsync(superUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(superUser, "P@ssword12");
                    await userManager.AddToRoleAsync(superUser, Enum.Roles.User.ToString());
                    await userManager.AddToRoleAsync(superUser, Enum.Roles.Guest.ToString());
                    await userManager.AddToRoleAsync(superUser, Enum.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(superUser, Enum.Roles.SuperAdmin.ToString());

                }
            }
        }

    }
}
