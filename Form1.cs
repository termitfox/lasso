using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wim
{
    public partial class Form1 : Form
    {
        Button[] buttons;
        int text = 0;
        int x = 700, y = 100, h = 70,dx = 35, dy = 85, dxy = 45;

        bool state = true;

        int button_number;
        Byte[] position = new Byte[11] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { button1, button2, button3, button4,
                                     button5, button6, button7, button8,
                                     button9, button10, button11, button12 };

            button1.Left = x;
            button1.Top = y;
            button1.Width = h;
            button1.Height = h;
            button1.Text = " ";

            for (byte i = 1; i < 12; i++)
            {
                buttons[i].Left = buttons[i - 1].Left + dxy;
                buttons[i].Top = buttons[i - 1].Top + dxy;
                buttons[i].Width = h;
                buttons[i].Height = h;
                buttons[i].Text = " ";
            }

            button13.Left = dx;                     button13.Top = dy;                  button13.Width = h; button13.Height = h; button13.Text = " ";
            button14.Left = dx + dxy;               button14.Top = dy + dxy;            button14.Width = h; button14.Height = h; button14.Text = " ";
            button15.Left = button14.Left + dxy;    button15.Top = dy;                  button15.Width = h; button15.Height = h; button15.Text = " ";
            button16.Left = button15.Left + dxy;    button16.Top = dy + dxy;            button16.Width = h; button16.Height = h; button16.Text = " ";
            button17.Left = button16.Left + dxy;    button17.Top = button16.Top + dxy;  button17.Width = h; button17.Height = h; button17.Text = " ";
            button18.Left = button16.Left;          button18.Top = button17.Top + dxy;  button18.Width = h; button18.Height = h; button18.Text = " ";
            button19.Left = button15.Left;          button19.Top = button18.Top + dxy;  button19.Width = h; button19.Height = h; button19.Text = " ";

            button1.Click += button1_Click;     button1.BackColor = Color.Pink;
            button2.Click += button2_Click;     button2.BackColor = Color.Pink;
            button3.Click += button3_Click;     button3.BackColor = Color.Pink;
            button4.Click += button4_Click;     button4.BackColor = Color.Pink;
            button5.Click += button5_Click;     button5.BackColor = Color.Pink;
            button6.Click += button6_Click;     button6.BackColor = Color.Aquamarine;
            button7.Click += button7_Click;     button7.BackColor = Color.Aquamarine;
            button8.Click += button8_Click;     button8.BackColor = Color.Aquamarine;
            button9.Click += button9_Click;     button9.BackColor = Color.Pink;
            button10.Click += button10_Click;   button10.BackColor = Color.Aquamarine;
            button11.Click += button11_Click;   button11.BackColor = Color.Aquamarine;
            button12.BackColor = Color.Aquamarine;


        }

        private void turn_blue_Up()
        {
            for (int i = button_number; i < 11; i++)
                switch (position[i])
                {
                    case 0: // Bottom
                        buttons[i + 1].Top = buttons[i].Top + dxy;
                        buttons[i + 1].Left = buttons[i].Left + dxy;
                        position[i] = 1;
                        break;
                    case 1: // Left
                        buttons[i + 1].Top = buttons[i].Top + dxy;
                        buttons[i + 1].Left = buttons[i].Left - dxy;
                        position[i] = 2;
                        break;
                    case 2: // Top
                        buttons[i + 1].Top = buttons[i].Top - dxy;
                        buttons[i + 1].Left = buttons[i].Left - dxy;
                        position[i] = 3;
                        break;
                    case 3: // Right
                        buttons[i + 1].Top = buttons[i].Top - dxy;
                        buttons[i + 1].Left = buttons[i].Left + dxy;
                        position[i] = 0;
                        break;
                }
        }

        private void turn_blue_Down()
        {
            for (int i = button_number; i > 0; i--)
                switch (position[i - 1])
                {
                    case 0: // Bottom
                        buttons[i - 1].Top = buttons[i].Top - dxy;
                        buttons[i - 1].Left = buttons[i].Left - dxy;
                        position[i - 1] = 1;
                        break;
                    case 1: // Left
                        buttons[i - 1].Top = buttons[i].Top - dxy;
                        buttons[i - 1].Left = buttons[i].Left + dxy;
                        position[i - 1] = 2;
                        break;
                    case 2: // Top
                        buttons[i - 1].Top = buttons[i].Top + dxy;
                        buttons[i - 1].Left = buttons[i].Left + dxy;
                        position[i - 1] = 3;
                        break;
                    case 3: // Right
                        buttons[i - 1].Top = buttons[i].Top + dxy;
                        buttons[i - 1].Left = buttons[i].Left - dxy;
                        position[i - 1] = 0;
                        break;
                }
        }

        private void turn_pink_Up()
        {
            for (int i = button_number; i < 11; i++)
                switch (position[i])
                {
                    case 0: // Left
                        buttons[i + 1].Top = buttons[i].Top - dxy;
                        buttons[i + 1].Left = buttons[i].Left - dxy;
                        position[i] = 3;
                        break;
                    case 1: // Top
                        buttons[i + 1].Top = buttons[i].Top - dxy;
                        buttons[i + 1].Left = buttons[i].Left + dxy;
                        position[i] = 0;
                        break;
                    case 2: // Right
                        buttons[i + 1].Top = buttons[i].Top + dxy;
                        buttons[i + 1].Left = buttons[i].Left + dxy;
                        position[i] = 1;
                        break;
                    case 3: // Bottom
                        buttons[i + 1].Top = buttons[i].Top + dxy;
                        buttons[i + 1].Left = buttons[i].Left - dxy;
                        position[i] = 2;
                        break;
                }
        }

        private void turn_pink_Down()
        {
            for (int i = button_number; i > 0; i--)
                switch (position[i - 1])
                {
                    case 0: // Left
                        buttons[i - 1].Top = buttons[i].Top + dxy;
                        buttons[i - 1].Left = buttons[i].Left + dxy;
                        position[i - 1] = 3;
                        break;
                    case 1: // Top
                        buttons[i - 1].Top = buttons[i].Top + dxy;
                        buttons[i - 1].Left = buttons[i].Left - dxy;
                        position[i - 1] = 0;
                        break;
                    case 2: // Right
                        buttons[i - 1].Top = buttons[i].Top - dxy;
                        buttons[i - 1].Left = buttons[i].Left - dxy;
                        position[i - 1] = 1;
                        break;
                    case 3: // Bottom
                        buttons[i - 1].Top = buttons[i].Top - dxy;
                        buttons[i - 1].Left = buttons[i].Left + dxy;
                        position[i - 1] = 2;
                        break;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 0;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 1;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 2;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 3;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 4;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 5;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 6;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 7;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 8;
            if (state) turn_pink_Up();
            else turn_pink_Down();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 9;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 10;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            button_number = 11;
            if (state) turn_blue_Up();
            else turn_blue_Down();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            text = 0;
            textBox1.Text = "0";
            button1.Left = x;
            button1.Top = y;

            if (!state)
            {
                button12.Click -= button12_Click;
                button1.Click += button1_Click;
                state = true;
            }

            for (int i = 1; i < 12; i++)
            {
                buttons[i].Left = buttons[i - 1].Left + dxy;
                buttons[i].Top = buttons[i - 1].Top + dxy;
                buttons[i].BringToFront();
            }

            for (int i = 0; i < 11; i++) position[i] = 1;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            text++;
            textBox1.Text = " " + text;
            if (state)
            {
                for (int i = 10; i >= 0; i--) buttons[i].BringToFront();
                state = false;
                button12.Click += button12_Click;
                button1.Click -= button1_Click;
            }
            else
            {
                button12.Click -= button12_Click;
                button1.Click += button1_Click;
                for (int i = 1; i < 12; i++) buttons[i].BringToFront();
                state = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = " " + text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

    }
}