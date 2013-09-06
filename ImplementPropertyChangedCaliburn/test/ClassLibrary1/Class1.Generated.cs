using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Caliburn.Micro;

namespace ClassLibrary1.Namespace1
{
	partial class Class1: PropertyChangedBase
	{
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

		public System.String ReadOnlyStringProperty { get; private set; }

		public System.Int32 ReadOnlyIntProperty { get; private set; }

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


		#region INotifyPropertyChanged implementation

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

		#endregion
	}

	namespace Namespace2
	{
		partial class Class2: PropertyChangedBase
		{
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

			partial class InnerClass2: PropertyChangedBase
			{
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

				public System.String ReadOnlyStringProperty { get; private set; }

				public System.Int32 ReadOnlyIntProperty { get; private set; }

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


				#region INotifyPropertyChanged implementation

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

				#endregion
			}

			partial class InnerClass3: PropertyChangedBase
			{
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


				#region INotifyPropertyChanged implementation

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

				#endregion
			}

			partial class InnerClass4
			{
			}

			#region INotifyPropertyChanged implementation

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

			#endregion
		}
	}
}
