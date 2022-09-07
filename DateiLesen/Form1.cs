namespace DateiLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLesen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ein.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;
            lblDisplay.Text = "";
            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                lblDisplay.Text += zeile + "\n";
            }
            sr.Close();
        }
    }
}