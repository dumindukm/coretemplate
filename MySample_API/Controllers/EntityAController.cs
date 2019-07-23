using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySample_CoreInterfaces;
using MySample_CoreInterfaces.Model;
using MySample_Utility.interfaces;

namespace MySample_API.Controllers
{
    [Produces("application/json")]
    [Route("api/EntityA")]
    public class EntityAController : Controller
    {
        private IEntityAService entitySrvice;
        private ICustomLogger logger;
        public EntityAController(IEntityAService entitySrvice, ICustomLogger logger)
        {
            this.entitySrvice = entitySrvice;
            this.logger = logger;
        }

        [HttpGet("GetDetails/{id}")]
        public EntityADetailModel GetDetails(int id)
        {
            logger.LogTrace("Mu log");
            return entitySrvice.GetEntityADetails(id);
        }

        [HttpGet("Create")]
        public EntityADetailModel CreateEntityA(EntityADetailModel model)
        {
            model = new EntityADetailModel();
            model.DisplayName = "hello";

            model = entitySrvice.Create(model);

            return model;
        }
    }
}