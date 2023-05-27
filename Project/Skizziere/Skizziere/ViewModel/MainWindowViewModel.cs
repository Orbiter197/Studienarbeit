using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
        

        public RelayCommand NewTextNote { get; set; }
        public RelayCommand NewImageNote { get; set; }
        public BoardViewModel BoardViewModel { get; set; }

        public MainWindowViewModel() 
        { 
            BoardViewModel = new BoardViewModel();
            NewTextNote = new RelayCommand(() => { BoardViewModel.AddTextNote(0, 0, 100, 100); });
            NewImageNote = new RelayCommand(() => { BoardViewModel.AddImageNote(200, 200, 100, 100); });
        }

        void AddTextNote()
        {
        }
    }
}
