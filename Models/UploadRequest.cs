namespace DataKapatmaMerkezi.Models;

public class UploadRequest
{
    public string TableName { get; set; } = "";

    public int CampaignId { get; set; }

    public string ExcelFile { get; set; } = "";
}
