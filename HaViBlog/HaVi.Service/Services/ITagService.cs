using HaViBlog.Service.ViewModels;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface ITagService
    {
        //get all record in table
        List<TagViewModel> GetAll();

        void Save();
    }
}