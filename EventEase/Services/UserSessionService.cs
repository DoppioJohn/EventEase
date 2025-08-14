public class UserSessionService
{
    public string? UserName { get; private set; }
    public string? UserEmail { get; private set; }
    public bool IsRegistered => !string.IsNullOrEmpty(UserEmail);

    public void SetUser(string name, string email)
    {
        UserName = name;
        UserEmail = email;
    }

    public void Clear()
    {
        UserName = null;
        UserEmail = null;
    }
}
