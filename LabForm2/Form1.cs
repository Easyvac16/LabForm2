namespace LabForm2
{
    public partial class Form1 : Form
    {
        bool Down;
        Point startPoint;
        List<Label> labels = new List<Label>();
        char currentSybmol;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point_X.Text = e.X.ToString();
            Point_Y.Text = e.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                currentSybmol = '*';
            }
            else if (e.Button == MouseButtons.Right)
            {
                currentSybmol = '^';
            }
            else if (e.Button == MouseButtons.Middle)
            {
                currentSybmol = '♩';
            }


            if (Down)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(e.X, e.Y);
                label.Text = currentSybmol.ToString();
                this.Controls.Add(label);
                labels.Add(label);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Down = true;
            startPoint = e.Location;

            Label label = new Label();
            label.AutoSize = true;
            label.Location = startPoint;
            label.Text = currentSybmol.ToString();
            this.Controls.Add(label);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Down = false;
            else if (e.Button == MouseButtons.Right) Down = false;
            else if (e.Button == MouseButtons.Middle) Down = false;
        }
    }
}