using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AtoCash.Models
{
    public class CurrencyType
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string CurrencyCode { get; set; }

        [Required]
        public string CurrencyName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [ForeignKey("StatusTypeId")]
        public virtual StatusType StatusType { get; set; }
        public int StatusTypeId { get; set; }
    }

    public class CurrencyTypeDTO
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }

        public string CurrencyName { get; set; }

        public string Country { get; set; }
        public int StatusTypeId { get; set; }
    }

    public class CurrencyTypeVM
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }

    }

}
