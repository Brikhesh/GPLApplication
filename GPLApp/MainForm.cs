using System;
using System.Drawing;
using System.Windows.Forms;

namespace GPLApp
{
    public partial class MainForm : Form
    {
        Graphics g;
        public MainForm()
        {
            InitializeComponent();
        }

        Creator factory = new Factory();
        Pen myPen = new Pen(Color.Red);


        public Color newcolor;
        int x = 0, y = 0, width, height, radius, repeatval;

        private void txt_Exec_Cmd_TextChanged(object sender, EventArgs e)
        {

            if (txt_Exec_Cmd.Text.ToLower().Trim() == "run")
            {
                Graphics g = DisplayPnl.CreateGraphics();
                string command = txt_Cmd_Box.Text.ToLower();
                string[] commandline = command.Split(new String[] { "\n" },
                 StringSplitOptions.RemoveEmptyEntries);

                for (int k = 0; k < commandline.Length; k++)
                {
                    string[] cmd = commandline[k].Split(' ');
                    if (cmd[0].Equals("moveto") == true)
                    {
                        DisplayPnl.Refresh();
                        string[] param = cmd[1].Split(',');
                        if (param.Length != 2)
                        { MessageBox.Show("Incorrect Parameter"); }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            moveTo(x, y);
                        }

                    }
                    
                    else if (cmd[0].Equals("drawto") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        int x = 0, y = 0;
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect Parameter");
                        }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            drawTo(x, y);
                        }
                    }
                    else if (cmd[0].Equals("rectangle") == true)
                    {
                        if (cmd.Length < 2)
                        {
                            MessageBox.Show("Invalid Parameter ");
                           
                        }
                        else
                        {
                            string[] param = cmd[1].Split(',');
                            if (param.Length < 2)
                            {
                                MessageBox.Show("Invalid Parameter ");
                               
                            }
                            else
                            {
                                Int32.TryParse(param[0], out width);
                                Int32.TryParse(param[1], out height);
                                ShapesInterface circle = factory.getShape("rectangle");
                                Rectangle r = new Rectangle();
                                r.Set(x, y, width, height);
                                r.Draw(g);
                               
                                
                            }
                        }
                    }

                }
            }
            else
            {
                if (txt_Exec_Cmd.Text.ToLower().Trim() == "clear")
                {
                    txt_Cmd_Box.Clear();
                    
                }
            }
        }
        private void txt_Cmd_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hlp = new HelpForm();
            //hlp.MdiParent = this;
            hlp.Show();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void moveTo(int toX, int toY)
        {
            x = toX;
            y = toY; 
        }

        public void drawTo(int toX, int toY)
        { 
            x = toX; 
            y = toY;
        }

    }
}

