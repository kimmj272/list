using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //TestArray();
            //TestArray2();
            //TestArray3();
            TestList();
            TestList2();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        public void TestArray()
        {
            txtResult.Text = "";

            int[] aTemp = new int[3];
            aTemp[0] = 100;
            aTemp[1] = 200;
            aTemp[2] = 300;

            for (int i = 0; i < aTemp.Length; i++)
            {
                string sLog = string.Format("Temp[{0}] = {1}", i, aTemp[i]);
                Console.WriteLine(sLog);
                txtResult.Text += sLog + "\n";
            }

            txtResult.Text += "----------------------------\n";
        }

        public void TestArray2()
        {
            int[] aTemp = new int[3];
            aTemp[0] = 100;
            aTemp[1] = 200;
            aTemp[2] = 300;

            int nIndex = 0;
            while (nIndex < aTemp.Length)
            {
                string sLog = string.Format("Temp[{0}] = {1}", nIndex, aTemp[nIndex]);
                Console.WriteLine(sLog);
                txtResult.Text += sLog + "\n";
                nIndex++;
            }

            txtResult.Text += "----------------------------\n";
        }

        public void TestArray3()
        {
            int[] aTemp = new int[3];
            aTemp[0] = 100;
            aTemp[1] = 200;
            aTemp[2] = 300;

            int nIndex = 0;
            do
            {
                string sLog = string.Format("Temp[{0}] = {1}", nIndex, aTemp[nIndex]);
                Console.WriteLine(sLog);
                txtResult.Text += sLog + "\n";
                nIndex++;
            }
            while (nIndex < aTemp.Length);

            txtResult.Text += "----------------------------\n";
        }

        public void TestList()
        {
            txtResult.Text = "";

            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);

            for(int i = 0; i < list.Count; i++)
            {
                string sLog = string.Format("list[{0}] = {1}", i, list[i]);
                Console.WriteLine(sLog);
                txtResult.Text += sLog + "\n";
            }

            txtResult.Text += "----------------------------\n";
        }

        public void TestList2()
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);

            int i = 0;
            foreach(int value in list)
            {
                string sLog = string.Format("list[{0}] = {1}", i, value);
                Console.WriteLine(sLog);
                txtResult.Text += sLog + "\n";
                i++;
            }

            txtResult.Text += "----------------------------\n";
        }
    }
}
