using System;

namespace WcfServiceLibrary.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Balance { get; set; }
    }
}