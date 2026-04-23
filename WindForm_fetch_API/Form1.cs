using WindForm_fetch_API.Models;
using WindForm_fetch_API.Services;

namespace WindForm_fetch_API
{
    public partial class Form1 : Form
    {
        public List<User> listUser;
        private readonly UserService _userService = new UserService();

        public Form1()
        {
            InitializeComponent();
            listUser = new List<User>();
            TbIdRead.ReadOnly = true;
        }
        private async void FetchUser()
        {
            try
            {
                listUser = await _userService.GetUser();
                dataGridView1.DataSource = listUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            try
            {
                FetchUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void BtnPost_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Name = Tb1.Text,
                    Saldo = int.Parse(Tb2.Text),
                    Hutang = int.Parse(Tb3.Text),
                    NetWorth = int.Parse(Tb4.Text),
                };

                bool isSuccess = await _userService.CrateAsync(user);

                if (isSuccess)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Tb1.Clear();
                    Tb2.Clear();
                    Tb3.Clear();
                    Tb4.Clear();
                    TbIdRead.Clear();
                    FetchUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BtnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string id = TbId.Text;
                if (listUser.Count > 0)
                {

                    dataGridView1.DataSource = null;
                }
                else
                {
                    listUser = new List<User>();
                }
                User user = await _userService.GetUserById(id);
                //dataGridView1.;
                listUser.Clear();
                listUser.Add(user);

                dataGridView1.DataSource = listUser;
                TbId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                string id = row.Cells["Id"].Value.ToString();


                TbIdRead.Text = id;


                Tb1.Text = row.Cells["Name"].Value.ToString();
                Tb2.Text = row.Cells["Saldo"].Value.ToString();
                Tb3.Text = row.Cells["Hutang"].Value.ToString();
                Tb4.Text = row.Cells["NetWorth"].Value.ToString();
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Name = Tb1.Text,
                    Saldo = int.Parse(Tb2.Text),
                    Hutang = int.Parse(Tb3.Text),
                    NetWorth = int.Parse(Tb4.Text),
                };
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bool isSuccess = await _userService.DeleteAsync(TbIdRead.Text);

                    if (isSuccess)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tb1.Clear();
                        Tb2.Clear();
                        Tb3.Clear();
                        Tb4.Clear();
                        TbIdRead.Clear();
                        FetchUser();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Name = Tb1.Text,
                    Saldo = int.Parse(Tb2.Text),
                    Hutang = int.Parse(Tb3.Text),
                    NetWorth = int.Parse(Tb4.Text),
                };
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengupdate data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bool isSuccess = await _userService.UpdateAsync(TbIdRead.Text, user);
                    if (isSuccess)
                    {
                        MessageBox.Show("Data berhasil diupdate!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Tb1.Clear();
                        Tb2.Clear();
                        Tb3.Clear();
                        Tb4.Clear();
                        TbIdRead.Clear();
                        FetchUser();
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
