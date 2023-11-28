using SpecificationsTest.Entities;

namespace SpecificationsTest.Specifications
{
    public class DiscountSpecification : ISpecification<Custumer>
    {
        public bool IsSatisfiedBy(Custumer entity)
        {
            return entity.IsPremium;
        }
    }
}
