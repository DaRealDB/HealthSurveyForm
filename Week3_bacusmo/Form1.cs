namespace Week3_bacusmo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Successfully submitted");
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name, name2, address, age, email, city,
                   province, date, cpnum, bd1, bd2,
                   bd3, g1 = " ", g2 = " ", no = " ", yes = " ";



            bd1 = cb_month.GetItemText(cb_month.SelectedItem);
            bd2 = cb_day.GetItemText(cb_day.SelectedItem);
            bd3 = cb_year.GetItemText(cb_year.SelectedItem);
            name = tb_lname.Text;
            name2 = tb_fname.Text;
            address = tb_add.Text;
            age = tb_age.Text;
            email = tb_email.Text;
            city = tb_city.Text;
            province = tb_prov.Text;
            date = tb_date.Text;
            cpnum = tb_cp.Text;

            if (rb_male.Checked)
            {
                g1 = rb_male.Text;
            }
            if (rb_female.Checked)
            {
                g2 = rb_female.Text;
            }


            string hbp = " ", dt2 = " ", dt1 = " ", gout = " ", diabetes = " ", hbpressure = " ", hc = " ", Td = " ", Lm = " ", Cw = " ", work,
                enjoy, other, rate, na = " ", yes1 = " ", no1 = " ", describe;

            work = tb_work.Text;
            enjoy = tb_enjoy.Text;
            other = tb_other.Text;
            rate = cb_rate.GetItemText(cb_rate.SelectedItem);

            //Question 1
            if (cb_hbp.Checked)
            {
                hbp = cb_hbp.Text;
            }
            if (cb_dt2.Checked)
            {
                dt2 = ", " + cb_dt2.Text;
            }
            if (cb_dt1.Checked)
            {
                dt1 = ", " + cb_dt1.Text;
            }
            if (cb_gout.Checked)
            {
                gout = ", " + cb_gout.Text;
            }

            //Question 2
            if (cb_diabetes.Checked)
            {
                diabetes = cb_diabetes.Text;
            }
            if (cb_hbpressure.Checked)
            {
                hbpressure = ", " + cb_hbpressure.Text;
            }
            if (cb_HC.Checked)
            {

                hc = ", " + cb_HC.Text;
            }
            if (cb_Thyroid.Checked)
            {
                Td = ", " + cb_Thyroid.Text;
            }
            if (cb_lithuim.Checked)
            {
                Lm = ", " + cb_lithuim.Text;
            }
            if (cb_CW.Checked)
            {
                Cw = ", " + cb_CW.Text;
            }
            //Are you pregnant question

            if (cb1_yes.Checked)
            {
                yes1 = cb1_yes.Text;
            }
            if (cb1_no.Checked)
            {
                no1 = cb1_no.Text;
            }
            if (cb_na.Checked)
            {
                na = cb_na.Text;
            }
            //food allergies question
            if (cb_yes.Checked)
            {
                yes = cb_yes.Text;
            }
            if (cb_no.Checked)
            {
                no = cb_no.Text;
            }


            describe = tb_describe.Text;






            MessageBox.Show("Report Summary: " +
                Environment.NewLine + "Date: " + date + Environment.NewLine + "Name: " + name + "," + name2 + Environment.NewLine + "Age: " + age +
                Environment.NewLine + "Gender: " + g1 + g2 + Environment.NewLine + "Address: " + address + "," + province + "," + city +
               Environment.NewLine + "Birth Date: " + bd1 + " " + bd2 + "," + " " + bd3 + Environment.NewLine + "Phone number: " + cpnum + Environment.NewLine +
               Environment.NewLine + "Medical Report: " + Environment.NewLine +
               "Has the following: " + hbp + dt1 + dt2 + gout + Environment.NewLine + "Taking medications for: " + diabetes + hbpressure + hc + Td + Lm + Cw +
               Environment.NewLine + "Are you pregnant?: " + yes1 + no1 + na + Environment.NewLine +
               "Do you have food allergies?: " + yes + no + Environment.NewLine + "If yes: " + describe + Environment.NewLine + Environment.NewLine
               + "Stress Report: " + Environment.NewLine + "What do you do for work? " + Environment.NewLine + work + Environment.NewLine +
               "Do you enjoy what you do? " + Environment.NewLine + enjoy + Environment.NewLine +
               "Are there any other stress in your life?: " + Environment.NewLine + other + Environment.NewLine + "Stress level: " + rate);

        }

        private void cb_diabetes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}