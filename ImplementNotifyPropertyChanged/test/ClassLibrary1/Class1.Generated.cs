
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace ClassLibrary1.Namespace1
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementNotifyPropertyChanged.tt", "")]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	partial class Class1: INotifyPropertyChanged, INotifyPropertyChanging
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

		public event PropertyChangedEventHandler PropertyChanged;
		public event PropertyChangingEventHandler PropertyChanging;
		protected virtual void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		protected virtual void RaisePropertyChanging(string propertyName)
		{
			if (PropertyChanging != null)
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
		}

		protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changingCallback = null, Action<T, T> changedCallback = null)
		{
			if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
			T oldValue = propertyValue;
			if (changingCallback != null) changingCallback(oldValue, newValue);
			RaisePropertyChanging(propertyName);
			propertyValue = newValue;
			RaisePropertyChanged(propertyName);
			if (changedCallback != null) changedCallback(oldValue, newValue);
		}

		public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Class1, TProperty>> propertySelector)
		{
			var memberExpression = propertySelector.Body as MemberExpression;
			if (memberExpression == null)
			{
				var unaryExpression = propertySelector.Body as UnaryExpression;
				if (unaryExpression != null)
				{
					memberExpression = unaryExpression.Operand as MemberExpression;
					if (memberExpression == null)
						throw new NotSupportedException();
				}
				else
					throw new NotSupportedException();
			}
			return memberExpression.Member.Name;
		}

		//ncrunch: no coverage end
		#endregion
	}

	namespace Namespace2
	{
		[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementNotifyPropertyChanged.tt", "")]
		[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
		partial class Class2: INotifyPropertyChanged, INotifyPropertyChanging
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
			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementNotifyPropertyChanged.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass2: INotifyPropertyChanged, INotifyPropertyChanging
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

				public event PropertyChangedEventHandler PropertyChanged;
				public event PropertyChangingEventHandler PropertyChanging;
				protected virtual void RaisePropertyChanged(string propertyName)
				{
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				}
				protected virtual void RaisePropertyChanging(string propertyName)
				{
					if (PropertyChanging != null)
						PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
				}

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changingCallback = null, Action<T, T> changedCallback = null)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					T oldValue = propertyValue;
					if (changingCallback != null) changingCallback(oldValue, newValue);
					RaisePropertyChanging(propertyName);
					propertyValue = newValue;
					RaisePropertyChanged(propertyName);
					if (changedCallback != null) changedCallback(oldValue, newValue);
				}

				public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2.InnerClass2, TProperty>> propertySelector)
				{
					var memberExpression = propertySelector.Body as MemberExpression;
					if (memberExpression == null)
					{
						var unaryExpression = propertySelector.Body as UnaryExpression;
						if (unaryExpression != null)
						{
							memberExpression = unaryExpression.Operand as MemberExpression;
							if (memberExpression == null)
								throw new NotSupportedException();
						}
						else
							throw new NotSupportedException();
					}
					return memberExpression.Member.Name;
				}

				//ncrunch: no coverage end
				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementNotifyPropertyChanged.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass3: INotifyPropertyChanged, INotifyPropertyChanging
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

				public event PropertyChangedEventHandler PropertyChanged;
				public event PropertyChangingEventHandler PropertyChanging;
				protected virtual void RaisePropertyChanged(string propertyName)
				{
					if (PropertyChanged != null)
						PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				}
				protected virtual void RaisePropertyChanging(string propertyName)
				{
					if (PropertyChanging != null)
						PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
				}

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changingCallback = null, Action<T, T> changedCallback = null)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					T oldValue = propertyValue;
					if (changingCallback != null) changingCallback(oldValue, newValue);
					RaisePropertyChanging(propertyName);
					propertyValue = newValue;
					RaisePropertyChanged(propertyName);
					if (changedCallback != null) changedCallback(oldValue, newValue);
				}

				public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2.InnerClass3, TProperty>> propertySelector)
				{
					var memberExpression = propertySelector.Body as MemberExpression;
					if (memberExpression == null)
					{
						var unaryExpression = propertySelector.Body as UnaryExpression;
						if (unaryExpression != null)
						{
							memberExpression = unaryExpression.Operand as MemberExpression;
							if (memberExpression == null)
								throw new NotSupportedException();
						}
						else
							throw new NotSupportedException();
					}
					return memberExpression.Member.Name;
				}

				//ncrunch: no coverage end
				#endregion
			}

			[System.CodeDom.Compiler.GeneratedCodeAttribute("ImplementNotifyPropertyChanged.tt", "")]
			[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
			partial class InnerClass4
			{
			}

			#region INotifyPropertyChanged implementation
			//ncrunch: no coverage start

			public event PropertyChangedEventHandler PropertyChanged;
			public event PropertyChangingEventHandler PropertyChanging;
			protected virtual void RaisePropertyChanged(string propertyName)
			{
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
			protected virtual void RaisePropertyChanging(string propertyName)
			{
				if (PropertyChanging != null)
					PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}

			protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue, Action<T, T> changingCallback = null, Action<T, T> changedCallback = null)
			{
				if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
				T oldValue = propertyValue;
				if (changingCallback != null) changingCallback(oldValue, newValue);
				RaisePropertyChanging(propertyName);
				propertyValue = newValue;
				RaisePropertyChanged(propertyName);
				if (changedCallback != null) changedCallback(oldValue, newValue);
			}

			public string GetPropertyName<TProperty>(Expression<Func<ClassLibrary1.Namespace1.Namespace2.Class2, TProperty>> propertySelector)
			{
				var memberExpression = propertySelector.Body as MemberExpression;
				if (memberExpression == null)
				{
					var unaryExpression = propertySelector.Body as UnaryExpression;
					if (unaryExpression != null)
					{
						memberExpression = unaryExpression.Operand as MemberExpression;
						if (memberExpression == null)
							throw new NotSupportedException();
					}
					else
						throw new NotSupportedException();
				}
				return memberExpression.Member.Name;
			}

			//ncrunch: no coverage end
			#endregion
		}
	}
}
