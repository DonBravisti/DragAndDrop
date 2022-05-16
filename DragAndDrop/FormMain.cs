using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class FormMain : Form
    {
        public static Card MovingCard = null;

        public FormMain()
        {
            InitializeComponent();
        }

        Train t1;
        Train t2;

        private void button1_Click(object sender, EventArgs e)
        {
            Card c1 = new Card(1, this);
            t1 = new Train(2, this, 400, 20);
            t2 = new Train(2, this, 400, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MovingCard != null && MovingCard.Bounds.IntersectsWith(t1.Bounds))
            {
                MovingCard.Location = new Point(1000, 1000);
                MessageBox.Show("AAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }
}
