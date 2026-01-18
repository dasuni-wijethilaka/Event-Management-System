namespace EventManagementSystem
{
    public static class Credentials
    {
        public static readonly string Username = "admin";
        public static readonly string Password = "password123";

        public static bool Validate(string username, string password)
        {
            return username == Username && password == Password;
        }
    }
}