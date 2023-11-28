using SpecificationsTest.Entities;

namespace SpecificationsTest.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
