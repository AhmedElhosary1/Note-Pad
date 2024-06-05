using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class NotePadMain : Form
    {
        public NotePadMain()
        {
            InitializeComponent();
        }

        // Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text Files|*.txt";
            dialog.FileName = "Txt" + ".txt";

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                File.WriteAllText(dialog.FileName, richTextBox.Text);
            }
        }


        // Import Button
        private void btnImport_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text Files|*.txt";

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox.Text = File.ReadAllText(dialog.FileName);
            }
        }


        // Copy Button
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox.Text);
        }


        // Paste Buuton
        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text + Clipboard.GetText();
        }


        // Cut Button
        private void btnCut_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox.Text);
            richTextBox.Text = "";
        }


        // Print Button
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }
        // Print Event
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font, Brushes.Black, new Point(100, 100));
        }


        // Type Button
        private void btnType_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            var result = fontDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                richTextBox.Font = fontDialog.Font;

            }
        }


        // Bold Button
        private void btnBold_Click(object sender, EventArgs e)
        {
            richTextBox.Font = new Font(richTextBox.Font, FontStyle.Bold);
        }


        // UnderLine Button
        private void btnUnderLine_Click(object sender, EventArgs e)
        {
            richTextBox.Font = new Font(richTextBox.Font, FontStyle.Underline);
        }


        // Left Align Button
        private void btnLeft_Click(object sender, EventArgs e)
        {
            richTextBox.RightToLeft = RightToLeft.No;
        }


        // Right Align Button
        private void btnRight_Click(object sender, EventArgs e)
        {
            richTextBox.RightToLeft = RightToLeft.Yes;
        }


        // ForeColor Button
        private void btnForColor_Click(object sender, EventArgs e)
        {
            var foreColor = new ColorDialog();
            var result = foreColor.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox.ForeColor = foreColor.Color;
            }
        }



        // BackColor Button
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            var backColor = new ColorDialog();
            var result = backColor.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox.BackColor = backColor.Color;
            }
        }


        // Track Bar Button
        private void trackBarSize_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                richTextBox.ZoomFactor = trackBarSize.Value;
                trackBarSize.Value = trackBarSize.Minimum;
            }
            catch { }
        }
    }
}
