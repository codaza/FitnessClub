using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
