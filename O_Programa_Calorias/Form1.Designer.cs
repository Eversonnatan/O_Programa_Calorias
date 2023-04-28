
namespace O_Programa_Calorias
{
    partial class frmPedido
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
            this.bttEnvio = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.grbLanche = new System.Windows.Forms.GroupBox();
            this.rbtXbacon = new System.Windows.Forms.RadioButton();
            this.rbtXburger = new System.Windows.Forms.RadioButton();
            this.rbtXsalada = new System.Windows.Forms.RadioButton();
            this.rbtMistoquente = new System.Windows.Forms.RadioButton();
            this.rbtHotdog = new System.Windows.Forms.RadioButton();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.rbtCerveja = new System.Windows.Forms.RadioButton();
            this.rbtRefri = new System.Windows.Forms.RadioButton();
            this.rbtSuco = new System.Windows.Forms.RadioButton();
            this.grbAcomp = new System.Windows.Forms.GroupBox();
            this.rbtSalada = new System.Windows.Forms.RadioButton();
            this.rbtMandioca = new System.Windows.Forms.RadioButton();
            this.rbtBatata = new System.Windows.Forms.RadioButton();
            this.rbtPolenta = new System.Windows.Forms.RadioButton();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblCaloria = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCaloria = new System.Windows.Forms.TextBox();
            this.rbtAgua = new System.Windows.Forms.RadioButton();
            this.rbtChopp = new System.Windows.Forms.RadioButton();
            this.rbtProvolone = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbLanche.SuspendLayout();
            this.grbBebida.SuspendLayout();
            this.grbAcomp.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttEnvio
            // 
            this.bttEnvio.Location = new System.Drawing.Point(217, 298);
            this.bttEnvio.Name = "bttEnvio";
            this.bttEnvio.Size = new System.Drawing.Size(152, 23);
            this.bttEnvio.TabIndex = 0;
            this.bttEnvio.Text = "&Enviar Pedido";
            this.bttEnvio.UseVisualStyleBackColor = true;
            this.bttEnvio.Click += new System.EventHandler(this.bttEnvio_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(645, 415);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(152, 23);
            this.bttExit.TabIndex = 1;
            this.bttExit.Text = "&Sair";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // grbLanche
            // 
            this.grbLanche.Controls.Add(this.rbtXbacon);
            this.grbLanche.Controls.Add(this.rbtXburger);
            this.grbLanche.Controls.Add(this.rbtXsalada);
            this.grbLanche.Controls.Add(this.rbtMistoquente);
            this.grbLanche.Controls.Add(this.rbtHotdog);
            this.grbLanche.Location = new System.Drawing.Point(25, 69);
            this.grbLanche.Name = "grbLanche";
            this.grbLanche.Size = new System.Drawing.Size(200, 163);
            this.grbLanche.TabIndex = 3;
            this.grbLanche.TabStop = false;
            this.grbLanche.Text = "Lanches";
            this.grbLanche.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtXbacon
            // 
            this.rbtXbacon.AutoSize = true;
            this.rbtXbacon.Location = new System.Drawing.Point(5, 120);
            this.rbtXbacon.Name = "rbtXbacon";
            this.rbtXbacon.Size = new System.Drawing.Size(66, 17);
            this.rbtXbacon.TabIndex = 7;
            this.rbtXbacon.TabStop = true;
            this.rbtXbacon.Text = "X-Bacon";
            this.rbtXbacon.UseVisualStyleBackColor = true;
            this.rbtXbacon.CheckedChanged += new System.EventHandler(this.rbtXbacon_CheckedChanged);
            // 
            // rbtXburger
            // 
            this.rbtXburger.AutoSize = true;
            this.rbtXburger.Location = new System.Drawing.Point(6, 97);
            this.rbtXburger.Name = "rbtXburger";
            this.rbtXburger.Size = new System.Drawing.Size(66, 17);
            this.rbtXburger.TabIndex = 6;
            this.rbtXburger.TabStop = true;
            this.rbtXburger.Text = "X-Burger";
            this.rbtXburger.UseVisualStyleBackColor = true;
            // 
            // rbtXsalada
            // 
            this.rbtXsalada.AutoSize = true;
            this.rbtXsalada.Location = new System.Drawing.Point(6, 74);
            this.rbtXsalada.Name = "rbtXsalada";
            this.rbtXsalada.Size = new System.Drawing.Size(68, 17);
            this.rbtXsalada.TabIndex = 5;
            this.rbtXsalada.TabStop = true;
            this.rbtXsalada.Text = "X-Salada";
            this.rbtXsalada.UseVisualStyleBackColor = true;
            // 
            // rbtMistoquente
            // 
            this.rbtMistoquente.AutoSize = true;
            this.rbtMistoquente.Location = new System.Drawing.Point(6, 51);
            this.rbtMistoquente.Name = "rbtMistoquente";
            this.rbtMistoquente.Size = new System.Drawing.Size(88, 17);
            this.rbtMistoquente.TabIndex = 4;
            this.rbtMistoquente.TabStop = true;
            this.rbtMistoquente.Text = "Misto-Quente";
            this.rbtMistoquente.UseVisualStyleBackColor = true;
            // 
            // rbtHotdog
            // 
            this.rbtHotdog.AutoSize = true;
            this.rbtHotdog.Location = new System.Drawing.Point(6, 28);
            this.rbtHotdog.Name = "rbtHotdog";
            this.rbtHotdog.Size = new System.Drawing.Size(65, 17);
            this.rbtHotdog.TabIndex = 3;
            this.rbtHotdog.TabStop = true;
            this.rbtHotdog.Text = "Hot-Dog";
            this.rbtHotdog.UseVisualStyleBackColor = true;
            // 
            // grbBebida
            // 
            this.grbBebida.Controls.Add(this.rbtChopp);
            this.grbBebida.Controls.Add(this.rbtAgua);
            this.grbBebida.Controls.Add(this.rbtCerveja);
            this.grbBebida.Controls.Add(this.rbtRefri);
            this.grbBebida.Controls.Add(this.rbtSuco);
            this.grbBebida.Location = new System.Drawing.Point(246, 69);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Size = new System.Drawing.Size(200, 163);
            this.grbBebida.TabIndex = 4;
            this.grbBebida.TabStop = false;
            this.grbBebida.Text = "Bebidas";
            // 
            // rbtCerveja
            // 
            this.rbtCerveja.AutoSize = true;
            this.rbtCerveja.Location = new System.Drawing.Point(6, 74);
            this.rbtCerveja.Name = "rbtCerveja";
            this.rbtCerveja.Size = new System.Drawing.Size(61, 17);
            this.rbtCerveja.TabIndex = 6;
            this.rbtCerveja.TabStop = true;
            this.rbtCerveja.Text = "Cerveja";
            this.rbtCerveja.UseVisualStyleBackColor = true;
            // 
            // rbtRefri
            // 
            this.rbtRefri.AutoSize = true;
            this.rbtRefri.Location = new System.Drawing.Point(6, 51);
            this.rbtRefri.Name = "rbtRefri";
            this.rbtRefri.Size = new System.Drawing.Size(83, 17);
            this.rbtRefri.TabIndex = 5;
            this.rbtRefri.TabStop = true;
            this.rbtRefri.Text = "Refrigerante";
            this.rbtRefri.UseVisualStyleBackColor = true;
            // 
            // rbtSuco
            // 
            this.rbtSuco.AutoSize = true;
            this.rbtSuco.Location = new System.Drawing.Point(6, 19);
            this.rbtSuco.Name = "rbtSuco";
            this.rbtSuco.Size = new System.Drawing.Size(50, 17);
            this.rbtSuco.TabIndex = 4;
            this.rbtSuco.TabStop = true;
            this.rbtSuco.Text = "Suco";
            this.rbtSuco.UseVisualStyleBackColor = true;
            // 
            // grbAcomp
            // 
            this.grbAcomp.Controls.Add(this.rbtProvolone);
            this.grbAcomp.Controls.Add(this.rbtSalada);
            this.grbAcomp.Controls.Add(this.rbtMandioca);
            this.grbAcomp.Controls.Add(this.rbtBatata);
            this.grbAcomp.Controls.Add(this.rbtPolenta);
            this.grbAcomp.Location = new System.Drawing.Point(495, 69);
            this.grbAcomp.Name = "grbAcomp";
            this.grbAcomp.Size = new System.Drawing.Size(200, 163);
            this.grbAcomp.TabIndex = 5;
            this.grbAcomp.TabStop = false;
            this.grbAcomp.Text = "Acompanhamentos";
            // 
            // rbtSalada
            // 
            this.rbtSalada.AutoSize = true;
            this.rbtSalada.Location = new System.Drawing.Point(6, 97);
            this.rbtSalada.Name = "rbtSalada";
            this.rbtSalada.Size = new System.Drawing.Size(58, 17);
            this.rbtSalada.TabIndex = 8;
            this.rbtSalada.TabStop = true;
            this.rbtSalada.Text = "Salada";
            this.rbtSalada.UseVisualStyleBackColor = true;
            // 
            // rbtMandioca
            // 
            this.rbtMandioca.AutoSize = true;
            this.rbtMandioca.Location = new System.Drawing.Point(6, 51);
            this.rbtMandioca.Name = "rbtMandioca";
            this.rbtMandioca.Size = new System.Drawing.Size(95, 17);
            this.rbtMandioca.TabIndex = 7;
            this.rbtMandioca.TabStop = true;
            this.rbtMandioca.Text = "Mandioca Frita";
            this.rbtMandioca.UseVisualStyleBackColor = true;
            // 
            // rbtBatata
            // 
            this.rbtBatata.AutoSize = true;
            this.rbtBatata.Location = new System.Drawing.Point(6, 28);
            this.rbtBatata.Name = "rbtBatata";
            this.rbtBatata.Size = new System.Drawing.Size(79, 17);
            this.rbtBatata.TabIndex = 6;
            this.rbtBatata.TabStop = true;
            this.rbtBatata.Text = "Batata Frita";
            this.rbtBatata.UseVisualStyleBackColor = true;
            // 
            // rbtPolenta
            // 
            this.rbtPolenta.AutoSize = true;
            this.rbtPolenta.Location = new System.Drawing.Point(6, 74);
            this.rbtPolenta.Name = "rbtPolenta";
            this.rbtPolenta.Size = new System.Drawing.Size(84, 17);
            this.rbtPolenta.TabIndex = 5;
            this.rbtPolenta.TabStop = true;
            this.rbtPolenta.Text = "Polenta Frita";
            this.rbtPolenta.UseVisualStyleBackColor = true;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 332);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(88, 13);
            this.lblPedido.TabIndex = 6;
            this.lblPedido.Text = "Pedido realizado:";
            // 
            // lblCaloria
            // 
            this.lblCaloria.AutoSize = true;
            this.lblCaloria.Location = new System.Drawing.Point(12, 382);
            this.lblCaloria.Name = "lblCaloria";
            this.lblCaloria.Size = new System.Drawing.Size(88, 13);
            this.lblCaloria.TabIndex = 7;
            this.lblCaloria.Text = "Total de calorias:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(15, 348);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(690, 20);
            this.txtPedido.TabIndex = 8;
            // 
            // txtCaloria
            // 
            this.txtCaloria.Location = new System.Drawing.Point(15, 398);
            this.txtCaloria.Name = "txtCaloria";
            this.txtCaloria.ReadOnly = true;
            this.txtCaloria.Size = new System.Drawing.Size(280, 20);
            this.txtCaloria.TabIndex = 9;
            this.txtCaloria.TextChanged += new System.EventHandler(this.txtCaloria_TextChanged);
            // 
            // rbtAgua
            // 
            this.rbtAgua.AutoSize = true;
            this.rbtAgua.Location = new System.Drawing.Point(6, 107);
            this.rbtAgua.Name = "rbtAgua";
            this.rbtAgua.Size = new System.Drawing.Size(50, 17);
            this.rbtAgua.TabIndex = 7;
            this.rbtAgua.TabStop = true;
            this.rbtAgua.Text = "Agua";
            this.rbtAgua.UseVisualStyleBackColor = true;
            // 
            // rbtChopp
            // 
            this.rbtChopp.AutoSize = true;
            this.rbtChopp.Location = new System.Drawing.Point(6, 130);
            this.rbtChopp.Name = "rbtChopp";
            this.rbtChopp.Size = new System.Drawing.Size(56, 17);
            this.rbtChopp.TabIndex = 8;
            this.rbtChopp.TabStop = true;
            this.rbtChopp.Text = "Chopp";
            this.rbtChopp.UseVisualStyleBackColor = true;
            // 
            // rbtProvolone
            // 
            this.rbtProvolone.AutoSize = true;
            this.rbtProvolone.Location = new System.Drawing.Point(6, 120);
            this.rbtProvolone.Name = "rbtProvolone";
            this.rbtProvolone.Size = new System.Drawing.Size(127, 17);
            this.rbtProvolone.TabIndex = 9;
            this.rbtProvolone.TabStop = true;
            this.rbtProvolone.Text = "Provolone a Milenesa";
            this.rbtProvolone.UseVisualStyleBackColor = true;
            this.rbtProvolone.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(380, 398);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(388, 375);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Gordometro";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCaloria);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblCaloria);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.grbAcomp);
            this.Controls.Add(this.grbBebida);
            this.Controls.Add(this.grbLanche);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttEnvio);
            this.Name = "frmPedido";
            this.Text = "O Programa Calorias";
            this.grbLanche.ResumeLayout(false);
            this.grbLanche.PerformLayout();
            this.grbBebida.ResumeLayout(false);
            this.grbBebida.PerformLayout();
            this.grbAcomp.ResumeLayout(false);
            this.grbAcomp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttEnvio;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.GroupBox grbLanche;
        private System.Windows.Forms.RadioButton rbtXburger;
        private System.Windows.Forms.RadioButton rbtXsalada;
        private System.Windows.Forms.RadioButton rbtMistoquente;
        private System.Windows.Forms.RadioButton rbtHotdog;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.RadioButton rbtCerveja;
        private System.Windows.Forms.RadioButton rbtRefri;
        private System.Windows.Forms.RadioButton rbtSuco;
        private System.Windows.Forms.GroupBox grbAcomp;
        private System.Windows.Forms.RadioButton rbtSalada;
        private System.Windows.Forms.RadioButton rbtMandioca;
        private System.Windows.Forms.RadioButton rbtBatata;
        private System.Windows.Forms.RadioButton rbtPolenta;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblCaloria;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCaloria;
        private System.Windows.Forms.RadioButton rbtXbacon;
        private System.Windows.Forms.RadioButton rbtChopp;
        private System.Windows.Forms.RadioButton rbtAgua;
        private System.Windows.Forms.RadioButton rbtProvolone;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

