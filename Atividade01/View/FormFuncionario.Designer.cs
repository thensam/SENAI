namespace Atividade01
{
    partial class FormFuncionario
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
            label1 = new Label();
            label2 = new Label();
            txtEmailF = new TextBox();
            txtNomeF = new TextBox();
            dataFuncionarios = new DataGridView();
            btnAdd = new Button();
            btnDelet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 19);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmailF
            // 
            txtEmailF.Location = new Point(256, 47);
            txtEmailF.Name = "txtEmailF";
            txtEmailF.Size = new Size(200, 23);
            txtEmailF.TabIndex = 2;
            // 
            // txtNomeF
            // 
            txtNomeF.Location = new Point(12, 48);
            txtNomeF.Name = "txtNomeF";
            txtNomeF.Size = new Size(212, 23);
            txtNomeF.TabIndex = 3;
            // 
            // dataFuncionarios
            // 
            dataFuncionarios.BackgroundColor = Color.White;
            dataFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFuncionarios.Location = new Point(12, 101);
            dataFuncionarios.Name = "dataFuncionarios";
            dataFuncionarios.Size = new Size(774, 345);
            dataFuncionarios.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(605, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADICIONAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(706, 47);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(80, 23);
            btnDelet.TabIndex = 6;
            btnDelet.Text = "DELETAR";
            btnDelet.UseVisualStyleBackColor = true;
            btnDelet.Click += btnDelet_Click;
            // 
            // FormFuncionario
            // 
            AccessibleName = "Funcionarios";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(798, 458);
            Controls.Add(btnDelet);
            Controls.Add(btnAdd);
            Controls.Add(dataFuncionarios);
            Controls.Add(txtNomeF);
            Controls.Add(txtEmailF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFuncionario";
            Text = "Funcionarios";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmailF;
        private TextBox txtNomeF;
        private DataGridView dataFuncionarios;
        private Button btnAdd;
        private Button btnDelet;
    }
}