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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.alimentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macronutrientCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.numMult = new System.Windows.Forms.NumericUpDown();
            this.lblMult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMult)).BeginInit();
            this.SuspendLayout();
            // 
            // flpGroceryItems
            // 
            this.flpGroceryItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGroceryItems.AutoScroll = true;
            this.flpGroceryItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGroceryItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGroceryItems.Location = new System.Drawing.Point(16, 126);
            this.flpGroceryItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpGroceryItems.Name = "flpGroceryItems";
            this.flpGroceryItems.Size = new System.Drawing.Size(1068, 471);
            this.flpGroceryItems.TabIndex = 0;
            this.flpGroceryItems.WrapContents = false;
            // 
            // btnAddGroceryItem
            // 
            this.btnAddGroceryItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGroceryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroceryItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroceryItem.Image")));
            this.btnAddGroceryItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGroceryItem.Location = new System.Drawing.Point(16, 85);
            this.btnAddGroceryItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGroceryItem.Name = "btnAddGroceryItem";
            this.btnAddGroceryItem.Size = new System.Drawing.Size(109, 33);
            this.btnAddGroceryItem.TabIndex = 1;
            this.btnAddGroceryItem.Text = "    Ajouter";
            this.btnAddGroceryItem.UseVisualStyleBackColor = true;
            this.btnAddGroceryItem.Click += new System.EventHandler(this.btnAddGroceryItem_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(526, 601);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblCalorie
            // 
            this.lblCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorie.Location = new System.Drawing.Point(623, 100);
            this.lblCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(86, 24);
            this.lblCalorie.TabIndex = 3;
            this.lblCalorie.Text = "Calories";
            // 
            // lblProtein
            // 
            this.lblProtein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProtein.Location = new System.Drawing.Point(737, 100);
            this.lblProtein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(98, 24);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Protéines";
            // 
            // lblCarbs
            // 
            this.lblCarbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCarbs.Location = new System.Drawing.Point(861, 100);
            this.lblCarbs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(92, 24);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Glucides";
            // 
            // lblFat
            // 
            this.lblFat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFat.Location = new System.Drawing.Point(987, 100);
            this.lblFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(77, 24);
            this.lblFat.TabIndex = 6;
            this.lblFat.Text = "Lipides";
            this.lblFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCalories
            // 
            this.lblUserCalories.AutoSize = true;
            this.lblUserCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCalories.Location = new System.Drawing.Point(143, 44);
            this.lblUserCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCalories.Name = "lblUserCalories";
            this.lblUserCalories.Size = new System.Drawing.Size(78, 24);
            this.lblUserCalories.TabIndex = 7;
            this.lblUserCalories.Text = "Calories";
            // 
            // lblUserProtein
            // 
            this.lblUserProtein.AutoSize = true;
            this.lblUserProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserProtein.Location = new System.Drawing.Point(335, 44);
            this.lblUserProtein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserProtein.Name = "lblUserProtein";
            this.lblUserProtein.Size = new System.Drawing.Size(89, 24);
            this.lblUserProtein.TabIndex = 8;
            this.lblUserProtein.Text = "Protéines";
            // 
            // lblUserCarbs
            // 
            this.lblUserCarbs.AutoSize = true;
            this.lblUserCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCarbs.Location = new System.Drawing.Point(535, 44);
            this.lblUserCarbs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCarbs.Name = "lblUserCarbs";
            this.lblUserCarbs.Size = new System.Drawing.Size(84, 24);
            this.lblUserCarbs.TabIndex = 9;
            this.lblUserCarbs.Text = "Glucides";
            // 
            // lblUserFat
            // 
            this.lblUserFat.AutoSize = true;
            this.lblUserFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserFat.Location = new System.Drawing.Point(732, 44);
            this.lblUserFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserFat.Name = "lblUserFat";
            this.lblUserFat.Size = new System.Drawing.Size(70, 24);
            this.lblUserFat.TabIndex = 10;
            this.lblUserFat.Text = "Lipides";
            // 
            // numCalories
            // 
            this.numCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalories.Location = new System.Drawing.Point(230, 44);
            this.numCalories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCalories.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCalories.Name = "numCalories";
            this.numCalories.Size = new System.Drawing.Size(80, 24);
            this.numCalories.TabIndex = 12;
            // 
            // numProteins
            // 
            this.numProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProteins.Location = new System.Drawing.Point(432, 44);
            this.numProteins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numProteins.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numProteins.Name = "numProteins";
            this.numProteins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numProteins.Size = new System.Drawing.Size(80, 24);
            this.numProteins.TabIndex = 13;
            // 
            // numCarbs
            // 
            this.numCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCarbs.Location = new System.Drawing.Point(626, 44);
            this.numCarbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCarbs.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCarbs.Name = "numCarbs";
            this.numCarbs.Size = new System.Drawing.Size(80, 24);
            this.numCarbs.TabIndex = 14;
            // 
            // numFat
            // 
            this.numFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFat.Location = new System.Drawing.Point(806, 44);
            this.numFat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numFat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFat.Name = "numFat";
            this.numFat.Size = new System.Drawing.Size(80, 24);
            this.numFat.TabIndex = 15;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalCalories.Location = new System.Drawing.Point(627, 603);
            this.lblTotalCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCalories.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(80, 24);
            this.lblTotalCalories.TabIndex = 16;
            this.lblTotalCalories.Text = "0";
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProtein
            // 
            this.lblTotalProtein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProtein.AutoSize = true;
            this.lblTotalProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalProtein.Location = new System.Drawing.Point(747, 603);
            this.lblTotalProtein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProtein.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTotalProtein.Name = "lblTotalProtein";
            this.lblTotalProtein.Size = new System.Drawing.Size(80, 24);
            this.lblTotalProtein.TabIndex = 17;
            this.lblTotalProtein.Text = "0";
            this.lblTotalProtein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCarb
            // 
            this.lblTotalCarb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCarb.AutoSize = true;
            this.lblTotalCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalCarb.Location = new System.Drawing.Point(867, 603);
            this.lblTotalCarb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCarb.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTotalCarb.Name = "lblTotalCarb";
            this.lblTotalCarb.Size = new System.Drawing.Size(80, 24);
            this.lblTotalCarb.TabIndex = 18;
            this.lblTotalCarb.Text = "0";
            this.lblTotalCarb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFat
            // 
            this.lblTotalFat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFat.AutoSize = true;
            this.lblTotalFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalFat.Location = new System.Drawing.Point(987, 603);
            this.lblTotalFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFat.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(80, 24);
            this.lblTotalFat.TabIndex = 19;
            this.lblTotalFat.Text = "0";
            this.lblTotalFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentsToolStripMenuItem,
            this.macronutrientCalculatorToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1101, 28);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // alimentsToolStripMenuItem
            // 
            this.alimentsToolStripMenuItem.Name = "alimentsToolStripMenuItem";
            this.alimentsToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.alimentsToolStripMenuItem.Text = "Aliments";
            this.alimentsToolStripMenuItem.Click += new System.EventHandler(this.alimentsToolStripMenuItem_Click);
            // 
            // macronutrientCalculatorToolStripMenuItem
            // 
            this.macronutrientCalculatorToolStripMenuItem.Name = "macronutrientCalculatorToolStripMenuItem";
            this.macronutrientCalculatorToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.macronutrientCalculatorToolStripMenuItem.Text = "Macronutrient Calculator";
            this.macronutrientCalculatorToolStripMenuItem.Click += new System.EventHandler(this.macronutrientCalculatorToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserLaListeToolStripMenuItem,
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // réinitialiserLaListeToolStripMenuItem
            // 
            this.réinitialiserLaListeToolStripMenuItem.Name = "réinitialiserLaListeToolStripMenuItem";
            this.réinitialiserLaListeToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.réinitialiserLaListeToolStripMenuItem.Text = "Réinitialiser la liste d\'épicerie";
            this.réinitialiserLaListeToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLaListeToolStripMenuItem_Click);
            // 
            // réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem
            // 
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem.Name = "réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem";
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem.Text = "Réinitialiser les données de l\'utilisateur";
            this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(945, 44);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "    Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numMult
            // 
            this.numMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numMult.Location = new System.Drawing.Point(70, 44);
            this.numMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMult.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMult.Name = "numMult";
            this.numMult.Size = new System.Drawing.Size(51, 24);
            this.numMult.TabIndex = 23;
            this.numMult.ValueChanged += new System.EventHandler(this.numMult_ValueChanged);
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMult.Location = new System.Drawing.Point(16, 44);
            this.lblMult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(50, 24);
            this.lblMult.TabIndex = 24;
            this.lblMult.Text = "Mult.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1101, 641);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.numMult);
            this.Controls.Add(this.btnSave);
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
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro To Quantity";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMult)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem alimentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macronutrientCalculatorToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLaListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numMult;
        private System.Windows.Forms.Label lblMult;
    }
}

