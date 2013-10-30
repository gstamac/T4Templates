using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TemplateAttributes;

namespace ClassLibrary1.Namespace1
{
    public interface IClass1Properties 
    {
        string StringProperty { get; set; }
        int IntProperty { get; set; }
        string ReadOnlyStringProperty { get; }
        int ReadOnlyIntProperty { get; }
        string WriteOnlyStringProperty { set; }
        int WriteOnlyIntProperty { set; }
    }

    public interface IClass2Properties
    {
        string StringProperty2 { get; set; }
        int IntProperty2 { get; set; }
    }

    [ImplementNotifyPropertyChanged(typeof(IClass1Properties))]
    public partial class Class1 : IClass1Properties
    {
    }

    namespace Namespace2
    {
        [ImplementNotifyPropertyChangedAttribute(typeof(IClass2Properties))]
        public partial class Class2 : IClass2Properties
        {
            [ImplementNotifyPropertyChanged(typeof(IClass1Properties))]
            [ImplementNotifyPropertyChanged(typeof(IClass2Properties))]
            public partial class InnerClass2 : IClass1Properties, IClass2Properties
            {
            }

            [ImplementNotifyPropertyChanged(typeof(IClass2Properties))]
            public partial class InnerClass3 : IClass2Properties
            {
            }

            public partial class InnerClass4
            {
            }
        }
    }
}
