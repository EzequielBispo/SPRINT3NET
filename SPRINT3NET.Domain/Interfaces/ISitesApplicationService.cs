using SPRINT3NET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPRINT3NET.Domain.Entities;

namespace SPRINT3NET.Domain.Interfaces
{
    internal interface ISitesApplicationService
    {
        IEnumerable<SitesEntity> BuscarTodosSites();
        SitesEntity? BuscarSitesID(int id);
        SitesEntity? SalvarSites(SitesEntity entity);
        SitesEntity? EditarSites(SitesEntity entity);
        SitesEntity? ApagarSites(int id);
    }
}
