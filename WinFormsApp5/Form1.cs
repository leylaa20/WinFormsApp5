namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button1.Text) / 100;

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button2.Text) / 100;

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button3.Text) / 100;

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button6.Text);

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button5.Text);

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_money.Text);
            float r1 = float.Parse(button4.Text);

            tbox_money.Text = (r + r1).ToString();
            lbl_money.Text = tbox_money.Text;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            tbox_money.ReadOnly = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void tbox_money_MouseLeave(object sender, EventArgs e)
        {           
            float f = 0;

            if (radioButton1.Checked == true) f = float.Parse(label3.Text);
            if (radioButton2.Checked == true) f = float.Parse(label11.Text);
            if (radioButton3.Checked == true) f = float.Parse(label12.Text);
            if (radioButton4.Checked == true) f = float.Parse(label13.Text);
            if (radioButton5.Checked == true) f = float.Parse(label14.Text);
            if (radioButton6.Checked == true) f = float.Parse(label16.Text);
            if (radioButton7.Checked == true) f = float.Parse(label19.Text);
            if (radioButton8.Checked == true) f = float.Parse(label17.Text);
            if (radioButton9.Checked == true) f = float.Parse(label15.Text);
            if (radioButton10.Checked == true) f = float.Parse(label18.Text);
            if (radioButton11.Checked == true) f = float.Parse(label20.Text);
            if (radioButton12.Checked == true) f = float.Parse(label21.Text);

            float l = float.Parse(lbl_money.Text);

            lbl_remain.Text = (l - f).ToString();            
        }
       
    }
}