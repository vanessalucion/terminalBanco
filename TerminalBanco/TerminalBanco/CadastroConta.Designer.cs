namespace TerminalBanco
{
    partial class Cadastro_de_Conta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label correntistaIdLabel;
            System.Windows.Forms.Label dataAberturaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label limiteCreditoLabel;
            System.Windows.Forms.Label saldoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Conta));
            this.contaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.correntistaIdTextBox = new System.Windows.Forms.TextBox();
            this.dataAberturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.limiteCreditoTextBox = new System.Windows.Forms.TextBox();
            this.saldoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            correntistaIdLabel = new System.Windows.Forms.Label();
            dataAberturaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            limiteCreditoLabel = new System.Windows.Forms.Label();
            saldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingNavigator)).BeginInit();
            this.contaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // correntistaIdLabel
            // 
            correntistaIdLabel.AutoSize = true;
            correntistaIdLabel.Location = new System.Drawing.Point(9, 132);
            correntistaIdLabel.Name = "correntistaIdLabel";
            correntistaIdLabel.Size = new System.Drawing.Size(72, 13);
            correntistaIdLabel.TabIndex = 1;
            correntistaIdLabel.Text = "Correntista Id:";
            // 
            // dataAberturaLabel
            // 
            dataAberturaLabel.AutoSize = true;
            dataAberturaLabel.Location = new System.Drawing.Point(5, 93);
            dataAberturaLabel.Name = "dataAberturaLabel";
            dataAberturaLabel.Size = new System.Drawing.Size(76, 13);
            dataAberturaLabel.TabIndex = 3;
            dataAberturaLabel.Text = "Data Abertura:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(62, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // limiteCreditoLabel
            // 
            limiteCreditoLabel.AutoSize = true;
            limiteCreditoLabel.Location = new System.Drawing.Point(8, 178);
            limiteCreditoLabel.Name = "limiteCreditoLabel";
            limiteCreditoLabel.Size = new System.Drawing.Size(73, 13);
            limiteCreditoLabel.TabIndex = 7;
            limiteCreditoLabel.Text = "Limite Credito:";
            // 
            // saldoLabel
            // 
            saldoLabel.AutoSize = true;
            saldoLabel.Location = new System.Drawing.Point(44, 220);
            saldoLabel.Name = "saldoLabel";
            saldoLabel.Size = new System.Drawing.Size(37, 13);
            saldoLabel.TabIndex = 9;
            saldoLabel.Text = "Saldo:";
            // 
            // contaBindingNavigator
            // 
            this.contaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contaBindingNavigator.BindingSource = this.contaBindingSource;
            this.contaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contaBindingNavigatorSaveItem});
            this.contaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contaBindingNavigator.Name = "contaBindingNavigator";
            this.contaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contaBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.contaBindingNavigator.TabIndex = 0;
            this.contaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // contaBindingNavigatorSaveItem
            // 
            this.contaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contaBindingNavigatorSaveItem.Enabled = false;
            this.contaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contaBindingNavigatorSaveItem.Image")));
            this.contaBindingNavigatorSaveItem.Name = "contaBindingNavigatorSaveItem";
            this.contaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contaBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // correntistaIdTextBox
            // 
            this.correntistaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaBindingSource, "CorrentistaId", true));
            this.correntistaIdTextBox.Location = new System.Drawing.Point(87, 129);
            this.correntistaIdTextBox.Name = "correntistaIdTextBox";
            this.correntistaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.correntistaIdTextBox.TabIndex = 2;
            // 
            // dataAberturaDateTimePicker
            // 
            this.dataAberturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contaBindingSource, "DataAbertura", true));
            this.dataAberturaDateTimePicker.Location = new System.Drawing.Point(87, 89);
            this.dataAberturaDateTimePicker.Name = "dataAberturaDateTimePicker";
            this.dataAberturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataAberturaDateTimePicker.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(87, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // limiteCreditoTextBox
            // 
            this.limiteCreditoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaBindingSource, "LimiteCredito", true));
            this.limiteCreditoTextBox.Location = new System.Drawing.Point(87, 175);
            this.limiteCreditoTextBox.Name = "limiteCreditoTextBox";
            this.limiteCreditoTextBox.Size = new System.Drawing.Size(100, 20);
            this.limiteCreditoTextBox.TabIndex = 8;
            // 
            // saldoTextBox
            // 
            this.saldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaBindingSource, "Saldo", true));
            this.saldoTextBox.Location = new System.Drawing.Point(87, 217);
            this.saldoTextBox.Name = "saldoTextBox";
            this.saldoTextBox.Size = new System.Drawing.Size(100, 20);
            this.saldoTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataSource = typeof(CORE.DAL.Conta);
            // 
            // Cadastro_de_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(saldoLabel);
            this.Controls.Add(this.saldoTextBox);
            this.Controls.Add(limiteCreditoLabel);
            this.Controls.Add(this.limiteCreditoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dataAberturaLabel);
            this.Controls.Add(this.dataAberturaDateTimePicker);
            this.Controls.Add(correntistaIdLabel);
            this.Controls.Add(this.correntistaIdTextBox);
            this.Controls.Add(this.contaBindingNavigator);
            this.Name = "Cadastro_de_Conta";
            this.Text = "Cadastro_de_Conta";
            this.Load += new System.EventHandler(this.Cadastro_de_Conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingNavigator)).EndInit();
            this.contaBindingNavigator.ResumeLayout(false);
            this.contaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contaBindingSource;
        private System.Windows.Forms.BindingNavigator contaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox correntistaIdTextBox;
        private System.Windows.Forms.DateTimePicker dataAberturaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox limiteCreditoTextBox;
        private System.Windows.Forms.TextBox saldoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}