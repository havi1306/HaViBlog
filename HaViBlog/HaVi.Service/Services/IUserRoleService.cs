using HaViBlog.Service.ViewModels;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface IUserRoleService
    {
        IList<PermissionViewModel> userRoles(int userId, string businessRoleId);

        IList<string> UserRolesAuthorizes(int userId);

        UserRoleViewModel FindById(int userId, int roleId);

        UserRoleViewModel Add(UserRoleViewModel userRoleViewModel);

        void Delete(UserRoleViewModel userRoleViewModel);

        void Save();
    }
}