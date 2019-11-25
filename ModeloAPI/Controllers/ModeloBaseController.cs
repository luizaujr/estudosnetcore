using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModeloAPI.Models.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/modelo")]
    [ApiController]
    public class ModeloBaseController : ControllerBase
    {
        /// <summary>
        /// Construtor da Classe.
        /// </summary>
        /// <returns></returns>
        public ModeloBaseController() : base()
        {

        }

        /// <summary>
        /// Detalhes - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// </summary>
        /// <remarks>
        /// Notas de Implementação -
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// </remarks>
        /// <returns>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum.</returns>        [HttpGet]
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpGet]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<ModeloBasePoco>>> Get()
        {
            return await this.GetListAsync();
        }











        /// <summary>
        /// Detalhes - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// </summary>
        /// <remarks>
        /// Notas de Implementação -
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// 
        /// Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere eu, lectus. Nam mattis, felis ut adipiscing.
        /// </remarks>
        /// <returns>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis condimentum.</returns>        [HttpGet]
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpGet]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ModeloBasePoco>> Get(int id)
        {
            return await this.GetInstanceAsync(id);
        }











        private Task<List<ModeloBasePoco>> GetListAsync()
        {
            List<ModeloBasePoco> list = Models.FakeDB.ModeloBaseDB.ListModelBase;
            return Task.FromResult(list);
        }

        private Task<ModeloBasePoco> GetInstanceAsync(int id)
        {
            ModeloBasePoco res = Models.FakeDB.ModeloBaseDB.ListModelBase.SingleOrDefault(poco => poco.Codigo == id);
            return Task.FromResult(res);
        }
    }
}