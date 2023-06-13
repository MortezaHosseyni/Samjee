using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samjee.Models
{
    public class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int TR_ID { get; set; }

        public string TR_Title { get; set; }

        [RegularExpression(@"^(?:[1-9]|10)$")] public byte? TR_Level { get; set; } // 1: Best | 10: Worst

        public byte TR_Type { get; set; } // 0: For ML | 1: For Calculating

        public DateTime TR_CreateDate { get; set; }

        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
