using HaViBlog.Service.ViewModels;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface IUserService
    {
        //get all record in table
        IList<UserViewModel> GetAll();

        UserViewModel FindById(int userId);

        UserViewModel Add(UserViewModel userViewModel);

        void Update(UserViewModel userViewModel);

        void Delete(int userId);

        void Save();
    }
}