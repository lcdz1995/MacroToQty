using System.Windows.Forms;

namespace MacroToQty.Layout
{
    class UnitNumericUpDown : NumericUpDown
    {
        private string Unit = "";

        public UnitNumericUpDown() : base() { }

        public void SetUnit(string unit)
        {
            this.Unit = unit;
            UpdateEditText();
        }

        protected override void UpdateEditText()
        {
            this.Text = this.Value + " " + this.Unit;
        }
    }
}
