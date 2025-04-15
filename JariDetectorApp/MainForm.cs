using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace JariDetectorApp
{
    public class MainForm : Form
    {
        private Button btnMulai;
        private Button btnKeluar;
        private Label lblHasil;

        public MainForm()
        {
            this.Text = "Deteksi Jari dengan Python";
            this.Width = 400;
            this.Height = 200;

            btnMulai = new Button();
            btnMulai.Text = "Mulai Deteksi";
            btnMulai.Location = new System.Drawing.Point(30, 30);
            btnMulai.Click += BtnMulai_Click;

            btnKeluar = new Button();
            btnKeluar.Text = "Keluar";
            btnKeluar.Location = new System.Drawing.Point(150, 30);
            btnKeluar.Click += BtnKeluar_Click;

            lblHasil = new Label();
            lblHasil.Text = "Hasil akan tampil di sini...";
            lblHasil.Location = new System.Drawing.Point(30, 80);
            lblHasil.Width = 300;

            this.Controls.Add(btnMulai);
            this.Controls.Add(btnKeluar);
            this.Controls.Add(lblHasil);
        }

        private async void BtnMulai_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "python";
            psi.Arguments = "jari.py";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = psi;
            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            lblHasil.Text = "Output Python: " + output.Trim();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}