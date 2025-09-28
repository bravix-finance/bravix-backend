using Bravix.Module.Organization.Repositories.Organization.Entities;

namespace Bravix.Module.Organization.Repositories.Organization;

public class OrganizationRepository : IOrganizationRepository
{
    public Task<OrganizationEntity[]> GetOrganizations(GetOrganizationsQuery query, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationEntity[]> UpsertOrganizations(OrganizationEntity[] entities, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationEntity[]> DeleteOrganizations(Guid[] organizationIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}