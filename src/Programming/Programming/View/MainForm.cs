using System.Windows.Forms;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            seasonHandleControl1.SeasonChange += Enumerations.PictureBox_UploadImage;
        }
    }
}
