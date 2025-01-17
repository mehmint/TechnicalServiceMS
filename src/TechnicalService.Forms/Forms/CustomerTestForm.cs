using System;
using System.Linq;
using System.Windows.Forms;
using TechnicalService.Core.Entities;
using TechnicalService.Data;

namespace TechnicalService.Forms
{
    public partial class CustomerTestForm : Form
    {
        private readonly TechnicalServiceContext _context;

        public CustomerTestForm()
        {
            InitializeComponent();
            _context = new TechnicalServiceContext();
        }

        private void CustomerTestForm_Load(object sender, EventArgs e)
        {
            RefreshCustomerList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FirstName = txtCustomerName.Text,
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };

                _context.Customers.Add(customer);
                _context.SaveChanges();

                MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Clear();
                RefreshCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCustomerList()
        {
            dataGridCustomers.DataSource = _context.Customers
                .Select(c => new
                {
                    c.Id,
                    c.FirstName,
                    c.CreatedDate
                })
                .ToList();
        }
    }
}
