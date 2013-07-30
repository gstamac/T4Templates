using System;

namespace TemplateAttributes
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	internal class ImplementNotifyPropertyChangedAttribute : Attribute
	{
		public ImplementNotifyPropertyChangedAttribute(Type aInterface)
		{
			Interface = aInterface;
		}
		public Type Interface { get; private set; }
	}
}
