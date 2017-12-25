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
            this.btnFood = new System.Windows.Forms.Button();
            this.numCalories = new System.Windows.Forms.NumericUpDown();
            this.numProteins = new System.Windows.Forms.NumericUpDown();
            this.numCarbs = new System.Windows.Forms.NumericUpDown();
            this.numFat = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblTotalProtein = new System.Windows.Forms.Label();
            this.lblTotalCarb = new System.Windows.Forms.Label();
            this.lblTotalFat = new System.Windows.Forms.Label();
            this.lnkMacroCalc = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            this.SuspendLayout();
            // 
            // flpGroceryItems
            // 
            this.flpGroceryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGroceryItems.AutoScroll = true;
            this.flpGroceryItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGroceryItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpGroceryItems.Location = new System.Drawing.Point(12, 69);
            this.flpGroceryItems.Name = "flpGroceryItems";
            this.flpGroceryItems.Size = new System.Drawing.Size(923, 383);
            this.flpGroceryItems.TabIndex = 0;
            this.flpGroceryItems.WrapContents = false;
            // 
            // btnAddGroceryItem
            // 
            this.btnAddGroceryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroceryItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroceryItem.Image")));
            this.btnAddGroceryItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGroceryItem.Location = new System.Drawing.Point(12, 36);
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
            this.lblTotal.Location = new System.Drawing.Point(520, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblCalorie
            // 
            this.lblCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorie.Location = new System.Drawing.Point(589, 48);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(71, 18);
            this.lblCalorie.TabIndex = 3;
            this.lblCalorie.Text = "Calories";
            // 
            // lblProtein
            // 
            this.lblProtein.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProtein.Location = new System.Drawing.Point(674, 48);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(80, 18);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Protéines";
            // 
            // lblCarbs
            // 
            this.lblCarbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCarbs.Location = new System.Drawing.Point(767, 48);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(74, 18);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Glucides";
            // 
            // lblFat
            // 
            this.lblFat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFat.Location = new System.Drawing.Point(871, 48);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(45, 18);
            this.lblFat.TabIndex = 6;
            this.lblFat.Text = "Gras";
            // 
            // lblUserCalories
            // 
            this.lblUserCalories.AutoSize = true;
            this.lblUserCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCalories.Location = new System.Drawing.Point(12, 9);
            this.lblUserCalories.Name = "lblUserCalories";
            this.lblUserCalories.Size = new System.Drawing.Size(63, 18);
            this.lblUserCalories.TabIndex = 7;
            this.lblUserCalories.Text = "Calories";
            // 
            // lblUserProtein
            // 
            this.lblUserProtein.AutoSize = true;
            this.lblUserProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserProtein.Location = new System.Drawing.Point(188, 9);
            this.lblUserProtein.Name = "lblUserProtein";
            this.lblUserProtein.Size = new System.Drawing.Size(71, 18);
            this.lblUserProtein.TabIndex = 8;
            this.lblUserProtein.Text = "Protéines";
            // 
            // lblUserCarbs
            // 
            this.lblUserCarbs.AutoSize = true;
            this.lblUserCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserCarbs.Location = new System.Drawing.Point(371, 9);
            this.lblUserCarbs.Name = "lblUserCarbs";
            this.lblUserCarbs.Size = new System.Drawing.Size(66, 18);
            this.lblUserCarbs.TabIndex = 9;
            this.lblUserCarbs.Text = "Glucides";
            // 
            // lblUserFat
            // 
            this.lblUserFat.AutoSize = true;
            this.lblUserFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserFat.Location = new System.Drawing.Point(551, 9);
            this.lblUserFat.Name = "lblUserFat";
            this.lblUserFat.Size = new System.Drawing.Size(41, 18);
            this.lblUserFat.TabIndex = 10;
            this.lblUserFat.Text = "Gras";
            // 
            // btnFood
            // 
            this.btnFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(844, 6);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(91, 27);
            this.btnFood.TabIndex = 11;
            this.btnFood.Text = "    Aliments";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // numCalories
            // 
            this.numCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCalories.Location = new System.Drawing.Point(81, 7);
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
            this.numProteins.Location = new System.Drawing.Point(265, 7);
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
            this.numCarbs.Location = new System.Drawing.Point(443, 7);
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
            this.numFat.Location = new System.Drawing.Point(598, 7);
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
            this.lblTotalCalories.Location = new System.Drawing.Point(593, 459);
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
            this.lblTotalProtein.Location = new System.Drawing.Point(683, 459);
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
            this.lblTotalCarb.Location = new System.Drawing.Point(773, 459);
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
            this.lblTotalFat.Location = new System.Drawing.Point(863, 459);
            this.lblTotalFat.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(60, 18);
            this.lblTotalFat.TabIndex = 19;
            this.lblTotalFat.Text = "0";
            this.lblTotalFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkMacroCalc
            // 
            this.lnkMacroCalc.AutoSize = true;
            this.lnkMacroCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lnkMacroCalc.Location = new System.Drawing.Point(695, 7);
            this.lnkMacroCalc.Name = "lnkMacroCalc";
            this.lnkMacroCalc.Size = new System.Drawing.Size(16, 18);
            this.lnkMacroCalc.TabIndex = 20;
            this.lnkMacroCalc.TabStop = true;
            this.lnkMacroCalc.Text = "?";
            this.lnkMacroCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMacroCalc_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(947, 488);
            this.Controls.Add(this.lnkMacroCalc);
            this.Controls.Add(this.lblTotalFat);
            this.Controls.Add(this.lblTotalCarb);
            this.Controls.Add(this.lblTotalProtein);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.numFat);
            this.Controls.Add(this.numCarbs);
            this.Controls.Add(this.numProteins);
            this.Controls.Add(this.numCalories);
            this.Controls.Add(this.btnFood);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro To Quantity";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
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
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.NumericUpDown numCalories;
        private System.Windows.Forms.NumericUpDown numProteins;
        private System.Windows.Forms.NumericUpDown numCarbs;
        private System.Windows.Forms.NumericUpDown numFat;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblTotalProtein;
        private System.Windows.Forms.Label lblTotalCarb;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.LinkLabel lnkMacroCalc;
    }
}

