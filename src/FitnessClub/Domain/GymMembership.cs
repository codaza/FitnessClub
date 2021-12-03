namespace FitnessClub.Domain
{
    internal class GymMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymMembership(decimal price)
        {
            _name = "Gym membership";
            _price = price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
