using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemektarifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        int index = 0;
        private void btnAddStage_Click(object sender, EventArgs e)
        {
            if (index <= stages .Length -1)
            {
                lstStages.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmıştır.");
            }
            
        }



        string[] stages = { "1- tencerede suyu kaynatın", "2- kaynar suya makarnaları dökün", "3- tuz atın", "4- makarnalar pişince süzgece alın", "5- tencereye biraz yağ koyduktan sonra makarnaları içine dökün ", "6- afiyet olsun", };
        private void Form1_Load(object sender, EventArgs e)
        {
            int index = 0;
            while (index<stages.Length)
            {
                lstStages.Items.Add(stages[index]);
                index++;
            }
        }
    }
}
