using BPOWBHelpers;

namespace BPOWBViewsLibrary.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static User GetDefaultCredentials()
        {
            return new User()
            {
                Username = AppConfigHelper.Get("OWBUsername"),
                Password = AppConfigHelper.Get("OWBPassword")
            };
        }
    }
}
