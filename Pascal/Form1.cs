namespace Pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            int m = 40;
            
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    int szoveg = Faktorialis(sor) / (Faktorialis(oszlop) * Faktorialis(sor - oszlop));
                    Button b = new Button();
                    b.Top = sor*m;
                    b.Left=oszlop*m;
                    b.Width = m;
                    b.Height = m;
                    b.Text = szoveg.ToString();


                    Controls.Add(b);
                }
            }
        }
        int Faktorialis(int n)
        {
            if (n == 0) { return 1; }
            else { return n * Faktorialis(n - 1); }
        }
    }
}