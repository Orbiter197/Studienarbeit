using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Skizziere.Core;
using Skizziere.Model;
using Skizziere.Model.Notes;
using Skizziere.Model.Shapes;

namespace Skizziere.ViewModel
{

    class MainWindowViewModel : ObservableObject
    {
        public Point CursorPosition { get; set; }

        public RelayCommand NewTextNote { get; set; }
        public RelayCommand NewImageNote { get; set; }

        private ObservableCollection<BasicNote> notes;
        public ObservableCollection<BasicNote> Notes { get => notes; set => notes = value; }

        public MainWindowViewModel() 
        { 
            notes = new ObservableCollection<BasicNote>();
            NewTextNote = new RelayCommand(() => { AddTextNote(0, 0, 100, 100); });
            NewImageNote = new RelayCommand(() => { AddImageNote(200, 200, 100, 100); });
        }

        public void UpdateCursorPosition(MouseEventArgs e, UIElement relativeTo)
        {
            CursorPosition = e.GetPosition(null);
            Point relativePosition = e.GetPosition(relativeTo);
        }

        public void AddTextNote(int x, int y, int width, int height)
        {
            Notes.Add(new TextNote((int) CursorPosition.X, (int) CursorPosition.Y, width, height, VisibilityState.Visible));
            OnPropertyChanged("Notes");
        }

        public void AddImageNote(int x, int y, int width, int height)
        {
            Notes.Add(new ImageNote(x, y, width, height, VisibilityState.Visible));
            OnPropertyChanged("Notes");
        }
    }
}
