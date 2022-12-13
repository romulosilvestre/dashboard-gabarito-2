
namespace MicroLabs.Pages.Services
{
public class LoginService
{
    public int Id { get; set; }
    public string? Usuario { get; set; }
    public string? Senha { get; set; }
    private DateTime DataCriacao { get; set; }
}
}