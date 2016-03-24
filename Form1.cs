using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPoker
{
    public partial class frmTable : Form
    {
        Random rnd = new Random();
        public frmTable()
        {
            InitializeComponent();
          
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            Deck deck = new Deck(this, rnd);
            for (Int32 i = 0; i < 52; i++)
            {
                this.flowLayoutPanel1.Controls.Add(deck.Deal().CARD);
            }


        }
    }
}
