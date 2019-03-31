using HaViBlog.Infrastructure.DomainEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("PostCategory")]
    public class PostCategory : DomainEntity<int>
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}