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
            .ConstructUsing(c => new Post(c.Title, c.Description, c.Content, c.Thumbnail,
            c.CreateDate, c.UpdateDate, c.Status, c.Alias, c.UserId, c.ViewCount));

            CreateMap<CategoryViewModel, Category>()
                .ConstructUsing(a => new Category(a.Id, a.CategoryName, a.ParentId,
                a.IconClass, a.Url, a.IsParent));

            CreateMap<CommentViewModel, Comment>()
           .ConstructUsing(c => new Comment());
        }
    }
}