﻿
namespace _2._3_AplicacionProyectoU2
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
            this.ucControlProyecto1 = new _2._3_ControlProyectoU2.ucControlProyecto();
            this.SuspendLayout();
            // 
            // ucControlProyecto1
            // 
            this.ucControlProyecto1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucControlProyecto1.Location = new System.Drawing.Point(12, 12);
            this.ucControlProyecto1.Name = "ucControlProyecto1";
            this.ucControlProyecto1.Size = new System.Drawing.Size(394, 122);
            this.ucControlProyecto1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucControlProyecto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _3_ControlProyectoU2.ucControlProyecto ucControlProyecto1;
    }
}

