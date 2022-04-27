using System;

using R5T.T0064;


namespace R5T.D0032
{
    [ServiceDefinitionMarker]
    public interface IUserNameProvider : IServiceDefinition
    {
        string GetUserName();
    }
}
