using System.ComponentModel.DataAnnotations;

namespace HaViBlog.Infrastructure.DomainEntity
{
    public abstract class DomainEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}