﻿#pragma warning disable SA1402 // File may only contain a single class
namespace Gu.Wpf.PropertyGrid
{
    using System.Windows;

    public static partial class PropertyGrid
    {
        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.RegisterAttached(
            "IsReadOnly",
            typeof(bool),
            typeof(PropertyGrid),
            new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldValueStringFormatProperty = DependencyProperty.RegisterAttached(
            "OldValueStringFormat",
            typeof(string),
            typeof(PropertyGrid),
            new FrameworkPropertyMetadata(
                "Old value: {0}",
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldDataContextProperty = DependencyProperty.RegisterAttached(
            "OldDataContext",
            typeof(object),
            typeof(PropertyGrid),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Helper for setting IsReadOnly property on a UIElement.
        /// </summary>
        /// <param name="element">UIElement to set IsReadOnly property on.</param>
        /// <param name="value">IsReadOnly property value.</param>
        public static void SetIsReadOnly(this UIElement element, bool value)
        {
            element.SetValue(IsReadOnlyProperty, value);
        }

        /// <summary>
        /// Helper for reading IsReadOnly property from a UIElement.
        /// </summary>
        /// <param name="element">UIElement to read IsReadOnly property from.</param>
        /// <returns>IsReadOnly property value.</returns>
        [AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
        [AttachedPropertyBrowsableForType(typeof(UIElement))]
        public static bool GetIsReadOnly(this UIElement element)
        {
            return (bool)element.GetValue(IsReadOnlyProperty);
        }

        /// <summary>
        /// Helper for setting OldValueStringFormat property on a UIElement.
        /// </summary>
        /// <param name="element">UIElement to set OldValueStringFormat property on.</param>
        /// <param name="value">OldValueStringFormat property value.</param>
        public static void SetOldValueStringFormat(this UIElement element, string value)
        {
            element.SetValue(OldValueStringFormatProperty, value);
        }

        /// <summary>
        /// Helper for reading OldValueStringFormat property from a UIElement.
        /// </summary>
        /// <param name="element">UIElement to read OldValueStringFormat property from.</param>
        /// <returns>OldValueStringFormat property value.</returns>
        [AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
        [AttachedPropertyBrowsableForType(typeof(UIElement))]
        public static string GetOldValueStringFormat(this UIElement element)
        {
            return (string)element.GetValue(OldValueStringFormatProperty);
        }

        /// <summary>
        /// Helper for setting OldDataContext property on a UIElement.
        /// </summary>
        /// <param name="element">UIElement to set OldDataContext property on.</param>
        /// <param name="value">OldDataContext property value.</param>
        public static void SetOldDataContext(this UIElement element, object value)
        {
            element.SetValue(OldDataContextProperty, value);
        }

        /// <summary>
        /// Helper for reading OldDataContext property from a UIElement.
        /// </summary>
        /// <param name="element">UIElement to read OldDataContext property from.</param>
        /// <returns>OldDataContext property value.</returns>
        [AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
        [AttachedPropertyBrowsableForType(typeof(UIElement))]
        public static object GetOldDataContext(this UIElement element)
        {
            return (object)element.GetValue(OldDataContextProperty);
        }
    }

    public abstract partial class Row
    {
        public static readonly DependencyProperty IsReadOnlyProperty = PropertyGrid.IsReadOnlyProperty.AddOwner(
            typeof(Row),
            new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldValueStringFormatProperty = PropertyGrid.OldValueStringFormatProperty.AddOwner(
            typeof(Row),
            new FrameworkPropertyMetadata(
                "Old value: {0}",
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldDataContextProperty = PropertyGrid.OldDataContextProperty.AddOwner(
            typeof(Row),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.Inherits,
                OnOldDataContextChanged));

        public bool IsReadOnly
        {
            get { return (bool)this.GetValue(IsReadOnlyProperty); }
            set { this.SetValue(IsReadOnlyProperty, value); }
        }

        public string OldValueStringFormat
        {
            get { return (string)this.GetValue(OldValueStringFormatProperty); }
            set { this.SetValue(OldValueStringFormatProperty, value); }
        }

        public object OldDataContext
        {
            get { return (object)this.GetValue(OldDataContextProperty); }
            set { this.SetValue(OldDataContextProperty, value); }
        }
    }

    public partial class Rows
    {
        public static readonly DependencyProperty IsReadOnlyProperty = PropertyGrid.IsReadOnlyProperty.AddOwner(
            typeof(Rows),
            new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldValueStringFormatProperty = PropertyGrid.OldValueStringFormatProperty.AddOwner(
            typeof(Rows),
            new FrameworkPropertyMetadata(
                "Old value: {0}",
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldDataContextProperty = PropertyGrid.OldDataContextProperty.AddOwner(
            typeof(Rows),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.Inherits,
                OnOldDataContextChanged));

        public bool IsReadOnly
        {
            get { return (bool)this.GetValue(IsReadOnlyProperty); }
            set { this.SetValue(IsReadOnlyProperty, value); }
        }

        public string OldValueStringFormat
        {
            get { return (string)this.GetValue(OldValueStringFormatProperty); }
            set { this.SetValue(OldValueStringFormatProperty, value); }
        }

        public object OldDataContext
        {
            get { return (object)this.GetValue(OldDataContextProperty); }
            set { this.SetValue(OldDataContextProperty, value); }
        }
    }

    public partial class ContentRow
    {
        public static readonly DependencyProperty IsReadOnlyProperty = PropertyGrid.IsReadOnlyProperty.AddOwner(
            typeof(ContentRow),
            new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldValueStringFormatProperty = PropertyGrid.OldValueStringFormatProperty.AddOwner(
            typeof(ContentRow),
            new FrameworkPropertyMetadata(
                "Old value: {0}",
                FrameworkPropertyMetadataOptions.Inherits));

        public static readonly DependencyProperty OldDataContextProperty = PropertyGrid.OldDataContextProperty.AddOwner(
            typeof(ContentRow),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.Inherits,
                OnOldDataContextChanged));

        public bool IsReadOnly
        {
            get { return (bool)this.GetValue(IsReadOnlyProperty); }
            set { this.SetValue(IsReadOnlyProperty, value); }
        }

        public string OldValueStringFormat
        {
            get { return (string)this.GetValue(OldValueStringFormatProperty); }
            set { this.SetValue(OldValueStringFormatProperty, value); }
        }

        public object OldDataContext
        {
            get { return (object)this.GetValue(OldDataContextProperty); }
            set { this.SetValue(OldDataContextProperty, value); }
        }
    }
}
