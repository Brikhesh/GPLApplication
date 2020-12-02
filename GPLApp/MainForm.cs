using System;
using System.Drawing;
using System.IO;
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
        int x = 0, y = 0, width, height, radius;

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
                    else if (cmd[0].Equals("circle") == true)
                    {
                        if (cmd.Length != 2) { MessageBox.Show("Incorrect Parameter"); }
                        else
                        {
                            if (cmd[1].Equals("radius") == true)
                            {
                                ShapesInterface circle = factory.getShape("circle");
                                Circle c = new Circle();
                                c.Set(x, y, radius);
                                c.Draw(g);
                            }
                            else
                            {
                                Int32.TryParse(cmd[1], out radius);
                                ShapesInterface circle = factory.getShape("circle");
                                Circle c = new Circle();
                                c.Set(x, y, radius);
                                c.Draw(g);
                            }
                        }
                    }
                    else if (cmd[0].Equals("triangle") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect Parameter");

                        }
                        else
                        {
                            Int32.TryParse(param[0], out width);
                            Int32.TryParse(param[1], out height);
                            ShapesInterface circle = factory.getShape("triangle");
                            Triangle r = new Triangle();
                            r.Set(x, y, width, height);
                            r.Draw(g);
                        }
                    }

                    else if (!cmd[0].Equals(null))
                    {
                        int errorLine = k + 1;
                        MessageBox.Show("Invalid command recognised on line " + errorLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.WriteLine(txt_Cmd_Box.Text);
                write.Close();
                MessageBox.Show("File Saved Successfully");
            }
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Browse file from specified folder";
            openFileDialog1.InitialDirectory = "E:\\";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "DOCX files (*.docx)|*.docx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //Browse .txt file from computer             
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.                        
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                //displays the text inside the file on TextBox named as txtInput                
                txt_Cmd_Box.Text = File.ReadAllText(openFileDialog1.FileName);
            }
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

