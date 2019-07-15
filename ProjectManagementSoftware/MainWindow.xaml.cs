using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ProjectManagementSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Data DataContent { get; set; }

        // Any CPU
        private string jsonPath = "../../Data.json";
        //private string jsonPath = "Data.json"; // 64bit

        private string Contents { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Contents = File.ReadAllText(jsonPath);
            DataContent = JsonConvert.DeserializeObject<Data>(Contents);
            // DataContent can now be used to read and change fields in Data.json
            // All fields should be marked as required before altering DataContent
            // Some sample data of what one project may look like is included in Data.json

            // Here is how you would add a new project to DataContent
            Project newProject = new Project
            {
                Name = "",
                Description = ""
                // more
            };

            DataContent.Projects.Append(newProject);
            // Then call UpdateJsonFile()
            UpdateJsonFile();

        }

        // Call this function after changing any attribute of DataContent
        private void UpdateJsonFile()
        {
            string updatedFile = JsonConvert.SerializeObject(DataContent);
            File.WriteAllText(jsonPath, updatedFile);
        }
    }
}
