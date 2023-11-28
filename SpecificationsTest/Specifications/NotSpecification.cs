namespace SpecificationsTest.Specifications
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> specifications;

        public NotSpecification(ISpecification<T> specification)
        {
            specifications = specification;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return !specifications.IsSatisfiedBy(entity);
        }
    }
}