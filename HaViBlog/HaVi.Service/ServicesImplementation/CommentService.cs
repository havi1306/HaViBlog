using AutoMapper;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Infrastructure.Interface;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using System;

namespace HaViBlog.Service.ServicesImplementation
{
    public class CommentService : ICommentService
    {
        private IReadRepository<Comment> _commentRepository;
        private ICUDRepository<Comment> _commentRepositoryCUD;

        private IUnitOfWork _unitOfWork;

        public CommentService(IReadRepository<Comment> commentRepository
                                , IUnitOfWork unitOfWork
                                , ICUDRepository<Comment> commentRepositoryCUD)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
            _commentRepositoryCUD = commentRepositoryCUD;
        }

        public CommentViewModel Add(CommentViewModel comment)
        {
            var cm = Mapper.Map<CommentViewModel, Comment>(comment);
            _commentRepositoryCUD.Add(cm);
            return comment;
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}