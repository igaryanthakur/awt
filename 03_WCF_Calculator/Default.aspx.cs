using System;
using System.Web.UI;

namespace WCFCalculator
{
    public partial class Default : Page
    {
        // Instantiate the WCF service
        // In a real scenario, add Service Reference and use the generated proxy client
        // e.g.: CalculatorServiceClient svc = new CalculatorServiceClient();
        // For same-project demo, we instantiate directly:
        private CalculatorService svc = new CalculatorService();

        protected void Page_Load(object sender, EventArgs e) { }

        private bool TryGetInputs(out double a, out double b)
        {
            a = b = 0;
            if (!double.TryParse(txtNum1.Text.Trim(), out a) ||
                !double.TryParse(txtNum2.Text.Trim(), out b))
            {
                lblError.Text = "Please enter valid numbers.";
                lblResult.Visible = false;
                return false;
            }
            lblError.Text = "";
            return true;
        }

        private void ShowResult(string operation, string result)
        {
            lblResult.Text = operation + " = " + result;
            lblResult.Visible = true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            ShowResult(a + " + " + b, svc.Add(a, b).ToString("F2"));
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            ShowResult(a + " - " + b, svc.Subtract(a, b).ToString("F2"));
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            ShowResult(a + " × " + b, svc.Multiply(a, b).ToString("F2"));
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;
            ShowResult(a + " ÷ " + b, svc.Divide(a, b));
        }

        protected void btnCircle_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text.Trim(), out double r))
            {
                lblError.Text = "Enter radius in Number 1 field.";
                return;
            }
            lblError.Text = "";
            ShowResult("Area of Circle (r=" + r + ")", svc.AreaOfCircle(r).ToString("F4"));
        }

        protected void btnTriangle_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double b, out double h)) return;
            ShowResult("Area of Triangle (base=" + b + ", height=" + h + ")",
                       svc.AreaOfTriangle(b, h).ToString("F4"));
        }
    }
}
