using System.Configuration;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        private string name = ConfigurationManager.AppSettings["FONT_NAME"];
        private float size = float.Parse(ConfigurationManager.AppSettings["FONT_SIZE"]);

        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font(name, size, FontStyle.Bold, GraphicsUnit.Point, 204);
            Height = label1.Height;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                await Task.Delay(100);
                var time = DateTime.Now;
                label1.Text = time.ToString("D") + "   " + time.ToString("T");
                Width = 30 + label1.Width;
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            label1.Font = fontDialog1.Font;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FONT_NAME"].Value = label1.Font.Name;
            config.AppSettings.Settings["FONT_SIZE"].Value = label1.Font.Size.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Height = label1.Height;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
