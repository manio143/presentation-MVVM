using System.Collections.Generic;
using System.Windows;
using MVVM_Pattern.Models;
using MVVM_Pattern.ViewModels;
using MVVM_Pattern.Views;

namespace MVVM_Pattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var people = new List<Person>
            {
                new Person {Name = "Jan", Surname = "Kowalski", Hometown = "Warszawa"},
                new Person {Name = "Jan", Surname = "Nowak", Hometown = "Warszawa"},
                new Person {Name = "Sebastian", Surname = "Śmirzyński", Hometown = "Wrocław"},
                new Person {Name = "Krzysztof", Surname = "Walewski", Hometown = "Kraków"},
                new Person {Name = "Wacław", Surname = "Kowalski", Hometown = "Warszawa"},
                new Person {Name = "Piotr", Surname = "Narcyski", Hometown = "Częstochowa"},
                new Person {Name = "Stefan", Surname = "Nowak", Hometown = "Kraków"},
                new Person {Name = "Zbigniew", Surname = "Waśny", Hometown = "Gdańsk"},
                new Person {Name = "Jan", Surname = "Kolski", Hometown = "Wrocław"},
                new Person {Name = "Wojciech", Surname = "Kowalski", Hometown = "Warszawa"},
                new Person {Name = "Jan", Surname = "Nienacki", Hometown = "Warszawa"},
                new Person {Name = "Jan", Surname = "Nizurski", Hometown = "Kraków"},
                new Person {Name = "Adam", Surname = "Mickiewicz", Hometown = "Gdańsk"},
                new Person {Name = "Juliusz", Surname = "Słowacki", Hometown = "Wrocław"}
            };
            Grid.Children.Add(new UserHometownView(new UserHometownViewModel(people)));
        }
    }
}
