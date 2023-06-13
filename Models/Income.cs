using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samjee.Models
{
    public class Income
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int IN_ID { get; set; }

        public string IN_Title { get; set; }

        public long IN_Value { get; set; }

        public DateTime IN_CreateDate { get; set; }

        [ForeignKey("Transaction")]
        public int IN_Transaction { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
