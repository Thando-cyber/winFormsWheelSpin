using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace winFormsWheelSpin
{
    public partial class Form1 : Form
    {
        
        public int val;
        bool wheelIsMoved;
        float wheelTimes;
        Timer wheelTimer;
        SpinOWheel spin;
        public Form1()
        {
            InitializeComponent();
            wheelTimer = new Timer();
            wheelTimer.Interval = 30;
            wheelTimer.Tick += wheelTimer_Tick;
            spin = new SpinOWheel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class SpinOWheel
        {
            public Bitmap obrazek;
            public Bitmap tempObrazek;
            public float kat;
            public int[] wartosciStanu;
            public int stan;
            public SpinOWheel()
            {
                tempObrazek = new Bitmap(Properties.Resources.Wheel_Test5);
                obrazek = new Bitmap(Properties.Resources.Wheel_Test5);
                wartosciStanu = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 09, 08, 07, 06, 05, 04, 03, 02, 01 };
                kat = 0.0f;
            }
        }
        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");


            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }
        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }

        }
        private void wheelTimer_Tick(object sender, EventArgs e)
        {

            if (wheelIsMoved && wheelTimes > 0)
            {
                spin.kat += wheelTimes / 10;
                spin.kat = spin.kat % 360;
                RotateImage(pictureBox2, spin.obrazek, spin.kat);
                wheelTimes--;
                playSimpleSound();
            }
            spin.stan = Convert.ToInt32(Math.Ceiling(spin.kat / 18));
            //string value = Convert.ToString(spin.wartosciStanu[spin.stan]);

            if (spin.stan == 0)
            {
                spin.stan = 0;
            }
            else
            {
                spin.stan -= 1;
            }

            label2.Text = Convert.ToString(spin.wartosciStanu[spin.stan]);
            int win = Int32.Parse(Convert.ToString(spin.wartosciStanu[spin.stan]));
            if (win==20)
            {
                val = 10000;
            }
            else
            {
                val = (win*10000)+10000;
            }
            label3.Text = Convert.ToString(val);
            //MessageBox.Show("Congratulations ! You've Won R" + val);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            wheelIsMoved = true;
            Random rand = new Random();
            wheelTimes = rand.Next(150, 180);
            //string winVal = comboBox1.Text.Remove(0);
            //int userVal= Int32.Parse(winVal);
            //int stopVal = 0;

            string value = Convert.ToString(spin.wartosciStanu[spin.stan]);
            int win = Int32.Parse(value);

            wheelTimer.Start();
            


        }
        private void playSimpleSound()
        {
            string filename = "Tick.wav";

            string soundloc = Path.GetFullPath(filename); 
            SoundPlayer ticksound = new SoundPlayer(soundloc);
            ticksound.Play();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}