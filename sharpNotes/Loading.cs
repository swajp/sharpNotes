namespace sharpNotes
{
    public partial class Loading : Form
    {
        private int timeToWait = 15;
        private int elapsedTime = 0;
        public Loading()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Black;
            this.BackColor = Color.Black;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (elapsedTime < timeToWait)
            {
                elapsedTime++;
            }
            else
            {
                timer1.Stop();
                DialogResult = DialogResult.OK;
            }
        }
    }
}