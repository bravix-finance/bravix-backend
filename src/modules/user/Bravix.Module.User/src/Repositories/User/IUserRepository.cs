using Bravix.Module.User.Repositories.User.Entities;

namespace Bravix.Module.User.Repositories.User;

public interface IUserRepository
{
    Task<UserEntity[]> GetUsers(GetUsersQuery query, CancellationToken token);
    
    Task<UserEntity[]> UpsertUsers(UserEntity[] users, CancellationToken token);
    
    Task<UserEntity[]> DeleteUsers(Guid[] userIds, CancellationToken token);
}