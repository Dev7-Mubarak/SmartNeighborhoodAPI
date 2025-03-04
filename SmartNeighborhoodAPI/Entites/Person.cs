﻿using SmartNeighborhoodAPI.Entites;
using System.ComponentModel.DataAnnotations;

namespace OurProjectSmartNeiborhood.Entites
{
    public class Person
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string SecondName { get; set; }
        [MaxLength(30)]
        public string ThirdName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string? Job { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public byte[]? Image { get; set; }
        [MaxLength(5)]
        public string BloodType { get; set; }
        [MaxLength(100)]
        public string IdentityNumber { get; set; }
        public string? TypeOfIdentity { get; set; }
        [MaxLength(30)]
        public string Status { get; set; }
        public AppUser? User { get; set; }
        public List<FamilyMember>? FamilyMembers { get; set; }


        //public List<ContactInfo> ContactInfos { get; set; }
        //public List<TeamMember> TeamMembers { get; set; }
        //public List<PersonComplain> PersonComplains { get; set; }


    }
}
