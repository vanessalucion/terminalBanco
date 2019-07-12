using CORE.BUSSINES;
using CORE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalBanco
{
    public partial class TabelaCorrentista : Form
    {
        public TabelaCorrentista()
        {
            InitializeComponent();
            correntistaBindingSource.DataSource = new OnCorrentista().Lista();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new CadastroCorrentista();
            form.Novo();
            form.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var form = new CadastroCorrentista();
            form.Editar(correntistaBindingSource.Current as Correntista);
            form.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var c = correntistaBindingSource.Current as Correntista;
                new OnCorrentista().Excluir(c);
                correntistaBindingSource.RemoveCurrent();
            }
        }
    }
}
