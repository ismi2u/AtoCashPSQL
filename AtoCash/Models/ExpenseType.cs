﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtoCash.Models
{
    public class ExpenseType
    {


        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ExpenseTypeName { get; set; }

        [Required]
        public string ExpenseTypeDesc { get; set; }

        [Required]
        [ForeignKey("StatusTypeId")]
        public virtual StatusType StatusType { get; set; }
        public int StatusTypeId { get; set; }

    }


    public class ExpenseTypeDTO
    {

        public int Id { get; set; }
        public string ExpenseTypeName { get; set; }
        public string ExpenseTypeDesc { get; set; }
        public string StatusType { get; set; }
        public int StatusTypeId { get; set; }

    }


    public class ExpenseTypeVM
    {
        public int Id { get; set; }
        public string ExpenseTypeName { get; set; }

    }
}
