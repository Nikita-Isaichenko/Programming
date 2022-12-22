using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppEvent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var contact = new Contact();

            var Form1 = new EventForm() { Text = "main", Contact = contact };
            var Form2 = new EventForm() { Text = "secondary", Contact = contact };
            var Form3 = new EventForm() { Text = "secondary", Contact = contact };

            Form1.Show();
            Form2.Show();
            Form3.Show();
            
        }
    }
}
