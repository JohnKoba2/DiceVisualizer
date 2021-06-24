using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DNDDiceSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRoll_Click(object sender, EventArgs e)
        {
            txResults.Text = "";
            Dice();

        }
        /// <summary>
        /// 
        /// </summary>
        private void Dice()
        {
            int roll,  total = 0, count = 1, mod=0;
            int die = (int)numDice.Value;
            Random r = new Random();

            //searches through the radio buttons and finds the first checked one
            RadioButton selected = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

           //if the found button isnt null and isnt the default option
            if (selected != null && selected != default(RadioButton)) 
            {
                //sets sides to the radio button tag parameter
                int sides = int.Parse(selected.Tag.ToString());

                //while the count is less than the total amount of die
                //rolls the die and adds it to the text
                //when it gets to the last die it outputs the result and then doesn't put a comma
                while (count <= die)
                {
                    roll = r.Next(sides) + 1;
                    total += roll;
                    txResults.Text += roll;
                    if (count <= die - 1)
                        txResults.Text += ",";
                    count++;

                }
                //after the loop it prints out the total of all die rolled. 
                txResults.Text += Environment.NewLine + "Total:" + total;
            }
            //if no die was selected it prints out to choose a die from the screen.
            else txResults.Text = "Please Choose a Die.";
            
        }

        private void txResults_TextChanged(object sender, EventArgs e)
        {

        }
    } }
