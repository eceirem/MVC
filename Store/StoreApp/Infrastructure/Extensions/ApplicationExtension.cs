using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructure.Extensions
{
    public static class ApplicationExtension
    {
        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string adminPassword = "Admin+123456.";
            //User manager
            UserManager<IdentityUser> userManager = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            //Role manager
            RoleManager<IdentityRole> roleManager = app
                .ApplicationServices
                .CreateAsyncScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            IdentityUser user = await userManager.FindByNameAsync(adminUser);

            if (user is null)
            {
                user = new IdentityUser()
                {
                    Email = "eceiremsiser@gmail.com",
                    PhoneNumber = "5078249751",
                    UserName = adminUser,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    
                };
                var result = await userManager.CreateAsync(user, adminPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("Admin user could not created");
                }
                var roleResult = await userManager.AddToRolesAsync(user, roleManager.Roles.Select(r => r.Name).ToList());

                if(!roleResult.Succeeded)
                {
                    throw new Exception("Admin user could not added to role");
                }
            }
        }
    }
}
