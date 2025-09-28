using Bravix.Module.Organization.Services.Organization.Models;

namespace Bravix.Module.Organization.Services.Organization;

public class OrganizationService : IOrganizationService
{
    public Task<OrganizationModel[]> GetUserOrganizations(Guid userId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationModel[]> GetOrganizations(Guid[] organisationIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationModel> UpsertOrganizations(OrganizationModel[] organizations, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationBindingModel[]> BindOrganizations(Guid userId, Guid[] organizationIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationBindingModel[]> UnbindOrganizations(Guid userId, Guid[] organizationIds, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}