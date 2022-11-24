namespace Triorama
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.trampa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmove = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Puntuación:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(94, 58);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(36, 37);
            this.lblPuntos.TabIndex = 19;
            this.lblPuntos.Text = "0";
            // 
            // pnlJuego
            // 
            this.pnlJuego.Location = new System.Drawing.Point(230, 12);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(468, 275);
            this.pnlJuego.TabIndex = 20;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(12, 211);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(212, 35);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Reiniciar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(212, 35);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // trampa
            // 
            this.trampa.AutoSize = true;
            this.trampa.Location = new System.Drawing.Point(88, 310);
            this.trampa.Name = "trampa";
            this.trampa.Size = new System.Drawing.Size(35, 13);
            this.trampa.TabIndex = 22;
            this.trampa.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Movimientos:";
            // 
            // lblmove
            // 
            this.lblmove.AutoSize = true;
            this.lblmove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmove.Location = new System.Drawing.Point(96, 136);
            this.lblmove.Name = "lblmove";
            this.lblmove.Size = new System.Drawing.Size(27, 29);
            this.lblmove.TabIndex = 24;
            this.lblmove.Text = "0";
            // 
            // tmr
            // 
            this.tmr.Interval = 500;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 298);
            this.ControlBox = false;
            this.Controls.Add(this.lblmove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trampa);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MEMORAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label trampa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmove;
        private System.Windows.Forms.Timer tmr;
    }
}

