using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GuessMe.Resources;

namespace GuessMe
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor
        public int randomnumber;


        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

            

        }
     


        public MainPage()
        {
            
            InitializeComponent();
            randomnumber = GenerateRandomNumber(1, 100);
            response.Visibility = System.Windows.Visibility.Collapsed;
            userno.Visibility = System.Windows.Visibility.Collapsed;
          

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
           
        }

      
        

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            int userint;

            if (int.TryParse(userno.Text, out userint))
            {

                userint = Convert.ToInt32(userno.Text);

                int randomNumber = Convert.ToInt32(no.Text);

                if (userint > randomNumber)
                {
                    response.Text = "Lower!";
                }

                else if (userint - randomNumber == 5)
                {
                    response.Text = "Close!";
                }

                else if (userint - randomNumber == 1)
                {
                    response.Text = "Really Close!";
                }

                else if (randomNumber > userint)
                {
                    response.Text = "Higher!";
                }

                else if (randomNumber - userint == -5)
                {
                    response.Text = "Close!";
                }

                else if (userint - randomNumber == -1)
                {
                    response.Text = "Really Close!";
                }

                else
                {
                    response.Text = "You got it!";
                }


                

            }

            else
            {
                MessageBoxResult result1 =
  MessageBox.Show("Please enter a number",
  "Enter a number", MessageBoxButton.OKCancel);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int randomnumber = GenerateRandomNumber(1, 100);
            no.Text = randomnumber.ToString();

            response.Visibility = System.Windows.Visibility.Visible;
            userno.Visibility = System.Windows.Visibility.Visible;

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}