using Bravix.Module.Organization.Repositories.OrganizationBinding.Entities;

namespace Bravix.Module.Organization.Repositories.OrganizationBinding;

public class OrganizationBindingRepository : IOrganizationBindingRepository
{
    public Task<OrganizationBindingEntity[]> GetBindings(GetBindingsQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationBindingEntity[]> AddBindings(OrganizationBindingEntity[] entities, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationBindingEntity[]> RemoveBindings(RemoveBindingsQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}