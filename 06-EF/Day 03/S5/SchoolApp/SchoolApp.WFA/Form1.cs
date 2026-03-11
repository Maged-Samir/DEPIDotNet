using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;

namespace SchoolApp.WFA
{
    public partial class Form1 : Form
    {
        SchoolDBContext context = new SchoolDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
              Name = txt_name.Text,
              Age =int.Parse(txt_age.Text),
              Address = txt_address.Text,
            };
            context.Students.Add(s);
            context.SaveChanges();
            LoadData();
            ClearBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var students = context.Students.Include(s => s.Department).Select(s => new { s.Id, s.Name, s.Address, s.Age }).ToList();
            dataGridView1.DataSource = students;
        }
        private void ClearBoxes()
        {
            txt_name.Clear();
            txt_age.Clear();
            txt_address.Clear();
        }
    }
}
