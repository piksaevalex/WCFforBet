using System;

namespace WcfServiceLibrary.Model
{
    public class Bet
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double InValue { get; set; }
        public double Coefficent { get; set; }
        public bool? Result { get; set; }
        public double? OutValue { get; set; }
    }
}