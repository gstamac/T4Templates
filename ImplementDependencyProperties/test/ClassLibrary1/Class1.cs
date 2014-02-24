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
    [ImplementAttachedDependencyProperties(typeof(IInternalClassProperties))]
    public partial class Class1 : DependencyObject, IClass1Properties
    {
        private interface IInternalClassProperties
        {
            string StringProperty2 { get; set; }
            int IntProperty2 { get; set; }
        }

        private static string StringProperty_DEFAULT_VALUE = "";

        public static void OnStringPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }

        private const int IntProperty_DEFAULT_VALUE = 190;
        private const FrameworkPropertyMetadataOptions IntProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;

        private void OnIntPropertyChanged() { }

        private const FrameworkPropertyMetadataOptions FloatProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;

        private void OnFloatPropertyChanged(float oldValue, float newValue) { }

        private static string StringProperty2_DEFAULT_VALUE = "";

        public static void OnStringProperty2Changed(DependencyObject d, DependencyPropertyChangedEventArgs e) { }

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
