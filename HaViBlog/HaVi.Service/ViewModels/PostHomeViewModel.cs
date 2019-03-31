using System;

namespace HaViBlog.Service.ViewModels
{
    public class PostHomeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; } = "~/img/blog-post-1.jpeg";
        public DateTime CreateDate { get; set; }
        public string Alias { get; set; }
        public int? ViewCount { get; set; }
        // 2 thuoc tinh user
        public string ImageAvatar { get; set; }
        public string UserName { get; set; }
        // tạo  
        public string DateCreateAgo { get; set; }
    }
}