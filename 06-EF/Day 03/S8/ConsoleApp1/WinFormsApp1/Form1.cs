using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SchoolDBContext context = new SchoolDBContext();
        int selectedItem = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var newStudent = new Student()
            {
                Name = txt_name.Text,
                Age = int.Parse(txt_age.Text),
                Address = txt_address.Text,
            };
            context.Students.Add(newStudent);
            context.SaveChanges();
            LoadData();
            ClearTextBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var stds = context.Students.Select(s => new
            {
                s.Id,
                s.Name,
                s.Age,
                s.Address
            }).ToList();
            dataGridView1.DataSource = stds;
        }
        private void ClearTextBoxes()
        {
            txt_name.Clear();
            txt_age.Clear();
            txt_address.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var std = context.Students.FirstOrDefault(s => s.Id == selectedItem);
            if (std != null)
            {
                txt_name.Text = std.Name;
                txt_age.Text = std.Age.ToString();
                txt_address.Text = std.Address;
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var std = context.Students.FirstOrDefault(s => s.Id == selectedItem);
             std.Name = txt_name.Text;
             std.Age=int.Parse( txt_age.Text);
             std.Address = txt_address.Text;

            context.Students.Update(std);
            context.SaveChanges();
            LoadData();
            ClearTextBoxes();

        }
    }
}
