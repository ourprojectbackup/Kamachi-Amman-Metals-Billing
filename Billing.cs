using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamachi_Amman_Metals_Billing
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            IncreaseFontSize(this, 20);
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void IncreaseFontSize(Form form, float fontSize)
        {
            foreach (Control control in form.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, fontSize);

                // If the control contains other controls (e.g., GroupBox, Panel)
                if (control.HasChildren)
                {
                    SetFontSizeForControls(control, fontSize);
                }
            }
        }

        private void SetFontSizeForControls(Control parent, float fontSize)
        {
            // Set the font size for the current control
            parent.Font = new Font(parent.Font.FontFamily, fontSize);

            // Recursively set the font size for child controls
            foreach (Control child in parent.Controls)
            {
                SetFontSizeForControls(child, fontSize);
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
