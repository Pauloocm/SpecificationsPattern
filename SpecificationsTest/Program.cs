using SpecificationsTest.Entities;
using SpecificationsTest.Specifications;


var costumer = new Custumer("Paulo", true, DateTime.Now.AddYears(-2));

bool isOneYearMembership = new OneYearMembershipSpecification().IsSatisfiedBy(costumer);


Console.WriteLine(isOneYearMembership);


//var isEligibleForDiscountAndIsOneYearMembership = new DiscountSpecification()
//    .And(new OneYearMembershipSpecification())
//    .IsSatisfiedBy(costumer);




