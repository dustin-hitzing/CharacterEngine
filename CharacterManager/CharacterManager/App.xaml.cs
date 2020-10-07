using System;
using CharacterManager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharacterManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new CharacterSheetMainPage();
            MainPage = new CharacterCreationWizard();
        }
    }
}
