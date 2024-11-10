using User.Application.Repository.Abstract;

namespace User.Application.Repository;

public interface IUserRepository : IBaseRepository<User.Domain.User>
{
}
