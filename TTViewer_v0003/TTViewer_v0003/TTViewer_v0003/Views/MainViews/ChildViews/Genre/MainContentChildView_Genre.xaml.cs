﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.ViewModels;
using TTViewer_v0003.Views.MainViews.ChildViews.Today;
using TTViewer_v0003.Views.TabViews;
using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews.ChildViews.Genre
{
    public partial class MainContentChildView_Genre : ContentView
    {
        SwitchGalleryViewModel viewModel;
        RelativeLayout reletiveLayout;
        public MainContentChildView_Genre()
        {
            InitializeComponent();
       //     Label l1 = new Label
       //     {
       //         Text = "The ContentView (colored aqua in this " +
       //"example) might not seem very useful " +
       //"because it can have a single child " +
       //"(in this example a Label) and doesn't " +
       //"do much else. But ContentView is sometimes a " +
       //"convenient way of providing a background " +
       //"color or giving a little margin to its " +
       //"child through its own Padding property.",
       //         TextColor = Color.Purple
       //     };

       //     Label l2 = new Label
       //     {
       //         Text = "리리리리리리맘보.",
       //         TextColor = Color.Purple
       //     };

       //     var beachImage = new Image { Aspect = Aspect.AspectFit };
       //     beachImage.Source = ImageSource.FromFile("sample03.jpg");

       //     //Image img = new Image();
       //     //img.Source = "TTViewer_v0003.Views.MainViews.ChildViews.Genre.Images.sample03.png";
       //     Content = new StackLayout
       //     {
       //         Children =
       //         {
       //             l1,
       //             l2,
       //             beachImage
       //         }
       //     };

            //Content = new Label
            //{
            //    Text = "T리리리리리리리",

            //    TextColor = Color.Purple
            //};


            //    ScrollView scrollview = scv;

            //    //makeChild();

            //    Label header = new Label
            //    {
            //        Text = "ListView",
            //        FontSize = 50,
            //        FontAttributes = FontAttributes.Bold,
            //        HorizontalOptions = LayoutOptions.Center
            //    };

            //    // Define some data.
            //    List<Person> people = new List<Person>
            //    {
            //        new Person("Abigail", new DateTime(1975, 1, 15), Color.Aqua),
            //        new Person("Bob", new DateTime(1976, 2, 20), Color.Black),
            //        new Person("Cathy", new DateTime(1977, 3, 10), Color.Blue),
            //        new Person("David", new DateTime(1978, 4, 25), Color.Fuchsia),
            //        new Person("Eugenie", new DateTime(1979, 5, 5), Color.Gray),
            //        new Person("Freddie", new DateTime(1980, 6, 30), Color.Green),
            //        new Person("Greta", new DateTime(1981, 7, 15), Color.Lime),
            //        new Person("Harold", new DateTime(1982, 8, 10), Color.Maroon),
            //        new Person("Irene", new DateTime(1983, 9, 25), Color.Navy),
            //        new Person("Jonathan", new DateTime(1984, 10, 10), Color.Olive),
            //        new Person("Kathy", new DateTime(1985, 11, 20), Color.Purple),
            //        new Person("Larry", new DateTime(1986, 12, 5), Color.Red),
            //        new Person("Monica", new DateTime(1975, 1, 5), Color.Silver),
            //        new Person("Nick", new DateTime(1976, 2, 10), Color.Teal),
            //        new Person("Olive", new DateTime(1977, 3, 20), Color.White),
            //        new Person("Pendleton", new DateTime(1978, 4, 10), Color.Yellow),
            //        new Person("Queenie", new DateTime(1979, 5, 15), Color.Aqua),
            //        new Person("Rob", new DateTime(1980, 6, 30), Color.Blue),
            //        new Person("Sally", new DateTime(1981, 7, 5), Color.Fuchsia),
            //        new Person("Timothy", new DateTime(1982, 8, 30), Color.Green),
            //        new Person("Uma", new DateTime(1983, 9, 10), Color.Lime),
            //        new Person("Victor", new DateTime(1984, 10, 20), Color.Maroon),
            //        new Person("Wendy", new DateTime(1985, 11, 5), Color.Navy),
            //        new Person("Xavier", new DateTime(1986, 12, 30), Color.Olive),
            //        new Person("Yvonne", new DateTime(1987, 1, 10), Color.Purple),
            //        new Person("Zachary", new DateTime(1988, 2, 5), Color.Red)
            //    };

            //    ListView listView = new ListView
            //    {
            //        // Source of data items.
            //        ItemsSource = people,
            //        Rotation = 270,
            //        // Define template for displaying each item.
            //        // (Argument of DataTemplate constructor is called for 
            //        //      each item; it must return a Cell derivative.)
            //        ItemTemplate = new DataTemplate(() =>
            //        {
            //            // Create views with bindings for displaying each property.
            //            Label nameLabel = new Label();
            //            nameLabel.SetBinding(Label.TextProperty, "Name");

            //            Label birthdayLabel = new Label();
            //            birthdayLabel.SetBinding(Label.TextProperty,
            //                new Binding("Birthday", BindingMode.OneWay,
            //                            null, null, "Born {0:d}"));

            //            BoxView boxView = new BoxView();
            //            boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

            //            // Return an assembled ViewCell.
            //            return new ViewCell
            //            {
            //                View = new StackLayout
            //                {
            //                    Padding = new Thickness(0, 5),
            //                    Orientation = StackOrientation.Horizontal,
            //                    Children =
            //                    {
            //                        boxView,
            //                        new StackLayout
            //                        {
            //                            VerticalOptions = LayoutOptions.Center,
            //                            Spacing = 0,
            //                            Children =
            //                            {
            //                                nameLabel,
            //                                birthdayLabel
            //                            }
            //                        }
            //                    }
            //                }
            //            };
            //        })
            //    };

            //    // Build the page.
            //    this.Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            header,
            //            listView
            //        }
            //    };
            //}

            //class Person
            //{
            //    public Person(string name, DateTime birthday, Color favoriteColor)
            //    {
            //        this.Name = name;
            //        this.Birthday = birthday;
            //        this.FavoriteColor = favoriteColor;
            //    }

            //    public string Name { private set; get; }

            //    public DateTime Birthday { private set; get; }

            //    public Color FavoriteColor { private set; get; }
            //};

            //public void makeChild()
            //{
            //    viewModel = new SwitchGalleryViewModel();
            //    BindingContext = viewModel;

            //    //reletiveLayout = new RelativeLayout
            //    //{
            //    //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    //    VerticalOptions = LayoutOptions.FillAndExpand
            //    //};

            //    //var carousel = new CarouselLayout
            //    //{
            //    //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    //    IndicatorStyle = CarouselLayout.IndicatorStyleEnum.Dots,
            //    //    ItemTemplate = new DataTemplate(typeof(GalleryView))
            //    //};
            //    //carousel.SetBinding(CarouselLayout.ItemsSourceProperty, "Pages");
            //    //carousel.SetBinding(CarouselLayout.SelectedItemProperty, "CurrentPage", BindingMode.TwoWay);

            //    //reletiveLayout.Children.Add(carousel,
            //    //    Constraint.Constant(0),
            //    //    Constraint.Constant(0),
            //    //    //Constraint.RelativeToParent((parent) => { return 300; }),
            //    //    //Constraint.RelativeToParent((parent) => { return 200; })
            //    //    );

            //    //Content = reletiveLayout;
            //
        }

        //void OnImageSizeChanged(object sender, EventArgs args)
        //{
        //    Image image = (Image)sender;
        //}

    }
}
