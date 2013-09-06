using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateAttributes;

namespace ClassLibrary1
{
    public interface IClass2Parent
    {
        string ParentProperty { get; set; }
    }

    public interface IClass2Child
    {
        string ChildProperty { get; set; }
    }

    public interface IClass2ChildsChild
    {
        string ChildsChildProperty { get; set; }
    }

    [ImplementPropertyChangedCaliburn(typeof(IClass2Parent))]
    public partial class Class2Parent : IClass2Parent
    {
    }

    [ImplementPropertyChangedCaliburn(typeof(IClass2Child))]
    public partial class Class2Child : Class2Parent, IClass2Child
    {
    }

    [ImplementPropertyChangedCaliburn(typeof(IClass2ChildsChild))]
    public partial class Class2ChildsChild : Class2Child, IClass2ChildsChild
    {
    }
}
