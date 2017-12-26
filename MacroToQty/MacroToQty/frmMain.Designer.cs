namespace MacroToQty
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flpGroceryItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddGroceryItem = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblUserCalories = new System.Windows.Forms.Label();
            this.lblUserProtein = new System.Windows.Forms.Label();
            this.lblUserCarbs = new System.Windows.Forms.Label();
            this.lblUserFat = new System.Windows.Forms.Label();
            this.numCalories = new System.Windows.Forms.NumericUpDown();
            this.numProteins = new System.Windows.Forms.NumericUpDown();
            this.numCarbs = new System.Windows.Forms.NumericUpDown();
            this.numFat = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblTotalProtein = new System.Windows.Forms.Label();
            this.lblTotalCarb = new System.Windows.Forms.Label();
            this.lblTotalFat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alimentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macronutrientCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGroceryItems
            // 
            this.flpGroceryItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGroceryItems.AutoScroll = true;
            this.flpGroceryItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGroceryItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGroceryItems.Location = new System.Drawing.Point(12, 98);
            this.flpGroceryItems.Name = "flpGroceryItems";
            this.flpGroceryItems.Size = new System.Drawing.Size(923, 383);
            this.flpGroceryItems.TabIndex = 0;
            this.flpGroceryItems.WrapContents = false;
            // 
            // btnAddGroceryItem
            // 
            this.btnAddGroceryItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGroceryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroceryItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroceryItem.Image")));
            this.btnAddGroceryItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGroceryItem.Location = new System.Drawing.Point(12, 65);
            this.btnAddGroceryItem.Name = "btnAddGroceryItem";
            this.btnAddGroceryItem.Size = new System.Drawing.Size(87, 27);
            this.btnAddGroceryItem.TabIndex = 1;
            this.btnAddGroceryItem.Text = "   Ajouter";
            this.btnAddGroceryItem.UseVisualStyleBackColor = true;
            this.btnAddGroceryItem.Click += new System.EventHandler(this.btnAddGroceryItem_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(520, 484);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblCalorie
            // 
            this.lblCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorie.Location = new System.Drawing.Point(589, 77);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(71, 18);
            this.lblCalorie.TabIndex = 3;
            this.lblCalorie.Text = "Calories";
            // 
            // lblProtein
            // 
            this.lblProtein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProtein.Location = new System.Drawing.Point(674, 77);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(80, 18);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Protéines";
            // 
            // lblCarbs
            // 
            this.lblCarbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCarbs.Location = new System.Drawing.Point(767, 77);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(74, 18);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Glucides";
            // 
            // lblFat
            // 
            this.lblFat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFat.Location = new System.Drawing.Point(862, 77);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(61, 18);
            this.lblFat.TabIndex = 6;
            this.lblFat.Text = "Lipides";
            this.lblFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCalories
            // 
            this.lblUserCalories.AutoSize = true;
            this.lblUserCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCalories.Location = new System.Drawing.Point(12, 33);
            this.lblUserCalories.Name = "lblUserCalories";
            this.lblUserCalories.Size = new System.Drawing.Size(63, 18);
            this.lblUserCalories.TabIndex = 7;
            this.lblUserCalories.Text = "Calories";
            // 
            // lblUserProtein
            // 
            this.lblUserProtein.AutoSize = true;
            this.lblUserProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserProtein.Location = new System.Drawing.Point(188, 33);
            this.lblUserProtein.Name = "lblUserProtein";
            this.lblUserProtein.Size = new System.Drawing.Size(71, 18);
            this.lblUserProtein.TabIndex = 8;
            this.lblUserProtein.Text = "Protéines";
            // 
            // lblUserCarbs
            // 
            this.lblUserCarbs.AutoSize = true;
            this.lblUserCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCarbs.Location = new System.Drawing.Point(371, 33);
            this.lblUserCarbs.Name = "lblUserCarbs";
            this.lblUserCarbs.Size = new System.Drawing.Size(66, 18);
            this.lblUserCarbs.TabIndex = 9;
            this.lblUserCarbs.Text = "Glucides";
            // 
            // lblUserFat
            // 
            this.lblUserFat.AutoSize = true;
            this.lblUserFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserFat.Location = new System.Drawing.Point(551, 33);
            this.lblUserFat.Name = "lblUserFat";
            this.lblUserFat.Size = new System.Drawing.Size(54, 18);
            this.lblUserFat.TabIndex = 10;
            this.lblUserFat.Text = "Lipides";
            // 
            // numCalories
            // 
            this.numCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalories.Location = new System.Drawing.Point(81, 31);
            this.numCalories.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCalories.Name = "numCalories";
            this.numCalories.Size = new System.Drawing.Size(60, 21);
            this.numCalories.TabIndex = 12;
            this.numCalories.ValueChanged += new System.EventHandler(this.numCalories_ValueChanged);
            // 
            // numProteins
            // 
            this.numProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProteins.Location = new System.Drawing.Point(265, 31);
            this.numProteins.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numProteins.Name = "numProteins";
            this.numProteins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numProteins.Size = new System.Drawing.Size(60, 21);
            this.numProteins.TabIndex = 13;
            this.numProteins.ValueChanged += new System.EventHandler(this.numProteins_ValueChanged);
            // 
            // numCarbs
            // 
            this.numCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCarbs.Location = new System.Drawing.Point(443, 31);
            this.numCarbs.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCarbs.Name = "numCarbs";
            this.numCarbs.Size = new System.Drawing.Size(60, 21);
            this.numCarbs.TabIndex = 14;
            this.numCarbs.ValueChanged += new System.EventHandler(this.numCarbs_ValueChanged);
            // 
            // numFat
            // 
            this.numFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFat.Location = new System.Drawing.Point(610, 31);
            this.numFat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFat.Name = "numFat";
            this.numFat.Size = new System.Drawing.Size(60, 21);
            this.numFat.TabIndex = 15;
            this.numFat.ValueChanged += new System.EventHandler(this.numFat_ValueChanged);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalCalories.Location = new System.Drawing.Point(593, 487);
            this.lblTotalCalories.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(60, 18);
            this.lblTotalCalories.TabIndex = 16;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProtein
            // 
            this.lblTotalProtein.AutoSize = true;
            this.lblTotalProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalProtein.Location = new System.Drawing.Point(683, 487);
            this.lblTotalProtein.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblTotalProtein.Name = "lblTotalProtein";
            this.lblTotalProtein.Size = new System.Drawing.Size(60, 18);
            this.lblTotalProtein.TabIndex = 17;
            this.lblTotalProtein.Text = "0";
            this.lblTotalProtein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCarb
            // 
            this.lblTotalCarb.AutoSize = true;
            this.lblTotalCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalCarb.Location = new System.Drawing.Point(773, 487);
            this.lblTotalCarb.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblTotalCarb.Name = "lblTotalCarb";
            this.lblTotalCarb.Size = new System.Drawing.Size(60, 18);
            this.lblTotalCarb.TabIndex = 18;
            this.lblTotalCarb.Text = "0";
            this.lblTotalCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFat
            // 
            this.lblTotalFat.AutoSize = true;
            this.lblTotalFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalFat.Location = new System.Drawing.Point(863, 487);
            this.lblTotalFat.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(60, 18);
            this.lblTotalFat.TabIndex = 19;
            this.lblTotalFat.Text = "0";
            this.lblTotalFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentsToolStripMenuItem,
            this.macronutrientCalculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alimentsToolStripMenuItem
            // 
            this.alimentsToolStripMenuItem.Name = "alimentsToolStripMenuItem";
            this.alimentsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.alimentsToolStripMenuItem.Text = "Aliments";
            this.alimentsToolStripMenuItem.Click += new System.EventHandler(this.alimentsToolStripMenuItem_Click);
            // 
            // macronutrientCalculatorToolStripMenuItem
            // 
            this.macronutrientCalculatorToolStripMenuItem.Name = "macronutrientCalculatorToolStripMenuItem";
            this.macronutrientCalculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.macronutrientCalculatorToolStripMenuItem.Text = "Macronutrient Calculator";
            this.macronutrientCalculatorToolStripMenuItem.Click += new System.EventHandler(this.macronutrientCalculatorToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(947, 517);
            this.Controls.Add(this.lblTotalFat);
            this.Controls.Add(this.lblTotalCarb);
            this.Controls.Add(this.lblTotalProtein);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.numFat);
            this.Controls.Add(this.numCarbs);
            this.Controls.Add(this.numProteins);
            this.Controls.Add(this.numCalories);
            this.Controls.Add(this.lblUserFat);
            this.Controls.Add(this.lblUserCarbs);
            this.Controls.Add(this.lblUserProtein);
            this.Controls.Add(this.lblUserCalories);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAddGroceryItem);
            this.Controls.Add(this.flpGroceryItems);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro To Quantity";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGroceryItems;
        private System.Windows.Forms.Button btnAddGroceryItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblUserCalories;
        private System.Windows.Forms.Label lblUserProtein;
        private System.Windows.Forms.Label lblUserCarbs;
        private System.Windows.Forms.Label lblUserFat;
        private System.Windows.Forms.NumericUpDown numCalories;
        private System.Windows.Forms.NumericUpDown numProteins;
        private System.Windows.Forms.NumericUpDown numCarbs;
        private System.Windows.Forms.NumericUpDown numFat;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblTotalProtein;
        private System.Windows.Forms.Label lblTotalCarb;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alimentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macronutrientCalculatorToolStripMenuItem;
    }
}

