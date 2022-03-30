using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace NotePad_OOP_Project_2019
{
    public partial class Form1 : Form
    {
        string path; //<----//
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //************************************************************************//
        //************************************************************************//

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            using (OpenFileDialog O = new OpenFileDialog() { Filter = "Text Documents|*.txt" }) //<----//
            {
                if (O.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader SR = new StreamReader(O.FileName))
                        {

                              textBox1.Text = SR.ReadToEnd();  
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
        
        //************************************************************************//
        //************************************************************************//

        private async  void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))   //<----//
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt"}) 
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = sfd.FileName;
                            using (StreamWriter SW = new StreamWriter(sfd.FileName))
                            {
                                await  SW.WriteLineAsync(textBox1.Text);  //<----//
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            

                        }

                    }
                }
            }
            else
            {

                try
                {
                    using (StreamWriter SW = new StreamWriter(path))
                    {
                        await  SW.WriteLineAsync(textBox1.Text);  //<---
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ivalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        //************************************************************************//
        //************************************************************************//

        private async   void saveAsToolStripMenuItem_Click(object sender, EventArgs e)   //<----Async --> await
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt"}) //<----//
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter SW = new StreamWriter(sfd.FileName))
                        {
                          await  SW.WriteLineAsync(textBox1.Text);  //<----//
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        //************************************************************************//
        //************************************************************************//


        private void exittoolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //************************************************************************//
        //************************************************************************//

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                using (frmAbout frm = new frmAbout())
                {
                    frm.ShowDialog();
                }
            }
        //************************************************************************//
        //************************************************************************//
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                newToolStripMenuItem.Enabled = true;
            }
            else
            {
                newToolStripMenuItem.Enabled = false;
            }
        }
        //************************************************************************//
        //************************************************************************//
        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //************************************************************************//
        //************************************************************************//
        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog F = new FontDialog();
            if (F.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = F.Font;
            }
        }
        //************************************************************************//
        //************************************************************************//
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog C = new ColorDialog();
            if (C.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor  = C.Color;
            }
        }
        //************************************************************************//
        //************************************************************************//
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog C = new ColorDialog();
            if (C.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor  = C.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     
    }
}
