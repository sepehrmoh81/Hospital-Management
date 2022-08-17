namespace Classes
{
    class Doctor : Person
    {
        public string Profession { get; set; }
        public string Degree { get; set; }

        public Doctor(int Id, string Name, string Profession, string Degree)
        {
            this.Id = Id;
            this.Name = Name;
            this.Profession = Profession;
            this.Degree = Degree;
        }
    }
}
