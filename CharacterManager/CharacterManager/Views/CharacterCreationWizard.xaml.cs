using CharacterManager.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharacterManager.Views
{
    public partial class CharacterCreationWizard : ReactiveContentPage<CharacterCreationWizardViewModel>
    {
        public CharacterCreationWizard()
        {
            InitializeComponent();
            ViewModel = new CharacterCreationWizardViewModel();
            this.WhenActivated(disposable =>
            {
            this.Bind(ViewModel, x => x.NewCharacter.Name, x => x.characterName.Text)
            .DisposeWith(disposable);
            });

            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, x => x.NewTrait.Name, x => x.characterQuality.Text)
                .DisposeWith(disposable);
            });

            //this.WhenActivated(disposable =>
            //{
            //    this.Bind(ViewModel, x => x.NewCharacter.CharacterClass, x => x.classOptionName.Text)
            //    .DisposeWith(disposable);
            //});

            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, x => x.NewCharacter.Title, x => x.characterBackground.Text)
                .DisposeWith(disposable);
            });

            //this.WhenActivated(disposable =>
            //{
            //    this.Bind(ViewModel, x => x.SaveCommand, x => x.saveBtn.GestureRecognizers=() => { });
            //});

        }
    }
}