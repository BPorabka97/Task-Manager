using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerMVC.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskID { get; set; }
        [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
