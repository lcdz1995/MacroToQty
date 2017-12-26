using MacroToQty.Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroToQty.Layout
{
    class FoodItem : Panel
    {
        private const int MARGIN_TOP = 15;
        private const int MARGIN_LEFT = 15;

        public event EventHandler DeleteButtonClicked;

        private TextBox txtName;
        private Label lblCalorie;
        private Label lblProtein;
        private Label lblCarb;
        private Label lblFat;
        private NumericUpDown numCalorie;
        private NumericUpDown numProtein;
        private NumericUpDown numCarb;
        private NumericUpDown numFat;
        private Button btnDelete;

        public FoodItem(int id)
        {
            this.Name = id.ToString();
            this.Width = 895;
            this.Height = 50;
            this.BackColor = Color.Azure;
            AddControls();
        }

        public FoodItem(int id, Food item) : this(id)
        {
            txtName.Text = item.Name;
            numCalorie.Value = item.Calorie;
            numProtein.Value = item.Protein;
            numCarb.Value = item.Carbs;
            numFat.Value = item.Fat;
        }

        private void AddControls()
        {
            // txtName
            txtName = new TextBox()
            {
                Location = new Point(MARGIN_LEFT, MARGIN_TOP),
                Width = 180
            };
            this.Controls.Add(txtName);

            // lblCalorie
            lblCalorie = new Label()
            {
                Location = new Point(MARGIN_LEFT + 200, MARGIN_TOP),
                Text = "Cal.",
                Width = 35,
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            var tltCalorie = new ToolTip();
            tltCalorie.IsBalloon = true;
            tltCalorie.SetToolTip(lblCalorie, "Calories");
            this.Controls.Add(lblCalorie);

            // numCalorie
            numCalorie = new NumericUpDown()
            {
                Location = new Point(MARGIN_LEFT + 235, MARGIN_TOP),
                Width = 55,
                Minimum = 0,
                Maximum = 9999,
                Increment = 1,
                DecimalPlaces = 0,
                BackColor = Color.AliceBlue
            };
            this.Controls.Add(numCalorie);

            // lblProtein
            lblProtein = new Label()
            {
                Location = new Point(MARGIN_LEFT + 310, MARGIN_TOP),
                Text = "Prot.",
                Width = 40,
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            var tltProtein = new ToolTip();
            tltProtein.IsBalloon = true;
            tltProtein.SetToolTip(lblProtein, "Protéines");
            this.Controls.Add(lblProtein);

            // numProtein
            numProtein = new NumericUpDown()
            {
                Location = new Point(MARGIN_LEFT + 353, MARGIN_TOP),
                Width = 55,
                Minimum = 0,
                Maximum = 9999,
                Increment = 1,
                DecimalPlaces = 0,
                BackColor = Color.AliceBlue
            };
            this.Controls.Add(numProtein);

            // lblCarb
            lblCarb = new Label()
            {
                Location = new Point(MARGIN_LEFT + 430, MARGIN_TOP),
                Text = "Gluc.",
                Width = 43,
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            var tltCarb = new ToolTip();
            tltCarb.IsBalloon = true;
            tltCarb.SetToolTip(lblCarb, "Glucides");
            this.Controls.Add(lblCarb);

            // numCarb
            numCarb = new NumericUpDown()
            {
                Location = new Point(MARGIN_LEFT + 475, MARGIN_TOP),
                Width = 55,
                Minimum = 0,
                Maximum = 9999,
                Increment = 1,
                DecimalPlaces = 0,
                BackColor = Color.AliceBlue
            };
            this.Controls.Add(numCarb);

            // lblFat
            lblFat = new Label()
            {
                Location = new Point(MARGIN_LEFT + 550, MARGIN_TOP),
                Text = "Lip.",
                Width = 35,
                Font = new Font("Microsoft Sans Serif", 10F)
            };
            var tltFat = new ToolTip();
            tltFat.IsBalloon = true;
            tltFat.SetToolTip(lblFat, "Lipides");
            this.Controls.Add(lblFat);

            // numFat
            numFat = new NumericUpDown()
            {
                Location = new Point(MARGIN_LEFT + 585, MARGIN_TOP),
                Width = 55,
                Minimum = 0,
                Maximum = 9999,
                Increment = 1,
                DecimalPlaces = 0,
                BackColor = Color.AliceBlue
            };
            this.Controls.Add(numFat);

            // btnDelete
            btnDelete = new Button()
            {
                Image = Properties.Resources.delete,
                Location = new Point(MARGIN_LEFT + 820, MARGIN_TOP),
                BackColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 20,
                Height = 20
            };
            btnDelete.Click += btnDelete_Click;
            this.Controls.Add(btnDelete);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteButtonClicked != null)
            {
                DeleteButtonClicked(this, e);
            }
        }
    }
}
