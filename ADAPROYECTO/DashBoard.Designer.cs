namespace ADAPROYECTO
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pMenuVertical = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbarraTitulo = new System.Windows.Forms.Panel();
            this.pcCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenuVertical.SuspendLayout();
            this.pbarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenuVertical
            // 
            this.pMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pMenuVertical.Controls.Add(this.button2);
            this.pMenuVertical.Controls.Add(this.button1);
            this.pMenuVertical.Controls.Add(this.btnRegCliente);
            this.pMenuVertical.Controls.Add(this.label1);
            this.pMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pMenuVertical.Name = "pMenuVertical";
            this.pMenuVertical.Size = new System.Drawing.Size(193, 604);
            this.pMenuVertical.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(30, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ventas por Fecha";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "  Producto por Nombre";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegCliente
            // 
            this.btnRegCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegCliente.FlatAppearance.BorderSize = 0;
            this.btnRegCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegCliente.Image")));
            this.btnRegCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegCliente.Location = new System.Drawing.Point(30, 109);
            this.btnRegCliente.Name = "btnRegCliente";
            this.btnRegCliente.Size = new System.Drawing.Size(134, 47);
            this.btnRegCliente.TabIndex = 1;
            this.btnRegCliente.Text = "Lista de Productos";
            this.btnRegCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegCliente.UseVisualStyleBackColor = true;
            this.btnRegCliente.Click += new System.EventHandler(this.btnRegCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTP";
            // 
            // pbarraTitulo
            // 
            this.pbarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pbarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbarraTitulo.Controls.Add(this.pcCerrar);
            this.pbarraTitulo.Controls.Add(this.pictureBox1);
            this.pbarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbarraTitulo.Location = new System.Drawing.Point(193, 0);
            this.pbarraTitulo.Name = "pbarraTitulo";
            this.pbarraTitulo.Size = new System.Drawing.Size(1022, 50);
            this.pbarraTitulo.TabIndex = 2;
            // 
            // pcCerrar
            // 
            this.pcCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcCerrar.Image")));
            this.pcCerrar.Location = new System.Drawing.Point(1220, 8);
            this.pcCerrar.Name = "pcCerrar";
            this.pcCerrar.Size = new System.Drawing.Size(0, 35);
            this.pcCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCerrar.TabIndex = 0;
            this.pcCerrar.TabStop = false;
            this.pcCerrar.Click += new System.EventHandler(this.pcCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 604);
            this.Controls.Add(this.pbarraTitulo);
            this.Controls.Add(this.pMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.Shown += new System.EventHandler(this.DashBoard_Shown);
            this.pMenuVertical.ResumeLayout(false);
            this.pMenuVertical.PerformLayout();
            this.pbarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuVertical;
        private System.Windows.Forms.Panel pbarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcCerrar;
        private System.Windows.Forms.Button btnRegCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}