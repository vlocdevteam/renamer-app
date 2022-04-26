namespace RenamerApp
{
    partial class RenamerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenamerApp));
            this.btnRenomear = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenomear
            // 
            resources.ApplyResources(this.btnRenomear, "btnRenomear");
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // RenamerApp
            // 
            this.AcceptButton = this.btnRenomear;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRenomear);
            this.KeyPreview = true;
            this.Name = "RenamerApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.Button btnFechar;
    }
}

