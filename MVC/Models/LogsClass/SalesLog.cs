namespace MVC.Models.Logs;

public class SalesLog
{
    public int Id { get; set; }
    public DateTime LogDate { get; set; }
    public string Message { get; set; } = string.Empty;
    public int SalesRecordId { get; set; }
    public virtual SalesRecord SalesRecord { get; set; } = new SalesRecord();
}