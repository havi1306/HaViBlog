using AutoMapper.QueryableExtensions;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Infrastructure.Interface;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HaViBlog.Service.ServicesImplementation
{
    public class CategoryService : ICategoryService
    {
        private IReadRepository<Category> _categoryRepository;
        private IReadRepository<PostCategory> _postCategoryRepository;

        private IUnitOfWork _unitOfWork;

        public CategoryService(IReadRepository<Category> categoryRepository, IReadRepository<PostCategory> postCategoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CategoryViewModel> GetAll()
        {
            return _categoryRepository.FindAll().ProjectTo<CategoryViewModel>().ToList();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CategoriesGroupViewModel> GetCategoriesGroup()
        {
            var groupJoin = from pc in _postCategoryRepository.FindAll()
                            join c in _categoryRepository.FindAll()
                            on pc.CategoryId equals c.Id
                            select new
                            {
                                Id = pc.Id,
                                CategoryId = pc.CategoryId,
                                CategoryName = c.CategoryName,
                                Url = c.Url
                            };
            var listGroupCount = groupJoin.GroupBy(info => info.CategoryName)
                        .Select(group => new CategoriesGroupViewModel
                        {
                            CategoryName = group.Key,
                            GroupCount = group.Count(),
                            //Url=group.Url
                        });
            return listGroupCount.ToList();
        }
    }
}