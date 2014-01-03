
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Caliburn.Micro;

namespace ClassLibrary1.Namespace1
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementPropertyChangedCaliburn.tt", "")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	partial class Class1: PropertyChangedBase
	{
		#region IClass1Properties

		private System.String _StringProperty;
		public System.String StringProperty
		{
			get { return _StringProperty; }
			set { ChangeProperty<System.String>("StringProperty", ref _StringProperty, value, changedCallback: (o, n) => OnStringPropertyChanged()); }
		}

		private System.Int32 _IntProperty;
		public System.Int32 IntProperty
		{
			get { return _IntProperty; }
			set { ChangeProperty<System.Int32>("IntProperty", ref _IntProperty, value, changedCallback: OnIntPropertyChanged); }
		}

		private System.String _ReadOnlyStringProperty;
		public System.String ReadOnlyStringProperty
		{
			get { return _ReadOnlyStringProperty; }
			private set { ChangeProperty<System.String>("ReadOnlyStringProperty", ref _ReadOnlyStringProperty, value); }
		}

		private System.Int32 _ReadOnlyIntProperty;
		public System.Int32 ReadOnlyIntProperty
		{
			get { return _ReadOnlyIntProperty; }
			private set { ChangeProperty<System.Int32>("ReadOnlyIntProperty", ref _ReadOnlyIntProperty, value); }
		}

		private System.String _WriteOnlyStringProperty;
		public System.String WriteOnlyStringProperty
		{
			set { ChangeProperty<System.String>("WriteOnlyStringProperty", ref _WriteOnlyStringProperty, value); }
		}

		private System.Int32 _WriteOnlyIntProperty;
		public System.Int32 WriteOnlyIntProperty
		{
			set { ChangeProperty<System.Int32>("WriteOnlyIntProperty", ref _WriteOnlyIntProperty, value); }
		}

		#endregion

		#region INotifyPropertyChanged implementation
		//ncrunch: no coverage start

		protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changedCallback = null)
		{
			if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
			T oldValue = propertyValue;
			propertyValue = newValue;
			NotifyOfPropertyChange(propertyName);
			if (changedCallback != null) changedCallback(oldValue, newValue);
		}

		public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Class1, TProperty>> propertySelector)
		{
			return propertySelector.GetMemberInfo().Name;
		}

		//ncrunch: no coverage end
		#endregion
	}

	namespace Namespace2
	{
		[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementPropertyChangedCaliburn.tt", "")]
		[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
		partial class Class2: PropertyChangedBase
		{
			#region IClass2Properties

			private System.String _StringProperty2;
			public System.String StringProperty2
			{
				get { return _StringProperty2; }
				set { ChangeProperty<System.String>("StringProperty2", ref _StringProperty2, value); }
			}

			private System.Int32 _IntProperty2;
			public System.Int32 IntProperty2
			{
				get { return _IntProperty2; }
				set { ChangeProperty<System.Int32>("IntProperty2", ref _IntProperty2, value); }
			}

			#endregion
			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementPropertyChangedCaliburn.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass2: PropertyChangedBase
			{
				#region IClass1Properties

				private System.String _StringProperty;
				public System.String StringProperty
				{
					get { return _StringProperty; }
					set { ChangeProperty<System.String>("StringProperty", ref _StringProperty, value); }
				}

				private System.Int32 _IntProperty;
				public System.Int32 IntProperty
				{
					get { return _IntProperty; }
					set { ChangeProperty<System.Int32>("IntProperty", ref _IntProperty, value); }
				}

				private System.String _ReadOnlyStringProperty;
				public System.String ReadOnlyStringProperty
				{
					get { return _ReadOnlyStringProperty; }
					private set { ChangeProperty<System.String>("ReadOnlyStringProperty", ref _ReadOnlyStringProperty, value); }
				}

				private System.Int32 _ReadOnlyIntProperty;
				public System.Int32 ReadOnlyIntProperty
				{
					get { return _ReadOnlyIntProperty; }
					private set { ChangeProperty<System.Int32>("ReadOnlyIntProperty", ref _ReadOnlyIntProperty, value); }
				}

				private System.String _WriteOnlyStringProperty;
				public System.String WriteOnlyStringProperty
				{
					set { ChangeProperty<System.String>("WriteOnlyStringProperty", ref _WriteOnlyStringProperty, value); }
				}

				private System.Int32 _WriteOnlyIntProperty;
				public System.Int32 WriteOnlyIntProperty
				{
					set { ChangeProperty<System.Int32>("WriteOnlyIntProperty", ref _WriteOnlyIntProperty, value); }
				}

				#endregion
				#region IClass2Properties

				private System.String _StringProperty2;
				public System.String StringProperty2
				{
					get { return _StringProperty2; }
					set { ChangeProperty<System.String>("StringProperty2", ref _StringProperty2, value); }
				}

				private System.Int32 _IntProperty2;
				public System.Int32 IntProperty2
				{
					get { return _IntProperty2; }
					set { ChangeProperty<System.Int32>("IntProperty2", ref _IntProperty2, value); }
				}

				#endregion

				#region INotifyPropertyChanged implementation
				//ncrunch: no coverage start

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changedCallback = null)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					T oldValue = propertyValue;
					propertyValue = newValue;
					NotifyOfPropertyChange(propertyName);
					if (changedCallback != null) changedCallback(oldValue, newValue);
				}

				public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2.InnerClass2, TProperty>> propertySelector)
				{
					return propertySelector.GetMemberInfo().Name;
				}

				//ncrunch: no coverage end
				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementPropertyChangedCaliburn.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass3: PropertyChangedBase
			{
				#region IClass2Properties

				private System.String _StringProperty2;
				public System.String StringProperty2
				{
					get { return _StringProperty2; }
					set { ChangeProperty<System.String>("StringProperty2", ref _StringProperty2, value); }
				}

				private System.Int32 _IntProperty2;
				public System.Int32 IntProperty2
				{
					get { return _IntProperty2; }
					set { ChangeProperty<System.Int32>("IntProperty2", ref _IntProperty2, value); }
				}

				#endregion

				#region INotifyPropertyChanged implementation
				//ncrunch: no coverage start

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changedCallback = null)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					T oldValue = propertyValue;
					propertyValue = newValue;
					NotifyOfPropertyChange(propertyName);
					if (changedCallback != null) changedCallback(oldValue, newValue);
				}

				public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2.InnerClass3, TProperty>> propertySelector)
				{
					return propertySelector.GetMemberInfo().Name;
				}

				//ncrunch: no coverage end
				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementPropertyChangedCaliburn.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass4
			{
			}

			#region INotifyPropertyChanged implementation
			//ncrunch: no coverage start

			protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changedCallback = null)
			{
				if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
				T oldValue = propertyValue;
				propertyValue = newValue;
				NotifyOfPropertyChange(propertyName);
				if (changedCallback != null) changedCallback(oldValue, newValue);
			}

			public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2, TProperty>> propertySelector)
			{
				return propertySelector.GetMemberInfo().Name;
			}

			//ncrunch: no coverage end
			#endregion
		}
	}
}
