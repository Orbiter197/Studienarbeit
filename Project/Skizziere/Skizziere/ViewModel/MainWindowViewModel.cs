using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Skizziere.Core;
using Skizziere.Model;
using Skizziere.Model.Shapes;

namespace Skizziere.ViewModel
{

    class MainWindowViewModel : ObservableObject
    {
        public BoardViewModel BoardViewModel { get; set; }
        public MainWindowViewModel() 
        { 
            BoardViewModel = new BoardViewModel();
            
        }
    }
}
