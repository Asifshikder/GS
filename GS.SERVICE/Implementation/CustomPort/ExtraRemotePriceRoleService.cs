using GS.DATA.Entities;
using GS.DATA.Entities.CustomPort;
using GS.REPO;
using GS.SERVICE.Interface.CustomPort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.SERVICE.Implementation.CustomPort
{
    public class ExtraRemoteControlPriceRoleService : IExtraRemoteControlPriceRoleService
    {
        private readonly IRepository<ExtraRemoteControlPriceRole> ExtraRemoteControlPriceRolerepository;
        public ExtraRemoteControlPriceRoleService(IRepository<ExtraRemoteControlPriceRole> ExtraRemoteControlPriceRolerepository)
        {
            this.ExtraRemoteControlPriceRolerepository = ExtraRemoteControlPriceRolerepository;
        }

        public IEnumerable<ExtraRemoteControlPriceRole> AllAsIEnumerable()
        {
            return ExtraRemoteControlPriceRolerepository.GetAllIEnumerable();
        }

        public IQueryable<ExtraRemoteControlPriceRole> AllAsIQueryable()
        {
            return ExtraRemoteControlPriceRolerepository.GetAllIQueryable();
        }

        public List<ExtraRemoteControlPriceRole> AllAsList()
        {
            return ExtraRemoteControlPriceRolerepository.GetAll();
        }

        public void DeleteById(int id)
        {
            var entity = ExtraRemoteControlPriceRolerepository.Get(id);
            ExtraRemoteControlPriceRolerepository.Delete(entity);
        }

        public void DeleteEntity(ExtraRemoteControlPriceRole ExtraRemoteControl)
        {
            ExtraRemoteControlPriceRolerepository.Delete(ExtraRemoteControl);
        }

        public ExtraRemoteControlPriceRole GetById(int id)
        {
            return ExtraRemoteControlPriceRolerepository.Get(id);
        }

        public void InsertEntity(ExtraRemoteControlPriceRole ExtraRemoteControl)
        {
            ExtraRemoteControlPriceRolerepository.Insert(ExtraRemoteControl);
        }

        public void UpdateEntity(ExtraRemoteControlPriceRole ExtraRemoteControl)
        {
            ExtraRemoteControlPriceRolerepository.Update(ExtraRemoteControl);
        }
    }
}

