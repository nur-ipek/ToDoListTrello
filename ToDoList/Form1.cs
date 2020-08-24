using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        public List<string> notes = new List<string>();

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayfaİsmiFormu sayfaİsmiFormu = new SayfaİsmiFormu()
            {
                MdiParent = this
            };
            sayfaİsmiFormu.Show();
        }

        private void yeniNotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniNot yeniNot = new YeniNot();
            yeniNot.Show(this);
        }
    }
}
