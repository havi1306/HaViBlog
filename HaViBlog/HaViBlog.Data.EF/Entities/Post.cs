using HaViBlog.Infrastructure.DomainEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("Post")]
    public class Post : DomainEntity<int>
    {
        [MaxLength(500)]
        [Required]// not null
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [MaxLength(256)]
        public string Thumbnail { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

        public byte Status { get; set; }
        public string Alias { get; set; }
        public int UserId { get; set; }
        public int ViewCount { get; set; }

        public User User { get; set; }

        //public ICollection<PostCategory> PostCategories { get; set; }
        //public ICollection<Comment> Comments { get; set; }
        //public ICollection<PostTag> PostTag { get; set; }
        public Post()
        {
        }
        public Post(string title, string description, string content, string thumbnail,
                   DateTime? createDate, DateTime? UpdateDate, byte Status, string Alias,
                   int userId, int viewCount
                   )
        {
        }
    }
}