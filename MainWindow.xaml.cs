using System;
using System.Windows;
using Microsoft.Win32;


namespace InventoryPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "EXPORT"; // Default file name
            dialog.DefaultExt = ".xlsx"; // Default file extension
            dialog.Filter = "Excel documents (.xlsx)|*.xlsx"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dialog.FileName;

                File_textBox.Text = filename;
            }
        }

        private void btnProcessFile_Click(object sender, RoutedEventArgs e)
        {
            if (Selection_comboBox.SelectedIndex == 0)
                AisleCount.parseAisleCounts(File_textBox.Text);

            if (Selection_comboBox.SelectedIndex == 1)
                BinConsolidation.createBinConsolidation(File_textBox.Text);

            if (Selection_comboBox.SelectedIndex == 2)
                PartialPallets.createPartialPallets(File_textBox.Text);
        }
    }
}
