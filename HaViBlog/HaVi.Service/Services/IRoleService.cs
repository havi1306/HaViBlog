using HaViBlog.Service.ViewModels;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface IRoleService
    {
        //get all record in table
        IList<RoleViewModel> GetAll();

        IList<RoleViewModel> GetAllWithBusinessRole(string businessId);

        IList<PermissionViewModel> GetRolesWithBusinessRoleId(string businessRoleId);

        RoleViewModel FindById(int id);

        RoleViewModel Add(RoleViewModel roleViewModel);

        void Update(RoleViewModel roleViewModel);

        void Save();
    }
}