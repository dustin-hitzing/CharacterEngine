using CharacterManager.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CharacterManager.ViewModels
{
    public class CharacterSheetMainViewModel: ReactiveObject
    {
        [Reactive]
        public string Name { get; set; }

        public CharacterSheetMainViewModel()
        {
      
        }
    }
}