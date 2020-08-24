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
    public partial class YapılacaklarListesi : Form
    {
        public YapılacaklarListesi()
        {
            InitializeComponent();

        }

        private void todoList_Load(object sender, EventArgs e)
        {
            pnlToDo.AllowDrop = true;
            pnlDoing.AllowDrop = true;
            pnlDone.AllowDrop = true;

            pnlDoing.DragOver += new DragEventHandler(this.pnlDoing_DragOver);
            pnlDoing.DragDrop += new DragEventHandler(this.pnlDoing_DragDrop);

            pnlDone.DragOver += new DragEventHandler(this.pnlDone_DragOver);
            pnlDone.DragDrop += new DragEventHandler(this.pnlDone_DragDrop);
        }

        public void CreateLabel(string text)
        {
            Label label = new Label();
            label.Dock = DockStyle.Top;
            label.Text = text;
            label.MouseDown += new MouseEventHandler(this.label_MouseDown);
            this.pnlToDo.Controls.Add(label);
        }

        

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                label.DoDragDrop(label, DragDropEffects.All);
            }
        }

        private void pnlDoing_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pnlDoing_DragDrop(object sender, DragEventArgs e)
        {
            Label label = (Label)e.Data.GetData(typeof(Label));
            this.pnlDoing.Controls.Add(label);
        }

        private void pnlDone_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pnlDone_DragDrop(object sender, DragEventArgs e)
        {
            Label label = (Label)e.Data.GetData(typeof(Label));
            this.pnlDone.Controls.Add(label);
        }

        private void pnlToDo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDone_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
