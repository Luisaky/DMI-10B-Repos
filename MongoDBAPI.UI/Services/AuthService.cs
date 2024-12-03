using System.Threading.Tasks;

public class AuthService
{
    private bool isAuthenticated = false;

    public Task<bool> Login(string username, string password)
    {
        // Validación simple de credenciales
        if (username == "admin" && password == "12345")
        {
            isAuthenticated = true;
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }

    public Task Logout()
    {
        isAuthenticated = false;
        return Task.CompletedTask;
    }

    public Task<bool> IsAuthenticated()
    {
        return Task.FromResult(isAuthenticated);
    }
}
