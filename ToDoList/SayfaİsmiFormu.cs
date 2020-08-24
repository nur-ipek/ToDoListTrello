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
    public partial class SayfaİsmiFormu : Form
    {
        public SayfaİsmiFormu()
        {
            InitializeComponent();
        }

        

        private void SayfaİsmiFormu_Load(object sender, EventArgs e)
        {
            // this.IsMdiContainer = true;
  
        }

        private void btnOpenthePage_Click(object sender, EventArgs e)
        {
            YapılacaklarListesi ToDoList = new YapılacaklarListesi();

            ToDoList.MdiParent = this.MdiParent;

            ToDoList.Text = txtPageName.Text;

            ToDoList.Show();

            this.Close();
        }
    }
}
