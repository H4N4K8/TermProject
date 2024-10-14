using System.ComponentModel.DataAnnotations;

namespace Chapter3Project.Models
{
    public class ClothingPoses
    {
        public int Id { get; set; }
        public string SetId { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter set name.")]
        [Display(Name = "Set Name")]
        public string SetName { get; set; } = string.Empty;
        [Display(Name = "Smiski Pose")]
        public string SmiskiType { get; set; } = string.Empty;

    }
}
