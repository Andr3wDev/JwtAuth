namespace JWTApp.Constants
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }

        public const string default_username = "user";
        public const string default_email = "user@user.user";
        public const string default_password = "Qwertyuiop1!";
        public const Roles default_role = Roles.User;
    }
}
