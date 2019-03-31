using HaViBlog.Service.ViewModels;

namespace HaViBlog.Service.Services
{
    public interface ICommentService
    {
        CommentViewModel Add(CommentViewModel comment);

        void Save();
    }
}