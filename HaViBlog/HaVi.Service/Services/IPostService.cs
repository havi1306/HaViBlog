using HaViBlog.Service.ViewModels;
using HaViBlog.Utilities.Dtos;
using System.Collections.Generic;

namespace HaViBlog.Service.Services
{
    public interface IPostService
    {
        List<PostViewModel> GetLatest();

        IList<PostViewModel> GetAll();

        PagedResult<PostHomeViewModel> GetAllPaging(string keyword, int page, int pageSize);

        // lay recode dua theo id
        PostViewModel GetById(int id);
        // detail post
        DetailPostViewModel GetDetail(int id);

        PostViewModel Add(PostViewModel post);

        void Update(PostViewModel post);

        void Delete(int id);

        void Save();
    }
}