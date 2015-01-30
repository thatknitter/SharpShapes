using SharpShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GrapeShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateClassList();
            //PopulateTestShapes();
        }

        public static int ArgumentCountFor(string className)
        {
            Type classType = GetShapeTypeOf(className);
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return classConstructor.GetParameters().Length;
        }

        private static Type GetShapeTypeOf(string className)
        {
            Type classType = Assembly.GetAssembly(typeof(Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First();
            return classType;
        }

        public static Shape InstantiateWithArguments(string className, object[] args)
        {
            Type classType = GetShapeTypeOf(className);
            ConstructorInfo classConstructor = classType.GetConstructors().First();
            return (Shape)classConstructor.Invoke(args);
        }

        private void PopulateClassList()
        {
            var classList = new List<string>();
            var shapeType = typeof(Shape);
            foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes())
            {
                if (type.IsSubclassOf(shapeType) && !type.IsAbstract)
                {
                    classList.Add(type.Name);
                }
            }
            ShapeType.ItemsSource = classList;
        }

        //private void PopulateTestShapes()
        //{
        //    var square = new Square(30);
        //    square.FillColor = System.Drawing.Color.AliceBlue;
        //    square.BorderColor = System.Drawing.Color.BurlyWood;

        //    var square2 = new Square(200);
        //    square2.BorderColor = System.Drawing.Color.Navy;
        //    square2.FillColor = System.Drawing.Color.Fuchsia;
        //    DrawSquare(1, 50, square);
        //    DrawSquare(50, 5, square2);
        //}


       

       
        private void ShapeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Enable/Disable Inputs based on the number of required arguments.
            string className = (String)ShapeType.SelectedValue;
            int argCount = ArgumentCountFor(className);
            Argument1.IsEnabled = true;
            Argument2.IsEnabled = (argCount > 1);
            Argument3.IsEnabled = (argCount > 2);
            Argument1.Text = "0";
            Argument2.Text = "0";
            Argument3.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Retrieve correct number of arguments
            string className = (String)ShapeType.SelectedValue;
            int argCount = ArgumentCountFor(className);
            object[] potentialArgs = new object[] { Int32.Parse(Argument1.Text), Int32.Parse(Argument2.Text), Int32.Parse(Argument3.Text) };
            //Create Shape
            Shape shape = InstantiateWithArguments(className, potentialArgs.Take(argCount).ToArray());
            //Draw shape
            shape.DrawOnto(ShapeCanvas, 50, 50);
        }
    }
}