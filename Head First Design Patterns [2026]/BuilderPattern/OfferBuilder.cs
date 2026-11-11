namespace BuilderPattern;

public class OfferBuilder
{
    private readonly Offer _offer = new();
    
    public OfferBuilder WithJobId(int jobId)
    {
        if (jobId <= 0)
            throw new Exception("Job ID must be greater than zero.");

        _offer.JobId = jobId;
        return this;
    }

    public OfferBuilder WithCandidateName(string candidateName)
    {
        if (string.IsNullOrWhiteSpace(candidateName))
            throw new Exception("Candidate name is required.");

        _offer.CandidateName = candidateName.Trim();
        return this;
    }

    public OfferBuilder WithDepartment(string department)
    {
        _offer.Department = department.Trim();
        return this;
    }

    public OfferBuilder WithOfferStatus(Status status)
    {
        _offer.OfferStatus = status;
        return this;
    }

    public OfferBuilder WithIsInternalCandidate(bool isInternal)
    {
        _offer.IsInternalCandidate = isInternal;
        return this;
    }

    public OfferBuilder WithAnnualCTC(decimal annualCTC)
    {
        // Example business range: ₹1 to ₹1 crore.
        if (annualCTC is < 1 or > 1_00_00_000)
            throw new Exception( "Annual CTC must be between ₹1 and ₹1 crore.");

        _offer.AnnualCTC = annualCTC;
        return this;
    }

    public OfferBuilder WithJoiningBonus(decimal joiningBonus)
    {
        _offer.JoiningBonus = joiningBonus;
        return this;
    }

    public OfferBuilder WithEmploymentType(string employmentType)
    {
        _offer.EmploymentType = employmentType.Trim();
        return this;
    }

    public OfferBuilder WithWorkLocation(string workLocation)
    {
        _offer.WorkLocation = workLocation.Trim();
        return this;
    }

    public OfferBuilder WithJoiningDate(DateTime joiningDate)
    {
        _offer.JoiningDate = joiningDate;
        return this;
    }

    public OfferBuilder WithReportingManager(string reportingManager)
    {
        _offer.ReportingManager = reportingManager?.Trim() ?? string.Empty;
        return this;
    }

    public OfferBuilder WithNotes(string? notes)
    {
        _offer.Notes = notes?.Trim();
        return this;
    }

    public Offer Build()
    {
        // Cross-property validation
        if (_offer.JoiningBonus > _offer.AnnualCTC)
            throw new Exception("Joining bonus cannot exceed annual CTC.");
        return _offer;
    }
}
