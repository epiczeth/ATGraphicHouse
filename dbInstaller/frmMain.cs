using System;
using System.Data;
using System.Windows.Forms;
using dbInstaller.Properties;
using MySql.Data.MySqlClient;
using Zeth;

namespace dbInstaller
{
    public partial class FrmMain : Form
    {
        private MySqlConnection _conn;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void TestConnection()
        {
            try
            {
                _conn =
                    new MySqlConnection(string.Format("Server={0};port={1};uid={2};pwd={3};", txthost.Text, txtport.Text,
                        txtuid.Text, txtpass.Text));
                _conn.Open();
                Button4.Visible = true;
                Button4.Enabled = true;
                GroupBox1.Enabled = false;
                Button1.Enabled = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Button4.Enabled = false;
                GroupBox1.Enabled = true;
                Button1.Enabled = true;
            }
            finally
            {
                _conn.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(this,
                    @"การสร้างฐานข้อมูลใหม่จะลบ ฐานข้อมูลเก่าออกทั้งหมด คุณต้องการจะดำเนินการต่อหรือไม่?",
                    @"ลบฐานข้อมูล", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed)
                    {
                        _conn.Close();
                    }
                    _conn.Open();
                    var sc = new MySqlScript(_conn, Settings.Default.sql);
                    if (sc.Execute() >= 1)
                    {
                        MessageBox.Show(@"สร้างฐานข้อมูลสำเร็จ");
                    }
                    else
                    {
                        MessageBox.Show(@"สร้างฐานข้อมูลล้มเหลว");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}