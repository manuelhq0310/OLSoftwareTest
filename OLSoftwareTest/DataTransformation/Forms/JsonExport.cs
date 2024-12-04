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
    public partial class JsonExport : Form
    {
        public JsonExport(string json)
        {
            InitializeComponent();
            txtJson.Text = json;
        }
    }
}
