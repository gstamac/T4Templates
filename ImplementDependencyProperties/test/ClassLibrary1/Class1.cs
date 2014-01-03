using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TemplateAttributes;

namespace ClassLibrary1.Namespace1
{
    public interface IClass1Properties
    {
        string StringProperty { get; set; }
        int IntProperty { get; set; }
        float FloatProperty { get; set; }
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

    [ImplementDependencyProperties(typeof(IClass1Properties))]
    public partial class Class1 : DependencyObject, IClass1Properties
    {
        public static void OnStringPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void OnIntPropertyChanged()
        {

        }

        private void OnFloatPropertyChanged(float oldValue, float newValue)
        {

        }
    }

    namespace Namespace2
    {
        [ImplementDependencyProperties(typeof(IClass2Properties))]
        public partial class Class2 : DependencyObject, IClass2Properties
        {
            [ImplementDependencyProperties(typeof(IClass1Properties))]
            [ImplementDependencyProperties(typeof(IClass2Properties))]
            public partial class InnerClass2 : DependencyObject, IClass1Properties, IClass2Properties
            {
            }

            [ImplementDependencyProperties(typeof(IClass2Properties))]
            public partial class InnerClass3 : DependencyObject, IClass2Properties
            {
            }

            public partial class InnerClass4
            {
            }
        }
    }
}
