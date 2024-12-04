namespace DataTransformation.Forms
{
    partial class JsonExport
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
            txtJson = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtJson
            // 
            txtJson.Location = new Point(12, 50);
            txtJson.Multiline = true;
            txtJson.Name = "txtJson";
            txtJson.ReadOnly = true;
            txtJson.ScrollBars = ScrollBars.Both;
            txtJson.Size = new Size(518, 424);
            txtJson.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 2;
            label1.Text = "JSON";
            // 
            // JsonExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 486);
            Controls.Add(label1);
            Controls.Add(txtJson);
            Name = "JsonExport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "JsonExport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJson;
        private Label label1;
    }
}