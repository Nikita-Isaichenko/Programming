using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public Item item;

        public Customer customer;
        public MainForm()
        {
            InitializeComponent();
            
            Item[] items = new Item[10];
            Customer[] customers = new Customer[10];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item("dkj", "jdalkfs", 100.5);
                customers[i] = new Customer("djkfalf", "jasdfklsdf");
                Console.WriteLine(items[i].Id);
                Console.WriteLine(customers[i].Id);
            }

        }
    }
}
