using SpecificationsTest.Entities;

namespace SpecificationsTest.Specifications
{
    public class OneYearMembershipSpecification : ISpecification<Custumer>
    {
        public bool IsSatisfiedBy(Custumer entity)
        {
            return entity.MembershipStartDate <= DateTime.Now.AddYears(-1);
        }
    }
}
