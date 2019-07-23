using MySample_CoreInterfaces;
using MySample_CoreInterfaces.Model;
using MySample_Domain;
using MySampleDataInterfaces;
using MySampleDataInterfaces.Common;
using System;
using System.Linq;

namespace MySample_CoreServices
{
    public class EntityAService : IEntityAService
    {
        private IEntityADataService entityADataService;
        private IUnitOfWork unitOfWork;

        public EntityAService(IEntityADataService entityADataService, IUnitOfWork unitOfWork)
        {
            this.entityADataService = entityADataService;
            this.unitOfWork = unitOfWork;
        }

        public EntityADetailModel Create(EntityADetailModel model)
        {
            EntityA entity = new EntityA();
            entity.DisplayName = model.DisplayName;
            this.entityADataService.Add(entity);
            unitOfWork.Save();

            return model;
        }

        public EntityADetailModel GetEntityADetails(int id)
        {
            return this.entityADataService.GetAll().Where(x=> x.Id == id).
                Select(p => new EntityADetailModel()
                {
                   Id = p.Id,
                   DisplayName = p.DisplayName
                    
                })
                .Single(); ;
        }

        public string GetSampleAppName()
        {
            return "My Sample App";
        }
    }
}
