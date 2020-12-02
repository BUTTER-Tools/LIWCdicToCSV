namespace LIWCdicToCSV
{
    partial class SettingsForm_LIWCdicToCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_LIWCdicToCSV));
            this.ChooseInputFileButton = new System.Windows.Forms.Button();
            this.OutputCSVFile = new System.Windows.Forms.TextBox();
            this.EncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InputLIWCFileTextbox = new System.Windows.Forms.TextBox();
            this.ChooseOutputFileButton = new System.Windows.Forms.Button();
            this.CSVQuoteTextbox = new System.Windows.Forms.TextBox();
            this.CSVDelimiterTextbox = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.PosterStylePictureBox = new System.Windows.Forms.PictureBox();
            this.TableStylePictureBox = new System.Windows.Forms.PictureBox();
            this.TableStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.CSVStyleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PosterStyleRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PosterStylePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStylePictureBox)).BeginInit();
            this.CSVStyleTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseInputFileButton
            // 
            this.ChooseInputFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseInputFileButton.Location = new System.Drawing.Point(24, 382);
            this.ChooseInputFileButton.Name = "ChooseInputFileButton";
            this.ChooseInputFileButton.Size = new System.Drawing.Size(118, 40);
            this.ChooseInputFileButton.TabIndex = 0;
            this.ChooseInputFileButton.Text = "Choose File";
            this.ChooseInputFileButton.UseVisualStyleBackColor = true;
            this.ChooseInputFileButton.Click += new System.EventHandler(this.ChooseOutputCSVFile_Click);
            // 
            // OutputCSVFile
            // 
            this.OutputCSVFile.Enabled = false;
            this.OutputCSVFile.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputCSVFile.Location = new System.Drawing.Point(24, 353);
            this.OutputCSVFile.MaxLength = 2147483647;
            this.OutputCSVFile.Name = "OutputCSVFile";
            this.OutputCSVFile.Size = new System.Drawing.Size(516, 23);
            this.OutputCSVFile.TabIndex = 1;
            // 
            // EncodingDropdown
            // 
            this.EncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodingDropdown.FormattingEnabled = true;
            this.EncodingDropdown.Location = new System.Drawing.Point(24, 55);
            this.EncodingDropdown.Name = "EncodingDropdown";
            this.EncodingDropdown.Size = new System.Drawing.Size(268, 23);
            this.EncodingDropdown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select CSV Output File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select File Encoding";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(502, 585);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select LIWC Dictionary Input File:";
            // 
            // InputLIWCFileTextbox
            // 
            this.InputLIWCFileTextbox.Enabled = false;
            this.InputLIWCFileTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLIWCFileTextbox.Location = new System.Drawing.Point(21, 182);
            this.InputLIWCFileTextbox.MaxLength = 2147483647;
            this.InputLIWCFileTextbox.Name = "InputLIWCFileTextbox";
            this.InputLIWCFileTextbox.Size = new System.Drawing.Size(516, 23);
            this.InputLIWCFileTextbox.TabIndex = 14;
            // 
            // ChooseOutputFileButton
            // 
            this.ChooseOutputFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOutputFileButton.Location = new System.Drawing.Point(21, 211);
            this.ChooseOutputFileButton.Name = "ChooseOutputFileButton";
            this.ChooseOutputFileButton.Size = new System.Drawing.Size(118, 40);
            this.ChooseOutputFileButton.TabIndex = 13;
            this.ChooseOutputFileButton.Text = "Choose File";
            this.ChooseOutputFileButton.UseVisualStyleBackColor = true;
            this.ChooseOutputFileButton.Click += new System.EventHandler(this.ChooseInputLIWCFile_Click);
            // 
            // CSVQuoteTextbox
            // 
            this.CSVQuoteTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSVQuoteTextbox.Location = new System.Drawing.Point(146, 461);
            this.CSVQuoteTextbox.MaxLength = 1;
            this.CSVQuoteTextbox.Name = "CSVQuoteTextbox";
            this.CSVQuoteTextbox.Size = new System.Drawing.Size(101, 23);
            this.CSVQuoteTextbox.TabIndex = 26;
            this.CSVQuoteTextbox.Text = "\"";
            this.CSVQuoteTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CSVDelimiterTextbox
            // 
            this.CSVDelimiterTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSVDelimiterTextbox.Location = new System.Drawing.Point(24, 460);
            this.CSVDelimiterTextbox.MaxLength = 1;
            this.CSVDelimiterTextbox.Name = "CSVDelimiterTextbox";
            this.CSVDelimiterTextbox.Size = new System.Drawing.Size(101, 23);
            this.CSVDelimiterTextbox.TabIndex = 25;
            this.CSVDelimiterTextbox.Text = ",";
            this.CSVDelimiterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(143, 442);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 16);
            this.label42.TabIndex = 24;
            this.label42.Text = "CSV Quote:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(23, 442);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(102, 16);
            this.label41.TabIndex = 23;
            this.label41.Text = "CSV Delimiter:";
            // 
            // PosterStylePictureBox
            // 
            this.PosterStylePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PosterStylePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PosterStylePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosterStylePictureBox.Image = global::LIWCdicToCSV.Properties.Resources.PosterStyle;
            this.PosterStylePictureBox.Location = new System.Drawing.Point(140, 11);
            this.PosterStylePictureBox.Name = "PosterStylePictureBox";
            this.PosterStylePictureBox.Size = new System.Drawing.Size(309, 246);
            this.PosterStylePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PosterStylePictureBox.TabIndex = 28;
            this.PosterStylePictureBox.TabStop = false;
            // 
            // TableStylePictureBox
            // 
            this.TableStylePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableStylePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TableStylePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableStylePictureBox.Image = global::LIWCdicToCSV.Properties.Resources.TableStyle;
            this.TableStylePictureBox.Location = new System.Drawing.Point(140, 277);
            this.TableStylePictureBox.Name = "TableStylePictureBox";
            this.TableStylePictureBox.Size = new System.Drawing.Size(309, 247);
            this.TableStylePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TableStylePictureBox.TabIndex = 29;
            this.TableStylePictureBox.TabStop = false;
            // 
            // TableStyleRadioButton
            // 
            this.TableStyleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableStyleRadioButton.AutoSize = true;
            this.TableStyleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.TableStyleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableStyleRadioButton.Location = new System.Drawing.Point(5, 390);
            this.TableStyleRadioButton.Name = "TableStyleRadioButton";
            this.TableStyleRadioButton.Size = new System.Drawing.Size(114, 20);
            this.TableStyleRadioButton.TabIndex = 31;
            this.TableStyleRadioButton.TabStop = true;
            this.TableStyleRadioButton.Text = "\"Table\" Style";
            this.TableStyleRadioButton.UseVisualStyleBackColor = false;
            this.TableStyleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // CSVStyleTableLayoutPanel
            // 
            this.CSVStyleTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.CSVStyleTableLayoutPanel.ColumnCount = 2;
            this.CSVStyleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CSVStyleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.CSVStyleTableLayoutPanel.Controls.Add(this.PosterStyleRadioButton, 0, 0);
            this.CSVStyleTableLayoutPanel.Controls.Add(this.TableStyleRadioButton, 0, 1);
            this.CSVStyleTableLayoutPanel.Controls.Add(this.PosterStylePictureBox, 1, 0);
            this.CSVStyleTableLayoutPanel.Controls.Add(this.TableStylePictureBox, 1, 1);
            this.CSVStyleTableLayoutPanel.Location = new System.Drawing.Point(631, 12);
            this.CSVStyleTableLayoutPanel.Name = "CSVStyleTableLayoutPanel";
            this.CSVStyleTableLayoutPanel.RowCount = 2;
            this.CSVStyleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CSVStyleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CSVStyleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CSVStyleTableLayoutPanel.Size = new System.Drawing.Size(467, 535);
            this.CSVStyleTableLayoutPanel.TabIndex = 32;
            this.CSVStyleTableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanel1_CellPaint);
            // 
            // PosterStyleRadioButton
            // 
            this.PosterStyleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PosterStyleRadioButton.AutoSize = true;
            this.PosterStyleRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.PosterStyleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosterStyleRadioButton.Location = new System.Drawing.Point(5, 124);
            this.PosterStyleRadioButton.Name = "PosterStyleRadioButton";
            this.PosterStyleRadioButton.Size = new System.Drawing.Size(114, 20);
            this.PosterStyleRadioButton.TabIndex = 32;
            this.PosterStyleRadioButton.TabStop = true;
            this.PosterStyleRadioButton.Text = "\"Poster\" Style";
            this.PosterStyleRadioButton.UseVisualStyleBackColor = false;
            this.PosterStyleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // SettingsForm_LIWCdicToCSV
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 634);
            this.Controls.Add(this.CSVQuoteTextbox);
            this.Controls.Add(this.CSVDelimiterTextbox);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputLIWCFileTextbox);
            this.Controls.Add(this.ChooseOutputFileButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncodingDropdown);
            this.Controls.Add(this.OutputCSVFile);
            this.Controls.Add(this.ChooseInputFileButton);
            this.Controls.Add(this.CSVStyleTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_LIWCdicToCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read .txt Files from Folder Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PosterStylePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableStylePictureBox)).EndInit();
            this.CSVStyleTableLayoutPanel.ResumeLayout(false);
            this.CSVStyleTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseInputFileButton;
        private System.Windows.Forms.TextBox OutputCSVFile;
        private System.Windows.Forms.ComboBox EncodingDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputLIWCFileTextbox;
        private System.Windows.Forms.Button ChooseOutputFileButton;
        private System.Windows.Forms.TextBox CSVQuoteTextbox;
        private System.Windows.Forms.TextBox CSVDelimiterTextbox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox PosterStylePictureBox;
        private System.Windows.Forms.PictureBox TableStylePictureBox;
        private System.Windows.Forms.RadioButton TableStyleRadioButton;
        private System.Windows.Forms.TableLayoutPanel CSVStyleTableLayoutPanel;
        private System.Windows.Forms.RadioButton PosterStyleRadioButton;
    }
}