using Microsoft.EntityFrameworkCore;

namespace Phonebook
{
    public partial class Form1 : Form
    {
     
    private readonly IPersonDataSource _personDataSource; 

        public Form1(IPersonDataSource personDataSource)
        {
            InitializeComponent();
            this.Text = "Assignment 5b"; 
            _personDataSource = new PersonContextDataSource();
            LoadPeople();
            personBindingSource.DataSource = _personDataSource.GetPeople();
        }

        private void LoadPeople()
        {
            var bindingList = _personDataSource.GetPeople();
            personBindingSource.DataSource = bindingList;
            dataGridView1.DataSource = personBindingSource; 
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var context = new PersonContext())
            {
                foreach (var person in personBindingSource.List)
                {
                    context.People.Add((Person)person);
                }
                context.SaveChanges();
            }
        }

    }
}
    

