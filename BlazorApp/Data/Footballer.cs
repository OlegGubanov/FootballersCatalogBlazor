using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Footballer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Team { get; set; }
        [Required]
        public string Country { get; set; }

        public Footballer()
        {
            Name = null;
            Surname = null;
            Gender = Gender.Male;
            Birthdate = new DateTime(2000, 1, 1);
            Team = null;
            Country = null;
        }

        public Footballer(string name, string surname, Gender gender, DateTime birthdate, string team, string country)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Birthdate = birthdate;
            Team = team;
            Country = country;
        }
    }
}
