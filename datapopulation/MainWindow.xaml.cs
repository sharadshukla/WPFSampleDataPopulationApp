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
using datapopulation.Model;

namespace datapopulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        // List to populate the grid
        List<person> ListofPersons;

        public MainWindow()
        {
            InitializeComponent();

            // Populating the data

             ListofPersons = new List<person>();
            ListofPersons.Add(new person(){firstName ="Sharad",
                lastName="Shukla", DateofBirth= new DateTime(1983,06,13), info="Hardware/Software Programming"});
           
            ListofPersons.Add(new person(){ firstName="Rohit", 
                lastName="Tidke",DateofBirth=new DateTime(1986,2,12), info="Software Programming"});

            ListofPersons.Add(new person(){ firstName = "Rajat",
                lastName = "Shukla", DateofBirth = new DateTime(1976, 10, 24), info = "Hardware Designing" });

            ListofPersons.Add(new person() {firstName = "Martin",
                lastName = "Jung", DateofBirth = new DateTime(1982, 10, 15), info = "Firmware Designing"});

            this.sharadGrid.ItemsSource = ListofPersons;

            // Selecting the People with knowledge of Hardware
            var hardwareQ = from p in ListofPersons
                            where p.info.ToLower().Contains("hardware")
                            select p;

            this.sharadGrid_LINQ.ItemsSource = hardwareQ.ToList();
        }
    }
}
