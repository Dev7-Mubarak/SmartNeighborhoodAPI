﻿namespace OurProjectSmartNeiborhood.Entites
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string FamilyNotes { get; set; }






        public int FamilyCatgoryId { get; set; }
        public FamilyCatgory FamilyCatgory { get; set; }

        public int FamilyTypeId { get; set; }
        public FamilyType FamilyType { get; set; }

        public List<FamilyMember> FamilyMembers { get; set; }


        public int? BlockId { get; set; }
        public Block? Block { get; set; }
    }
}
