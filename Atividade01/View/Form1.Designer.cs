namespace Atividade01
{
    partial class Form1
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
            lblTarefa = new Label();
            lblStatus = new Label();
            lblData = new Label();
            txtTarefa = new TextBox();
            dateTarefa = new DateTimePicker();
            statusTarefa = new ComboBox();
            btnConfirm = new Button();
            dataTarefa = new DataGridView();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataTarefa).BeginInit();
            SuspendLayout();
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Font = new Font("Segoe UI", 9.75F);
            lblTarefa.Location = new Point(12, 21);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(44, 17);
            lblTarefa.TabIndex = 0;
            lblTarefa.Text = "Tarefa";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F);
            lblStatus.Location = new Point(392, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 17);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9.75F);
            lblData.Location = new Point(202, 21);
            lblData.Name = "lblData";
            lblData.Size = new Size(35, 17);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(12, 50);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(165, 23);
            txtTarefa.TabIndex = 3;
            // 
            // dateTarefa
            // 
            dateTarefa.Location = new Point(202, 51);
            dateTarefa.Name = "dateTarefa";
            dateTarefa.Size = new Size(154, 23);
            dateTarefa.TabIndex = 4;
            // 
            // statusTarefa
            // 
            statusTarefa.FormattingEnabled = true;
            statusTarefa.Items.AddRange(new object[] { "Em andamento", "Concluido", "Programado" });
            statusTarefa.Location = new Point(392, 51);
            statusTarefa.Name = "statusTarefa";
            statusTarefa.Size = new Size(121, 23);
            statusTarefa.TabIndex = 5;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(553, 50);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(106, 26);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dataTarefa
            // 
            dataTarefa.AllowUserToDeleteRows = false;
            dataTarefa.BackgroundColor = Color.White;
            dataTarefa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTarefa.Location = new Point(12, 138);
            dataTarefa.Name = "dataTarefa";
            dataTarefa.Size = new Size(774, 308);
            dataTarefa.TabIndex = 7;
            dataTarefa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(680, 51);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(106, 26);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(798, 458);
            Controls.Add(btnDeletar);
            Controls.Add(dataTarefa);
            Controls.Add(btnConfirm);
            Controls.Add(statusTarefa);
            Controls.Add(dateTarefa);
            Controls.Add(txtTarefa);
            Controls.Add(lblData);
            Controls.Add(lblStatus);
            Controls.Add(lblTarefa);
            Name = "Form1";
            Text = "Tarefas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataTarefa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarefa;
        private Label lblStatus;
        private Label lblData;
        private TextBox txtTarefa;
        private DateTimePicker dateTarefa;
        private ComboBox statusTarefa;
        private Button btnConfirm;
        private DataGridView dataTarefa;
        private Label lblTop;
        private Button btnDeletar;
    }
}
