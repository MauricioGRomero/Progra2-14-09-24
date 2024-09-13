namespace Dapper_demo
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
            this.dgvObenerTodo = new System.Windows.Forms.DataGridView();
            this.BtnObtenerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObenerTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObenerTodo
            // 
            this.dgvObenerTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObenerTodo.Location = new System.Drawing.Point(12, 22);
            this.dgvObenerTodo.Name = "dgvObenerTodo";
            this.dgvObenerTodo.RowHeadersWidth = 51;
            this.dgvObenerTodo.RowTemplate.Height = 24;
            this.dgvObenerTodo.Size = new System.Drawing.Size(776, 203);
            this.dgvObenerTodo.TabIndex = 0;
            // 
            // BtnObtenerTodo
            // 
            this.BtnObtenerTodo.Location = new System.Drawing.Point(354, 308);
            this.BtnObtenerTodo.Name = "BtnObtenerTodo";
            this.BtnObtenerTodo.Size = new System.Drawing.Size(75, 23);
            this.BtnObtenerTodo.TabIndex = 1;
            this.BtnObtenerTodo.Text = "Obtener todo";
            this.BtnObtenerTodo.UseVisualStyleBackColor = true;
            this.BtnObtenerTodo.Click += new System.EventHandler(this.BtnObtenerTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnObtenerTodo);
            this.Controls.Add(this.dgvObenerTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObenerTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObenerTodo;
        private System.Windows.Forms.Button BtnObtenerTodo;
    }
}

