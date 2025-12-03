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
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            var term = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(term))
            {
                _bindingSource.DataSource = _repository.GetTransactions().ToList();
                return;
            }

            var filtered = _repository.GetTransactions()
                .Where(t => t.Description.Contains(term, StringComparison.OrdinalIgnoreCase)
                            || t.Date.ToString("d").Contains(term, StringComparison.OrdinalIgnoreCase)
                            || t.Amount.ToString().Contains(term))
                .ToList();

            _bindingSource.DataSource = filtered;
        }
    }
}
