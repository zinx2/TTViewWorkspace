using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTViewer_v0003.ViewModels;
using TTViewer_v0003.Views.MainViews.ChildViews;
using TTViewer_v0003.Views.TabViews;
using Xamarin.Forms;

namespace TTViewer_v0003.Views.MainViews
{
    public class MainContentView : ContentPage
    { 

        View _tabs;

        RelativeLayout relativeLayout;

        CarouselLayout.IndicatorStyleEnum _indicatorStyle;

        SwitcherMainPageViewModel viewModel;

        public MainContentView()
        {
            _indicatorStyle = CarouselLayout.IndicatorStyleEnum.Tabs;

            viewModel = new SwitcherMainPageViewModel();
            BindingContext = viewModel;

            Title = _indicatorStyle.ToString();

            relativeLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var pagesCarousel = CreatePagesCarousel();
            var dots = CreatePagerIndicatorContainer();
            _tabs = CreateTabs();

            switch (pagesCarousel.IndicatorStyle)
            {
                case CarouselLayout.IndicatorStyleEnum.Dots:
                    relativeLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.RelativeToParent((parent) => { return parent.Y; }),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.RelativeToParent((parent) => { return parent.Height / 2; })
                    );

                    relativeLayout.Children.Add(dots,
                        Constraint.Constant(0),
                        Constraint.RelativeToView(pagesCarousel,
                            (parent, sibling) => { return sibling.Height - 18; }),
                        Constraint.RelativeToParent(parent => parent.Width),
                        Constraint.Constant(18)
                    );
                    break;
                case CarouselLayout.IndicatorStyleEnum.Tabs:
                    var tabsHeight = 50;
                    relativeLayout.Children.Add(_tabs,
                        Constraint.Constant(0),
                        Constraint.Constant(0),
                        Constraint.RelativeToParent(parent => parent.Width),
                        Constraint.Constant(tabsHeight)
                    );
                    //Constraint.RelativeToParent((parent) => { return parent.Height - tabsHeight; })
                    relativeLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.Constant(tabsHeight),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.RelativeToView(_tabs, (parent, sibling) => { return parent.Height - (sibling.Height); })
                    );
                    //Constraint.RelativeToParent((parent) => { return parent.Y; }),
                    break;
                default:
                    relativeLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.RelativeToParent((parent) => { return parent.Y; }),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.RelativeToParent((parent) => { return parent.Height; })
                    );
                    break;
            }

            Content = relativeLayout;

        }

        CarouselLayout CreatePagesCarousel()
        {
            var carousel = new CarouselLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                IndicatorStyle = _indicatorStyle,
                ItemTemplate = new DataTemplate(typeof(MainContentChildView)),
                
            };
            carousel.SetBinding(CarouselLayout.ItemsSourceProperty, "Pages");
            carousel.SetBinding(CarouselLayout.SelectedItemProperty, "CurrentPage", BindingMode.TwoWay);

            return carousel;
        }

        View CreatePagerIndicatorContainer()
        {
            return new StackLayout
            {
                Children = { CreatePagerIndicators() }
            };
        }

        View CreatePagerIndicators()
        {
            var pagerIndicator = new PagerIndicatorDots() { DotSize = 5, DotColor = Color.Black };
            pagerIndicator.SetBinding(PagerIndicatorDots.ItemsSourceProperty, "Pages");
            pagerIndicator.SetBinding(PagerIndicatorDots.SelectedItemProperty, "CurrentPage");
            return pagerIndicator;
        }

        View CreateTabsContainer()
        {
            return new StackLayout
            {
                Children = { CreateTabs() }
            };
        }

        View CreateTabs()
        {
            var pagerIndicator = new PagerIndicatorTabs() { HorizontalOptions = LayoutOptions.CenterAndExpand };
            pagerIndicator.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            pagerIndicator.SetBinding(PagerIndicatorTabs.ColumnDefinitionsProperty, "Pages", BindingMode.Default, new SpacingConverter());
            pagerIndicator.SetBinding(PagerIndicatorTabs.ItemsSourceProperty, "Pages");
            pagerIndicator.SetBinding(PagerIndicatorTabs.SelectedItemProperty, "CurrentPage");

            return pagerIndicator;
        }
    }

    public class SpacingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var items = value as IEnumerable<MainContentChildViewModel>;

            var collection = new ColumnDefinitionCollection();
            foreach (var item in items)
            {
                collection.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                //collection.Add(item.ChildView);
            }
            return collection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
