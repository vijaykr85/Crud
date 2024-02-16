using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Student
    {
        [Key]
        public int roll { get; set; }

        public string name { get; set; }

        public string subject { get; set; } 


    }
}
