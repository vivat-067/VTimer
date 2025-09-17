using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VTimer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Helper.SetFormBounds(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {            

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();            

            labVersion.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
            labAssembley.Text =@"("+Assembly.GetExecutingAssembly().GetName().Version.ToString()+")";

            labDevBy.Text = "vit.vatkov@adonis-soft.ru";           

        }
    }
}
