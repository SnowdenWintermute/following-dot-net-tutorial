using DevSpot.Constants;
using Microsoft.AspNetCore.Identity;

namespace DevSpot.Data
{
    public class RoleSeeder
    {
        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(Roles.ADMIN))
            {
                var result = await roleManager.CreateAsync(new IdentityRole(Roles.ADMIN));
            }
            if (!await roleManager.RoleExistsAsync(Roles.EMPLOYER))
            {
                var result = await roleManager.CreateAsync(new IdentityRole(Roles.EMPLOYER));
            }
            if (!await roleManager.RoleExistsAsync(Roles.JOB_SEEKER))
            {
                var result = await roleManager.CreateAsync(new IdentityRole(Roles.JOB_SEEKER));
            }
        }
    }
}
