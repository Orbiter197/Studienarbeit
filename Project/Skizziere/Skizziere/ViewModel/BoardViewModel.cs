using Skizziere.Core;
using Skizziere.Model.Notes;
using System.Collections.ObjectModel;

namespace Skizziere.ViewModel
{
    class BoardViewModel : ObservableObject
    {
        public ObservableCollection<BasicNote> Notes { get; set; }
        public BoardViewModel() 
        { 
            Notes = new ObservableCollection<BasicNote>();
            Notes.Add(new ImageNote(10, 10, 100, 100, VisibilityState.Visible));
            Notes.Add(new TextNote(200, 200, 100, 100, VisibilityState.Visible));
        }
    }
}
