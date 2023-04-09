using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace to_do_app.Models
{
    [Table("app_task")]
    public class AppTask
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Column("task_description")]
        public string TaskDescription { get; set; }
        
        [Required]
        [StringLength(100)]
        [Column("user")]
        public string User { get; set; }
    }
}
