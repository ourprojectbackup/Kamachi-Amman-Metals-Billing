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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();

            billing.Show();
            this.Hide();
        }

  

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddNewItem addNewItem = new AddNewItem();
            addNewItem.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncreaseFontSize(this, 20);
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
    }
}
