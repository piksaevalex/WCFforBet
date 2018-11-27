using System;

namespace WcfServiceLibrary.model
{
    public class Account
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float Balance { get; set; }
    }
}