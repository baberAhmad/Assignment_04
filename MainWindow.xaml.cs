﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person{Name = "John Harry", Age = 26, Gender = "Male"};
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + "is " + person.Age + "and" + person.Gender;
            MessageBox.Show(message);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
    }
}
