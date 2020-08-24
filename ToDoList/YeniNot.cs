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
    public partial class YeniNot : Form
    {
        public YeniNot()
        {
            InitializeComponent();
        }

        int maxLength = 135;
        string result;

        private void YeniNot_Load(object sender, EventArgs e)
        {
            richText.MaxLength = maxLength;
            lblResult.Text = string.Empty;
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            int currentLength = richText.Text.Length;
            int diffValue = maxLength - currentLength;

            result = string.Format("{0} ", diffValue);

            lblResult.Text = currentLength == 0
                ? string.Empty
                : result;
        }

        public string text = string.Empty;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //MdiChildActivate

            //YapılacaklarListesi todopanel = new YapılacaklarListesi();
           
            YapılacaklarListesi todopanel = (YapılacaklarListesi)Owner.ActiveMdiChild;
             
            text = richText.Text;

            todopanel.CreateLabel(text);
            todopanel.Show();
            this.Close();
            // yeniform (ailesi form1)-- yapılacaklar listesi
            // yeni note butonuna yaplıcaklar listesine text at.


            
        }






    }
}
