using ClosedXML.Excel;
using DataKapatmaMerkezi.Models;

namespace DataKapatmaMerkezi.Services;

public class ExcelService
{
    public List<CustomerRecord> Read(string fileName)
    {
        var result = new List<CustomerRecord>();

        using var wb = new XLWorkbook(fileName);

        var ws = wb.Worksheet(1);

        var headerRow = ws.Row(1);

        int column = -1;

        foreach (var cell in headerRow.CellsUsed())
        {
            if (cell.GetString().Trim() == "Sıra No")
            {
                column = cell.Address.ColumnNumber;
                break;
            }
        }

        if (column == -1)
            throw new Exception("Excel içerisinde 'Sıra No' sütunu bulunamadı.");

        foreach (var row in ws.RowsUsed().Skip(1))
        {
            var value = row.Cell(column).GetString().Trim();

            if (!string.IsNullOrWhiteSpace(value))
            {
                result.Add(new CustomerRecord
                {
                    CustomerId = value
                });
            }
        }

        return result
            .GroupBy(x => x.CustomerId)
            .Select(x => x.First())
            .ToList();
    }
}
