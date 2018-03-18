using MacroToQty.Code;
using MacroToQty.Layout;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MacroToQty
{
    public partial class frmFood : Form
    {
        #region Load / Init
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            BindFoodItems();
        }

        private void BindFoodItems()
        {
            List<Food> items = null;

            using (var db = new DbContext())
            {
                items = FoodManager.GetList(db);
            }

            foreach (Food item in items)
            {
                AddFoodItem(item);
            }
        }
        #endregion

        #region Events
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            AddFoodItem();
            EnableControls(true);
        }

        private void AddFoodItem(Food item = null)
        {
            FoodItem foodItem = null;

            if (item != null)
            {
                foodItem = new FoodItem(item);
            }
            else
            {
                foodItem = new FoodItem((int?)null);
            }
            foodItem.DeleteButtonClicked += DeleteFoodItem;
            flpFoodItems.Controls.Add(foodItem);
        }

        private void DeleteFoodItem(object sender, EventArgs e)
        {
            var foodItem = sender as FoodItem;
            var id = foodItem.Name;
            flpFoodItems.Controls.RemoveByKey(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DbContext())
            {
                foreach (FoodItem item in flpFoodItems.Controls)
                {
                    FoodManager.Save(db, item: item.GetFoodBO());
                }
            }

            this.Close();
        }
        #endregion

        #region Helpers
        private void EnableControls(bool enabled)
        {
            btnAddFood.Enabled = enabled;
            btnSave.Enabled = enabled;

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
    }
}
