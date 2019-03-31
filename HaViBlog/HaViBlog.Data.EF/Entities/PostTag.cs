using HaViBlog.Infrastructure.DomainEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("PostTag")]
    public class PostTag : DomainEntity<int>
    {
        public int PostId { get; set; }
        public int TagId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }

        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
    }
}