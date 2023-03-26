
namespace comunicacion
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
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            this.btnConectar = new System.Windows.Forms.Button();
            this.textBoxtemp = new System.Windows.Forms.TextBox();
            this.textBoxedad = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textapelli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aGaugeTemp = new System.Windows.Forms.AGauge();
            this.textBoxdatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(511, 88);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(151, 47);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // textBoxtemp
            // 
            this.textBoxtemp.Location = new System.Drawing.Point(125, 70);
            this.textBoxtemp.Name = "textBoxtemp";
            this.textBoxtemp.Size = new System.Drawing.Size(100, 22);
            this.textBoxtemp.TabIndex = 1;
            // 
            // textBoxedad
            // 
            this.textBoxedad.Location = new System.Drawing.Point(125, 217);
            this.textBoxedad.Name = "textBoxedad";
            this.textBoxedad.Size = new System.Drawing.Size(100, 22);
            this.textBoxedad.TabIndex = 2;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(125, 113);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxnombre.TabIndex = 3;
            // 
            // textapelli
            // 
            this.textapelli.Location = new System.Drawing.Point(125, 172);
            this.textapelli.Name = "textapelli";
            this.textapelli.Size = new System.Drawing.Size(100, 22);
            this.textapelli.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "APELLIDOS";
            // 
            // aGaugeTemp
            // 
            this.aGaugeTemp.BaseArcColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aGaugeTemp.BaseArcRadius = 80;
            this.aGaugeTemp.BaseArcStart = 135;
            this.aGaugeTemp.BaseArcSweep = 270;
            this.aGaugeTemp.BaseArcWidth = 2;
            this.aGaugeTemp.Center = new System.Drawing.Point(100, 100);
            aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(0, 0);
            aGaugeLabel1.Text = "TEMP";
            this.aGaugeTemp.GaugeLabels.Add(aGaugeLabel1);
            aGaugeRange1.Color = System.Drawing.Color.Red;
            aGaugeRange1.EndValue = -20F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.Magenta;
            aGaugeRange2.EndValue = 40F;
            aGaugeRange2.InnerRadius = 70;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 60F;
            aGaugeRange3.Color = System.Drawing.Color.Empty;
            aGaugeRange3.EndValue = 0F;
            aGaugeRange3.InnerRadius = 1;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange3";
            aGaugeRange3.OuterRadius = 2;
            aGaugeRange3.StartValue = 0F;
            this.aGaugeTemp.GaugeRanges.Add(aGaugeRange1);
            this.aGaugeTemp.GaugeRanges.Add(aGaugeRange2);
            this.aGaugeTemp.GaugeRanges.Add(aGaugeRange3);
            this.aGaugeTemp.Location = new System.Drawing.Point(463, 170);
            this.aGaugeTemp.MaxValue = 60F;
            this.aGaugeTemp.MinValue = -20F;
            this.aGaugeTemp.Name = "aGaugeTemp";
            this.aGaugeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGaugeTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeTemp.NeedleRadius = 60;
            this.aGaugeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeTemp.NeedleWidth = 2;
            this.aGaugeTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesInterInnerRadius = 73;
            this.aGaugeTemp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesInterWidth = 1;
            this.aGaugeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorStepValue = 10F;
            this.aGaugeTemp.ScaleLinesMajorWidth = 2;
            this.aGaugeTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeTemp.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorTicks = 9;
            this.aGaugeTemp.ScaleLinesMinorWidth = 1;
            this.aGaugeTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleNumbersFormat = null;
            this.aGaugeTemp.ScaleNumbersRadius = 95;
            this.aGaugeTemp.ScaleNumbersRotation = 0;
            this.aGaugeTemp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTemp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTemp.Size = new System.Drawing.Size(220, 180);
            this.aGaugeTemp.TabIndex = 9;
            this.aGaugeTemp.Text = "aGauge1";
            this.aGaugeTemp.Value = 0F;
            this.aGaugeTemp.ValueInRangeChanged += new System.EventHandler<System.Windows.Forms.ValueInRangeChangedEventArgs>(this.aGauge1_ValueInRangeChanged);
            // 
            // textBoxdatos
            // 
            this.textBoxdatos.Location = new System.Drawing.Point(125, 286);
            this.textBoxdatos.Name = "textBoxdatos";
            this.textBoxdatos.Size = new System.Drawing.Size(100, 22);
            this.textBoxdatos.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxdatos);
            this.Controls.Add(this.aGaugeTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textapelli);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxedad);
            this.Controls.Add(this.textBoxtemp);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox textBoxtemp;
        private System.Windows.Forms.TextBox textBoxedad;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textapelli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.AGauge aGaugeTemp;
        private System.Windows.Forms.TextBox textBoxdatos;
        private System.Windows.Forms.Label label6;
    }
}

