using SPRINT3NET.Domain.Entities;

namespace SPRINT3NET.Domain.Interfaces
{
    public interface ISitesApplicationService
    {
        IEnumerable<SitesEntity> ObterTodosSites();
        SitesEntity? ObterSitesPorId(int id);
        SitesEntity? SalvarSites(SitesEntity entity);
        SitesEntity? EditarSites(SitesEntity entity);
        SitesEntity? ApagarSites(int id);
    }
}
