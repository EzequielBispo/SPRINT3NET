using SPRINT3NET.Domain.Entities;
using SPRINT3NET.Domain.Interfaces;

namespace SPRINT3NET.Application.Services
{
    public class SitesApplicationService : ISitesApplicationService
    {
        private readonly ISitesRepository _sitesRepository;

        public SitesApplicationService(ISitesRepository sitesRepository)
        {
            _sitesRepository = sitesRepository;
        }

        public SitesEntity? DeletarSites(int id)
        {
            return _sitesRepository.ApagarSites(id);
        }

        public SitesEntity? EditarSites(SitesEntity entity)
        {
            return _sitesRepository.EditarSites(entity);
        }

        public SitesEntity? ObterSitesPorId(int id)
        {
            return _sitesRepository.ObterPorId(id);
        }

        public IEnumerable<SitesEntity> BuscarTodosSites()
        {
            return _sitesRepository.ObterTodos();
        }

        public SitesEntity? SalvarSites(SitesEntity entity)
        {
            return _sitesRepository.SalvarSites(entity);
        }

        public IEnumerable<SitesEntity> ObterTodosSites()
        {
            throw new NotImplementedException();
        }

        public SitesEntity? ApagarSites(int id)
        {
            throw new NotImplementedException();
        }
    }
}
