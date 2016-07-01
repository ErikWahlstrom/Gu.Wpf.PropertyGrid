namespace Gu.Wpf.PropertyGrid
{
    using System.Collections;
    using System.Windows;
    using System.Windows.Controls;

    public class SelectorRow : Row<object>
    {
        public static readonly DependencyProperty ItemsSourceProperty = ItemsControl.ItemsSourceProperty.AddOwner(
            typeof(SelectorRow), new FrameworkPropertyMetadata(default(IEnumerable)));

        static SelectorRow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SelectorRow), new FrameworkPropertyMetadata(typeof(SelectorRow)));
        }

        public IEnumerable ItemsSource
        {
            get { return this.GetValue(ItemsSourceProperty) as IEnumerable; }
            set { this.SetValue(ItemsSourceProperty, value); }
        }
    }
}