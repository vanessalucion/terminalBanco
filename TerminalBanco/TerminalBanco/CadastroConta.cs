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
    public partial class Cadastro_de_Conta : Form        
    {
        public EnumOperacoes op { get; set; }
        public Cadastro_de_Conta()
        {
            InitializeComponent();
        }

        public void Novo()
        {
            op = EnumOperacoes.Novo;
            contaBindingSource.AddNew();
        }

        public void Editar(Conta c)
        {
            contaBindingSource.DataSource = c;
            op = EnumOperacoes.Editar;
        }

        private void Salvar()
        {
            contaBindingSource.EndEdit();
            var registro = contaBindingSource.Current as Conta;
            try
            {
                if(op == EnumOperacoes.Novo)
                {
                    new OnConta().Novo(registro);
                }
                else
                {
                    new OnConta().Salvar(registro);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao salvar registro: " + ex.Message);
            }
            Close();
        }

        private void Cadastro_de_Conta_Load(object sender, EventArgs e)
        {          
        
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
