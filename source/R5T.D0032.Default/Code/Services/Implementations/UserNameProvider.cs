using System;using R5T.T0064;


namespace R5T.D0032.Default
{[ServiceImplementationMarker]
    public class UserNameProvider : IUserNameProvider,IServiceImplementation
    {
        public string GetUserName()
        {
            var userName = Environment.UserName;
            return userName;
        }
    }
}
