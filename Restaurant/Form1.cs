namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            
        }

        private void InitializeComboBoxes()
        {
            comboBox1.Items.AddRange(new string[] { "Soda - $1.95", "Tea - $1.95",
                "Coffee - $1.25", "Mineral Water - $2.95", "Juice - $2.50", "Milk - $1.50", });
            comboBox2.Items.AddRange(new string[] { "Buttalo Wings - $3.00", "Buitalo Fingers - $5.00",
                "Potato Sleins - $4.00",  "Nachos - $4.00",  "Mushroom Caps - $4.00" , "Shrimp Cocktail - $5.00","Chips and Salse - $3.00"});
            comboBox3.Items.AddRange(new string[] { "Seafood Alfredo - $15.00", "Chicken Alfredo - $10.00", "Chicken Picara - $12.00"
            , "Turkey Club - $12.00", "Tabster Pie - $19.00"});
            comboBox4.Items.AddRange(new string[] { "Apple Pie - $3.00", "Sundae - $4.00", "Carror Calo - $3.50", "Mud Vie - $4.00" });
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            double subtotal = 0.0;

            subtotal += GetItemPrice(comboBox1.SelectedItem);
            subtotal += GetItemPrice(comboBox2.SelectedItem);
            subtotal += GetItemPrice(comboBox3.SelectedItem);
            subtotal += GetItemPrice(comboBox4.SelectedItem);

            double tax = subtotal * 0.07; 
            double total = subtotal + tax;

            textBox3.Text = subtotal.ToString("C");
            textBox4.Text = tax.ToString("C");
            textBox5.Text = total.ToString("C");

        }
        private double GetItemPrice(object selectedItem)
        {
            if (selectedItem == null) return 0.0;

            string item = selectedItem.ToString();
            string[] parts = item.Split('-');

            if (parts.Length < 2)
            {
                return 0.0;
            }

            double price;
            if (double.TryParse(parts[1].Trim().Replace("$", ""), out price))
            {
                return price;
            }

            return 0.0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            textBox3.Text = "$0.00";
            textBox4.Text = "$0.00";
            textBox5.Text = "$0.00";
        }
    }

}
