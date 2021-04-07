
namespace Projeto_Final
{
    partial class Form1
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
            this.MSmenu = new System.Windows.Forms.MenuStrip();
            this.novaTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSmenu
            // 
            this.MSmenu.BackColor = System.Drawing.Color.MintCream;
            this.MSmenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MSmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaTarefaToolStripMenuItem});
            this.MSmenu.Location = new System.Drawing.Point(0, 0);
            this.MSmenu.Name = "MSmenu";
            this.MSmenu.Size = new System.Drawing.Size(800, 24);
            this.MSmenu.TabIndex = 0;
            this.MSmenu.Text = "menuStrip1";
            // 
            // novaTarefaToolStripMenuItem
            // 
            this.novaTarefaToolStripMenuItem.Name = "novaTarefaToolStripMenuItem";
            this.novaTarefaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.novaTarefaToolStripMenuItem.Text = "Nova Tarefa";
            this.novaTarefaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.novaTarefaToolStripMenuItem.Click += new System.EventHandler(this.novaTarefaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MSmenu);
            this.MainMenuStrip = this.MSmenu;
            this.Name = "Form1";
            this.Text = "Página Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MSmenu.ResumeLayout(false);
            this.MSmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSmenu;
        private System.Windows.Forms.ToolStripMenuItem novaTarefaToolStripMenuItem;
    }
}

