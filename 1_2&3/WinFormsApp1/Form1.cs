using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Shop shop = new Shop();
        Playlist playlist = new Playlist();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void CreateProduct(object sender, EventArgs e)
        {
            // ��� ������� �� ������ ������� ������ ������ � ��������� �������
            shop.CreateProduct(textBox1.Text, numericUpDown1.Value, Convert.ToInt32(numericUpDown2.Value));
            shop.GridRefresh(dataGridView1);
        }

        public void ProfitUpdate()
        {
            // ���������� ������ � ��������

            label1.Text = "����� ������� : " + shop.Profit;
        }

        private void SellProducts(object sender, EventArgs e)
        {
            // ������� ��� ������� �������� ������ ����� ������ �� �������� ��������

            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string name = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();

                    int count = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"������� ���������� ������������ ������ {name}"));

                    Product product = shop.FindByName(name);
                    shop.Sell(product, count);

                    shop.Profit += Convert.ToDouble(Convert.ToInt32(product.Price) * count);

                }
                shop.GridRefresh(dataGridView1);

                ProfitUpdate();
            }
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            // ������� ��� �������� �������� ������ ����� ������ �� �������� ��������

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                string name = dataGridView1.Rows[index].Cells[0].Value.ToString();

                Product product = shop.FindByName(name);

                shop.RemoveProduct(product);

                shop.GridRefresh(dataGridView1);
            }
        }

        // ������� ��� ���������� ������
        private void RefreshSong(Song song)
        {
            label5.Text = $"�������� : {song.title}\n����� : {song.author}\n���� : {song.filename}";

        }
        // ���������� �����
        private void AddSong(object sender, EventArgs e)
        {
            if (!(textBox2.Text == "") && !(textBox3.Text == "") && !(textBox4.Text == ""))
            {
                playlist.AddSong(textBox2.Text, textBox3.Text, textBox4.Text);
                Song song = playlist.NextSong();
                RefreshSong(song);
            }


        }
        // ������� ������ �����
        private void ClearSongs(object sender, EventArgs e)
        {
            playlist.ClearSongs();
            label5.Text = "������ �� �������\n������� ������ :(";
        }
        // �������� ���������� �����
        private void PreviousSong(object sender, EventArgs e)
        {
            if (playlist.GetListCount() > 0)
            {
                Song song = playlist.PreviousSong();
                RefreshSong(song);
            }
            else
            {
                MessageBox.Show("� ��� ���� �����");
            }
        }
        // �������� ��������� �����
        private void NextSong(object sender, EventArgs e)
        {
            if (playlist.GetListCount() > 0)
            {
                Song song = playlist.NextSong();
                RefreshSong(song);
            }
            else
            {
                MessageBox.Show("� ��� ���� �����");
            }


        }
        // ������� ������� �����
        private void DeleteSong(object sender, EventArgs e)
        {
            if (playlist.GetListCount() > 0)
            {
                playlist.RemoveSong();
                if (playlist.GetListCount() > 0)
                {
                    Song song = playlist.NextSong();
                    RefreshSong(song);
                }
                else
                {
                    label5.Text = "������ �� �������\n������� ������ :(";
                }
            }
            else
            {
                MessageBox.Show("� ��� ���� �����");
            }
        }
        // �������� ����� �� �������
        private void SelectSong(object sender, EventArgs e)
        {
            if (playlist.GetListCount() > 0)
            {
                Song song = playlist.SelectSong(Convert.ToInt32(numericUpDown3.Value));
                RefreshSong(song);
            }
            else
            {
                MessageBox.Show("� ��� ���� �����");
            }
        }
        // ������� ����� �� ���������� ������ �� �������
        private void DeleteSongObject(object sender, EventArgs e)
        {
            if (!(textBox5.Text == "") && !(textBox6.Text == "") && !(textBox7.Text == ""))
            {
                playlist.RemoveSong(textBox5.Text, textBox6.Text, textBox7.Text);
                if (playlist.GetListCount() > 0)
                {
                    Song song = playlist.NextSong();
                    RefreshSong(song);
                }
                else
                {
                    label5.Text = "������ �� �������\n������� ������ :(";
                }
            }
        }
    }
}
