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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernDesign.MVVM.View
{
    /// <summary>
    /// Interaction logic for DashBoardView.xaml
    /// </summary>
    public partial class DashBoardView : UserControl
    {
        public DashBoardView()
        {
            InitializeComponent();


            Project FirstProject = new Project();

            FirstProject.ProjectID = "#001";
            FirstProject.Updates = "Project on Target";
            FirstProject.Items = "Documentation";
            FirstProject.Users = "DJC, GKJ, LKJ";
            FirstProject.TimeLine = "March 1st";
            FirstProject.Budget = "54%";
            Dashboard.Items.Add(FirstProject);  


        }

        public class Project
        {
            public string ProjectID { get; set; }
            public string Updates { get; set; }
            public string Items { get; set; }
            public string Users { get; set; }
            public string TimeLine { get; set; }
            public string Budget { get; set; }
            
        }
        
    }
}
