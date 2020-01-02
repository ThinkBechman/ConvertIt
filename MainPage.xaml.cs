using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConvertIt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        // initialize public variables that need to be shared with muiltiple methods in this class
        public bool Balthazar;
        public bool Professor;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmitClick(object sender, RoutedEventArgs e)
        {

            DateTime ProfessorProtonBD;
            DateTime BalthazarBD;
            DateTime userDate;
            var result = 0;

            if (Balthazar) 
            {
                BalthazarBD = Convert.ToDateTime("2017-11-27");

                userDate = dtePicker.Date.DateTime;

                result = (userDate - BalthazarBD).Days;

                // Display result
                txtResults.Text = "The answer is: " + result;


            }
            if (Professor)
            {
                ProfessorProtonBD = Convert.ToDateTime("2018-12-10");

                userDate = dtePicker.Date.DateTime;

                result = (userDate - ProfessorProtonBD).Days;

                // Display result
                txtResults.Text = "The answer is: " + result;
            }
        }

        private void BalthazarChecked(object sender, RoutedEventArgs e)
        {
            Balthazar = true;
            
        }

        private void ProfessorChecked(object sender, RoutedEventArgs e)
        {
            Professor = true;

        }
    }
}
