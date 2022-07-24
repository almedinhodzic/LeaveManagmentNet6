using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }

        [Display(Name = "Number of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Please type a number between 1 and 50")]
        public int NumberOfDays { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}