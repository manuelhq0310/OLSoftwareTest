namespace DataTransformation.Forms
{
    partial class ReadCSVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCsvPath = new TextBox();
            btnLoadCsv = new Button();
            btnReadCsv = new Button();
            dataGridView1 = new DataGridView();
            btnExportJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCsvPath
            // 
            txtCsvPath.Location = new Point(25, 29);
            txtCsvPath.Name = "txtCsvPath";
            txtCsvPath.ReadOnly = true;
            txtCsvPath.Size = new Size(465, 23);
            txtCsvPath.TabIndex = 0;
            // 
            // btnLoadCsv
            // 
            btnLoadCsv.Location = new Point(496, 29);
            btnLoadCsv.Name = "btnLoadCsv";
            btnLoadCsv.Size = new Size(79, 23);
            btnLoadCsv.TabIndex = 1;
            btnLoadCsv.Text = "Cargar CSV";
            btnLoadCsv.UseVisualStyleBackColor = true;
            btnLoadCsv.Click += btnLoadCsv_Click;
            // 
            // btnReadCsv
            // 
            btnReadCsv.Location = new Point(581, 29);
            btnReadCsv.Name = "btnReadCsv";
            btnReadCsv.Size = new Size(79, 23);
            btnReadCsv.TabIndex = 2;
            btnReadCsv.Text = "Leer CSV";
            btnReadCsv.UseVisualStyleBackColor = true;
            btnReadCsv.Click += btnReadCsv_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(734, 291);
            dataGridView1.TabIndex = 3;
            // 
            // btnExportJson
            // 
            btnExportJson.Location = new Point(665, 29);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(94, 23);
            btnExportJson.TabIndex = 4;
            btnExportJson.Text = "Exportar JSON";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            // 
            // ReadCSVForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 402);
            Controls.Add(btnExportJson);
            Controls.Add(dataGridView1);
            Controls.Add(btnReadCsv);
            Controls.Add(btnLoadCsv);
            Controls.Add(txtCsvPath);
            Name = "ReadCSVForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReadCSVForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCsvPath;
        private Button btnLoadCsv;
        private Button btnReadCsv;
        private DataGridView dataGridView1;
        private Button btnExportJson;
    }
}