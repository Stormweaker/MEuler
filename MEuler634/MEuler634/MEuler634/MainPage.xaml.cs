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
            long n = Convert.ToInt64(TextInput.Text);

            Solution sol = Solver.BruteForce(n);

            labelSolutionNumber.Text = sol.NumberOfSolutions.ToString();
        }
    }
}
