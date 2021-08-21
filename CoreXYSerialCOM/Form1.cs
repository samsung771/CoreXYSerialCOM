using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreXYSerialCOM
{
    public partial class Form1 : Form
    {
        int x, y, prevX, prevY;
        bool stepperOn = true;
        bool magnetOn = false;

        private static Button[] grid;

        bool[] board = new bool[64];

        public Form1()
        {
            InitializeComponent();

            grid = new Button[64] {
            btn00, btn10, btn20, btn30, btn40, btn50, btn60, btn70,
            btn01, btn11, btn21, btn31, btn41, btn51, btn61, btn71,
            btn02, btn12, btn22, btn32, btn42, btn52, btn62, btn72,
            btn03, btn13, btn23, btn33, btn43, btn53, btn63, btn73,
            btn04, btn14, btn24, btn34, btn44, btn54, btn64, btn74,
            btn05, btn15, btn25, btn35, btn45, btn55, btn65, btn75,
            btn06, btn16, btn26, btn36, btn46, btn56, btn66, btn76,
            btn07, btn17, btn27, btn37, btn47, btn57, btn67, btn77};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] command = new byte[5];

            command[0] = 0x01;
            byte[] xB = BitConverter.GetBytes(x);
            byte[] yB = BitConverter.GetBytes(y);
            
            //sending 0xFF over serial makes it an NVT command so replaces it with 0xFE
            for (int i = 0; i < 2; i++)
            {
                if (xB[i] == 0xFF) xB[i] = 0xFE;
                if (yB[i] == 0xFF) yB[i] = 0xFE;
            }

            command[1] = xB[1];
            command[2] = xB[0];
            command[3] = yB[1];
            command[4] = yB[0];

            if (serialPort1.IsOpen)
            {
                if (prevX != x || prevY != y)
                {
                    serialPort1.Write(command, 0, 5);
                    comboBox1.Items.Add(x.ToString() + " " + y.ToString());
                    prevX = x;
                    prevY = y;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[5];

            command[0] = 0x03;

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(command, 0, 5);
                comboBox1.Items.Add("0 0");
            }
        }

        private void btnMag_Click(object sender, EventArgs e)
        {
            if (magnetOn)
            {
                byte[] command = new byte[5];

                command[0] = 0x05;
                command[4] = 0x00;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(command, 0, 5);
                }
                magnetOn = false;

                btnMag.Text = "Turn Magnet On";
            }
            else
            {
                byte[] command = new byte[5];

                command[0] = 0x05;
                command[4] = 0x01;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(command, 0, 5);
                }
                magnetOn = true;

                btnMag.Text = "Turn Magnet Off";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    btnStart.Text = "End";
                }
                catch
                {
                    MessageBox.Show("Serial Port Unavailable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
                btnStart.Text = "Start";
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (stepperOn)
            {
                byte[] command = new byte[5];

                command[0] = 0x02;
                command[4] = 0x00;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(command, 0, 5);
                }
                stepperOn = false;

                btnStep.Text = "Enable Steppers";
            }
            else
            {
                byte[] command = new byte[5];

                command[0] = 0x02;
                command[4] = 0x01;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(command, 0, 5);
                }
                stepperOn = true;

                btnStep.Text = "Disable Steppers";
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            y = (int)((Cursor.Position.X - this.Left - 6 - button1.Left) / (double)(button1.Width) * 350);
            x = (int)((Cursor.Position.Y - this.Top - 30 - button1.Top) / (double)(button1.Height) * 560);

            if (x < 0) x = 0;
            else if (x > 560) x = 560;

            if (y < 0) y = 0;
            else if (y > 350) y = 350;

            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();


            byte[] command = new byte[5];

            command[0] = 0x04;
            command[4] = 0x00;

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(command, 0, 5);
                for (int read = 0; read < serialPort1.BytesToRead; read++)
                {
                    byte[] buffer = new byte[1];
                    serialPort1.Read(buffer,0,1);

                    if (buffer[0] == 0xFE)
                    {
                        byte[] input = new byte[8];
                        serialPort1.Read(input, 0, 8);

                        for (int bytes = 0; bytes < 8; bytes++)
                        {
                            for (int bits = 0; bits < 8; bits++)
                            {
                                board[bytes * 8 + bits] = (input[bytes] & (1 << bits)) != 0;
                            }
                        }

                    }
                    else if (buffer[0] == '1')
                    {
                        comboBox1.SelectedIndex++;
                    }
                }
            }

            for (int space = 0; space < 64; space++)
            {
                if (board[space]) grid[space].BackColor = Color.FromArgb(245, 210, 69);
                else grid[space].BackColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
