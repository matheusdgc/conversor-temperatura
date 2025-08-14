namespace APP_CONVERSOR
{
    partial class FORM_CONVERSOR
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CONVERSOR));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbK = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.GBDestino = new System.Windows.Forms.GroupBox();
            this.RbToK = new System.Windows.Forms.RadioButton();
            this.RbToF = new System.Windows.Forms.RadioButton();
            this.RbToC = new System.Windows.Forms.RadioButton();
            this.GBResposta = new System.Windows.Forms.GroupBox();
            this.BTNConverter = new System.Windows.Forms.Button();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.LbResposta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GBDestino.SuspendLayout();
            this.GBResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbK);
            this.groupBox1.Controls.Add(this.RbF);
            this.groupBox1.Controls.Add(this.RbC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONVERTER DE:";
            // 
            // RbK
            // 
            this.RbK.AutoSize = true;
            this.RbK.Location = new System.Drawing.Point(6, 144);
            this.RbK.Name = "RbK";
            this.RbK.Size = new System.Drawing.Size(84, 25);
            this.RbK.TabIndex = 2;
            this.RbK.TabStop = true;
            this.RbK.Text = "KELVIN";
            this.RbK.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Location = new System.Drawing.Point(6, 96);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(126, 25);
            this.RbF.TabIndex = 1;
            this.RbF.TabStop = true;
            this.RbF.Text = "FAHRENHEIT";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Location = new System.Drawing.Point(6, 42);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(90, 25);
            this.RbC.TabIndex = 0;
            this.RbC.TabStop = true;
            this.RbC.Text = "CELSIUS";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // GBDestino
            // 
            this.GBDestino.Controls.Add(this.RbToK);
            this.GBDestino.Controls.Add(this.RbToF);
            this.GBDestino.Controls.Add(this.RbToC);
            this.GBDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDestino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBDestino.Location = new System.Drawing.Point(204, 12);
            this.GBDestino.Name = "GBDestino";
            this.GBDestino.Size = new System.Drawing.Size(170, 210);
            this.GBDestino.TabIndex = 1;
            this.GBDestino.TabStop = false;
            this.GBDestino.Text = "CONVERTER PARA:";
            // 
            // RbToK
            // 
            this.RbToK.AutoSize = true;
            this.RbToK.Location = new System.Drawing.Point(20, 144);
            this.RbToK.Name = "RbToK";
            this.RbToK.Size = new System.Drawing.Size(84, 25);
            this.RbToK.TabIndex = 3;
            this.RbToK.TabStop = true;
            this.RbToK.Text = "KELVIN";
            this.RbToK.UseVisualStyleBackColor = true;
            // 
            // RbToF
            // 
            this.RbToF.AutoSize = true;
            this.RbToF.Location = new System.Drawing.Point(20, 96);
            this.RbToF.Name = "RbToF";
            this.RbToF.Size = new System.Drawing.Size(126, 25);
            this.RbToF.TabIndex = 3;
            this.RbToF.TabStop = true;
            this.RbToF.Text = "FAHRENHEIT";
            this.RbToF.UseVisualStyleBackColor = true;
            // 
            // RbToC
            // 
            this.RbToC.AutoSize = true;
            this.RbToC.Location = new System.Drawing.Point(20, 42);
            this.RbToC.Name = "RbToC";
            this.RbToC.Size = new System.Drawing.Size(90, 25);
            this.RbToC.TabIndex = 3;
            this.RbToC.TabStop = true;
            this.RbToC.Text = "CELSIUS";
            this.RbToC.UseVisualStyleBackColor = true;
            // 
            // GBResposta
            // 
            this.GBResposta.Controls.Add(this.LbResposta);
            this.GBResposta.Controls.Add(this.BTNConverter);
            this.GBResposta.Controls.Add(this.TxtTemperatura);
            this.GBResposta.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBResposta.Location = new System.Drawing.Point(12, 239);
            this.GBResposta.Name = "GBResposta";
            this.GBResposta.Size = new System.Drawing.Size(362, 199);
            this.GBResposta.TabIndex = 3;
            this.GBResposta.TabStop = false;
            this.GBResposta.Text = "TEMPERATURA:";
            // 
            // BTNConverter
            // 
            this.BTNConverter.BackColor = System.Drawing.Color.Coral;
            this.BTNConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConverter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNConverter.Image = ((System.Drawing.Image)(resources.GetObject("BTNConverter.Image")));
            this.BTNConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNConverter.Location = new System.Drawing.Point(58, 72);
            this.BTNConverter.Name = "BTNConverter";
            this.BTNConverter.Size = new System.Drawing.Size(244, 62);
            this.BTNConverter.TabIndex = 1;
            this.BTNConverter.Text = "CONVERTER";
            this.BTNConverter.UseVisualStyleBackColor = false;
            this.BTNConverter.Click += new System.EventHandler(this.BTNConverter_Click);
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtTemperatura.Location = new System.Drawing.Point(58, 27);
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(244, 28);
            this.TxtTemperatura.TabIndex = 0;
            this.TxtTemperatura.Text = "0";
            this.TxtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbResposta
            // 
            this.LbResposta.ForeColor = System.Drawing.Color.Black;
            this.LbResposta.Location = new System.Drawing.Point(58, 151);
            this.LbResposta.Name = "LbResposta";
            this.LbResposta.Size = new System.Drawing.Size(244, 28);
            this.LbResposta.TabIndex = 2;
            this.LbResposta.Text = "Resposta";
            this.LbResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FORM_CONVERSOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.GBResposta);
            this.Controls.Add(this.GBDestino);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FORM_CONVERSOR";
            this.Text = "CONVERSOR DE TEMPERATURA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBDestino.ResumeLayout(false);
            this.GBDestino.PerformLayout();
            this.GBResposta.ResumeLayout(false);
            this.GBResposta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBDestino;
        private System.Windows.Forms.RadioButton RbK;
        private System.Windows.Forms.RadioButton RbF;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.RadioButton RbToF;
        private System.Windows.Forms.RadioButton RbToC;
        private System.Windows.Forms.RadioButton RbToK;
        private System.Windows.Forms.GroupBox GBResposta;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.Button BTNConverter;
        private System.Windows.Forms.TextBox LbResposta;
    }
}

