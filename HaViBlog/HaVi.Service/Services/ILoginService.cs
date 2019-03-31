using HaViBlog.Service.ViewModels;

namespace HaViBlog.Service.Services
{
    public interface ILoginService
    {
        UserViewModel checkLogin(string userName, string passWord);

        UserViewModel IsAdmin(int userId);

        void Save();
    }
}