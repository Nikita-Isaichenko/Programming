using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {      
        public MainForm()
        {
            InitializeComponent();           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerTab.SaveCustomersData();
            ItemsTab.SaveItemsData();
        }
    }
}
