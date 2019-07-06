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
    public partial class FormConta : Form
    {
        public FormConta()
        {
            InitializeComponent();
            contaBindingSource.DataSource = new OnConta().Lista();
        }

        private void FormConta_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var form = new Cadastro_de_Conta();
            form.Novo();
            form.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var c = contaBindingSource.Current as Conta;
                new OnConta().Excluir(c);
                contaBindingSource.RemoveCurrent();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = new Cadastro_de_Conta();
            form.Editar(contaBindingSource.Current as Conta);
            form.ShowDialog();
        }
    }
}
