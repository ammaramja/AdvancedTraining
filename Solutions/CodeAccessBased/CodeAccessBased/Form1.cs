using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;

namespace CodeAccessBased
{


    //[FileIOPermission(SecurityAction.PermitOnly, Read = @"d:\")]
    [FileIOPermission(SecurityAction.PermitOnly, Write = @"d:\")]
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writeFile = new StreamWriter(@"d:\xyz.txt");
                writeFile.WriteLine("Testing!");
                MessageBox.Show("Done");
                writeFile.Close();

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader read = new StreamReader(@"d:\test.txt");
                
                MessageBox.Show(read.ReadLine());
                read.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
