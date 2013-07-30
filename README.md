T4Templates
===========

T4 templates to use with T4Toolbox

Usage
-----

1. Install [T4Toolbox](http://t4toolbox.codeplex.com/)
2. Add template to a project (You can use NuGet)
3. Set "Custom Tool Template" to desired template

ImplementNotifyPropertyChanged.tt
---------------------------------

Define properties in an interface.

```c#
public interface IClass1Properties
{
    string StringProperty { get; set; }
    int IntProperty { get; set; }
}
```    
Define **partial** class with *ImplementNotifyPropertyChanged* attribute

```c#
[ImplementNotifyPropertyChanged(typeof(IClass1Properties))]
public partial class Class1 : IClass1Properties
{
}
```    
Properties will be generated with *NotifyPropertyChanging* and *NotifyPropertyChanged* events.

AddDataMsTests.tt
-----------------

Add **partial** keyword to a test class

```c#
[TestClass]
public partial class UnitTest1
{
```
Add a method to a test class with *DataTestMethod* attributes

```c#
[DataTestMethod("10", 10)]
[DataTestMethod("20", 20)]
[DataTestMethod("30", 30)]
private void DataTest(string stringParam, int intParam)
{
    Assert.AreEqual(intParam, Int32.Parse(stringParam));
}
```    
Test methods will be generated for each *DataTestMethod* attribute.

If you set the *Result* attribute property the result of a method will be asserted.

```c#
[DataTestMethod("10", Result = 10)]
[DataTestMethod("12", Result = 12)]
private int DataTestWithResult3(string stringParam)
{
    return Int32.Parse(stringParam);
}
```
Other properties of *DataTestMethod* attribute are:
* Message
* TestName
* Description
* ExpectedException
* Ignore
* Priority
* Timeout
* WorkItem

They translate to *MsTest* attributes. You can also use original attributes and they will be added to all generated 
tests. The attributes will still be overwritten with properties of *DataTestMethod* attribute. 
Description attribute will be formatted using test parameters and result.

```c#
[DataTestMethod("10", Result = 10, Priority = 3)]
[DataTestMethod("12", Result = 12)]
[Priority(10)]
[Description("Test for \"{0}\" should return {1}")]
private int DataTest(string stringParam)
{
    return Int32.Parse(stringParam);
}
```
Following test will be generated from this code.

```c#
[TestMethod]
[Priority(3)]
[Description("Test for \"10\" should return 10")]
public void DataTest_10_10()
{
    Assert.AreEqual(10, DataTest("10"));
}

[TestMethod]
[Description("Test for \"12\" should return 12")]
[Priority(10)]
public void DataTest_12_12()
{
    Assert.AreEqual(12, DataTest("12"));
}
```    
