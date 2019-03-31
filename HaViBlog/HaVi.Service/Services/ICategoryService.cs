using HaViBlog.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaViBlog.Service.Services
{
    public interface ICategoryService
    {
        //get all record in table
        List<CategoryViewModel> GetAll();

        List<CategoriesGroupViewModel> GetCategoriesGroup();

        void Save();
    }
}
