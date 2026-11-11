using BuilderPattern;

var builder = new OfferBuilder();

var offer = builder
    .WithJobId(101)
    .WithCandidateName("John")
    .WithDepartment("Engineering")
    .WithOfferStatus(Status.Published)
    .WithIsInternalCandidate(false)
    .WithAnnualCTC(2500000)
    .WithJoiningBonus(100000)
    .WithEmploymentType("Permanent")
    .WithWorkLocation("Bangalore")
    .WithJoiningDate(new DateTime(2027, 1, 1))
    .WithReportingManager("David")
    .WithNotes("Senior Software Engineer offer")
    .Build();

offer.PrintOffer();
