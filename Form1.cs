using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace winFormsWheelSpin
{
    public partial class Form1 : Form
    {

        public int val;
        //public int count;
        bool wheelIsMoved;
        float wheelTimes;
        Timer wheelTimer;
        SpinOWheel spin;
        public Form1()
        {

            InitializeComponent();
            wheelTimer = new Timer();
            wheelTimer.Interval = 136;
            wheelTimer.Tick += wheelTimer_Tick;
            spin = new SpinOWheel();
            //count = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class SpinOWheel
        {
            public Bitmap image;
            public Bitmap temporaryImage;
            public float kat;
            public int[] wheelNum;
            public int stan;

            public SpinOWheel() //is meant to move image
            {
                temporaryImage = new Bitmap(Properties.Resources.Wheel_Test5);
                image = new Bitmap(Properties.Resources.Wheel_Test5);
                wheelNum = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 09, 08, 07, 06, 05, 04, 03, 02, 01 };
                kat = 0.0f;
            }
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width/2, (float)image.Height/2), angle);
        }

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            Bitmap rotatedBmap = new Bitmap(image.Width, image.Height);
            rotatedBmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmap);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            return rotatedBmap;
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

        private void wheelTimer_Tick(object sender, EventArgs e)//internal logic for tracking and controlling wheel movement
        {
            if (wheelIsMoved && wheelTimes > 0)
            {
                spin.kat += wheelTimes/20;
                spin.kat = spin.kat % 360;
                RotateImage(pictureBox2, spin.image, spin.kat);
                wheelTimes--;
                playSimpleSound(true);
            }
            spin.stan = Convert.ToInt32(Math.Ceiling(spin.kat/18));
            if (spin.stan == 0)
            {
                spin.stan = 0;
            }
            else
            {
                spin.stan -= 1;
            }

            label2.Text = Convert.ToString(spin.wheelNum[spin.stan]);
            int win = Int32.Parse(Convert.ToString(spin.wheelNum[spin.stan]));
            if (win==20)
            {
                val = 10000;
            }
            else
            {
                val = (win*10000)+10000;
            }
            label3.Text = Convert.ToString(val);

            int count = Convert.ToInt32(numericUpDown1.Value);
            if (val == count)
            {
                wheelTimes = 0;
                wheelTimer.Stop();
                playSimpleSound(false);
                //numericUpDown1.ReadOnly = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled= false;
            wheelIsMoved = true;
            wheelTimes =200;
            string value = Convert.ToString(spin.wheelNum[spin.stan]);
            int win = Int32.Parse(value);
            wheelTimer.Start();
            button1.Enabled= true;
        }
        private void playSimpleSound(bool sound)
        {

            SoundPlayer ticksound = new SoundPlayer(Path.GetFullPath("Tick.wav"));
            if (sound == true)
            {
                ticksound.Play();
            }
            else if (sound== false)
            {
                ticksound.Stop();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}