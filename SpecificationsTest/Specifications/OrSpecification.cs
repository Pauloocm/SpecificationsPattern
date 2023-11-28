namespace SpecificationsTest.Specifications
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        public OrSpecification(ISpecification<T> leftSpec, ISpecification<T> rightSpec)
        {
            left = leftSpec;
            right = rightSpec;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return left.IsSatisfiedBy(entity) || right.IsSatisfiedBy(entity);
        }
    }
}