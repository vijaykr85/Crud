using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Crud
    {
        [Key]
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }


    }
}
