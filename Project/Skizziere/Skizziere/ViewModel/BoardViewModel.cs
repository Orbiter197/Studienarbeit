using Skizziere.Core;
using Skizziere.Model.Notes;
using System.Collections.ObjectModel;
using System.Windows.Media.Media3D;

namespace Skizziere.ViewModel
{
    class BoardViewModel : ObservableObject
    {

        private ObservableCollection<BasicNote> notes;
        public ObservableCollection<BasicNote> Notes 
        { 
            get => notes; 
            set 
            { 
                notes = value; 
                OnPropertyChanged("Notes"); 
            } 
        }

        public BoardViewModel() 
        { 
            Notes = new ObservableCollection<BasicNote>();
            Notes.Add(new TextNote(50, 50, 100, 100, VisibilityState.Visible));
            OnPropertyChanged("Notes");
        }

        public void AddTextNote(int x, int y, int width, int height)
        {
            Notes.Clear();
            OnPropertyChanged("Notes");
        }

        public void AddImageNote(int x, int y, int width, int height)
        {
            Notes.Add(new ImageNote(x, y, width, height, VisibilityState.Visible));
            OnPropertyChanged("Notes");
        }

    }
}
