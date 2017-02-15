using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2activity
{
    public partial class frmNumberSwap : Form
    {
        public frmNumberSwap()
        {
            InitializeComponent();

            //Fill in list boxes
            GenerateLists();
        }

        //Swap numbers button
        private void btnSwapNumber_Click(object sender, EventArgs e)
        {
            //Store selected numbers into variables
            string strLeftNumber = lstLeft.SelectedItem.ToString();
            string strRightNumber = lstRight.SelectedItem.ToString();
            //Input variables into listbox selected items
            lstLeft.Items[lstLeft.SelectedIndex] = strRightNumber;
            lstRight.Items[lstRight.SelectedIndex] = strLeftNumber;

        }

        //Swap lists button
        private void btnSwapList_Click(object sender, EventArgs e)
        {
            //Declare arrays for holding lists
            string[] strLeft = new string[lstLeft.Items.Count];
            string[] strRight = new string[lstRight.Items.Count];

            //Store left list into an array
            for (int i = 0; i < lstLeft.Items.Count; i++)
            {
                strLeft[i] = Convert.ToString(lstLeft.Items[i]);
            }
            
            //Store right list into an array
            for (int i = 0; i < lstRight.Items.Count; i++)
            {
                strRight[i] = Convert.ToString(lstRight.Items[i]);
            }
            
            //Clear both listboxes
            lstLeft.Items.Clear();
            lstRight.Items.Clear();

            //Output arrays into opposite list boxes
            lstLeft.Items.AddRange(strRight);
            lstRight.Items.AddRange(strLeft);
            
        }

        //Method for generating intial numbers in list boxes
        private void GenerateLists()
        {
            //Left list box
            lstLeft.Items.Add("10");
            lstLeft.Items.Add("20");
            lstLeft.Items.Add("30");
            lstLeft.Items.Add("40");
            lstLeft.Items.Add("50");

            //Right list box
            lstRight.Items.Add("100");
            lstRight.Items.Add("220");
            lstRight.Items.Add("330");
            lstRight.Items.Add("420");
            lstRight.Items.Add("550");
        }
        
    }
}
