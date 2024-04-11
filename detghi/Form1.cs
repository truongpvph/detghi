using detghi.Models;
using System.Data;

namespace detghi
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        Net1021FinalllllContext context = new Net1021FinalllllContext();
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnthongbao_Click(object sender, EventArgs e)
        {
            if (txtthongdiep.Text == "")
            {
                MessageBox.Show("vui long nhap thong diep", "thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(txtthongdiep.Text, "thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnloatcau1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                cbbluachon.Items.Add(i);
            }
            MessageBox.Show("Load thanh cong");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("Nganh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));
            foreach (var a in context.Sinhviens.ToList())
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = count++;
                dr["Ten"] = a.Ten;
                dr["Nganh"] = a.Nganh;
                dr["GioiTinh"] = a.Gioitinh;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            MessageBox.Show("Load Thanh Cong ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dtr = dataGridView1.Rows[e.RowIndex];
            txtten.Text = dtr.Cells[1].Value.ToString();
            txtnganh.Text = dtr.Cells[2].Value.ToString();
            if (Convert.ToBoolean(dtr.Cells[3].Value) == true)
            {
                rdonam.Checked = true;
            }
            if (Convert.ToBoolean(dtr.Cells[3].Value) == false)
            {
                rdonu.Checked = true;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Ban co chac chan muon clear khong ???", "thong bao ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (DialogResult == DialogResult.Yes)
            {
                txtten.Text = string.Empty;
                txtnganh.Text = string.Empty;
                rdonam.Checked = false;
                rdonu.Checked = false;
                MessageBox.Show("clear thanh cong");
            }
            else
            {
                return;
            }
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            try
            {
                var a = "F:\\Net.txt";
                StreamReader sr = new StreamReader(a);
                txtdoc_ghi.Text = sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("doc file  thanh cong ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("doc file khong thanh cong ");
            }

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                var a = "F:\\Net.txt";
                StreamWriter sr = new StreamWriter(a);
                sr.Write(txtdoc_ghi.Text);
                sr.Close();
                MessageBox.Show("doc file  thanh cong ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("doc file khong thanh cong ");
            }

        }
    }
}
