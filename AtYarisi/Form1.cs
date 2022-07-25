using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        Random rnd = new Random();
        

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timerYaris.Start();
            
        }

        private void timerYaris_Tick(object sender, EventArgs e)
        {
            if (At1.Right < lblFinish.Left && At2.Right < lblFinish.Left && At3.Right < lblFinish.Left)
            {
                At1.Left += rnd.Next(1, 50);
                At2.Left += rnd.Next(1, 50);
                At3.Left += rnd.Next(1, 50);
            }
            else if (At1.Right >= lblFinish.Left)
            {
                timerYaris.Stop();
                DialogResult dr = MessageBox.Show("At-1 kazandı. Tekrar oynamak ister misiniz","At Yarışı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    At1.Left=At2.Left=At3.Left=0;
                    timerYaris.Start();
                }
                else
                {
                    Close();
                }

            } 
            else if (At2.Right >= lblFinish.Left)
            {
                
                timerYaris.Stop();
                DialogResult dr = MessageBox.Show("At-2 kazandı. Tekrar oynamak ister misiniz", "At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    At1.Left = At2.Left = At3.Left = 0;
                    timerYaris.Start();
                }
                else
                {
                    Close();
                }

            }
            else if (At3.Right >= lblFinish.Left)
            {
                
                timerYaris.Stop();
                DialogResult dr = MessageBox.Show("At-3 kazandı. Tekrar oynamak ister misiniz", "At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    At1.Left = At2.Left = At3.Left = 0;
                    timerYaris.Start();
                }
                else
                {
                    Close();
                }
            }


        }
    }
}
