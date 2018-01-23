using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        private IList<Person> Persons { get; set; }
        private BindingSource bindingSource;
        private int selectedId { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true)
            {
                checkBox1.BackColor = Color.Khaki;
            }
            else
                checkBox1.BackColor = Color.MediumSeaGreen;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked != true)
            {
                checkBox2.BackColor = Color.Khaki;
            }
            else
                checkBox2.BackColor = Color.Red;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Veritabanı bağlantısı ve select işlemi
            SqlConnection connection = new SqlConnection("Server=.; Database=IsGüvenligi;Trusted_Connection= True;");
            SqlCommand command = new SqlCommand("SELECT*FROM Persons", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); // veri tabanından veri getirmek için kullanılır
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            selectedId = 0;
            //kaynak bağlama ile listemizle rehber giridini bağlıyoruz
            Persons = new List<Person>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var person = new Person();
                person.Id = Convert.ToInt32(dr["Id"]);
                person.FullName = dr["FullName"].ToString();
                person.Secure = dr["Secure"].ToString();
                person.InSecure = dr["InSecure"].ToString();
                person.Positive = dr["Positive"].ToString();
                person.Negative = dr["Negative"].ToString();
                Persons.Add(person);
            }
            bindingSource = new BindingSource();
            bindingSource.DataSource = Persons;
            dgvIsGuvenligiFormu.DataSource = bindingSource;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person;
            if (selectedId > 0)
            {
                person = Persons.FirstOrDefault(c => c.Id == selectedId);
            }

            else
            {
                person = new Person();
                //contact id yi belirle (çünkü id şu an otomatik artan sayı değil)
                if (Persons.Count() > 0)
                {
                    person.Id = Persons.Max(c => c.Id) + 1;
                }
                else
                {
                    person.Id = 1;
                }
            }
            //formdaki değerleri contact'a ata
            person.FullName = txtFullName.Text;
            person.Secure = txtSecure.Text;
            person.InSecure = txtInSecure.Text;
            person.Positive = txtPositive.Text;
            person.Negative = txtNegative.Text;
            //contact nesnesini listeye ekle

            if (selectedId <= 0)
            {
                Persons.Add(person);
            }
            //rehber grid'ini güncelle
            PersonsUpdate();
            Clean();
        }
        public void PersonsUpdate()
        {
            bindingSource.ResetBindings(false);
        }

        private void dgvIsGuvenligiFormu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIsGuvenligiFormu.Rows.Count > 1 && e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvIsGuvenligiFormu.Rows[e.RowIndex].Cells[0].Value);
                var person = Persons.FirstOrDefault(c => c.Id == selectedId);
                txtFullName.Text = person.FullName;
                txtSecure.Text = person.Secure;
                txtInSecure.Text = person.InSecure;
                txtPositive.Text = person.Positive;
                txtNegative.Text = person.Negative;

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            selectedId = 0;
            txtFullName.Text = "";
            txtSecure.Text = "";
            txtInSecure.Text = "";
            txtPositive.Text = "";
            txtNegative.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId > 0)
            {
                Persons.Remove(Persons.FirstOrDefault(c => c.Id == selectedId));
                PersonsUpdate();
                Clean();
            }
        }
    }
}
    

