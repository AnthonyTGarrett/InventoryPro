using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OfficeOpenXml;

namespace InventoryPro
{
    internal class AisleCount
    {
        public static void parseAisleCounts(string filename)
        {
            MessageBox.Show($"Aisle Counts : {filename}");
        }
    }
}
