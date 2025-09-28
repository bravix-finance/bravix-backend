using Bravix.Module.Organization.Repositories.Organization.Entities;

namespace Bravix.Module.Organization.Repositories.Organization;

public interface IOrganizationRepository
{
    Task<OrganizationEntity[]> GetOrganizations(GetOrganizationsQuery query, CancellationToken token);
    
    Task<OrganizationEntity[]> UpsertOrganizations(OrganizationEntity[] entities, CancellationToken token);
    
    Task<OrganizationEntity[]> DeleteOrganizations(Guid[] organizationIds, CancellationToken token);
}