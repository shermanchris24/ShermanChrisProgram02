/*Program name: ShermanChrisProgram02
 * Program Author: Chris Sherman
 * Date: 6/7/19
 * Description: Program displays 5 cards, user can click on one of the cards and program will display the name of that card.
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShermanChrisProgram02
{
    public partial class cardIdentifyierForm : Form
    {
        public cardIdentifyierForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardNameDisplay.Text = "Eight of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardNameDisplay.Text = "Two of Clubs";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardNameDisplay.Text = "King of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardNameDisplay.Text = "Ace of Spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cardNameDisplay.Text = "Joker";
        }
    }
}
