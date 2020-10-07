using CharacterManager.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CharacterManager.ViewModels
{
    public class CharacterSheetMainViewModel: ReactiveObject
    {
        [Reactive]
        public Character CurrentCharacter { get; set; }

        public CharacterSheetMainViewModel()
        {
            //CurrentCharacter = System.IO.Load;
        }
    }
}