namespace DictionaryFlasher
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            outputBox.Text = Formatter.FormatInput(inputBox.Text, (FormatType)formatTypeBox.SelectedItem);
            Cursor.Current = Cursors.Default;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Save.DoSave(inputBox.Text, ref folderBrowserDialog);
            Cursor.Current = Cursors.Default;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
    }
}