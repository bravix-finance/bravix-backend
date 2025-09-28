using Bravix.Module.User.Repositories.User.Entities;

namespace Bravix.Module.User.Repositories.User;

public class UserRepository : IUserRepository
{
    public Task<UserEntity[]> GetUsers(GetUsersQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity[]> UpsertUsers(UserEntity[] users, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity[]> DeleteUsers(Guid[] userIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}