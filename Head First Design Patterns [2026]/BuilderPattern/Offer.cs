namespace BuilderPattern;

public class Offer
{
    // Basic details
    public int JobId { get; set; }
    public string CandidateName { get; set; }
    public string Department { get; set; }
    public Status OfferStatus { get; set; }
    public bool IsInternalCandidate { get; set; }

    // Compensation
    public decimal AnnualCTC { get; set; }
    public decimal JoiningBonus { get; set; }

    // Employment details
    public string EmploymentType { get; set; }
    public string WorkLocation { get; set; }
    public DateTime JoiningDate { get; set; }

    // Additional details
    public string ReportingManager { get; set; }
    public string? Notes { get; set; }
    
    public void PrintOffer()
    {
        Console.WriteLine("========== JOB OFFER ==========");
        Console.WriteLine($"Job ID: {JobId}");
        Console.WriteLine($"Candidate: {CandidateName}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Status: {OfferStatus}");
        Console.WriteLine($"Internal Candidate: {IsInternalCandidate}");
        Console.WriteLine($"Annual CTC: {AnnualCTC:N2}");
        Console.WriteLine($"Joining Bonus: {JoiningBonus:N2}");
        Console.WriteLine($"Employment Type: {EmploymentType}");
        Console.WriteLine($"Work Location: {WorkLocation}");
        Console.WriteLine($"Joining Date: {JoiningDate:dd MMM yyyy}");
        Console.WriteLine($"Reporting Manager: {ReportingManager}");
        Console.WriteLine($"Notes: {Notes ?? "N/A"}");
        Console.WriteLine("===============================");
    }
}
