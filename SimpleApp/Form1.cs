using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleApp
{
    public partial class Form1 : Form
    {
        private List<string> namaList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            dataGridView1.Columns.Add("No", "No");
            dataGridView1.Columns.Add("Nama", "Nama");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();

            if (!string.IsNullOrEmpty(nama))
            {
                namaList.Add(nama);
                TampilkanData();
                txtNama.Clear();
            }
            else
            {
                MessageBox.Show("Nama tidak boleh kosong!");
            }
        }

        private void TampilkanData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < namaList.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, namaList[i]);
            }
        }
    }
}
