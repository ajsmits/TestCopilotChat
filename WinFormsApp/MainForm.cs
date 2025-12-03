using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly TransactionRepository _repository = new TransactionRepository();
        private BindingList<Transaction> _bindingList = new BindingList<Transaction>();
        private BindingSource _bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();

            _bindingList = new BindingList<Transaction>(_repository.GetTransactions().ToList());
            _bindingSource.DataSource = _bindingList;
            dataGridView1.DataSource = _bindingSource;

            txtSearch.TextChanged += TxtSearch_TextChanged;
            txtDescSearch.TextChanged += TxtDescSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void TxtDescSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var general = txtSearch.Text.Trim();
            var desc = txtDescSearch.Text.Trim();

            var items = _repository.GetTransactions();

            if (!string.IsNullOrEmpty(desc))
            {
                items = items.Where(t => t.Description.Contains(desc, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(general))
            {
                items = items.Where(t => t.Description.Contains(general, StringComparison.OrdinalIgnoreCase)
                                         || t.Date.ToString("d").Contains(general, StringComparison.OrdinalIgnoreCase)
                                         || t.Amount.ToString().Contains(general));
            }

            _bindingSource.DataSource = items.ToList();
        }
    }
}
