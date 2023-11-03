using System.Collections.Generic;
using System.Windows;

namespace InventoryPro
{
    internal class AisleCount
    {
        private List<StorageBin> _storageBins = new List<StorageBin>();
        public static void parseAisleCounts(string filename)
        {
            string filePath = filename;
            MessageBox.Show($"Bin Consolidate: {filename}");


            //using (var package = new ExcelPackage(new FileInfo(filePath)))
            //{
            //    Get the first worksheet in the Excel file(index 1 - based).
            //    worksheet = package.Workbook.Worksheets[1];
            //
            //
            //}
        }
    }
}
