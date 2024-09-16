using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPRINT3NET.Domain.Entities;
using SPRINT3NET.Domain.Interfaces;

namespace SPRINT3NET.Application.Services
{
    internal class SitesApplicationService : ISitesApplicationService
    {
        private readonly ISitesRepository _sitesRepository;

        public SitesApplicationService(ISitesRepository sitesRepository)
        {
            _sitesRepository = sitesRepository;
        }

        public SitesEntity? ApagarSites(int id)
        {
            return _sitesRepository.ApagarSites(id);
        }

        public SitesEntity? EditarSites(SitesEntity entity)
        {
            return _sitesRepository.EditarSites(entity);
        }

        public SitesEntity? BuscarSitesID(int id)
        {
            return _sitesRepository.BuscarSitesID(id);
        }

        public IEnumerable<SitesEntity> BuscarTodosSites()
        {
            return _sitesRepository.BuscarTodos()
        }

        public SitesEntity? SalvarSites(SitesEntity entity)
        {
            return _sitesRepository.SalvarSites(entity);
        }
    }
}
