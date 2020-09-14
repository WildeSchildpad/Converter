namespace Converter
{
    partial class Converter
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
            this.BtnConvert = new System.Windows.Forms.Button();
            this.ConvertLabel = new System.Windows.Forms.Label();
            this.BtnAns = new System.Windows.Forms.Button();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.MTFTextbox = new System.Windows.Forms.RichTextBox();
            this.BtnClrHistory = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.BtnRecover = new System.Windows.Forms.Button();
            this.ConvertType = new System.Windows.Forms.ComboBox();
            this.EuroDollarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(206, 27);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 20);
            this.BtnConvert.TabIndex = 3;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // ConvertLabel
            // 
            this.ConvertLabel.Location = new System.Drawing.Point(28, 4);
            this.ConvertLabel.Name = "ConvertLabel";
            this.ConvertLabel.Size = new System.Drawing.Size(172, 20);
            this.ConvertLabel.TabIndex = 4;
            this.ConvertLabel.Text = "DefaultText";
            this.ConvertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAns
            // 
            this.BtnAns.Location = new System.Drawing.Point(31, 82);
            this.BtnAns.Name = "BtnAns";
            this.BtnAns.Size = new System.Drawing.Size(80, 23);
            this.BtnAns.TabIndex = 5;
            this.BtnAns.Text = "Answer";
            this.BtnAns.UseVisualStyleBackColor = true;
            this.BtnAns.Click += new System.EventHandler(this.BtnAns_Click);
            // 
            // HistoryBox
            // 
            this.HistoryBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.Location = new System.Drawing.Point(12, 111);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(211, 225);
            this.HistoryBox.TabIndex = 7;
            this.HistoryBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MTFTextbox
            // 
            this.MTFTextbox.Location = new System.Drawing.Point(31, 28);
            this.MTFTextbox.Name = "MTFTextbox";
            this.MTFTextbox.Size = new System.Drawing.Size(169, 19);
            this.MTFTextbox.TabIndex = 8;
            this.MTFTextbox.Text = "";
            this.MTFTextbox.Enter += new System.EventHandler(this.MTFTextbox_Enter);
            this.MTFTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MTFTextbox_KeyDown);
            this.MTFTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTFTextbox_KeyPress);
            this.MTFTextbox.Leave += new System.EventHandler(this.MTFTextbox_Leave);
            // 
            // BtnClrHistory
            // 
            this.BtnClrHistory.Location = new System.Drawing.Point(229, 111);
            this.BtnClrHistory.Name = "BtnClrHistory";
            this.BtnClrHistory.Size = new System.Drawing.Size(83, 23);
            this.BtnClrHistory.TabIndex = 9;
            this.BtnClrHistory.Text = "Clear History";
            this.BtnClrHistory.UseVisualStyleBackColor = true;
            this.BtnClrHistory.Click += new System.EventHandler(this.BtnClrHistory_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.Location = new System.Drawing.Point(117, 82);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(83, 23);
            this.BtnClr.TabIndex = 10;
            this.BtnClr.Text = "Clear";
            this.BtnClr.UseVisualStyleBackColor = true;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // BtnRecover
            // 
            this.BtnRecover.Location = new System.Drawing.Point(229, 140);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(83, 23);
            this.BtnRecover.TabIndex = 11;
            this.BtnRecover.Text = "Recover";
            this.BtnRecover.UseVisualStyleBackColor = true;
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // ConvertType
            // 
            this.ConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvertType.FormattingEnabled = true;
            this.ConvertType.Items.AddRange(new object[] {
            "Meter To Foot",
            "Foot To Meter",
            "Euro To Dollar",
            "Dollar To Euro"});
            this.ConvertType.Location = new System.Drawing.Point(59, 55);
            this.ConvertType.Name = "ConvertType";
            this.ConvertType.Size = new System.Drawing.Size(121, 21);
            this.ConvertType.TabIndex = 12;
            this.ConvertType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EuroDollarLabel
            // 
            this.EuroDollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroDollarLabel.Location = new System.Drawing.Point(12, 31);
            this.EuroDollarLabel.Name = "EuroDollarLabel";
            this.EuroDollarLabel.Size = new System.Drawing.Size(13, 14);
            this.EuroDollarLabel.TabIndex = 13;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 549);
            this.Controls.Add(this.EuroDollarLabel);
            this.Controls.Add(this.ConvertType);
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.BtnClrHistory);
            this.Controls.Add(this.MTFTextbox);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.BtnAns);
            this.Controls.Add(this.ConvertLabel);
            this.Controls.Add(this.BtnConvert);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeasurementConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label ConvertLabel;
        private System.Windows.Forms.Button BtnAns;
        private System.Windows.Forms.ListBox HistoryBox;
        private System.Windows.Forms.RichTextBox MTFTextbox;
        private System.Windows.Forms.Button BtnClrHistory;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.Button BtnRecover;
        private System.Windows.Forms.ComboBox ConvertType;
        private System.Windows.Forms.Label EuroDollarLabel;
    }
}

