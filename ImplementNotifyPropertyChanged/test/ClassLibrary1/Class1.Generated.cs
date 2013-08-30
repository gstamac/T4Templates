using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace ClassLibrary1.Namespace1
{
	partial class Class1: INotifyPropertyChanged, INotifyPropertyChanging
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

		protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue)
		{
			if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
			RaisePropertyChanging(propertyName);
			propertyValue = newValue;
			RaisePropertyChanged(propertyName);
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

		#endregion
	}

	namespace Namespace2
	{
		partial class Class2: INotifyPropertyChanged, INotifyPropertyChanging
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

			partial class InnerClass2: INotifyPropertyChanged, INotifyPropertyChanging
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

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					RaisePropertyChanging(propertyName);
					propertyValue = newValue;
					RaisePropertyChanged(propertyName);
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

				#endregion
			}

			partial class InnerClass3: INotifyPropertyChanged, INotifyPropertyChanging
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

				protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue)
				{
					if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
					RaisePropertyChanging(propertyName);
					propertyValue = newValue;
					RaisePropertyChanged(propertyName);
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

				#endregion
			}

			partial class InnerClass4
			{
			}

			#region INotifyPropertyChanged implementation

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

			protected virtual void ChangeProperty<T>(string propertyName, ref T propertyValue, T newValue)
			{
				if ((propertyValue == null && newValue == null) || (propertyValue != null && propertyValue.Equals(newValue))) return;
				RaisePropertyChanging(propertyName);
				propertyValue = newValue;
				RaisePropertyChanged(propertyName);
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

			#endregion
		}
	}
}
