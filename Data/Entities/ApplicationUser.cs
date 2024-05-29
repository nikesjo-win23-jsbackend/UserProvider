using Microsoft.AspNetCore.Identity;

namespace Data.Entities;

public class ApplicationUser : IdentityUser
{
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    [ProtectedPersonalData]
    public string? Bio { get; set; }

    [ProtectedPersonalData]
    public string? ProfileImageUrl { get; set; } = "avatar.jpg";

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}
