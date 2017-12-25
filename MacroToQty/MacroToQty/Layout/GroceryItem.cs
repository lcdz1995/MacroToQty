using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroToQty.Code;
using MacroToQty.Layout;

namespace MacroToQty
{
    public class GroceryItem : Panel
    {
        private const int MARGIN_TOP = 15;
        private const int MARGIN_LEFT = 15;

        public event EventHandler DeleteButtonClicked;
        public Action UpdateTotals;

        private ComboBox cmbFood;
        private TrackBar trkQuantity;
        private Button btnDelete;
        private UnitNumericUpDown numQuantity;
        private Label lblCalories;
        private Label lblProteins;
        private Label lblCarbs;
        private Label lblFat;

        public GroceryItem(int id)
        {
            this.Name = id.ToString();
            this.Width = 915;
            this.Height = 50;
            this.BackColor = Color.Azure;
            AddControls();
        }

        private void AddControls()
        {
            // cmbFood
            cmbFood = new ComboBox()
            {
                ValueMember = "Id",
                DisplayMember = "Name",
                Location = new Point(MARGIN_LEFT, MARGIN_TOP),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 180
            };
            using (var db = new DbContext())
            {
                cmbFood.Items.AddRange(FoodManager.GetList(db).ToArray());
            }
            this.Controls.Add(cmbFood);
            cmbFood.SelectedValueChanged += cmbFood_SelectedValueChanged;

            // trkQuantity
            trkQuantity = new TrackBar() 
            {
                Location = new Point(MARGIN_LEFT + 190, MARGIN_TOP),
                Width = 250,
                Enabled = false,
                TickStyle = TickStyle.None
            };
            trkQuantity.ValueChanged += trkQuantity_ValueChanged;
            this.Controls.Add(trkQuantity);

            // numQuantity
            numQuantity = new UnitNumericUpDown()
            {
                Location = new Point(MARGIN_LEFT + 450, MARGIN_TOP),
                Width = 55,
                Minimum = 0,
                Maximum = 9999,
                Increment = 1,
                DecimalPlaces = 0,
                Enabled = false,
                BackColor = Color.AliceBlue
            };
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            this.Controls.Add(numQuantity);

            // btnDelete
            btnDelete = new Button() 
            {
                Image = Properties.Resources.delete,
                Location = new Point(MARGIN_LEFT + 530, MARGIN_TOP),
                BackColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 20,
                Height = 20
            };
            btnDelete.Click += btnDelete_Click;
            this.Controls.Add(btnDelete);

            // lblCalories
            lblCalories = new Label()
            {
                Location = new Point(MARGIN_LEFT + 563, MARGIN_TOP),
                Text = "0",
                Width = 60,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 11.25F)
            };
            this.Controls.Add(lblCalories);

            // lblProteins
            lblProteins = new Label()
            {
                Location = new Point(MARGIN_LEFT + 653, MARGIN_TOP),
                Width = 60,
                Text = "0",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 11.25F)
            };
            this.Controls.Add(lblProteins);

            // lblCarbs
            lblCarbs = new Label()
            {
                Location = new Point(MARGIN_LEFT + 743, MARGIN_TOP),
                Text = "0",
                Width = 60,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 11.25F)
            };
            this.Controls.Add(lblCarbs);

            // lblFat
            lblFat = new Label()
            {
                Location = new Point(MARGIN_LEFT + 833, MARGIN_TOP),
                Text = "0",
                Width = 60,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 11.25F)
            };
            this.Controls.Add(lblFat);
        }

        #region Gets
        public decimal GetCalorieCount()
        {
            decimal value = 0;
            decimal.TryParse(lblCalories.Text, out value);
            return value;
        }

        public decimal GetProteinCount()
        {
            decimal value = 0;
            decimal.TryParse(lblProteins.Text, out value);
            return value;
        }

        public decimal GetCarbCount()
        {
            decimal value = 0;
            decimal.TryParse(lblCarbs.Text, out value);
            return value;
        }

        public decimal GetFatCount()
        {
            decimal value = 0;
            decimal.TryParse(lblFat.Text, out value);
            return value;
        }
        #endregion

        #region Events
        private void cmbFood_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedFood = cmbFood.SelectedItem as Food;
            numQuantity.SetUnit(selectedFood.IsUnit ? "u" : "g");
            trkQuantity.Enabled = true;
            numQuantity.Enabled = true;
            trkQuantity.Maximum = selectedFood.IsUnit ? 30 : 500;

            CalculateMarcos();

            if (UpdateTotals != null)
            {
                UpdateTotals();
            }
        }
        
        private void trkQuantity_ValueChanged(object sender, EventArgs e)
        {
            numQuantity.Value = trkQuantity.Value;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numQuantity.Value <= trkQuantity.Maximum)
            {
                trkQuantity.Value = (int)numQuantity.Value;
            }

            CalculateMarcos();

            if (UpdateTotals != null)
            {
                UpdateTotals();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteButtonClicked != null)
            {
                DeleteButtonClicked(this, e);
            }
        }

        private void CalculateMarcos()
        {
            var food = cmbFood.SelectedItem as Food;
            var number = numQuantity.Value;
            
            lblCalories.Text = ((int)(food.IsUnit ? food.Calorie * number : (decimal)food.Calorie / (decimal)food.Quantity * number)).ToString();
            lblProteins.Text = ((int)(food.IsUnit ? food.Protein * number : (decimal)food.Protein / (decimal)food.Quantity * number)).ToString();
            lblCarbs.Text = ((int)(food.IsUnit ? food.Carbs * number : (decimal)food.Carbs / (decimal)food.Quantity * number)).ToString();
            lblFat.Text = ((int)(food.IsUnit ? food.Fat * number : (decimal)food.Fat / (decimal)food.Quantity * number)).ToString();
        }
        #endregion

        #region Helpers
        
        #endregion
    }
}
