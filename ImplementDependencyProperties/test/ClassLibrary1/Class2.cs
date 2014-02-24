using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TemplateAttributes;

namespace ClassLibrary1
{
    public interface IClass1Properties
    {
        int NothingProperty { get; set; }
        int DefValProperty { get; set; }
        int OptionProperty { get; set; }
        int ChangedProperty { get; set; }
        int DefValOptionProperty { get; set; }
        int DefValChangedProperty { get; set; }
        int OptionChangedProperty { get; set; }
        int DefValOptionChangedProperty { get; set; }
    }

    [ImplementDependencyProperties(typeof(IClass1Properties))]
    public partial class Class1 : DependencyObject
    {
        private const int DefValProperty_DEFAULT_VALUE = 190;
        private const int DefValOptionProperty_DEFAULT_VALUE = 190;
        private const int DefValChangedProperty_DEFAULT_VALUE = 190;
        private const int DefValOptionChangedProperty_DEFAULT_VALUE = 190;

        private const FrameworkPropertyMetadataOptions OptionProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;
        private const FrameworkPropertyMetadataOptions DefValOptionProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;
        private const FrameworkPropertyMetadataOptions OptionChangedProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;
        private const FrameworkPropertyMetadataOptions DefValOptionChangedProperty_OPTIONS = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault;

        public static void OnChangedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }
        public static void OnDefValChangedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }
        public static void OnOptionChangedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }
        public static void OnDefValOptionChangedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }

    }
}
