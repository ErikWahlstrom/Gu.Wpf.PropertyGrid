﻿namespace Gu.Wpf.PropertyGrid
{
    using System.Windows;

    public abstract partial class Row
    {
#pragma warning disable SA1202 // Elements must be ordered by access

        /// <summary>Identifies the <see cref="UsePropertyNameAsHeader"/> dependency property.</summary>
        public static readonly DependencyProperty UsePropertyNameAsHeaderProperty = PropertyGrid.UsePropertyNameAsHeaderProperty.AddOwner(
                typeof(Row),
                new FrameworkPropertyMetadata(
                    BooleanBoxes.False,
                    FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.NotDataBindable));

        /// <summary>Identifies the <see cref="Header"/> dependency property.</summary>
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            nameof(Header),
            typeof(string),
            typeof(Row),
            new PropertyMetadata(string.Empty));

        /// <summary>Identifies the <see cref="Suffix"/> dependency property.</summary>
        public static readonly DependencyProperty SuffixProperty = DependencyProperty.Register(
            nameof(Suffix),
            typeof(string),
            typeof(Row),
            new PropertyMetadata(string.Empty));

        /// <summary>Identifies the <see cref="OldValue"/> dependency property.</summary>
        public static readonly DependencyProperty OldValueProperty = DependencyProperty.Register(
            nameof(OldValue),
            typeof(object),
            typeof(Row),
#pragma warning disable WPF0016 // Default value is shared reference type.
            new PropertyMetadata(new object(), OnOldValueChanged));
#pragma warning restore WPF0016 // Default value is shared reference type.

        private static readonly DependencyPropertyKey IsDirtyPropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(IsDirty),
            typeof(bool?),
            typeof(Row),
            new PropertyMetadata(null));

        /// <summary>Identifies the <see cref="IsDirty"/> dependency property.</summary>
        public static readonly DependencyProperty IsDirtyProperty = IsDirtyPropertyKey.DependencyProperty;
#pragma warning restore SA1202 // Elements must be ordered by access

        static Row()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Row), new FrameworkPropertyMetadata(typeof(Row)));
            FocusableProperty.OverrideMetadata(typeof(Row), new FrameworkPropertyMetadata(BooleanBoxes.False));
        }

        public bool UsePropertyNameAsHeader
        {
            get => (bool)this.GetValue(UsePropertyNameAsHeaderProperty);
            set => this.SetValue(UsePropertyNameAsHeaderProperty, BooleanBoxes.Box(value));
        }

        public string Header
        {
            get => (string)this.GetValue(HeaderProperty);
            set => this.SetValue(HeaderProperty, value);
        }

        public string Suffix
        {
            get => (string)this.GetValue(SuffixProperty);
            set => this.SetValue(SuffixProperty, value);
        }

        public object OldValue
        {
            get => this.GetValue(OldValueProperty);
            set => this.SetValue(OldValueProperty, value);
        }

        public bool? IsDirty
        {
            get => (bool?)this.GetValue(IsDirtyProperty);
            protected set => this.SetValue(IsDirtyPropertyKey, value);
        }
    }
}
