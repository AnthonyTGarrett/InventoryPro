using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OfficeOpenXml;
using System.IO;

namespace InventoryPro
{
    internal class AisleCount
    {
        public static void parseAisleCounts(string filename)
        {
            string filePath = filename;


            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                // Get the first worksheet in the Excel file (index 1-based).
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                
            }
        }
    }
}
