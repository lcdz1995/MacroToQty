using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroToQty.Code;

namespace MacroToQty
{
    public partial class frmMain : Form
    {
        private int GroceryItemsId = 1;
        private frmFood frmFood = null;
        private bool IsWeekMode = false;

        #region Load / Init
        public frmMain()
        {            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            BindUserInfos();
        }

        private void BindUserInfos()
        {
            try
            {
                decimal value = 0;
                using (var db = new DbContext())
                {
                    decimal.TryParse(UserInfosManager.GetValue(db, "Calories"), out value);
                    numCalories.Value = value;

                    decimal.TryParse(UserInfosManager.GetValue(db, "Proteins"), out value);
                    numProteins.Value = value;

                    decimal.TryParse(UserInfosManager.GetValue(db, "Carbs"), out value);
                    numCarbs.Value = value;

                    decimal.TryParse(UserInfosManager.GetValue(db, "Fat"), out value);
                    numFat.Value = value;

                    var isWeekModeStr = UserInfosManager.GetValue(db, key: "IsWeekMode");
                    if (isWeekModeStr == "")
                    {
                        UserInfosManager.Save(db, key: "IsWeekMode", value: IsWeekMode.ToString());
                    }
                    else
                    {
                        IsWeekMode = bool.Parse(isWeekModeStr);
                        if (IsWeekMode)
                        {
                            mettreEnModeSemaineToolStripMenuItem.Text = "Mettre en mode journée";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnAddGroceryItem_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            AddGroceryItem();
            EnableControls(true);
        }

        private void AddGroceryItem()
        {
            var groceryItem = new GroceryItem(GroceryItemsId++);
            groceryItem.DeleteButtonClicked += DeleteGroceryItem;
            groceryItem.UpdateTotals = UpdateTotals;
            flpGroceryItems.Controls.Add(groceryItem);
        }

        private void DeleteGroceryItem(object sender, EventArgs e)
        {
            var groceryItem = sender as GroceryItem;
            var id = groceryItem.Name;
            flpGroceryItems.Controls.RemoveByKey(id);
        }

        private void UpdateTotals()
        {
            int totalCalories = 0, totalProtein = 0, totalCarb = 0, totalFat = 0;

            foreach (GroceryItem item in flpGroceryItems.Controls)
            {
                totalCalories += (int)item.GetCalorieCount();
                totalProtein += (int)item.GetProteinCount();
                totalCarb += (int)item.GetCarbCount();
                totalFat += (int)item.GetFatCount();
            }

            lblTotalCalories.Text = totalCalories.ToString();
            lblTotalProtein.Text = totalProtein.ToString();
            lblTotalCarb.Text = totalCarb.ToString();
            lblTotalFat.Text = totalFat.ToString();
        }

        private void numCalories_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                UserInfosManager.Save(db, "Calories", numCalories.Value.ToString());
            }
        }

        private void numProteins_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                UserInfosManager.Save(db, "Proteins", numProteins.Value.ToString());
            }
        }

        private void numCarbs_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                UserInfosManager.Save(db, "Carbs", numCarbs.Value.ToString());
            }
        }

        private void numFat_ValueChanged(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                UserInfosManager.Save(db, "Fat", numFat.Value.ToString());
            }
        }

        private void lnkMacroCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void frmFood_FormClosed(object sender, EventArgs e)
        {
            this.frmFood = null;
        }

        #region Helpers
        private void EnableControls(bool enabled)
        {
            numCalories.Enabled = enabled;
            numProteins.Enabled = enabled;
            numFat.Enabled = enabled;
            numCarbs.Enabled = enabled;
            btnAddGroceryItem.Enabled = enabled;

            foreach (Control control in flpGroceryItems.Controls)
            {
                control.Enabled = enabled;
            }

            if (!enabled)
            {
                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        #endregion

        #region ToolStripMenu
        private void alimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmFood == null)
            {
                this.frmFood = new frmFood();
                this.frmFood.FormClosed += frmFood_FormClosed;
            }

            this.frmFood.Show();
            this.frmFood.BringToFront();
        }

        private void macronutrientCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var link = new LinkLabel.Link();
            link.LinkData = "https://www.bodybuilding.com/fun/macronutrients_calculator.htm";
            Process.Start(link.LinkData as string);
        }

        private void réinitialiserLaListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpGroceryItems.Controls.Clear();
        }

        private void réinitialiserLesDonnéesDeLutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numCalories.Value = 0;
            numProteins.Value = 0;
            numCarbs.Value = 0;
            numFat.Value = 0;
        }

        private void mettreEnModeSemaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsWeekMode)
            {
                mettreEnModeSemaineToolStripMenuItem.Text = "Mettre en mode semaine";
                numCalories.Value = (int)(numCalories.Value / 7);
                numProteins.Value = (int)(numProteins.Value / 7);
                numCarbs.Value = (int)(numCarbs.Value / 7);
                numFat.Value = (int)(numFat.Value / 7);
            }
            else
            {
                mettreEnModeSemaineToolStripMenuItem.Text = "Mettre en mode journée";
                numCalories.Value = (int)(numCalories.Value * 7);
                numProteins.Value = (int)(numProteins.Value * 7);
                numCarbs.Value = (int)(numCarbs.Value * 7);
                numFat.Value = (int)(numFat.Value * 7);
            }

            IsWeekMode = !IsWeekMode;
            using (var db = new DbContext())
            {
                UserInfosManager.Save(db, key: "IsWeekMode", value: IsWeekMode.ToString());
            }
        }
        #endregion
    }
}
