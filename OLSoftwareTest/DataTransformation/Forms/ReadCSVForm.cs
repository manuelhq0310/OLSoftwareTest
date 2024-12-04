using DataTransformation.Models;
using DataTransformation.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransformation.Forms
{
    public partial class ReadCSVForm : Form
    {
        private readonly string _informationType;
        InformationService informationService = new InformationService();

        public ReadCSVForm(string informationType)
        {
            InitializeComponent();
            _informationType = informationType;
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                Title = "Seleccione un archivo CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCsvPath.Text = openFileDialog.FileName;
            }
        }

        private void btnReadCsv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCsvPath.Text))
            {
                string filePath = txtCsvPath.Text;

                try
                {
                    switch (_informationType)
                    {
                        case Constants.CLIENTS:
                            List<Person> clientsList = informationService.ReadClientsCsv(filePath);
                            dataGridView1.DataSource = clientsList;
                            break;
                        case Constants.PRODUCTS:
                            List<Product> productsList = informationService.ReadProductsCsv(filePath);
                            dataGridView1.DataSource = productsList;
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCsvPath.Text))
            {
                string filePath = txtCsvPath.Text;

                try
                {
                    string json = string.Empty;

                    switch (_informationType)
                    {
                        case Constants.CLIENTS:
                            List<Person> clientsList = informationService.ReadClientsCsv(filePath);
                            json = JsonConvert.SerializeObject(clientsList, Formatting.Indented);
                            break;
                        case Constants.PRODUCTS:
                            List<Product> productsList = informationService.ReadProductsCsv(filePath);
                            json = JsonConvert.SerializeObject(productsList, Formatting.Indented);
                            break;
                    }

                    JsonExport jsonExport = new JsonExport(json);
                    jsonExport.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
