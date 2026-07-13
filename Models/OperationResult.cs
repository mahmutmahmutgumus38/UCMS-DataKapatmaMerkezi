namespace DataKapatmaMerkezi.Models;

public class OperationResult
{
    public bool Success { get; set; }

    public int TotalExcelRecords { get; set; }

    public int UpdatedListRecords { get; set; }

    public int UpdatedCustomerRecords { get; set; }

    public string Message { get; set; } = string.Empty;

    public double DurationSeconds { get; set; }
}
