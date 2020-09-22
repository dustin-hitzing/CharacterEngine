using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using CharacterManager.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharacterManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterSheetMainPage : ReactiveContentPage<CharacterSheetMainViewModel>
    {
        public CharacterSheetMainPage()
        {
            InitializeComponent();
            ViewModel = new CharacterSheetMainViewModel();

            //this.WhenActivated(disposable =>
            //{
                //this.Bind(ViewModel, x => x.Name, x => x.characterName.Text)
                    //.DisposeWith(disposable);
            //});
        }
    }
}