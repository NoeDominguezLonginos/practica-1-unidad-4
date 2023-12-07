namespace practica_1_unidad_4
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
            groupBox1 = new GroupBox();
            txtmonto = new TextBox();
            btnAbrir = new Button();
            txtcliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnretiro = new Button();
            btndeposito = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            txtsaldo = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label5 = new Label();
            lstretiros = new Label();
            lstdepositos = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmonto);
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtcliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(132, 93);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(183, 23);
            txtmonto.TabIndex = 3;
            txtmonto.Text = "500";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(411, 48);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(116, 35);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(132, 45);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(183, 23);
            txtcliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnretiro);
            groupBox2.Controls.Add(btndeposito);
            groupBox2.Location = new Point(9, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trasacciones";
            // 
            // btnretiro
            // 
            btnretiro.Location = new Point(247, 45);
            btnretiro.Name = "btnretiro";
            btnretiro.Size = new Size(112, 34);
            btnretiro.TabIndex = 1;
            btnretiro.Text = "Retiro";
            btnretiro.UseVisualStyleBackColor = true;
            // 
            // btndeposito
            // 
            btndeposito.Location = new Point(60, 45);
            btndeposito.Name = "btndeposito";
            btndeposito.Size = new Size(120, 34);
            btndeposito.TabIndex = 0;
            btndeposito.Text = "Deposito";
            btndeposito.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(txtsaldo);
            groupBox3.Controls.Add(listBox2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lstretiros);
            groupBox3.Controls.Add(lstdepositos);
            groupBox3.Location = new Point(9, 296);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(545, 206);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // button4
            // 
            button4.Location = new Point(408, 153);
            button4.Name = "button4";
            button4.Size = new Size(90, 32);
            button4.TabIndex = 6;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtsaldo
            // 
            txtsaldo.AcceptsReturn = true;
            txtsaldo.Location = new Point(408, 108);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(90, 23);
            txtsaldo.TabIndex = 5;
            txtsaldo.TextChanged += textBox3_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "500", "10" });
            listBox2.Location = new Point(184, 61);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(128, 124);
            listBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "300", "400" });
            listBox1.Location = new Point(20, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(122, 124);
            listBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 78);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Saldo";
            // 
            // lstretiros
            // 
            lstretiros.AutoSize = true;
            lstretiros.Location = new Point(219, 31);
            lstretiros.Name = "lstretiros";
            lstretiros.Size = new Size(43, 15);
            lstretiros.TabIndex = 1;
            lstretiros.Text = "Retiros";
            lstretiros.Click += label4_Click;
            // 
            // lstdepositos
            // 
            lstdepositos.AutoSize = true;
            lstdepositos.Location = new Point(45, 31);
            lstdepositos.Name = "lstdepositos";
            lstdepositos.Size = new Size(59, 15);
            lstdepositos.TabIndex = 0;
            lstdepositos.Text = "Depositos";
            lstdepositos.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 514);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtcliente;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtmonto;
        private Button btnAbrir;
        private Button btnretiro;
        private Button btndeposito;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label5;
        private Label lstretiros;
        private Button button4;
        private TextBox txtsaldo;
        private Label lstdepositos;
    }
}