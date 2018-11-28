using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WcfServiceLibrary.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public double Balance { get; set; }
    }
}