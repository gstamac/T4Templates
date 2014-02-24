
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;

namespace ClassLibrary1.Namespace1
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	partial class Class1
	{
		#region IClass1Properties

		public static readonly DependencyProperty StringPropertyProperty = 
			DependencyProperty.Register("StringProperty", typeof(System.String), typeof(Class1),
			new PropertyMetadata(StringProperty_DEFAULT_VALUE, OnStringPropertyChanged));

		public System.String StringProperty
		{
			get { return (System.String)GetValue(StringPropertyProperty); }
			set { SetValue(StringPropertyProperty, value); }
		}

		public static readonly DependencyProperty IntPropertyProperty = 
			DependencyProperty.Register("IntProperty", typeof(System.Int32), typeof(Class1),
			new FrameworkPropertyMetadata(IntProperty_DEFAULT_VALUE, IntProperty_OPTIONS, (d, e) => ((Class1)d).OnIntPropertyChanged()));

		public System.Int32 IntProperty
		{
			get { return (System.Int32)GetValue(IntPropertyProperty); }
			set { SetValue(IntPropertyProperty, value); }
		}

		public static readonly DependencyProperty FloatPropertyProperty = 
			DependencyProperty.Register("FloatProperty", typeof(System.Single), typeof(Class1),
			new FrameworkPropertyMetadata(default(System.Single), FloatProperty_OPTIONS, (d, e) => ((Class1)d).OnFloatPropertyChanged((System.Single)e.OldValue, (System.Single)e.NewValue)));

		public System.Single FloatProperty
		{
			get { return (System.Single)GetValue(FloatPropertyProperty); }
			set { SetValue(FloatPropertyProperty, value); }
		}

		public static readonly DependencyProperty ReadOnlyStringPropertyProperty = 
			DependencyProperty.Register("ReadOnlyStringProperty", typeof(System.String), typeof(Class1),
			new PropertyMetadata());

		public System.String ReadOnlyStringProperty
		{
			get { return (System.String)GetValue(ReadOnlyStringPropertyProperty); }
			private set { SetValue(ReadOnlyStringPropertyProperty, value); }
		}

		public static readonly DependencyProperty ReadOnlyIntPropertyProperty = 
			DependencyProperty.Register("ReadOnlyIntProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata());

		public System.Int32 ReadOnlyIntProperty
		{
			get { return (System.Int32)GetValue(ReadOnlyIntPropertyProperty); }
			private set { SetValue(ReadOnlyIntPropertyProperty, value); }
		}

		public static readonly DependencyProperty WriteOnlyStringPropertyProperty = 
			DependencyProperty.Register("WriteOnlyStringProperty", typeof(System.String), typeof(Class1),
			new PropertyMetadata());

		public System.String WriteOnlyStringProperty
		{
			set { SetValue(WriteOnlyStringPropertyProperty, value); }
		}

		public static readonly DependencyProperty WriteOnlyIntPropertyProperty = 
			DependencyProperty.Register("WriteOnlyIntProperty", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata());

		public System.Int32 WriteOnlyIntProperty
		{
			set { SetValue(WriteOnlyIntPropertyProperty, value); }
		}

		#endregion
		#region IInternalClassProperties

		public static readonly DependencyProperty StringProperty2Property = 
			DependencyProperty.RegisterAttached("StringProperty2", typeof(System.String), typeof(Class1),
			new PropertyMetadata(StringProperty2_DEFAULT_VALUE, OnStringProperty2Changed));

		public static System.String GetStringProperty2(DependencyObject obj)
		{
			return (System.String)obj.GetValue(StringProperty2Property);
		}

		public static void SetStringProperty2(DependencyObject obj, System.String value)
		{
			obj.SetValue(StringProperty2Property, value);
		}


		public static readonly DependencyProperty IntProperty2Property = 
			DependencyProperty.RegisterAttached("IntProperty2", typeof(System.Int32), typeof(Class1),
			new PropertyMetadata());

		public static System.Int32 GetIntProperty2(DependencyObject obj)
		{
			return (System.Int32)obj.GetValue(IntProperty2Property);
		}

		public static void SetIntProperty2(DependencyObject obj, System.Int32 value)
		{
			obj.SetValue(IntProperty2Property, value);
		}


		#endregion
	}

	namespace Namespace2
	{
		[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
		[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
		partial class Class2
		{
			#region IClass2Properties

			public static readonly DependencyProperty StringProperty2Property = 
				DependencyProperty.Register("StringProperty2", typeof(System.String), typeof(Class2),
				new PropertyMetadata());

			public System.String StringProperty2
			{
				get { return (System.String)GetValue(StringProperty2Property); }
				set { SetValue(StringProperty2Property, value); }
			}

			public static readonly DependencyProperty IntProperty2Property = 
				DependencyProperty.Register("IntProperty2", typeof(System.Int32), typeof(Class2),
				new PropertyMetadata());

			public System.Int32 IntProperty2
			{
				get { return (System.Int32)GetValue(IntProperty2Property); }
				set { SetValue(IntProperty2Property, value); }
			}

			#endregion
			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass2
			{
				#region IClass1Properties

				public static readonly DependencyProperty StringPropertyProperty = 
					DependencyProperty.Register("StringProperty", typeof(System.String), typeof(InnerClass2),
					new PropertyMetadata());

				public System.String StringProperty
				{
					get { return (System.String)GetValue(StringPropertyProperty); }
					set { SetValue(StringPropertyProperty, value); }
				}

				public static readonly DependencyProperty IntPropertyProperty = 
					DependencyProperty.Register("IntProperty", typeof(System.Int32), typeof(InnerClass2),
					new PropertyMetadata());

				public System.Int32 IntProperty
				{
					get { return (System.Int32)GetValue(IntPropertyProperty); }
					set { SetValue(IntPropertyProperty, value); }
				}

				public static readonly DependencyProperty FloatPropertyProperty = 
					DependencyProperty.Register("FloatProperty", typeof(System.Single), typeof(InnerClass2),
					new PropertyMetadata());

				public System.Single FloatProperty
				{
					get { return (System.Single)GetValue(FloatPropertyProperty); }
					set { SetValue(FloatPropertyProperty, value); }
				}

				public static readonly DependencyProperty ReadOnlyStringPropertyProperty = 
					DependencyProperty.Register("ReadOnlyStringProperty", typeof(System.String), typeof(InnerClass2),
					new PropertyMetadata());

				public System.String ReadOnlyStringProperty
				{
					get { return (System.String)GetValue(ReadOnlyStringPropertyProperty); }
					private set { SetValue(ReadOnlyStringPropertyProperty, value); }
				}

				public static readonly DependencyProperty ReadOnlyIntPropertyProperty = 
					DependencyProperty.Register("ReadOnlyIntProperty", typeof(System.Int32), typeof(InnerClass2),
					new PropertyMetadata());

				public System.Int32 ReadOnlyIntProperty
				{
					get { return (System.Int32)GetValue(ReadOnlyIntPropertyProperty); }
					private set { SetValue(ReadOnlyIntPropertyProperty, value); }
				}

				public static readonly DependencyProperty WriteOnlyStringPropertyProperty = 
					DependencyProperty.Register("WriteOnlyStringProperty", typeof(System.String), typeof(InnerClass2),
					new PropertyMetadata());

				public System.String WriteOnlyStringProperty
				{
					set { SetValue(WriteOnlyStringPropertyProperty, value); }
				}

				public static readonly DependencyProperty WriteOnlyIntPropertyProperty = 
					DependencyProperty.Register("WriteOnlyIntProperty", typeof(System.Int32), typeof(InnerClass2),
					new PropertyMetadata());

				public System.Int32 WriteOnlyIntProperty
				{
					set { SetValue(WriteOnlyIntPropertyProperty, value); }
				}

				#endregion
				#region IClass2Properties

				public static readonly DependencyProperty StringProperty2Property = 
					DependencyProperty.Register("StringProperty2", typeof(System.String), typeof(InnerClass2),
					new PropertyMetadata());

				public System.String StringProperty2
				{
					get { return (System.String)GetValue(StringProperty2Property); }
					set { SetValue(StringProperty2Property, value); }
				}

				public static readonly DependencyProperty IntProperty2Property = 
					DependencyProperty.Register("IntProperty2", typeof(System.Int32), typeof(InnerClass2),
					new PropertyMetadata());

				public System.Int32 IntProperty2
				{
					get { return (System.Int32)GetValue(IntProperty2Property); }
					set { SetValue(IntProperty2Property, value); }
				}

				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass3
			{
				#region IClass2Properties

				public static readonly DependencyProperty StringProperty2Property = 
					DependencyProperty.Register("StringProperty2", typeof(System.String), typeof(InnerClass3),
					new PropertyMetadata());

				public System.String StringProperty2
				{
					get { return (System.String)GetValue(StringProperty2Property); }
					set { SetValue(StringProperty2Property, value); }
				}

				public static readonly DependencyProperty IntProperty2Property = 
					DependencyProperty.Register("IntProperty2", typeof(System.Int32), typeof(InnerClass3),
					new PropertyMetadata());

				public System.Int32 IntProperty2
				{
					get { return (System.Int32)GetValue(IntProperty2Property); }
					set { SetValue(IntProperty2Property, value); }
				}

				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementDependencyProperties.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass4
			{
			}
		}
	}
}
