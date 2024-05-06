using aplicatie.Models;

public interface IAuthService
{
    bool Authenticate(string username, string password);
}

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository; // presupunând că există un repository pentru utilizatori

    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public bool Authenticate(string username, string password)
    {
        var user = _userRepository.GetUserByUsername(username) as User; // Presupunând că GetUserByUsername returnează un obiect de tip User

        // Verifică dacă user nu este null și dacă parola introdusă corespunde
        if (user != null && user.Password == password)
        {
            return true; // Autentificare reușită
        }

        return false; // Autentificare eșuată
    }


}
