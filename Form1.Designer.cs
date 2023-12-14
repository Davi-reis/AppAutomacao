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
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(187, 92);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 92);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // bpBarraProgresso
            // 
            bpBarraProgresso.Location = new Point(12, 266);
            bpBarraProgresso.Name = "bpBarraProgresso";
            bpBarraProgresso.Size = new Size(537, 29);
            bpBarraProgresso.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 227);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0 %";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmConfirmacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 322);
            Controls.Add(lblTotal);
            Controls.Add(bpBarraProgresso);
            Controls.Add(btnConfirmar);
            Name = "frmConfirmacao";
            Text = "Automação Esocial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ProgressBar bpBarraProgresso;
        private Label lblTotal;
        private System.Windows.Forms.Timer timer1;
    }
}
