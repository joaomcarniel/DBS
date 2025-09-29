using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ofd.Title = "Open That Now";
            ofd.Filter = "Text Files|*.txt|PDF Files|*.pdf|All Files|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                RTB.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);

                this.Text = ofd.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save That Now";
            sfd.Filter = "Text Files|*.txt|PDF Files|*.pdf|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                RTB.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

                this.Text = sfd.FileName;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.Font = RTB.Font;
            fd.ShowDialog();
            RTB.Font = fd.Font;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            psd.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pd.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
