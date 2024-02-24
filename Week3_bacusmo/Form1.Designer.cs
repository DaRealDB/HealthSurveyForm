namespace Week3_bacusmo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_lname = new TextBox();
            tb_date = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_email = new TextBox();
            label7 = new Label();
            tb_cp = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tb_add = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tb_fname = new TextBox();
            label14 = new Label();
            tb_city = new TextBox();
            tb_prov = new TextBox();
            label8 = new Label();
            label15 = new Label();
            tb_age = new TextBox();
            label16 = new Label();
            label17 = new Label();
            rb_male = new RadioButton();
            rb_female = new RadioButton();
            label18 = new Label();
            cb_month = new ComboBox();
            cb_day = new ComboBox();
            cb_year = new ComboBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            cb_hbp = new CheckBox();
            cb_dt2 = new CheckBox();
            cb_dt1 = new CheckBox();
            cb_gout = new CheckBox();
            label24 = new Label();
            label25 = new Label();
            cb_diabetes = new CheckBox();
            cb_hbpressure = new CheckBox();
            cb_Thyroid = new CheckBox();
            cb_lithuim = new CheckBox();
            cb_HC = new CheckBox();
            cb_CW = new CheckBox();
            label26 = new Label();
            label27 = new Label();
            tb_describe = new TextBox();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            tb_work = new TextBox();
            label31 = new Label();
            tb_enjoy = new TextBox();
            label32 = new Label();
            tb_other = new TextBox();
            label33 = new Label();
            cb_rate = new ComboBox();
            bt_submit = new Button();
            cb_yes = new CheckBox();
            cb_no = new CheckBox();
            cb1_yes = new CheckBox();
            cb_na = new CheckBox();
            cb1_no = new CheckBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 54);
            label1.TabIndex = 0;
            label1.Text = "HEALTH SURVEY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(405, 63);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Please fill out this form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 98);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // tb_lname
            // 
            tb_lname.Location = new Point(70, 120);
            tb_lname.Multiline = true;
            tb_lname.Name = "tb_lname";
            tb_lname.Size = new Size(122, 20);
            tb_lname.TabIndex = 3;
            tb_lname.TextChanged += textBox1_TextChanged;
            // 
            // tb_date
            // 
            tb_date.ForeColor = SystemColors.MenuText;
            tb_date.Location = new Point(356, 120);
            tb_date.Multiline = true;
            tb_date.Name = "tb_date";
            tb_date.Size = new Size(217, 20);
            tb_date.TabIndex = 5;
            tb_date.TextChanged += tb_date_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(356, 98);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(70, 140);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 7;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(356, 140);
            label6.Name = "label6";
            label6.Size = new Size(122, 13);
            label6.TabIndex = 11;
            label6.Text = "Date e.g (MM-DD-YYYY)";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(73, 190);
            tb_email.Multiline = true;
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(234, 20);
            tb_email.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(70, 168);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 13;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // tb_cp
            // 
            tb_cp.ForeColor = SystemColors.MenuText;
            tb_cp.Location = new Point(356, 191);
            tb_cp.Multiline = true;
            tb_cp.Name = "tb_cp";
            tb_cp.Size = new Size(217, 20);
            tb_cp.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(354, 168);
            label9.Name = "label9";
            label9.Size = new Size(113, 19);
            label9.TabIndex = 15;
            label9.Text = "Phone Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(73, 213);
            label10.Name = "label10";
            label10.Size = new Size(122, 13);
            label10.TabIndex = 16;
            label10.Text = "example@example.com";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(354, 213);
            label11.Name = "label11";
            label11.Size = new Size(253, 13);
            label11.TabIndex = 17;
            label11.Text = "Enter a valid phone number e.g (+63 (943)-563-123)";
            label11.Click += label11_Click;
            // 
            // tb_add
            // 
            tb_add.Location = new Point(73, 263);
            tb_add.Multiline = true;
            tb_add.Name = "tb_add";
            tb_add.Size = new Size(234, 19);
            tb_add.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(73, 241);
            label12.Name = "label12";
            label12.Size = new Size(63, 19);
            label12.TabIndex = 19;
            label12.Text = "Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(73, 285);
            label13.Name = "label13";
            label13.Size = new Size(73, 13);
            label13.TabIndex = 21;
            label13.Text = "Street Address";
            label13.Click += label13_Click;
            // 
            // tb_fname
            // 
            tb_fname.Location = new Point(198, 120);
            tb_fname.Multiline = true;
            tb_fname.Name = "tb_fname";
            tb_fname.Size = new Size(109, 20);
            tb_fname.TabIndex = 22;
            tb_fname.TextChanged += textBox2_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(198, 140);
            label14.Name = "label14";
            label14.Size = new Size(57, 13);
            label14.TabIndex = 23;
            label14.Text = "First Name";
            // 
            // tb_city
            // 
            tb_city.Location = new Point(73, 313);
            tb_city.Multiline = true;
            tb_city.Name = "tb_city";
            tb_city.Size = new Size(119, 17);
            tb_city.TabIndex = 24;
            // 
            // tb_prov
            // 
            tb_prov.Location = new Point(198, 313);
            tb_prov.Multiline = true;
            tb_prov.Name = "tb_prov";
            tb_prov.Size = new Size(109, 17);
            tb_prov.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(73, 333);
            label8.Name = "label8";
            label8.Size = new Size(25, 13);
            label8.TabIndex = 26;
            label8.Text = "City";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(198, 333);
            label15.Name = "label15";
            label15.Size = new Size(82, 13);
            label15.TabIndex = 27;
            label15.Text = "State / Province";
            // 
            // tb_age
            // 
            tb_age.Location = new Point(636, 120);
            tb_age.Multiline = true;
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(94, 20);
            tb_age.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(636, 98);
            label16.Name = "label16";
            label16.Size = new Size(35, 19);
            label16.TabIndex = 29;
            label16.Text = "Age";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(636, 168);
            label17.Name = "label17";
            label17.Size = new Size(59, 19);
            label17.TabIndex = 30;
            label17.Text = "Gender";
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(636, 191);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(51, 19);
            rb_male.TabIndex = 31;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(636, 216);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(63, 19);
            rb_female.TabIndex = 32;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(356, 241);
            label18.Name = "label18";
            label18.Size = new Size(79, 19);
            label18.TabIndex = 34;
            label18.Text = "Birth Date";
            // 
            // cb_month
            // 
            cb_month.FormattingEnabled = true;
            cb_month.Items.AddRange(new object[] { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cb_month.Location = new Point(356, 263);
            cb_month.Name = "cb_month";
            cb_month.Size = new Size(97, 23);
            cb_month.TabIndex = 35;
            cb_month.SelectedIndexChanged += cb_month_SelectedIndexChanged;
            // 
            // cb_day
            // 
            cb_day.FormattingEnabled = true;
            cb_day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cb_day.Location = new Point(459, 263);
            cb_day.Name = "cb_day";
            cb_day.Size = new Size(97, 23);
            cb_day.TabIndex = 36;
            // 
            // cb_year
            // 
            cb_year.FormattingEnabled = true;
            cb_year.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100" });
            cb_year.Location = new Point(562, 263);
            cb_year.Name = "cb_year";
            cb_year.Size = new Size(97, 23);
            cb_year.TabIndex = 37;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(353, 289);
            label19.Name = "label19";
            label19.Size = new Size(37, 13);
            label19.TabIndex = 38;
            label19.Text = "Month";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(459, 289);
            label20.Name = "label20";
            label20.Size = new Size(25, 13);
            label20.TabIndex = 39;
            label20.Text = "Day";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(562, 289);
            label21.Name = "label21";
            label21.Size = new Size(28, 13);
            label21.TabIndex = 40;
            label21.Text = "Year";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(73, 374);
            label22.Name = "label22";
            label22.Size = new Size(63, 19);
            label22.TabIndex = 41;
            label22.Text = "Medical";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ActiveCaptionText;
            label23.Location = new Point(73, 408);
            label23.Name = "label23";
            label23.Size = new Size(173, 14);
            label23.TabIndex = 42;
            label23.Text = "Do you have any of the following?";
            label23.Click += label23_Click;
            // 
            // cb_hbp
            // 
            cb_hbp.AutoSize = true;
            cb_hbp.Location = new Point(73, 440);
            cb_hbp.Name = "cb_hbp";
            cb_hbp.Size = new Size(133, 19);
            cb_hbp.TabIndex = 43;
            cb_hbp.Text = "High blood pressure";
            cb_hbp.UseVisualStyleBackColor = true;
            // 
            // cb_dt2
            // 
            cb_dt2.AutoSize = true;
            cb_dt2.Location = new Point(73, 465);
            cb_dt2.Name = "cb_dt2";
            cb_dt2.Size = new Size(115, 19);
            cb_dt2.TabIndex = 44;
            cb_dt2.Text = "Diabetes - Type 2";
            cb_dt2.UseVisualStyleBackColor = true;
            // 
            // cb_dt1
            // 
            cb_dt1.AutoSize = true;
            cb_dt1.Location = new Point(212, 440);
            cb_dt1.Name = "cb_dt1";
            cb_dt1.Size = new Size(115, 19);
            cb_dt1.TabIndex = 45;
            cb_dt1.Text = "Diabetes - Type 1";
            cb_dt1.UseVisualStyleBackColor = true;
            // 
            // cb_gout
            // 
            cb_gout.AutoSize = true;
            cb_gout.Location = new Point(212, 465);
            cb_gout.Name = "cb_gout";
            cb_gout.Size = new Size(52, 19);
            cb_gout.TabIndex = 46;
            cb_gout.Text = "Gout";
            cb_gout.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(-6, 346);
            label24.Name = "label24";
            label24.Size = new Size(1239, 19);
            label24.TabIndex = 47;
            label24.Text = resources.GetString("label24.Text");
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ActiveCaptionText;
            label25.Location = new Point(353, 408);
            label25.Name = "label25";
            label25.Size = new Size(175, 14);
            label25.TabIndex = 48;
            label25.Text = "Are you taking any medications for";
            // 
            // cb_diabetes
            // 
            cb_diabetes.AutoSize = true;
            cb_diabetes.Location = new Point(356, 440);
            cb_diabetes.Name = "cb_diabetes";
            cb_diabetes.Size = new Size(71, 19);
            cb_diabetes.TabIndex = 49;
            cb_diabetes.Text = "Diabetes";
            cb_diabetes.UseVisualStyleBackColor = true;
            cb_diabetes.CheckedChanged += cb_diabetes_CheckedChanged;
            // 
            // cb_hbpressure
            // 
            cb_hbpressure.AutoSize = true;
            cb_hbpressure.Location = new Point(356, 465);
            cb_hbpressure.Name = "cb_hbpressure";
            cb_hbpressure.Size = new Size(133, 19);
            cb_hbpressure.TabIndex = 50;
            cb_hbpressure.Text = "High blood pressure";
            cb_hbpressure.UseVisualStyleBackColor = true;
            // 
            // cb_Thyroid
            // 
            cb_Thyroid.AutoSize = true;
            cb_Thyroid.Location = new Point(490, 440);
            cb_Thyroid.Name = "cb_Thyroid";
            cb_Thyroid.Size = new Size(66, 19);
            cb_Thyroid.TabIndex = 51;
            cb_Thyroid.Text = "Thryoid";
            cb_Thyroid.UseVisualStyleBackColor = true;
            // 
            // cb_lithuim
            // 
            cb_lithuim.AutoSize = true;
            cb_lithuim.Location = new Point(490, 465);
            cb_lithuim.Name = "cb_lithuim";
            cb_lithuim.Size = new Size(67, 19);
            cb_lithuim.TabIndex = 52;
            cb_lithuim.Text = "Lithuim";
            cb_lithuim.UseVisualStyleBackColor = true;
            // 
            // cb_HC
            // 
            cb_HC.AutoSize = true;
            cb_HC.Location = new Point(356, 490);
            cb_HC.Name = "cb_HC";
            cb_HC.Size = new Size(115, 19);
            cb_HC.TabIndex = 53;
            cb_HC.Text = "High Cholesterol";
            cb_HC.UseVisualStyleBackColor = true;
            // 
            // cb_CW
            // 
            cb_CW.AutoSize = true;
            cb_CW.Location = new Point(490, 490);
            cb_CW.Name = "cb_CW";
            cb_CW.Size = new Size(135, 19);
            cb_CW.TabIndex = 54;
            cb_CW.Text = "Coumadin(Warfarin)";
            cb_CW.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(70, 530);
            label26.Name = "label26";
            label26.Size = new Size(98, 14);
            label26.TabIndex = 56;
            label26.Text = "Are you pregnant?";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = SystemColors.ActiveCaptionText;
            label27.Location = new Point(351, 530);
            label27.Name = "label27";
            label27.Size = new Size(142, 14);
            label27.TabIndex = 59;
            label27.Text = "Do you have food allergies?";
            // 
            // tb_describe
            // 
            tb_describe.ForeColor = SystemColors.MenuText;
            tb_describe.Location = new Point(353, 592);
            tb_describe.Multiline = true;
            tb_describe.Name = "tb_describe";
            tb_describe.Size = new Size(234, 19);
            tb_describe.TabIndex = 62;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = SystemColors.ActiveCaptionText;
            label28.Location = new Point(351, 575);
            label28.Name = "label28";
            label28.Size = new Size(84, 14);
            label28.TabIndex = 63;
            label28.Text = "Please describe";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(700, 374);
            label29.Name = "label29";
            label29.Size = new Size(49, 19);
            label29.TabIndex = 64;
            label29.Text = "Stress";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.ActiveCaptionText;
            label30.Location = new Point(700, 408);
            label30.Name = "label30";
            label30.Size = new Size(134, 14);
            label30.TabIndex = 65;
            label30.Text = "What do you do for work?";
            // 
            // tb_work
            // 
            tb_work.ForeColor = SystemColors.MenuText;
            tb_work.Location = new Point(700, 425);
            tb_work.Multiline = true;
            tb_work.Name = "tb_work";
            tb_work.Size = new Size(234, 19);
            tb_work.TabIndex = 66;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label31.ForeColor = SystemColors.ActiveCaptionText;
            label31.Location = new Point(700, 465);
            label31.Name = "label31";
            label31.Size = new Size(140, 14);
            label31.TabIndex = 67;
            label31.Text = "Do you enjoy what you do?";
            // 
            // tb_enjoy
            // 
            tb_enjoy.ForeColor = SystemColors.MenuText;
            tb_enjoy.Location = new Point(700, 490);
            tb_enjoy.Multiline = true;
            tb_enjoy.Name = "tb_enjoy";
            tb_enjoy.Size = new Size(234, 19);
            tb_enjoy.TabIndex = 68;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label32.ForeColor = SystemColors.ActiveCaptionText;
            label32.Location = new Point(700, 521);
            label32.Name = "label32";
            label32.Size = new Size(195, 14);
            label32.TabIndex = 69;
            label32.Text = "Are there any other stress in your life?";
            // 
            // tb_other
            // 
            tb_other.ForeColor = SystemColors.MenuText;
            tb_other.Location = new Point(700, 538);
            tb_other.Multiline = true;
            tb_other.Name = "tb_other";
            tb_other.Size = new Size(234, 73);
            tb_other.TabIndex = 70;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = SystemColors.ActiveCaptionText;
            label33.Location = new Point(946, 408);
            label33.Name = "label33";
            label33.Size = new Size(124, 14);
            label33.TabIndex = 71;
            label33.Text = "Rate your overall Stress";
            // 
            // cb_rate
            // 
            cb_rate.FormattingEnabled = true;
            cb_rate.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cb_rate.Location = new Point(946, 425);
            cb_rate.Name = "cb_rate";
            cb_rate.Size = new Size(87, 23);
            cb_rate.TabIndex = 72;
            // 
            // bt_submit
            // 
            bt_submit.BackColor = Color.SkyBlue;
            bt_submit.Location = new Point(946, 578);
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(99, 33);
            bt_submit.TabIndex = 73;
            bt_submit.Text = "Submit";
            bt_submit.UseVisualStyleBackColor = false;
            bt_submit.Click += button1_Click;
            // 
            // cb_yes
            // 
            cb_yes.AutoSize = true;
            cb_yes.Location = new Point(356, 551);
            cb_yes.Name = "cb_yes";
            cb_yes.Size = new Size(43, 19);
            cb_yes.TabIndex = 74;
            cb_yes.Text = "Yes";
            cb_yes.UseVisualStyleBackColor = true;
            // 
            // cb_no
            // 
            cb_no.AutoSize = true;
            cb_no.Location = new Point(411, 551);
            cb_no.Name = "cb_no";
            cb_no.Size = new Size(42, 19);
            cb_no.TabIndex = 75;
            cb_no.Text = "No";
            cb_no.UseVisualStyleBackColor = true;
            // 
            // cb1_yes
            // 
            cb1_yes.AutoSize = true;
            cb1_yes.Location = new Point(73, 551);
            cb1_yes.Name = "cb1_yes";
            cb1_yes.Size = new Size(43, 19);
            cb1_yes.TabIndex = 76;
            cb1_yes.Text = "Yes";
            cb1_yes.UseVisualStyleBackColor = true;
            // 
            // cb_na
            // 
            cb_na.AutoSize = true;
            cb_na.Location = new Point(122, 551);
            cb_na.Name = "cb_na";
            cb_na.Size = new Size(48, 19);
            cb_na.TabIndex = 77;
            cb_na.Text = "N/A";
            cb_na.UseVisualStyleBackColor = true;
            // 
            // cb1_no
            // 
            cb1_no.AutoSize = true;
            cb1_no.Location = new Point(73, 576);
            cb1_no.Name = "cb1_no";
            cb1_no.Size = new Size(42, 19);
            cb1_no.TabIndex = 78;
            cb1_no.Text = "No";
            cb1_no.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(797, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 198);
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(945, 532);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 80;
            button1.Text = "Review";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1114, 749);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(cb1_no);
            Controls.Add(cb_na);
            Controls.Add(cb1_yes);
            Controls.Add(cb_no);
            Controls.Add(cb_yes);
            Controls.Add(bt_submit);
            Controls.Add(cb_rate);
            Controls.Add(label33);
            Controls.Add(tb_other);
            Controls.Add(label32);
            Controls.Add(tb_enjoy);
            Controls.Add(label31);
            Controls.Add(tb_work);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(tb_describe);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(cb_CW);
            Controls.Add(cb_HC);
            Controls.Add(cb_lithuim);
            Controls.Add(cb_Thyroid);
            Controls.Add(cb_hbpressure);
            Controls.Add(cb_diabetes);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(cb_gout);
            Controls.Add(cb_dt1);
            Controls.Add(cb_dt2);
            Controls.Add(cb_hbp);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(cb_year);
            Controls.Add(cb_day);
            Controls.Add(cb_month);
            Controls.Add(label18);
            Controls.Add(rb_female);
            Controls.Add(rb_male);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(tb_age);
            Controls.Add(label15);
            Controls.Add(label8);
            Controls.Add(tb_prov);
            Controls.Add(tb_city);
            Controls.Add(label14);
            Controls.Add(tb_fname);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(tb_add);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tb_cp);
            Controls.Add(label7);
            Controls.Add(tb_email);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_date);
            Controls.Add(tb_lname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_lname;
        private TextBox tb_date;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_email;
        private Label label7;
        private TextBox tb_cp;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tb_add;
        private Label label12;
        private Label label13;
        private TextBox tb_fname;
        private Label label14;
        private TextBox tb_city;
        private TextBox tb_prov;
        private Label label8;
        private Label label15;
        private TextBox tb_age;
        private Label label16;
        private Label label17;
        private RadioButton rb_male;
        private RadioButton rb_female;
        private Label label18;
        private ComboBox cb_month;
        private ComboBox cb_day;
        private ComboBox cb_year;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private CheckBox cb_hbp;
        private CheckBox cb_dt2;
        private CheckBox cb_dt1;
        private CheckBox cb_gout;
        private Label label24;
        private Label label25;
        private CheckBox cb_diabetes;
        private CheckBox cb_hbpressure;
        private CheckBox cb_Thyroid;
        private CheckBox cb_lithuim;
        private CheckBox cb_HC;
        private CheckBox cb_CW;
        private Label label26;
        private Label label27;
        private TextBox tb_describe;
        private Label label28;
        private Label label29;
        private Label label30;
        private TextBox tb_work;
        private Label label31;
        private TextBox tb_enjoy;
        private Label label32;
        private TextBox tb_other;
        private Label label33;
        private ComboBox cb_rate;
        private Button bt_submit;
        private CheckBox cb_yes;
        private CheckBox cb_no;
        private CheckBox cb1_yes;
        private CheckBox cb_na;
        private CheckBox cb1_no;
        private PictureBox pictureBox1;
        private Button button1;
    }
}