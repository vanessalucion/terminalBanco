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
    public partial class CadastroCorrentista : Form
    {
        public EnumOperacoes op { get; set; }
        public CadastroCorrentista()
        {
            InitializeComponent();
        }
        public void Novo()
        {
            op = EnumOperacoes.Novo;
            correntistaBindingSource.AddNew();
        }

        public void Editar(Correntista c)
        {
            correntistaBindingSource.DataSource = c;
            op = EnumOperacoes.Editar;
        }




        private void Salvar()
        {
            correntistaBindingSource.EndEdit();
            var registro = correntistaBindingSource.Current as Correntista;
            try
            {
                if (op == EnumOperacoes.Novo)
                {
                    new OnCorrentista().Novo(registro);
                }
                else
                {
                    new OnCorrentista().Salvar(registro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro: " + ex.Message);
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
