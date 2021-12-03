using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal class GymPlusPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymPlusPoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymPlusPoolMembership membership = new(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
