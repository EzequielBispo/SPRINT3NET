using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPRINT3NET.Domain.Entities

namespace SPRINT3NET.Domain.Interfaces
{
    public interface ISitesRepository
    {
        IEnumerable<SitesEntity> BuscarTodos();
        SitesEntity? BuscarSites(int id);
        SitesEntity? SalvarSites(SitesEntity entity);
        SitesEntity? EditarSites(SitesEntity entity);
        SitesEntity? ApagarSites(int id);
    }
}
