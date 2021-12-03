using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
