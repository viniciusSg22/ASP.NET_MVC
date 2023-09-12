using MVC.Data;
using MVC.Models;
using MVC.Models.Logs;

namespace MVC.Services.Logs;

public class SalesLogService
{
    private readonly MVCContext _context;

    public SalesLogService(MVCContext context)
    {
        _context = context;
    }

    public void LogSalesRecord(SalesRecord salesRecord, string message)
    {
        var salesLog = new SalesLog
        {
            LogDate = DateTime.Now,
            Message = message,
            SalesRecordId = salesRecord.Id,
        };

        _context.SalesLogs.Add(salesLog);
        _context.SaveChanges();
    }
}