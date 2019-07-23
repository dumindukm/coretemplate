using MySample_CoreInterfaces.Model;
using System;

namespace MySample_CoreInterfaces
{
    public interface IEntityAService
    {
        string GetSampleAppName();
        EntityADetailModel GetEntityADetails(int id);
        EntityADetailModel Create(EntityADetailModel model);
    }
}
