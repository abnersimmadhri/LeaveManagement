using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LeaveManagement.Entity.LeaveManagement
{
    public class User : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Emp_SID { get; set; }
        [DisplayName("Company No.")]
        [Required]
        public string CompanyNo { get; set; }
        [DisplayName("UserName")]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string InternetAddress { get; set; }
        [DisplayName("Department")]
        public string OrganisatinalUnit { get; set; }
        public string SupervisorPersonnelNumber { get; set; }
        [DisplayName("Manager UserName")]
        public string SupervisorNotesUserName { get; set; }
        public string Supervisor { get; set; }
        public string SupervisorSID { get; set; }
        [ForeignKey("SupervisorSID")]
        public virtual User Manager { get; set; }
        public string SupervisorKnownAs { get; set; }
        [DisplayName("GL")]
        public string CostCentre { get; set; }
        [DisplayName("Payroll Code")]
        public string PayrollCode { get; set; }

        public string SubgroupCode { get; set; }
    }
}
