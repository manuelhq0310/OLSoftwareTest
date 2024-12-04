using DataTransformation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransformation.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void itemClients_Click(object sender, EventArgs e)
        {
            ReadCSVForm readCSVForm = new ReadCSVForm(Constants.CLIENTS);
            readCSVForm.ShowDialog();
        }

        private void itemProducts_Click(object sender, EventArgs e)
        {
            ReadCSVForm readCSVForm = new ReadCSVForm(Constants.PRODUCTS);
            readCSVForm.ShowDialog();
        }
    }
}
