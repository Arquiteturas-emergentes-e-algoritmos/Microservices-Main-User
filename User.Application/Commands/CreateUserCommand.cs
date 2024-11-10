using User.Application.Commands.Abstract;

namespace User.Application.Commands;

public class CreateUserCommand : ICommandRequest
{
    public bool Validate()
    {
        return true;
    }
}
