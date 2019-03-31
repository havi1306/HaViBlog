using AutoMapper;
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
    public class UserService : IUserService
    {
        private IReadRepository<User> userRepository;
        private ICUDRepository<User> userCUDRepository;

        private IUnitOfWork unitOfWork;

        public UserService(IReadRepository<User> _userRepository
            , ICUDRepository<User> _userCUDRepository
            , IUnitOfWork _unitOfWork)
        {
            userRepository = _userRepository;
            userCUDRepository = _userCUDRepository;
            unitOfWork = _unitOfWork;
        }

        public UserViewModel Add(UserViewModel userViewModel)
        {
            var user = Mapper.Map<UserViewModel, User>(userViewModel);
            userCUDRepository.Add(user);
            return userViewModel;
        }

        public void Delete(int userId)
        {
            var user = userRepository.FindSingle(s => s.Id == userId);
            userCUDRepository.Remove(user);
        }

        public UserViewModel FindById(int userId)
        {
            return Mapper.Map<User, UserViewModel>(userRepository.FindSingle(s => s.Id == userId));
        }

        public IList<UserViewModel> GetAll()
        {
            return userRepository.FindAll().ProjectTo<UserViewModel>().ToList();
        }

        public void Save()
        {
            unitOfWork.Commit();
        }

        public void Update(UserViewModel userViewModel)
        {
            userCUDRepository.Update(Mapper.Map<UserViewModel, User>(userViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}