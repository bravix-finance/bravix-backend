using Bravix.Module.Organization.Services.Organization.Models;

namespace Bravix.Module.Organization.Services.Organization;

public interface IOrganizationService
{
    Task<OrganizationModel[]> GetUserOrganizations(Guid userId, CancellationToken token);
    Task<OrganizationModel[]> GetOrganizations(Guid[] organisationIds, CancellationToken token);
    
    Task<OrganizationModel> UpsertOrganizations(OrganizationModel[] organizations, CancellationToken token);
    
    Task<OrganizationBindingModel[]> BindOrganizations(Guid userId, Guid[] organizationIds, CancellationToken token);
    Task<OrganizationBindingModel[]> UnbindOrganizations(Guid userId, Guid[] organizationIds, CancellationToken token);
}