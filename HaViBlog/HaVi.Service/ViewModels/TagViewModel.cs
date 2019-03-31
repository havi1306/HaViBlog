using System.ComponentModel.DataAnnotations;

namespace HaViBlog.Service.ViewModels
{
    public class TagViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string TagName { get; set; }
    }
}