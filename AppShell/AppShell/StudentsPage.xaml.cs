using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace AppShell
{
    public class Students
    {
        public string Name { get; set; }
        public string StudentsClass { get; set; }
        public bool Present { get; set; }
    }
    public partial class StudentsPage : ContentPage
    {
        public static ObservableCollection<Students> StudentsList { get; set; }
        public StudentsPage()
        {
            InitializeComponent();

        }
    }
}
