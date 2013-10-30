using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Caliburn.Micro;

namespace ClassLibrary1
{
	partial class Class2Parent: PropertyChangedBase
	{
		private System.String _ParentProperty;
		public System.String ParentProperty
		{
			get { return _ParentProperty; }
			set { ChangeProperty<System.String>("ParentProperty", ref _ParentProperty, value); }
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

		public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Class2Parent, TProperty>> propertySelector)
		{
			return propertySelector.GetMemberInfo().Name;
		}

		//ncrunch: no coverage end
		#endregion
	}

	partial class Class2Child
	{
		private System.String _ChildProperty;
		public System.String ChildProperty
		{
			get { return _ChildProperty; }
			set { ChangeProperty<System.String>("ChildProperty", ref _ChildProperty, value); }
		}

	}

	partial class Class2ChildsChild
	{
		private System.String _ChildsChildProperty;
		public System.String ChildsChildProperty
		{
			get { return _ChildsChildProperty; }
			set { ChangeProperty<System.String>("ChildsChildProperty", ref _ChildsChildProperty, value); }
		}

	}
}
