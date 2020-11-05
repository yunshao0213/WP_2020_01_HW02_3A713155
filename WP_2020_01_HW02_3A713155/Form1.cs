using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713155.Properties;

namespace WP_2020_01_HW02_3A713155
{
    public partial class Form1 : Form
    {
        List<Image> result = new List<Image>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            result.Add(Resources._1);
            result.Add(Resources._2);
            result.Add(Resources._3);
            result.Add(Resources._4);
            result.Add(Resources._5);
            result.Add(Resources._6);
            result.Add(Resources._7);
            result.Add(Resources._8);
            result.Add(Resources._9);
            result.Add(Resources._10);
            result.Add(Resources._11);
            result.Add(Resources._12);
            result.Add(Resources._13);
            result.Add(Resources._14);
            result.Add(Resources._15);
            result.Add(Resources._16);
            result.Add(Resources._17);
            result.Add(Resources._18);
            result.Add(Resources._19);
            result.Add(Resources._20);
            result.Add(Resources._21);
            result.Add(Resources._22);
            result.Add(Resources._23);
            result.Add(Resources._24);
            result.Add(Resources._25);
            result.Add(Resources._26);
            result.Add(Resources._27);
            result.Add(Resources._28);
            result.Add(Resources._29);
            result.Add(Resources._30);
            result.Add(Resources._31);
            result.Add(Resources._32);
            result.Add(Resources._33);
            result.Add(Resources._34);
            result.Add(Resources._35);
            result.Add(Resources._36);
            result.Add(Resources._37);
            result.Add(Resources._38);
            result.Add(Resources._39);
            result.Add(Resources._40);
            result.Add(Resources._41);
            result.Add(Resources._42);
            result.Add(Resources._43);
            result.Add(Resources._44);
            result.Add(Resources._45);
            result.Add(Resources._46);
            result.Add(Resources._47);
            result.Add(Resources._48);
            result.Add(Resources._49);
            result.Add(Resources._50);
            result.Add(Resources._51);
            result.Add(Resources._52);
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int rindex = (new Random()).Next(51) + 1; 
            pic.Image = result[rindex];
        }
    }
}
