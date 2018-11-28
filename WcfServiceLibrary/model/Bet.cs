using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WcfServiceLibrary.Model
{
    public class Bet
    {
        public int Id { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public double InValue { get; set; }
        public double Coefficent { get; set; }
        public bool? Result { get; set; }
        public double? OutValue { get; set; }
    }
}