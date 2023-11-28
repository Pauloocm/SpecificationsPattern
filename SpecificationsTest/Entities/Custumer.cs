namespace SpecificationsTest.Entities
{
    public class Custumer
    {
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public DateTime MembershipStartDate { get; set; }

        public Custumer(string name, bool isPremium, DateTime membershipStartDate)
        {
            Name = name;
            IsPremium = isPremium;
            MembershipStartDate = membershipStartDate;
        }
    }
}
