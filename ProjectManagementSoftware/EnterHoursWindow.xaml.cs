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
using System.Windows.Shapes;

namespace ProjectManagementSoftware
{
    /// <summary>
    /// Interaction logic for EnterHoursWindow.xaml
    /// </summary>
    public partial class EnterHours : Window
    {
        public EnterHours()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string requirementsHours = RequirementsTextBox.Text;
                string designingHours = DesigningTextBox.Text;
                string codingHours = CodingTextBox.Text;
                string testingHours = TestingTextBox.Text;
                string managementHours = ProjectManagementTextBox.Text;

                double requirementsDouble = Convert.ToDouble(requirementsHours);
                double designingDouble = Convert.ToDouble(designingHours);
                double codingDouble = Convert.ToDouble(codingHours);
                double testingDouble = Convert.ToDouble(testingHours);
                double managementDouble = Convert.ToDouble(managementHours);
                Data data = new Data();
                data.Projects[0].TimeSheet.Coding = 0.0;

                Close();
            } catch (FormatException ex)
            {
                MessageBox.Show("Error", ex.GetBaseException().Message.ToString());
            }
            
        }

    }
}
