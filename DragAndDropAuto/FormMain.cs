using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropAuto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSourceDrag_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourceDrag.DoDragDrop(buttonSourceDrag.Text, DragDropEffects.Copy);
        }

        private void textBoxTargetDrop_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(DataFormats.Text).ToString();
            textBoxTargetDrop.Text = text;
        }

        private void textBoxTargetDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}