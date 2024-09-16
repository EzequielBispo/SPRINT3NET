using SPRINT3NET.Data.AppData;
using SPRINT3NET.Domain.Entities;
using SPRINT3NET.Domain.Interfaces;

namespace SPRINT3NET.Data.Repositories
{
    public class SitesRepository : ISitesRepository
    {
        private readonly ApplicationContext _context;

        public SitesRepository(ApplicationContext context)
        {
            _context = context;
        }

        public SitesEntity? ApagarSites(int id)
        {
            var sites = _context.Sites.Find(id);

            if (sites is not null)
            {
                _context.Sites.Remove(sites);
                _context.SaveChanges();
                return sites;
            }
            return null;
        }

        public SitesEntity? EditarSites(SitesEntity entity)
        {
            var sites = _context.Sites.Find(entity.Id);

            if (sites is not null)
            {
                sites.Dominio = entity.Dominio;
                sites.Titulo = entity.Titulo;

                _context.Sites.Update(sites);
                _context.SaveChanges();

                return sites;
            }
            return null;
        }

        public SitesEntity? ObterPorId(int id)
        {
            var sites = _context.Sites.Find(id);

            if (sites is not null)
            {
                return sites;
            }
            return null;
        }

        public IEnumerable<SitesEntity> ObterTodos()
        {
            var sites = _context.Sites.ToList();

            return sites;
        }

        public SitesEntity? SalvarSites(SitesEntity entity)
        {
            _context.Sites.Add(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}