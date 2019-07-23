using Microsoft.EntityFrameworkCore;
using MySample_Domain;
using MySample_Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySample_DataService.Common
{
    public interface IDatabaseContext
    {
        DbSet<EntityA> EntityAs { get; set; }

        DbSet<T> Set<T>() where T : class, IEntity;

        void Save();
    }
}
