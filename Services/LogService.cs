namespace DataKapatmaMerkezi.Services;

public class LogService
{
    private readonly string _logFolder = "Logs";

    public LogService()
    {
        if (!Directory.Exists(_logFolder))
            Directory.CreateDirectory(_logFolder);
    }

    public void Write(string message)
    {
        var file = Path.Combine(_logFolder, $"{DateTime.Now:yyyy-MM-dd}.log");

        File.AppendAllText(file,
            $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}");
    }
}
