using System;

namespace HaViBlog.Service.ViewModels
{
    public class CommentInPostViewModel
    {
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
    }
}