namespace DictionaryFlasher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outputBox = new TextBox();
            formatTypeBox = new ComboBox();
            inputBox = new TextBox();
            saveButton = new Button();
            doButton = new Button();
            copyButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.AcceptsReturn = true;
            outputBox.AcceptsTab = true;
            outputBox.BackColor = Color.FromArgb(128, 128, 255);
            outputBox.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            outputBox.ForeColor = SystemColors.WindowText;
            outputBox.Location = new Point(410, 12);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.ScrollBars = ScrollBars.Vertical;
            outputBox.Size = new Size(378, 413);
            outputBox.TabIndex = 0;
            // 
            // formatTypeBox
            // 
            formatTypeBox.BackColor = Color.LightSteelBlue;
            formatTypeBox.Cursor = Cursors.Hand;
            formatTypeBox.FlatStyle = FlatStyle.Flat;
            formatTypeBox.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            formatTypeBox.FormattingEnabled = true;
            formatTypeBox.Items.AddRange(new object[] { FormatType.Form8, FormatType.Form7, FormatType.Quizlet, FormatType.Blooket });
            formatTypeBox.Location = new Point(300, 12);
            formatTypeBox.Name = "formatTypeBox";
            formatTypeBox.Size = new Size(111, 25);
            formatTypeBox.TabIndex = 1;
            // 
            // inputBox
            // 
            inputBox.AcceptsReturn = true;
            inputBox.AllowDrop = true;
            inputBox.BackColor = Color.FromArgb(128, 128, 255);
            inputBox.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            inputBox.Location = new Point(12, 12);
            inputBox.Multiline = true;
            inputBox.Name = "inputBox";
            inputBox.ScrollBars = ScrollBars.Vertical;
            inputBox.Size = new Size(289, 413);
            inputBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightSteelBlue;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.CheckedBackColor = Color.MidnightBlue;
            saveButton.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            saveButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(300, 84);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(111, 30);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // doButton
            // 
            doButton.BackColor = Color.LightSteelBlue;
            doButton.Cursor = Cursors.Hand;
            doButton.FlatAppearance.CheckedBackColor = Color.MidnightBlue;
            doButton.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            doButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            doButton.FlatStyle = FlatStyle.Flat;
            doButton.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            doButton.Location = new Point(300, 41);
            doButton.Name = "doButton";
            doButton.Size = new Size(111, 30);
            doButton.TabIndex = 4;
            doButton.Text = "Create";
            doButton.UseVisualStyleBackColor = false;
            doButton.Click += doButton_Click;
            // 
            // copyButton
            // 
            copyButton.BackColor = Color.LightSteelBlue;
            copyButton.Cursor = Cursors.Hand;
            copyButton.FlatAppearance.CheckedBackColor = Color.MidnightBlue;
            copyButton.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            copyButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Font = new Font("Calibri", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            copyButton.Location = new Point(410, 408);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(65, 30);
            copyButton.TabIndex = 5;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += copyButton_Click;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Choose save folder.";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(copyButton);
            Controls.Add(doButton);
            Controls.Add(saveButton);
            Controls.Add(inputBox);
            Controls.Add(formatTypeBox);
            Controls.Add(outputBox);
            Name = "Form1";
            Text = "Dictionary Flasher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputBox;
        private ComboBox formatTypeBox;
        private TextBox inputBox;
        private Button saveButton;
        private Button doButton;
        private Button copyButton;
        private FolderBrowserDialog folderBrowserDialog;
    }
}