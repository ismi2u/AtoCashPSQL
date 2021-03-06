using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtoCash.Models
{
    public class Department
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string DeptCode { get; set; }

        [Required]
        public string DeptName { get; set; }

        [Required]
        [ForeignKey("CostCenterId")]
        public virtual CostCenter CostCenter { get; set; }
        public int CostCenterId { get; set; }


        [Required]
        [ForeignKey("StatusTypeId")]
        public virtual StatusType StatusType { get; set; }
        public int StatusTypeId { get; set; }
    }

    public class DepartmentDTO
    {

        public int Id { get; set; }

        public string DeptCode { get; set; }

        public string DeptName { get; set; }

        public int CostCenterId { get; set; }

        public string CostCenter { get; set; }

        public string StatusType { get; set; }

        public int StatusTypeId { get; set; }

    }

    public class DepartmentVM
    {

        public int Id { get; set; }

        public string DeptName { get; set; }
        public string DeptDesc { get; set; }

    }
}
