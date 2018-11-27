using System;

namespace WcfServiceLibrary.model
{
    public class Bet
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float InValue { get; set; }
        public float Coefficent { get; set; }
        public bool? Result { get; set; }
        public float? OutValue { get; set; }
    }
}