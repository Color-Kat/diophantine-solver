namespace Diofant2
{
    public partial class DiafantForm : Form
    {
        DiofantSolver DiofantSolver = new DiofantSolver();

        public DiafantForm()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = gridCoefficients.Rows[0].Cells[0].Value?.ToString() ?? string.Empty;
            b = gridCoefficients.Rows[0].Cells[1].Value?.ToString() ?? string.Empty;
            c = gridCoefficients.Rows[0].Cells[2].Value?.ToString() ?? string.Empty;

            if (DiofantSolver.SetCoefficients(a, b, c))
            {
                DiofantSolver.Solve();
                DiofantSolver.ShowResult(gridSolves);
            } else
                MessageBox.Show("¬ведЄнные данные некорректны");
        }

    }
}
