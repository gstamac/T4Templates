
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;

namespace ClassLibrary1
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	partial class Class1
	{
		#region IClass1Properties

		public static readonly DependencyProperty NothingPropertyProperty = 
			DependencyProperty.Register("NothingProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata());

		public System.Int32 NothingProperty
		{
			get { return (System.Int32)GetValue(NothingPropertyProperty); }
			set { SetValue(NothingPropertyProperty, value); }
		}

		public static readonly DependencyProperty DefValPropertyProperty = 
			DependencyProperty.Register("DefValProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata(DefValProperty_DEFAULT_VALUE));

		public System.Int32 DefValProperty
		{
			get { return (System.Int32)GetValue(DefValPropertyProperty); }
			set { SetValue(DefValPropertyProperty, value); }
		}

		public static readonly DependencyProperty OptionPropertyProperty = 
			DependencyProperty.Register("OptionProperty", typeof(System.Int32), typeof(Class1),
			new FrameworkPropertyMetadata(default(System.Int32), OptionProperty_OPTIONS));

		public System.Int32 OptionProperty
		{
			get { return (System.Int32)GetValue(OptionPropertyProperty); }
			set { SetValue(OptionPropertyProperty, value); }
		}

		public static readonly DependencyProperty ChangedPropertyProperty = 
			DependencyProperty.Register("ChangedProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata(OnChangedPropertyChanged));

		public System.Int32 ChangedProperty
		{
			get { return (System.Int32)GetValue(ChangedPropertyProperty); }
			set { SetValue(ChangedPropertyProperty, value); }
		}

		public static readonly DependencyProperty DefValOptionPropertyProperty = 
			DependencyProperty.Register("DefValOptionProperty", typeof(System.Int32), typeof(Class1),
			new FrameworkPropertyMetadata(DefValOptionProperty_DEFAULT_VALUE, DefValOptionProperty_OPTIONS));

		public System.Int32 DefValOptionProperty
		{
			get { return (System.Int32)GetValue(DefValOptionPropertyProperty); }
			set { SetValue(DefValOptionPropertyProperty, value); }
		}

		public static readonly DependencyProperty DefValChangedPropertyProperty = 
			DependencyProperty.Register("DefValChangedProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata(DefValChangedProperty_DEFAULT_VALUE, OnDefValChangedPropertyChanged));

		public System.Int32 DefValChangedProperty
		{
			get { return (System.Int32)GetValue(DefValChangedPropertyProperty); }
			set { SetValue(DefValChangedPropertyProperty, value); }
		}

		public static readonly DependencyProperty OptionChangedPropertyProperty = 
			DependencyProperty.Register("OptionChangedProperty", typeof(System.Int32), typeof(Class1),
			new FrameworkPropertyMetadata(default(System.Int32), OptionChangedProperty_OPTIONS, OnOptionChangedPropertyChanged));

		public System.Int32 OptionChangedProperty
		{
			get { return (System.Int32)GetValue(OptionChangedPropertyProperty); }
			set { SetValue(OptionChangedPropertyProperty, value); }
		}

		public static readonly DependencyProperty DefValOptionChangedPropertyProperty = 
			DependencyProperty.Register("DefValOptionChangedProperty", typeof(System.Int32), typeof(Class1),
			new FrameworkPropertyMetadata(DefValOptionChangedProperty_DEFAULT_VALUE, DefValOptionChangedProperty_OPTIONS, OnDefValOptionChangedPropertyChanged));

		public System.Int32 DefValOptionChangedProperty
		{
			get { return (System.Int32)GetValue(DefValOptionChangedPropertyProperty); }
			set { SetValue(DefValOptionChangedPropertyProperty, value); }
		}

		#endregion
	}
}
