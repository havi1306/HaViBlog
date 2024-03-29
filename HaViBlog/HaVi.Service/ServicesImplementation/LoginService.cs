﻿using AutoMapper.QueryableExtensions;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Infrastructure.Interface;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using System;
using System.Linq;

namespace HaViBlog.Service.ServicesImplementation
{
    public class LoginService : ILoginService
    {
        private IReadRepository<User> userRepository;
        private IUnitOfWork unitOfWork;

        public LoginService(IReadRepository<User> _userRepository, IUnitOfWork _unitOfWork)
        {
            userRepository = _userRepository;
            unitOfWork = _unitOfWork;
        }

        public UserViewModel checkLogin(string userName, string passWord)
        {
            var user = userRepository.FindAll(s => s.UserName == userName && s.Password == passWord && s.Allowed == 1).ProjectTo<UserViewModel>().SingleOrDefault();
            return user;
        }

        public UserViewModel IsAdmin(int userId)
        {
            var user = userRepository.FindAll(s => s.Id == userId && s.IsAdmin.Value != 0).ProjectTo<UserViewModel>().FirstOrDefault();
            return user;
        }

        public void Save()
        {
            unitOfWork.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}