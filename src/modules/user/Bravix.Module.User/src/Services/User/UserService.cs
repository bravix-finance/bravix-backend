using Bravix.Module.User.Services.User.Models;

namespace Bravix.Module.User.Services.User;

public class UserService : IUserService
{
    public Task<UserModel[]> GetUsers(Guid[] userIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel[]> UpsertUsers(UserModel[] user, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel[]> DeleteUsers(Guid[] userIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}