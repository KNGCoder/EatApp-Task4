﻿using EatApp.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();
            persons.Add(new Person("Лаура", "Laura"));
            persons.Add(new Person("Лаура1", "Laura1"));
            persons.Add(new Person("Лаура1", "Laura1"));

            MyData.ItemsSource = persons;
        }
    }
}