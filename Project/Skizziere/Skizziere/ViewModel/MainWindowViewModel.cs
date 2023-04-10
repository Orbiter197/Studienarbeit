using System;
using System.Collections.Generic;
using System.Linq;
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
        Random r;

        public static MainWindowViewModel Instance { get; set; }
        public static Canvas Canvas { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public ICommand UndoCommand { get; set; }
        //public ICommand RedoCommand { get; set; }


        public ICommand SelectLabel { get; set; }


        public double MouseX { get; set; }
        public double MouseY { get; set; }

        public List<BasicItem> Items { get; set; }
        public Stack<List<BasicItem>> History { get; set; }


        public MainWindowViewModel()
        {
            Instance = this;
            r = new Random();
            Items = new List<BasicItem>();
            History = new Stack<List<BasicItem>>();
           
            

            SaveCommand = new RelayCommand(() => Export.SaveAsJson(Items));
            LoadCommand = new RelayCommand(() => Items = Export.LoadAsJson());
            UndoCommand = new RelayCommand(() => goBack());

            SelectLabel = new RelayCommand(() => { LeftMouseButtonClicked(); });

        }

        public void LeftMouseButtonClicked()
        {
            Color c = new Color();
            c = Color.FromRgb((byte) r.Next(0,255), (byte)r.Next(0, 255), (byte)r.Next(0, 255));
            Items.Add(new BasicItem() { X = (int)Mouse.GetPosition(Canvas).X, Y = (int)Mouse.GetPosition(Canvas).Y, H = 200, W = 500, Color = c }) ;
            Items = new List<BasicItem>(Items);
        }

        public void goBack()
        {
            if (Items.Count > 0)
            {
                Items.Remove(Items.Last());
                Items = new List<BasicItem>(Items);
            }
        }



        public int Width =>Items.Max(x => x.X + x.W);
        public int Height => Items.Max(x => x.Y + x.H);
    }
}
