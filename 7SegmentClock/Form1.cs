namespace _7SegmentClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("ddd");
            lblDate.Text = DateTime.Now.ToString("MMM / d / yyyy");
        }
    }
}