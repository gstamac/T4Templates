
using System;

//ncrunch: no coverage start
namespace TemplateAttributes
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	internal class ImplementDependencyPropertiesAttribute : Attribute
	{
		public ImplementDependencyPropertiesAttribute(Type aInterface)
		{
			Interface = aInterface;
		}
		public Type Interface { get; private set; }
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	internal class ImplementAttachedDependencyPropertiesAttribute : Attribute
	{
		public ImplementAttachedDependencyPropertiesAttribute(Type aInterface)
		{
			Interface = aInterface;
		}
		public Type Interface { get; private set; }
	}
}
//ncrunch: no coverage end
