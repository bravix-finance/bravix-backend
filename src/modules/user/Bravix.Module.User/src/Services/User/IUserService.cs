using Bravix.Module.User.Services.User.Models;

namespace Bravix.Module.User.Services.User;

public interface IUserService
{
    Task<UserModel[]> GetUsers(Guid[] userIds, CancellationToken token);
    
    Task<UserModel[]> UpsertUsers(UserModel[] user, CancellationToken token);
    
    Task<UserModel[]> DeleteUsers(Guid[] userIds, CancellationToken token);
}