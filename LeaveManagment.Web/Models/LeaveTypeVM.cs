using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models

{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required(ErrorMessage = "The Default Days field is required.")]
        [Range(1, 25, ErrorMessage = "Please enter a valid number")]
        public int DefaultDays { get; set; }

    }
}
