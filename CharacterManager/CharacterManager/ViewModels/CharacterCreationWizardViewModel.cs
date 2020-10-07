using CharacterManager.Models;
using Newtonsoft.Json;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CharacterManager.ViewModels
{
    public class CharacterCreationWizardViewModel : ReactiveObject
    {
        [Reactive]
        public Character NewCharacter { get; set; }

        public Trait NewTrait { get; set; }

        public ICommand SaveCommand { get; }

        public CharacterCreationWizardViewModel()
        {
            NewCharacter = new Character();

            NewTrait = new Trait();

            SaveCommand = new Command(SaveCharacter);
        }

        public void SaveCharacter()
        {
            //TODO: save character
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");

            string characterInfo = JsonConvert.SerializeObject(NewCharacter);

            File.WriteAllText(fileName, characterInfo);

        }
    }
}

