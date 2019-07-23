using MySample_Domain.Common;
using System;

namespace MySample_Domain
{
    public class EntityA: IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
    }
}
