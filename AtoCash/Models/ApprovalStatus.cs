using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtoCash.Models
{



    public class ApprovalStatusType
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]

        public string Status { get; set; }

        public string StatusDesc { get; set; }


        //    //Pending = 0,
        //    //Approved = 1,
        //    //Rejected = 2

    }
}
