using System.Drawing;
using System.Windows.Forms;

namespace AppAutomacao
{
    partial class frmConfirmacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnConfirmar = new Button();
            bpBarraProgresso = new ProgressBar();
            lblTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDatainicial = new Label();
            dateTimePickerInicial = new DateTimePicker();
            label1 = new Label();
            dateTimePickerFinal = new DateTimePicker();
            cboListaSolicitacao = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(54, 252);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(177, 92);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // bpBarraProgresso
            // 
            bpBarraProgresso.Location = new Point(0, 375);
            bpBarraProgresso.Name = "bpBarraProgresso";
            bpBarraProgresso.Size = new Size(714, 29);
            bpBarraProgresso.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(0, 352);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0 %";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblDatainicial
            // 
            lblDatainicial.AutoSize = true;
            lblDatainicial.Location = new Point(37, 107);
            lblDatainicial.Name = "lblDatainicial";
            lblDatainicial.Size = new Size(91, 20);
            lblDatainicial.TabIndex = 3;
            lblDatainicial.Text = "Data Inicial: ";
            // 
            // dateTimePickerInicial
            // 
            dateTimePickerInicial.CustomFormat = "";
            dateTimePickerInicial.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicial.Location = new Point(196, 102);
            dateTimePickerInicial.Name = "dateTimePickerInicial";
            dateTimePickerInicial.Size = new Size(125, 27);
            dateTimePickerInicial.TabIndex = 4;
            dateTimePickerInicial.ValueChanged += dateTimePickerInicial_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 111);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "Data Final:  ";
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinal.Location = new Point(553, 104);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(125, 27);
            dateTimePickerFinal.TabIndex = 6;
            dateTimePickerFinal.ValueChanged += dateTimePickerFinal_ValueChanged;
            // 
            // cboListaSolicitacao
            // 
            cboListaSolicitacao.FormattingEnabled = true;
            cboListaSolicitacao.Items.AddRange(new object[] { "Todos os eventos entegues em um determinado periodo", "Todos os eventos de um determinado trabalhador", "Todos os eventos enviados por aplicação web", "Tabela de estacionamentos, Obras ou Unidades de Órgãos Publicos", "Tabela de Rubricas", "Tabela de lotações tributarias", "Tabela de processos Administrativos/judicias", "Tabela de operadores portuarios" });
            cboListaSolicitacao.Location = new Point(196, 49);
            cboListaSolicitacao.Name = "cboListaSolicitacao";
            cboListaSolicitacao.Size = new Size(482, 28);
            cboListaSolicitacao.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 57);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 8;
            label2.Text = "Tipo de solicitação: ";
            // 
            // frmConfirmacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 404);
            Controls.Add(label2);
            Controls.Add(cboListaSolicitacao);
            Controls.Add(dateTimePickerFinal);
            Controls.Add(label1);
            Controls.Add(dateTimePickerInicial);
            Controls.Add(lblDatainicial);
            Controls.Add(lblTotal);
            Controls.Add(bpBarraProgresso);
            Controls.Add(btnConfirmar);
            Name = "frmConfirmacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Automação Esocial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ProgressBar bpBarraProgresso;
        private Label lblTotal;
        private System.Windows.Forms.Timer timer1;
        private Label lblDatainicial;
        private DateTimePicker dateTimePickerInicial;
        private Label label1;
        private DateTimePicker dateTimePickerFinal;
        private ComboBox cboListaSolicitacao;
        private Label label2;
    }
}
