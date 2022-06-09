using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
  public partial class TicTacToeGUI : Form
  {
     GameBoard gb;

    public TicTacToeGUI()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      gb = new TicTacToeBoard();
      LoadBoard();
      button1.Enabled = true;
      button2.Enabled = true;
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Enabled = true;
      button6.Enabled = true;
      button7.Enabled = true;
      button8.Enabled = true;
      button9.Enabled = true;

    }
   
  }
}
