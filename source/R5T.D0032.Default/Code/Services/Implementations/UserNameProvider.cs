using System;


namespace R5T.D0032.Default
{
    public class UserNameProvider : IUserNameProvider
    {
        public string GetUserName()
        {
            var userName = Environment.UserName;
            return userName;
        }
    }
}
