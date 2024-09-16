using SPRINT3NET.Domain.Entities;
using SPRINT3NET.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly ISitesApplicationService _SitesApplicationService;

        public SitesController(ISitesApplicationService SitesApplicationService)
        {
            _SitesApplicationService = SitesApplicationService;
        }

        /// <summary>
        /// Metodo para obter todos os dados de Sites
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<SitesEntity>>]
        public IActionResult Get()
        {
            var sites = _SitesApplicationService.ObterTodosSites();

            if(sites is not null)
                return Ok(sites);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Metodo para obter uma Sites
        /// </summary>
        /// <param name="id"> Identificado da Sites</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<SitesEntity>]
        public IActionResult GetPorId(int id)
        {
            var sites = _SitesApplicationService.ObterSitesPorId(id);

            if (sites is not null)
                return Ok(sites);

            return BadRequest("Não foi possivel obter os dados");
        }


        /// <summary>
        /// Metodos para salvar a Sites
        /// </summary>
        /// <param name="entity"> Modelo de dados da Sites</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<SitesEntity>]
        public IActionResult Post(SitesEntity entity)
        {
            var sites = _SitesApplicationService.SalvarSites(entity);

            if (sites is not null)
                return Ok(sites);

            return BadRequest("Não foi possivel salvar os dados");
        }

        /// <summary>
        /// Metodos para editar a Sites
        /// </summary>
        /// <param name="entity"> Modelo de dados da Sites</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<SitesEntity>]
        public IActionResult Put(SitesEntity entity)
        {
            var sites = _SitesApplicationService.EditarSites(entity);

            if (sites is not null)
                return Ok(sites);

            return BadRequest("Não foi possivel editar os dados");
        }

        /// <summary>
        /// Metodo para deletar uma Sites
        /// </summary>
        /// <param name="id"> Identificado da Sites</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<SitesEntity>]
        public IActionResult Delete(int id)
        {
            var sites = _SitesApplicationService.ApagarSites(id);

            if (sites is not null)
                return Ok(sites);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
