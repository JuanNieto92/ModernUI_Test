namespace ModernUI_Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInfoSistema = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.dropDownMenu1 = new ModernUI_Test.Clases.DropDownMenu(this.components);
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reenviarMensajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownMenu2 = new ModernUI_Test.Clases.DropDownMenu(this.components);
            this.etiquetadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.dropDownMenu1.SuspendLayout();
            this.dropDownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMenu.Controls.Add(this.btnGestion);
            this.panelMenu.Controls.Add(this.btnSolicitudes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(213, 542);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnInfoSistema);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 467);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 75);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnInfoSistema
            // 
            this.btnInfoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoSistema.Location = new System.Drawing.Point(3, 3);
            this.btnInfoSistema.Name = "btnInfoSistema";
            this.btnInfoSistema.Size = new System.Drawing.Size(65, 65);
            this.btnInfoSistema.TabIndex = 3;
            this.btnInfoSistema.Text = "Info del sistema";
            this.btnInfoSistema.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(74, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Manual";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(145, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGestion
            // 
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestion.Location = new System.Drawing.Point(0, 125);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(213, 50);
            this.btnGestion.TabIndex = 2;
            this.btnGestion.Text = "Gestión de muestra";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSolicitudes.Location = new System.Drawing.Point(0, 75);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(213, 50);
            this.btnSolicitudes.TabIndex = 1;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            this.btnSolicitudes.Click += new System.EventHandler(this.btn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(213, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // dropDownMenu1
            // 
            this.dropDownMenu1.IsMainMenu = false;
            this.dropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesToolStripMenuItem,
            this.reenviarMensajeToolStripMenuItem});
            this.dropDownMenu1.MenuItemHeight = 25;
            this.dropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropDownMenu1.Name = "dropDownMenu1";
            this.dropDownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropDownMenu1.Size = new System.Drawing.Size(167, 48);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // reenviarMensajeToolStripMenuItem
            // 
            this.reenviarMensajeToolStripMenuItem.Name = "reenviarMensajeToolStripMenuItem";
            this.reenviarMensajeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reenviarMensajeToolStripMenuItem.Text = "Reenviar Mensaje";
            // 
            // dropDownMenu2
            // 
            this.dropDownMenu2.IsMainMenu = false;
            this.dropDownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetadoToolStripMenuItem,
            this.recepciónToolStripMenuItem});
            this.dropDownMenu2.MenuItemHeight = 25;
            this.dropDownMenu2.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropDownMenu2.Name = "dropDownMenu2";
            this.dropDownMenu2.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropDownMenu2.Size = new System.Drawing.Size(132, 48);
            // 
            // etiquetadoToolStripMenuItem
            // 
            this.etiquetadoToolStripMenuItem.Name = "etiquetadoToolStripMenuItem";
            this.etiquetadoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.etiquetadoToolStripMenuItem.Text = "Etiquetado";
            // 
            // recepciónToolStripMenuItem
            // 
            this.recepciónToolStripMenuItem.Name = "recepciónToolStripMenuItem";
            this.recepciónToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.recepciónToolStripMenuItem.Text = "Recepción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.dropDownMenu1.ResumeLayout(false);
            this.dropDownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInfoSistema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Panel panelLogo;
        private Clases.DropDownMenu dropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reenviarMensajeToolStripMenuItem;
        private Clases.DropDownMenu dropDownMenu2;
        private System.Windows.Forms.ToolStripMenuItem etiquetadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepciónToolStripMenuItem;
    }
}

