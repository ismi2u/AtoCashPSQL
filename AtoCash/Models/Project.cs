using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AtoCash.Models
{
    public class Project
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public virtual CostCenter CostCenter { get; set; }
        public int CostCenterId { get; set; }

        [Required]
        [ForeignKey("ProjectManagerId")]
        public virtual Employee ProjectManager { get; set; }
        public int ProjectManagerId { get; set; }

        [Required]
        public string ProjectDesc{ get; set; }


        [Required]
        [ForeignKey("StatusTypeId")]
        public virtual StatusType StatusType { get; set; }
        public int StatusTypeId { get; set; }
    }

    public class ProjectDTO
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int CostCenterId { get; set; }
        public string CostCenter { get; set; }
        public int ProjectManagerId { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectDesc { get; set; }
        public int StatusTypeId { get; set; }
        public string StatusType { get; set; }

    }

    public class ProjectVM
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }

    }


}
