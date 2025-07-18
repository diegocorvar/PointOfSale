namespace PuntoDeVenta
{
    partial class MainFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalesView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.pnlTicketName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBarCode = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSaleOptions = new System.Windows.Forms.Panel();
            this.btnMany = new System.Windows.Forms.Button();
            this.btnComunArt = new System.Windows.Forms.Button();
            this.tabControlTickets = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInflows = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlTicketName.SuspendLayout();
            this.pnlBarCode.SuspendLayout();
            this.pnlSaleOptions.SuspendLayout();
            this.tabControlTickets.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.panelPurchase.SuspendLayout();
            this.panelAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1322, 53);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIEGO - PUNTO DE VENTA";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(13)))), ((int)(((byte)(75)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(1247, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSalesView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnSalesView
            // 
            this.btnSalesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalesView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalesView.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesView.Location = new System.Drawing.Point(0, 0);
            this.btnSalesView.Name = "btnSalesView";
            this.btnSalesView.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSalesView.Size = new System.Drawing.Size(121, 36);
            this.btnSalesView.TabIndex = 0;
            this.btnSalesView.Text = "F1 - VENTAS";
            this.btnSalesView.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Source Code Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(121, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "F2 - INVENTARIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.panelPurchase);
            this.pnlSales.Controls.Add(this.pnlTime);
            this.pnlSales.Controls.Add(this.tabControlTickets);
            this.pnlSales.Controls.Add(this.pnlSaleOptions);
            this.pnlSales.Controls.Add(this.pnlBarCode);
            this.pnlSales.Controls.Add(this.pnlTicketName);
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(0, 89);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(1322, 702);
            this.pnlSales.TabIndex = 2;
            // 
            // pnlTicketName
            // 
            this.pnlTicketName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTicketName.Controls.Add(this.label2);
            this.pnlTicketName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTicketName.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketName.Name = "pnlTicketName";
            this.pnlTicketName.Size = new System.Drawing.Size(1322, 36);
            this.pnlTicketName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "VENTAS - TICKET #";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlBarCode
            // 
            this.pnlBarCode.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBarCode.Controls.Add(this.button2);
            this.pnlBarCode.Controls.Add(this.textBox1);
            this.pnlBarCode.Controls.Add(this.label3);
            this.pnlBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarCode.Location = new System.Drawing.Point(0, 36);
            this.pnlBarCode.Name = "pnlBarCode";
            this.pnlBarCode.Size = new System.Drawing.Size(1322, 63);
            this.pnlBarCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código del producto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 39);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(630, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "ENTER - Agregar producto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlSaleOptions
            // 
            this.pnlSaleOptions.BackColor = System.Drawing.Color.Silver;
            this.pnlSaleOptions.Controls.Add(this.btnDel);
            this.pnlSaleOptions.Controls.Add(this.button3);
            this.pnlSaleOptions.Controls.Add(this.btnInflows);
            this.pnlSaleOptions.Controls.Add(this.btnSearch);
            this.pnlSaleOptions.Controls.Add(this.btnComunArt);
            this.pnlSaleOptions.Controls.Add(this.btnMany);
            this.pnlSaleOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSaleOptions.Location = new System.Drawing.Point(0, 99);
            this.pnlSaleOptions.Name = "pnlSaleOptions";
            this.pnlSaleOptions.Size = new System.Drawing.Size(1322, 38);
            this.pnlSaleOptions.TabIndex = 2;
            // 
            // btnMany
            // 
            this.btnMany.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMany.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMany.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMany.Location = new System.Drawing.Point(0, 0);
            this.btnMany.Name = "btnMany";
            this.btnMany.Size = new System.Drawing.Size(130, 38);
            this.btnMany.TabIndex = 0;
            this.btnMany.Text = "INS - Varios";
            this.btnMany.UseVisualStyleBackColor = false;
            // 
            // btnComunArt
            // 
            this.btnComunArt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComunArt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComunArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComunArt.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunArt.Location = new System.Drawing.Point(130, 0);
            this.btnComunArt.Name = "btnComunArt";
            this.btnComunArt.Size = new System.Drawing.Size(148, 38);
            this.btnComunArt.TabIndex = 1;
            this.btnComunArt.Text = "Ctrl + P - Art común";
            this.btnComunArt.UseVisualStyleBackColor = false;
            // 
            // tabControlTickets
            // 
            this.tabControlTickets.Controls.Add(this.tabPage1);
            this.tabControlTickets.Controls.Add(this.tabPage2);
            this.tabControlTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTickets.Font = new System.Drawing.Font("Klein", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTickets.Location = new System.Drawing.Point(0, 137);
            this.tabControlTickets.Name = "tabControlTickets";
            this.tabControlTickets.SelectedIndex = 0;
            this.tabControlTickets.Size = new System.Drawing.Size(1322, 565);
            this.tabControlTickets.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1314, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ticket 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1314, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ticket 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.pnlTime.Controls.Add(this.label4);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTime.Location = new System.Drawing.Point(0, 673);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(1322, 29);
            this.pnlTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1084, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "30/03/2005 12:12 pm";
            // 
            // panelPurchase
            // 
            this.panelPurchase.Controls.Add(this.button5);
            this.panelPurchase.Controls.Add(this.panelAmount);
            this.panelPurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPurchase.Location = new System.Drawing.Point(0, 573);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(1322, 100);
            this.panelPurchase.TabIndex = 5;
            // 
            // panelAmount
            // 
            this.panelAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panelAmount.Controls.Add(this.lblAmount);
            this.panelAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAmount.Location = new System.Drawing.Point(1062, 0);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(260, 100);
            this.panelAmount.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Klein", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAmount.Location = new System.Drawing.Point(15, 16);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(233, 64);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "$9999.5";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("Klein", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(894, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 100);
            this.button5.TabIndex = 1;
            this.button5.Text = "F12 - Cobrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(278, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "F10 - Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnInflows
            // 
            this.btnInflows.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInflows.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInflows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInflows.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInflows.Location = new System.Drawing.Point(381, 0);
            this.btnInflows.Name = "btnInflows";
            this.btnInflows.Size = new System.Drawing.Size(103, 38);
            this.btnInflows.TabIndex = 3;
            this.btnInflows.Text = "F9 - Entradas";
            this.btnInflows.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(484, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "F8 - Salidas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Klein", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(587, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 38);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "DEL - Borrar Art";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 791);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlTicketName.ResumeLayout(false);
            this.pnlTicketName.PerformLayout();
            this.pnlBarCode.ResumeLayout(false);
            this.pnlBarCode.PerformLayout();
            this.pnlSaleOptions.ResumeLayout(false);
            this.tabControlTickets.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.panelPurchase.ResumeLayout(false);
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalesView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlTicketName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBarCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlSaleOptions;
        private System.Windows.Forms.Button btnComunArt;
        private System.Windows.Forms.Button btnMany;
        private System.Windows.Forms.TabControl tabControlTickets;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInflows;
    }
}

