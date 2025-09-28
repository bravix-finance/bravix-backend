using Bravix.Module.Organization.Repositories.OrganizationBinding.Entities;

namespace Bravix.Module.Organization.Repositories.OrganizationBinding;

public interface IOrganizationBindingRepository
{
    Task<OrganizationBindingEntity[]> GetBindings(GetBindingsQuery query, CancellationToken token);
    
    Task<OrganizationBindingEntity[]> AddBindings(OrganizationBindingEntity[] entities, CancellationToken token);
    
    Task<OrganizationBindingEntity[]> RemoveBindings(RemoveBindingsQuery query, CancellationToken token);
}