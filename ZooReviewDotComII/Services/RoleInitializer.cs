using Microsoft.AspNetCore.Identity;
namespace ZooReviewDotComII.Services;

public class RoleInitializer
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleInitializer(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task InitializeAsync()
    {
        if (!await _roleManager.RoleExistsAsync("Admin"))
        {
            await _roleManager.CreateAsync(new IdentityRole("Admin"));
        }
        if (!await _roleManager.RoleExistsAsync("User"))
        {
            await _roleManager.CreateAsync(new IdentityRole("User"));
        }
        
        if (!await _roleManager.RoleExistsAsync("Moderator"))
            await _roleManager.CreateAsync(new IdentityRole("Moderator"));
    }
}
