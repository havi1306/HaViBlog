using AutoMapper;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Service.ViewModels;

namespace HaViBlog.Service.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Comment, CommentViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<BusinessRole, BusinessRoleViewModel>();
            CreateMap<Role, RoleViewModel>();
            CreateMap<UserRole, UserRoleViewModel>();
        }
    }
}