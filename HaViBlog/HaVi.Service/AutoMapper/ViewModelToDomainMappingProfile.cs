using AutoMapper;
using HaViBlog.Data.EF.Entities;
using HaViBlog.Service.ViewModels;

namespace HaViBlog.Service.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PostViewModel, Post>()
            .ConstructUsing(c => new Post());

            CreateMap<CategoryViewModel, Category>()
                .ConstructUsing(a => new Category(a.Id, a.CategoryName, a.ParentId,
                a.IconClass, a.Url, a.IsParent));

            CreateMap<CommentViewModel, Comment>()
           .ConstructUsing(c => new Comment());

            CreateMap<UserViewModel, User>()
           .ConstructUsing(c => new User());

            CreateMap<BusinessRoleViewModel, BusinessRole>()
           .ConstructUsing(c => new BusinessRole());

            CreateMap<RoleViewModel, Role>()
           .ConstructUsing(c => new Role());

            CreateMap<UserRoleViewModel, UserRole>()
            .ConstructUsing(c => new UserRole(c.UserId, c.RoleId));

        }
    }
}