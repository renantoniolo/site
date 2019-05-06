using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace zeroAcidentesApp.Component
{
    public partial class BarTitleContent : ContentView
    {
        public BarTitleContent()
        {
            InitializeComponent();
        }

        public string TitleText
        {
            get { return base.GetValue(TitleTextProperty).ToString(); }
            set { base.SetValue(TitleTextProperty, value); }
        }

        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(
            propertyName: "TitleText",
            returnType: typeof(string),
            declaringType: typeof(BarTitleContent),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BarTitleContent)bindable;
            control.xTitulo.Text = newValue.ToString();
        }

    }
}
