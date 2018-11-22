using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MEuler634
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TextInput.Text);

            Solution sol = Solver.BruteForce(n);

            labelSolutionNumber.Text = $"F(n) = {sol.NumberOfSolutions.ToString()}";

            List<string> listDecompositions = new List<string>();

            for (int i = 0; i < sol.ListA.Count; i++)
                listDecompositions.Add($"{sol.ListA[i]}^2 x {sol.ListB[i]}^3 = {sol.ListX[i]}");

            listViewDecompositions.ItemsSource = listDecompositions.ToArray();
        }
    }
}
