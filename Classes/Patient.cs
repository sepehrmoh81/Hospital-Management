namespace Classes
{
    class Patient : Person
    {
        public string EntryDate { get; set; }
        public string DischargeDate { get; set; }
        public string CurrentState { get; set; }
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }

        public Patient(int Id, string Name, int Age, string CurrentState)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.CurrentState = CurrentState;
        }
    }
}
