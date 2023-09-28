using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int computerScore = 0;
        int drawScore = 0;
        string playerChoice;
        String comChoice;
        Random random = new Random();
        String[] Options = { "R", "P", "S", "P", "S", "R" };

        public Form1()
        {
            InitializeComponent();
            Player_sc.Text = "";
            Com_sc.Text = "";
            Draw_sc.Text = "";


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
