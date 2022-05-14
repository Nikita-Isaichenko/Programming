using System.Windows.Forms;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            seasonHandleControl1.SeasonChange += Enumerations.PictureBox_UploadImagel;
        }
    }
}
