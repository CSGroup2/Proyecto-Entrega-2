
namespace Visual
{
    partial class Frm_Asignacion_Registrar
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
            this.dgvPeticion = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_conductor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.btnConductor = new FontAwesome.Sharp.IconButton();
            this.btnAmbulancia = new FontAwesome.Sharp.IconButton();
            this.btnAsignar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmb_Restantes = new System.Windows.Forms.Label();
            this.dgvAmb_Cond = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeticion
            // 
            this.dgvPeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeticion.Location = new System.Drawing.Point(32, 27);
            this.dgvPeticion.Name = "dgvPeticion";
            this.dgvPeticion.Size = new System.Drawing.Size(587, 128);
            this.dgvPeticion.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(110, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conductor:";
            // 
            // lbl_conductor
            // 
            this.lbl_conductor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_conductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_conductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_conductor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_conductor.Location = new System.Drawing.Point(228, 180);
            this.lbl_conductor.Name = "lbl_conductor";
            this.lbl_conductor.Size = new System.Drawing.Size(194, 26);
            this.lbl_conductor.TabIndex = 16;
            this.lbl_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(110, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ambulancia:";
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Placa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Placa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Placa.Location = new System.Drawing.Point(228, 224);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(194, 26);
            this.lbl_Placa.TabIndex = 16;
            this.lbl_Placa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConductor
            // 
            this.btnConductor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConductor.FlatAppearance.BorderSize = 0;
            this.btnConductor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConductor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnConductor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConductor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnConductor.IconSize = 40;
            this.btnConductor.Location = new System.Drawing.Point(439, 171);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConductor.Size = new System.Drawing.Size(141, 41);
            this.btnConductor.TabIndex = 17;
            this.btnConductor.Text = "Elegir";
            this.btnConductor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConductor.UseVisualStyleBackColor = true;
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAmbulancia.FlatAppearance.BorderSize = 0;
            this.btnAmbulancia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAmbulancia.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.btnAmbulancia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAmbulancia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAmbulancia.IconSize = 40;
            this.btnAmbulancia.Location = new System.Drawing.Point(439, 218);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAmbulancia.Size = new System.Drawing.Size(141, 41);
            this.btnAmbulancia.TabIndex = 17;
            this.btnAmbulancia.Text = "Elegir";
            this.btnAmbulancia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAmbulancia.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAsignar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAsignar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAsignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignar.IconSize = 40;
            this.btnAsignar.Location = new System.Drawing.Point(370, 505);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignar.Size = new System.Drawing.Size(170, 41);
            this.btnAsignar.TabIndex = 17;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(110, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ambulancias Restantes:";
            // 
            // lblAmb_Restantes
            // 
            this.lblAmb_Restantes.BackColor = System.Drawing.Color.Transparent;
            this.lblAmb_Restantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmb_Restantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAmb_Restantes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmb_Restantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAmb_Restantes.Location = new System.Drawing.Point(297, 268);
            this.lblAmb_Restantes.Name = "lblAmb_Restantes";
            this.lblAmb_Restantes.Size = new System.Drawing.Size(46, 26);
            this.lblAmb_Restantes.TabIndex = 16;
            this.lblAmb_Restantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAmb_Cond
            // 
            this.dgvAmb_Cond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmb_Cond.Location = new System.Drawing.Point(32, 316);
            this.dgvAmb_Cond.Name = "dgvAmb_Cond";
            this.dgvAmb_Cond.Size = new System.Drawing.Size(587, 171);
            this.dgvAmb_Cond.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 40;
            this.btnCancelar.Location = new System.Drawing.Point(104, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(170, 41);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Asignacion_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources._9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(662, 576);
            this.Controls.Add(this.dgvAmb_Cond);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnAmbulancia);
            this.Controls.Add(this.btnConductor);
            this.Controls.Add(this.lblAmb_Restantes);
            this.Controls.Add(this.lbl_Placa);
            this.Controls.Add(this.lbl_conductor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPeticion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Asignacion_Registrar";
            this.Text = "Frm_Asignacion_Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeticion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_conductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Placa;
        private FontAwesome.Sharp.IconButton btnConductor;
        private FontAwesome.Sharp.IconButton btnAmbulancia;
        private FontAwesome.Sharp.IconButton btnAsignar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmb_Restantes;
        private System.Windows.Forms.DataGridView dgvAmb_Cond;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}