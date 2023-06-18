using Samjee.Models;
using Samjee.Utilities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samjee
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Just Give Number
        private void txt_MLListLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (int.TryParse(txt_MLListLevel.Text + e.KeyChar, out int number))
            {
                if (number < 1 || number > 10)
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MLExpenseValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MLIncomeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CalcListLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CalcExpenseValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CalcIncomeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Return Lists Incomes & Expenses Count
        private async Task<int> ReturnListIncomesCountAsync(int listID)
        {
            using (var db = new AppDatabase())
            {
                await Task.Delay(5);
                return await db.Incomes.Where(i => i.IN_Transaction == listID).CountAsync();
            }
        }
        private async Task<int> ReturnListExpensesCountAsync(int listID)
        {
            using (var db = new AppDatabase())
            {
                await Task.Delay(5);
                return await db.Expenses.Where(x => x.EX_Transaction == listID).CountAsync();
            }
        }
        #endregion

        #region Machine Learning

        #region Load Lists
        private async void LoadMLList()
        {
            using (var db = new AppDatabase())
            {
                var transactions = await db.Transactions.Where(c => c.TR_Type == 0).ToListAsync();
                if (transactions.Count > 0)
                {
                    dgv_MLTransactionsList.Rows.Clear();

                    for (int i = 0; i < transactions.Count; i++)
                    {
                        await Task.Delay(5);

                        dgv_MLTransactionsList.Rows.Add();

                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListID"].Value = transactions[i].TR_ID;
                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListName"].Value = transactions[i].TR_Title;
                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListCreateDate"].Value = transactions[i].TR_CreateDate.ToPersianDate();
                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListLevel"].Value = transactions[i].TR_Level;
                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListIncomesNumber"].Value = await ReturnListIncomesCountAsync(transactions[i].TR_ID);
                        dgv_MLTransactionsList.Rows[i].Cells["col_MLListExpenseNumbers"].Value = await ReturnListExpensesCountAsync(transactions[i].TR_ID);
                    }
                }
            }
        }
        #endregion

        #region Load Lists In Combobox

        private async void LoadIncomeAndExpenseMLLists()
        {
            using (var db = new AppDatabase())
            {
                var t = await db.Transactions.Where(c => c.TR_Type == 0).ToListAsync();
                if (t.Count() > 0)
                {
                    await Task.Delay(5);
                    cmb_MLIncomeList.DataSource = t;
                    cmb_MLIncomeList.DisplayMember = "TR_Title";
                    cmb_MLIncomeList.ValueMember = "TR_ID";

                    await Task.Delay(5);
                    cmb_MLExpenseList.DataSource = t;
                    cmb_MLExpenseList.DisplayMember = "TR_Title";
                    cmb_MLExpenseList.ValueMember = "TR_ID";
                }
            }
        }

        #endregion

        #region Load Incomes & Expenses

        private async void LoadMLIncomes()
        {
            using (var db = new AppDatabase())
            {
                var incomes = await db.Incomes.Where(t => t.Transaction.TR_Type == 0).ToListAsync();

                if (incomes.Count() > 0)
                {
                    dgv_MLIncomes.Rows.Clear();

                    for (int i = 0; i < incomes.Count(); i++)
                    {
                        await Task.Delay(5);
                        dgv_MLIncomes.Rows.Add();
                        var incomeTransaction = incomes[i].IN_Transaction;

                        dgv_MLIncomes.Rows[i].Cells["col_MLIncomeID"].Value = incomes[i].IN_ID;
                        dgv_MLIncomes.Rows[i].Cells["col_MLIncomeName"].Value = incomes[i].IN_Title;
                        dgv_MLIncomes.Rows[i].Cells["col_MLIncomeValue"].Value = incomes[i].IN_Value;
                        dgv_MLIncomes.Rows[i].Cells["col_MLIncomeCreateDate"].Value = incomes[i].IN_CreateDate.ToPersianDate();
                        dgv_MLIncomes.Rows[i].Cells["col_MLIncomeList"].Value = db.Transactions.SingleOrDefaultAsync(t => t.TR_ID == incomeTransaction).Result.TR_Title;
                    }
                }
            }
        }

        private async void LoadMLExpenses()
        {
            using (var db = new AppDatabase())
            {
                var expenses = await db.Expenses.Where(t => t.Transaction.TR_Type == 0).ToListAsync();
                if (expenses.Count() > 0)
                {
                    dgv_MLExpenses.Rows.Clear();

                    for (int i = 0; i < expenses.Count(); i++)
                    {
                        await Task.Delay(5);
                        dgv_MLExpenses.Rows.Add();
                        var expenseTransaction = expenses[i].EX_Transaction;

                        dgv_MLExpenses.Rows[i].Cells["col_MLExpenseID"].Value = expenses[i].EX_ID;
                        dgv_MLExpenses.Rows[i].Cells["col_MLExpenseName"].Value = expenses[i].EX_Title;
                        dgv_MLExpenses.Rows[i].Cells["col_MLExpenseValue"].Value = expenses[i].EX_Value;
                        dgv_MLExpenses.Rows[i].Cells["col_MLExpenseCreateDate"].Value = expenses[i].EX_CreateDate.ToPersianDate();
                        dgv_MLExpenses.Rows[i].Cells["col_MLExpenseList"].Value = db.Transactions.FirstOrDefaultAsync(b => b.TR_ID == expenseTransaction).Result.TR_Title;
                    }
                }
            }
        }
        #endregion

        private async void tab_MachineLearning_Enter(object sender, System.EventArgs e)
        {
            await Task.Delay(5);
            LoadMLList();
            LoadIncomeAndExpenseMLLists();
            LoadMLIncomes();
            LoadMLExpenses();
        }

        private async void btn_MLSaveList_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MLListName.Text.Trim()) || string.IsNullOrEmpty(txt_MLListLevel.Text.Trim()))
            {
                MessageBox.Show("فیلد نام و سطح نمی‌تواند خالی باشد!", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDatabase())
            {
                var list = new Transaction()
                {
                    TR_Title = txt_MLListName.Text.Trim(),
                    TR_Level = byte.Parse(txt_MLListLevel.Text.Trim()),
                    TR_CreateDate = DateTime.Now,
                    TR_Type = 0
                };

                db.Transactions.Add(list);
                await db.SaveChangesAsync();

                await Task.Delay(5);
                LoadMLList();
                LoadIncomeAndExpenseMLLists();
            }
        }

        private async void btn_MLSaveIncome_Click(object sender, EventArgs e)
        {
            Transaction l = (Transaction)cmb_MLIncomeList.SelectedItem;
            if (string.IsNullOrEmpty(txt_MLIncomeTitle.Text.Trim()) || string.IsNullOrEmpty(txt_MLIncomeValue.Text.Trim()) || l.TR_ID <= 0)
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کرده مجدد امتحان کنید.", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDatabase())
                {
                    await Task.Delay(5);
                    db.Incomes.Add(new Income()
                    {
                        IN_Title = txt_MLIncomeTitle.Text.Trim(),
                        IN_Value = long.Parse(txt_MLIncomeValue.Text.Trim()),
                        IN_CreateDate = DateTime.Now,
                        IN_Transaction = l.TR_ID
                    });
                    await db.SaveChangesAsync();

                    LoadMLList();
                    LoadMLIncomes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ذخیره اطلاعات خطایی رخ داد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btn_MLSaveExpense_Click(object sender, EventArgs e)
        {
            Transaction l = (Transaction)cmb_MLExpenseList.SelectedItem;
            if (string.IsNullOrEmpty(txt_MLExpenseTitle.Text.Trim()) || string.IsNullOrEmpty(txt_MLExpenseValue.Text.Trim()) || l.TR_ID <= 0)
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کرده مجدد امتحان کنید.", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDatabase())
                {
                    await Task.Delay(5);
                    db.Expenses.Add(new Expense()
                    {
                        EX_Title = txt_MLExpenseTitle.Text.Trim(),
                        EX_Value = long.Parse(txt_MLExpenseValue.Text.Trim()),
                        EX_CreateDate = DateTime.Now,
                        EX_Transaction = l.TR_ID
                    });
                    await db.SaveChangesAsync();

                    LoadMLList();
                    LoadMLExpenses();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ذخیره اطلاعات خطایی رخ داد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        #region Calculating

        #region Load Lists
        private async void LoadCLList()
        {
            using (var db = new AppDatabase())
            {
                var transactions = await db.Transactions.Where(c => c.TR_Type == 1).ToListAsync();
                if (transactions.Count > 0)
                {
                    dgv_CalcTransactions.Rows.Clear();

                    for (int i = 0; i < transactions.Count; i++)
                    {
                        await Task.Delay(5);

                        dgv_CalcTransactions.Rows.Add();

                        dgv_CalcTransactions.Rows[i].Cells["col_CLListID"].Value = transactions[i].TR_ID;
                        dgv_CalcTransactions.Rows[i].Cells["col_CLListName"].Value = transactions[i].TR_Title;
                        dgv_CalcTransactions.Rows[i].Cells["col_CLListCreateDate"].Value = transactions[i].TR_CreateDate.ToPersianDate();
                        dgv_CalcTransactions.Rows[i].Cells["col_CLListLevel"].Value = (transactions[i].TR_Level != null ? transactions[i].TR_Level : null);
                        dgv_CalcTransactions.Rows[i].Cells["col_CLListIncomeNumbers"].Value = await ReturnListIncomesCountAsync(transactions[i].TR_ID);
                        dgv_CalcTransactions.Rows[i].Cells["col_CLListExpenseNumbers"].Value = await ReturnListExpensesCountAsync(transactions[i].TR_ID);
                    }
                }
            }
        }
        #endregion

        #region Load Lists In Combobox

        private async void LoadIncomeAndExpenseCLLists()
        {
            using (var db = new AppDatabase())
            {
                var t = await db.Transactions.Where(c => c.TR_Type == 1).ToListAsync();
                if (t.Count() > 0)
                {
                    await Task.Delay(5);
                    cmb_CalcIncomeList.DataSource = t;
                    cmb_CalcIncomeList.DisplayMember = "TR_Title";
                    cmb_CalcIncomeList.ValueMember = "TR_ID";

                    await Task.Delay(5);
                    cmb_CalcExpenseList.DataSource = t;
                    cmb_CalcExpenseList.DisplayMember = "TR_Title";
                    cmb_CalcExpenseList.ValueMember = "TR_ID";
                }
            }
        }

        #endregion

        #region Load Incomes & Expenses

        private async void LoadCLIncomes()
        {
            using (var db = new AppDatabase())
            {
                var incomes = await db.Incomes.Where(t => t.Transaction.TR_Type == 1).ToListAsync();

                if (incomes.Count() > 0)
                {
                    dgv_CalcIncomes.Rows.Clear();

                    for (int i = 0; i < incomes.Count(); i++)
                    {
                        await Task.Delay(5);
                        dgv_CalcIncomes.Rows.Add();
                        var incomeTransaction = incomes[i].IN_Transaction;

                        dgv_CalcIncomes.Rows[i].Cells["col_CLIncomeID"].Value = incomes[i].IN_ID;
                        dgv_CalcIncomes.Rows[i].Cells["col_CLIncomeTitle"].Value = incomes[i].IN_Title;
                        dgv_CalcIncomes.Rows[i].Cells["col_CLIncomeValue"].Value = incomes[i].IN_Value;
                        dgv_CalcIncomes.Rows[i].Cells["col_CLIncomeCreateDate"].Value = incomes[i].IN_CreateDate.ToPersianDate();
                        dgv_CalcIncomes.Rows[i].Cells["col_CLIncomeList"].Value = db.Transactions.SingleOrDefaultAsync(t => t.TR_ID == incomeTransaction).Result.TR_Title;
                    }
                }
            }
        }

        private async void LoadCLExpenses()
        {
            using (var db = new AppDatabase())
            {
                var expenses = await db.Expenses.Where(t => t.Transaction.TR_Type == 1).ToListAsync();
                if (expenses.Count() > 0)
                {
                    dgv_CalcExpenses.Rows.Clear();

                    for (int i = 0; i < expenses.Count(); i++)
                    {
                        await Task.Delay(5);
                        dgv_CalcExpenses.Rows.Add();
                        var expenseTransaction = expenses[i].EX_Transaction;

                        dgv_CalcExpenses.Rows[i].Cells["col_CLExpenseID"].Value = expenses[i].EX_ID;
                        dgv_CalcExpenses.Rows[i].Cells["col_CLExpenseTitle"].Value = expenses[i].EX_Title;
                        dgv_CalcExpenses.Rows[i].Cells["col_CLExpenseValue"].Value = expenses[i].EX_Value;
                        dgv_CalcExpenses.Rows[i].Cells["col_CLExpenseCreateDate"].Value = expenses[i].EX_CreateDate.ToPersianDate();
                        dgv_CalcExpenses.Rows[i].Cells["col_CLExpenseList"].Value = db.Transactions.FirstOrDefaultAsync(b => b.TR_ID == expenseTransaction).Result.TR_Title;
                    }
                }
            }
        }
        #endregion

        private async void tab_AICalc_Enter(object sender, EventArgs e)
        {
            await Task.Delay(5);
            LoadCLList();
            LoadIncomeAndExpenseCLLists();
            LoadCLIncomes();
            LoadCLExpenses();
        }

        private async void btn_CalcSaveList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CalcListName.Text.Trim()))
            {
                MessageBox.Show("فیلد نام نمی‌تواند خالی باشد!", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDatabase())
            {
                var list = new Transaction()
                {
                    TR_Title = txt_CalcListName.Text.Trim(),
                    TR_CreateDate = DateTime.Now,
                    TR_Type = 1
                };

                db.Transactions.Add(list);
                await db.SaveChangesAsync();

                await Task.Delay(5);
                LoadCLList();
                LoadIncomeAndExpenseCLLists();
            }
        }

        private async void btn_CalcSaveIncome_Click(object sender, EventArgs e)
        {
            Transaction l = (Transaction)cmb_CalcIncomeList.SelectedItem;
            if (string.IsNullOrEmpty(txt_CalcIncomeTitle.Text.Trim()) || string.IsNullOrEmpty(txt_CalcIncomeValue.Text.Trim()) || l.TR_ID <= 0)
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کرده مجدد امتحان کنید.", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDatabase())
                {
                    await Task.Delay(5);
                    db.Incomes.Add(new Income()
                    {
                        IN_Title = txt_CalcIncomeTitle.Text.Trim(),
                        IN_Value = long.Parse(txt_CalcIncomeValue.Text.Trim()),
                        IN_CreateDate = DateTime.Now,
                        IN_Transaction = l.TR_ID
                    });
                    await db.SaveChangesAsync();

                    LoadCLList();
                    LoadCLIncomes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ذخیره اطلاعات خطایی رخ داد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btn_CalcSaveExpense_Click(object sender, EventArgs e)
        {
            Transaction l = (Transaction)cmb_CalcExpenseList.SelectedItem;
            if (string.IsNullOrEmpty(txt_CalcExpenseTitle.Text.Trim()) || string.IsNullOrEmpty(txt_CalcExpenseValue.Text.Trim()) || l.TR_ID <= 0)
            {
                MessageBox.Show("لطفا فیلدهای خالی را بررسی کرده مجدد امتحان کنید.", "فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDatabase())
                {
                    await Task.Delay(5);
                    db.Expenses.Add(new Expense()
                    {
                        EX_Title = txt_CalcExpenseTitle.Text.Trim(),
                        EX_Value = long.Parse(txt_CalcExpenseValue.Text.Trim()),
                        EX_CreateDate = DateTime.Now,
                        EX_Transaction = l.TR_ID
                    });
                    await db.SaveChangesAsync();

                    LoadCLList();
                    LoadCLExpenses();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ذخیره اطلاعات خطایی رخ داد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion
    }
}
