using MVC.Models.Enums;
using MVC.Models;
using MVC.Models.Logs;

namespace MVC.Data;

public class SeedingService
{
    private MVCContext _context;

    public SeedingService(MVCContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (_context.Department.Any() ||
            _context.Sellers.Any() ||
            _context.SalesRecords.Any())
        {
            return; // DB has been seeded
        }

        Department d1 = new(1, "Computers");
        Department d2 = new(2, "Electronics");
        Department d3 = new(3, "Fashion");
        Department d4 = new(4, "Books");

        Seller s1 = new(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
        Seller s2 = new(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
        Seller s3 = new(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
        Seller s4 = new(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
        Seller s5 = new(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
        Seller s6 = new(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

        SalesRecord r1 = new(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
        SalesRecord r2 = new(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
        SalesRecord r3 = new(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
        SalesRecord r4 = new(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
        SalesRecord r5 = new(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
        SalesRecord r6 = new(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
        SalesRecord r7 = new(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
        SalesRecord r8 = new(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
        SalesRecord r9 = new(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
        SalesRecord r10 = new(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
        SalesRecord r11 = new(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
        SalesRecord r12 = new(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
        SalesRecord r13 = new(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
        SalesRecord r14 = new(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
        SalesRecord r15 = new(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
        SalesRecord r16 = new(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
        SalesRecord r17 = new(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
        SalesRecord r18 = new(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
        SalesRecord r19 = new(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
        SalesRecord r20 = new(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
        SalesRecord r21 = new(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
        SalesRecord r22 = new(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
        SalesRecord r23 = new(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
        SalesRecord r24 = new(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
        SalesRecord r25 = new(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
        SalesRecord r26 = new(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
        SalesRecord r27 = new(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
        SalesRecord r28 = new(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
        SalesRecord r29 = new(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
        SalesRecord r30 = new(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

        SalesLog l1 = new() { Id = 1, LogDate = new DateTime(2018, 09, 25), Message = "", SalesRecordId = r1.Id, SalesRecord = r1 };
        SalesLog l2 = new() { Id = 2, LogDate = new DateTime(2018, 09, 4), Message = "", SalesRecordId = r2.Id, SalesRecord = r2 };
        SalesLog l3 = new() { Id = 3, LogDate = new DateTime(2018, 09, 13), Message = "", SalesRecordId = r3.Id, SalesRecord = r3 };
        SalesLog l4 = new() { Id = 4, LogDate = new DateTime(2018, 09, 1), Message = "", SalesRecordId = r4.Id, SalesRecord = r4 };
        SalesLog l5 = new() { Id = 5, LogDate = new DateTime(2018, 09, 21), Message = "", SalesRecordId = r5.Id, SalesRecord = r5 };
        SalesLog l6 = new() { Id = 6, LogDate = new DateTime(2018, 09, 15), Message = "", SalesRecordId = r6.Id, SalesRecord = r6 };
        SalesLog l7 = new() { Id = 7, LogDate = new DateTime(2018, 09, 28), Message = "", SalesRecordId = r7.Id, SalesRecord = r7 };
        SalesLog l8 = new() { Id = 8, LogDate = new DateTime(2018, 09, 11), Message = "", SalesRecordId = r8.Id, SalesRecord = r8 };
        SalesLog l9 = new() { Id = 9, LogDate = new DateTime(2018, 09, 14), Message = "", SalesRecordId = r9.Id, SalesRecord = r9 };
        SalesLog l10 = new() { Id = 10, LogDate = new DateTime(2018, 09, 7), Message = "", SalesRecordId = r10.Id, SalesRecord = r10 };
        SalesLog l11 = new() { Id = 11, LogDate = new DateTime(2018, 09, 13), Message = "", SalesRecordId = r11.Id, SalesRecord = r11 };
        SalesLog l12 = new() { Id = 12, LogDate = new DateTime(2018, 09, 25), Message = "", SalesRecordId = r12.Id, SalesRecord = r12 };
        SalesLog l13 = new() { Id = 13, LogDate = new DateTime(2018, 09, 29), Message = "", SalesRecordId = r13.Id, SalesRecord = r13 };
        SalesLog l14 = new() { Id = 14, LogDate = new DateTime(2018, 09, 4), Message = "", SalesRecordId = r14.Id, SalesRecord = r14 };
        SalesLog l15 = new() { Id = 15, LogDate = new DateTime(2018, 09, 12), Message = "", SalesRecordId = r15.Id, SalesRecord = r15 };
        SalesLog l16 = new() { Id = 16, LogDate = new DateTime(2018, 10, 5), Message = "", SalesRecordId = r16.Id, SalesRecord = r16 };
        SalesLog l17 = new() { Id = 17, LogDate = new DateTime(2018, 10, 1), Message = "", SalesRecordId = r17.Id, SalesRecord = r17 };
        SalesLog l18 = new() { Id = 18, LogDate = new DateTime(2018, 10, 24), Message = "", SalesRecordId = r18.Id, SalesRecord = r18 };
        SalesLog l19 = new() { Id = 19, LogDate = new DateTime(2018, 10, 22), Message = "", SalesRecordId = r19.Id, SalesRecord = r19 };
        SalesLog l20 = new() { Id = 20, LogDate = new DateTime(2018, 10, 15), Message = "", SalesRecordId = r20.Id, SalesRecord = r20 };
        SalesLog l21 = new() { Id = 21, LogDate = new DateTime(2018, 10, 17), Message = "", SalesRecordId = r21.Id, SalesRecord = r21 };
        SalesLog l22 = new() { Id = 22, LogDate = new DateTime(2018, 10, 24), Message = "", SalesRecordId = r22.Id, SalesRecord = r22 };
        SalesLog l23 = new() { Id = 23, LogDate = new DateTime(2018, 10, 19), Message = "", SalesRecordId = r23.Id, SalesRecord = r23 };
        SalesLog l24 = new() { Id = 24, LogDate = new DateTime(2018, 10, 12), Message = "", SalesRecordId = r24.Id, SalesRecord = r24 };
        SalesLog l25 = new() { Id = 25, LogDate = new DateTime(2018, 10, 31), Message = "", SalesRecordId = r25.Id, SalesRecord = r25 };
        SalesLog l26 = new() { Id = 26, LogDate = new DateTime(2018, 10, 6), Message = "", SalesRecordId = r26.Id, SalesRecord = r26 };
        SalesLog l27 = new() { Id = 27, LogDate = new DateTime(2018, 10, 13), Message = "", SalesRecordId = r27.Id, SalesRecord = r27 };
        SalesLog l28 = new() { Id = 28, LogDate = new DateTime(2018, 10, 7), Message = "", SalesRecordId = r28.Id, SalesRecord = r28 };
        SalesLog l29 = new() { Id = 29, LogDate = new DateTime(2018, 10, 23), Message = "", SalesRecordId = r29.Id, SalesRecord = r29 };
        SalesLog l30 = new() { Id = 30, LogDate = new DateTime(2018, 10, 12), Message = "", SalesRecordId = r30.Id, SalesRecord = r30 };

        _context.Department.AddRange(d1, d2, d3, d4);

        _context.Sellers.AddRange(s1, s2, s3, s4, s5, s6);

        _context.SalesRecords.AddRange(
            r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
            r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
            r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
        );

        _context.SalesLogs.AddRange(
            l1, l2, l3, l4, l5, l6, l7, l8, l9, l10,
            l11, l12, l13, l14, l15, l16, l17, l18, l19, l20,
            l21, l22, l23, l24, l25, l26, l27, l28, l29, l30
        );

        _context.SaveChanges();
    }
}