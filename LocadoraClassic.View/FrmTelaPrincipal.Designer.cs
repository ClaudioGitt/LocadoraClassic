namespace LocadoraClassic.View
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gêneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMêsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gêneroToolStripMenuItem,
            this.FrmCategorias,
            this.filmesToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // gêneroToolStripMenuItem
            // 
            this.gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            this.gêneroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gêneroToolStripMenuItem.Text = "Gênero";
            this.gêneroToolStripMenuItem.Click += new System.EventHandler(this.gêneroToolStripMenuItem_Click);
            // 
            // FrmCategorias
            // 
            this.FrmCategorias.Name = "FrmCategorias";
            this.FrmCategorias.Size = new System.Drawing.Size(180, 22);
            this.FrmCategorias.Text = "Categorias";
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatórioDiárioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar Locação";
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaNegraToolStripMenuItem,
            this.faturamentoDoMêsToolStripMenuItem,
            this.faturamentoDoMêsToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // listaNegraToolStripMenuItem
            // 
            this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
            this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listaNegraToolStripMenuItem.Text = "Pendentes";
            // 
            // faturamentoDoMêsToolStripMenuItem
            // 
            this.faturamentoDoMêsToolStripMenuItem.Name = "faturamentoDoMêsToolStripMenuItem";
            this.faturamentoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.faturamentoDoMêsToolStripMenuItem.Text = "Faturamento do dia";
            // 
            // faturamentoDoMêsToolStripMenuItem1
            // 
            this.faturamentoDoMêsToolStripMenuItem1.Name = "faturamentoDoMêsToolStripMenuItem1";
            this.faturamentoDoMêsToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.faturamentoDoMêsToolStripMenuItem1.Text = "Faturamento do Mês";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem,
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
            // 
            // gráficoPizzaDeClientesPorEndereçoToolStripMenuItem
            // 
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Name = "gráficoPizzaDeClientesPorEndereçoToolStripMenuItem";
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Text = "Gráfico Pizza de Clientes por Endereço";
            // 
            // gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem
            // 
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Name = "gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem";
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Text = "Gráfico de Barra de Atrasados por Mês";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(892, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Locadora Classic";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrmCategorias;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gêneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMêsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gráficoPizzaDeClientesPorEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem;
    }
}

