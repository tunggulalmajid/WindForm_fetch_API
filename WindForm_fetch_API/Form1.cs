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
        }

        private async void Fetch_Click(object sender, EventArgs e)
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

                if (isSuccess) {
                    Tb1.Clear();
                    Tb2.Clear();
                    Tb3.Clear();
                    Tb4.Clear();
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
    }
}
