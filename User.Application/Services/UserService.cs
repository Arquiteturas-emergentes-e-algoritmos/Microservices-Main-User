using User.Application.Commands;
using User.Application.Commands.Abstract;
using User.Application.Repository;
using User.Application.Services.Abstract;

namespace User.Application.Services;

public class UserService(IUserRepository userRepository) : BaseService
{
    private readonly IUserRepository _userRepository = userRepository;
    public ICommandResponse Handle(CreateUserCommand command)
    {
        var user = new Domain.User();
        _userRepository.Add(user);
        return new CommandResponse(user, 200);
    }

    public ICommandResponse Handle(GetUserCommand command)
    {
        return new CommandResponse(_userRepository.GetById(command.UserId), 200);
    }
}
