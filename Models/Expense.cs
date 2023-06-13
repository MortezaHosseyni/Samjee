using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Samjee.Models
{
    public class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int EX_ID { get; set; }

        public string EX_Title { get; set; }

        public long EX_Value { get; set; }

        public DateTime EX_CreateDate { get; set; }

        [ForeignKey("Transaction")]
        public int EX_Transaction { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
