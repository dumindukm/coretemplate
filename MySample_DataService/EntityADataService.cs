using MySample_DataService.Common;
using MySample_Domain;
using MySampleDataInterfaces;
using System;

namespace MySample_DataService
{
    public class EntityADataService :BaseRepository<EntityA>, IEntityADataService
    {
        public EntityADataService(IDatabaseContext database) : base(database) { }
    }
}
