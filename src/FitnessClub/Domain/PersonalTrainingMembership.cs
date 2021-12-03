namespace FitnessClub.Domain
{
    internal class PersonalTrainingMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public PersonalTrainingMembership(decimal price)
        {
            _name = "Personal Training membership";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
