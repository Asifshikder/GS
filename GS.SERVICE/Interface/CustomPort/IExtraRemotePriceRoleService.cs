using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Interface.CustomPort
{
    public interface IExtraRemoteControlPriceRoleService
    {
        IEnumerable<ExtraRemoteControlPriceRole> AllAsIEnumerable();
        IQueryable<ExtraRemoteControlPriceRole> AllAsIQueryable();
        List<ExtraRemoteControlPriceRole> AllAsList();
        ExtraRemoteControlPriceRole GetById(int id);
        void InsertEntity(ExtraRemoteControlPriceRole ExtraRemoteControl);
        void UpdateEntity(ExtraRemoteControlPriceRole ExtraRemoteControl);
        void DeleteEntity(ExtraRemoteControlPriceRole ExtraRemoteControl);
        void DeleteById(int id);
    }
}
