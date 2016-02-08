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
using System.Windows.Forms.VisualStyles;

namespace NT_Seeding
{
    public partial class Form1 : Form
    {
        private readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "nuclearthrone/seed.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void applySeed_Click(object sender, EventArgs e)
        {
            

            File.WriteAllText(filePath, seedTextBox.Text);            
            
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            File.Delete(filePath);
        }
    }

}
