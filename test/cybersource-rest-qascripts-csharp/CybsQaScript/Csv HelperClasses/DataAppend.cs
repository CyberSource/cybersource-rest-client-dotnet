using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CybsQaScript.Csv_HelperClasses
{
    public class DataAppend
    {
        public IEnumerable<CSVLoadData> ReadPrevData()
        {
            TextReader txtReader1 = new StreamReader(@"../../CSV_Files/TestReport/TestResults.csv");
            var csv1 = new CsvHelper.CsvReader(txtReader1);
            IEnumerable<CSVLoadData> records = csv1.GetRecords<CSVLoadData>().ToList();
            csv1.Dispose();
            return records;
        }
    }
}