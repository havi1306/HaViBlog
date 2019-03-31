using AutoMapper.QueryableExtensions;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Infrastructure.Interface;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaViBlog.Service.ServicesImplementation
{
    public class TagService : ITagService
    {
        private IReadRepository<Tag> _tagRepository;
        private IUnitOfWork _unitOfWork;

        public TagService(IReadRepository<Tag> tagRepository, IUnitOfWork unitOfWork)
        {
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TagViewModel> GetAll()
        {
            return _tagRepository.FindAll().ProjectTo<TagViewModel>().ToList();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
