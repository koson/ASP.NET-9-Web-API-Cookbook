namespace SignalRServer.LoginModel;

public class LoginDTO
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Locale { get; set; } = "en-US";
}
