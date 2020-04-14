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

namespace WPFUIDesign
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Discription text is {DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckBox.IsChecked = AssemblyCheckBox.IsChecked = PlasmaCheckBox.IsChecked = LaserCheckBox.IsChecked =FoldCheckBox.IsChecked=
                 PrachaseCheckBox.IsChecked = LatheCheckBox.IsChecked = DrillCheckBox.IsChecked = RollCheckBox.IsChecked = SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;
            this.NoteText.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }
    }
}
