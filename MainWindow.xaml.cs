using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Comp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int totalCost = 0;
            totalCost += GetSelectedCost(OSComboBox);
            totalCost += GetSelectedCost(CPUComboBox);
            totalCost += GetSelectedCost(MotherboardComboBox);
            totalCost += GetSelectedCost(AntivirusComboBox);
            totalCost += GetSelectedCost(PowerSupplyComboBox);
            totalCost += GetSelectedCost(RAMComboBox);

            if (BluetoothCheckBox.IsChecked == true)
                totalCost += 500;
            if (EthernetCheckBox.IsChecked == true)
                totalCost += 250;
            if (SoundCardCheckBox.IsChecked == true)
                totalCost += 1500;
            if (CDDriveCheckBox.IsChecked == true)
                totalCost += 1000;

            ResultTextBlock.Text = $"Итоговая стоимость: {totalCost} рублей";
        }

        private int GetSelectedCost(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                return int.Parse(selectedItem.Tag.ToString());
            }
            return 0;
        }
    }
}