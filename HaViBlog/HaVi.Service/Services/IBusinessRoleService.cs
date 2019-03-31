
using HaViBlog.Service.ViewModels;
using HaViBlog.Utilities.Dtos;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface IBusinessRoleService
    {
        //get all record in table
        IList<BusinessRoleViewModel> GetAll();

        PagedResult<BusinessRoleViewModel> GetAllPaging(string keyword, int page, int pageSize);

        BusinessRoleViewModel Add(BusinessRoleViewModel bussinessRole);

        void Update(BusinessRoleViewModel bussinessRole);

        void Delete(string bussinessRoleId);

        BusinessRoleViewModel FindById(string id);

        void Save();
    }
}