using SPRINT3NET.Domain.Entities;

namespace SPRINT3NET.Domain.Interfaces
{
    public interface ISitesRepository
    {
        IEnumerable<SitesEntity> ObterTodos();
        SitesEntity? ObterPorId(int id);
        SitesEntity? SalvarSites(SitesEntity entity);
        SitesEntity? EditarSites(SitesEntity entity);
        SitesEntity? ApagarSites(int id);
    }
}
