namespace WbcProductsApi.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = "";
    public string PasswordHash { get; set; } = "";   // hash only, never the password
    public string Role { get; set; } = "User";       // "User" or "Admin"
}
