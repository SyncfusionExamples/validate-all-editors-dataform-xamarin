# How to validate all the editors of Xamarin.Forms DataForm (SfDataform)

You can validate all the editors of Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started) by using Validate method.

You can also refer the following article.

https://www.syncfusion.com/kb/11918/how-to-validate-all-the-editors-of-xamarin-forms-dataform-sfdataform

**C#**

You can validate all the properties using [Validate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~Validate().html) inside the **OnValidate** command handler.

``` c#
public DataFormViewModel()
{
    loginInfo = new DataFormModel();
    this.ValidateCommand = new Command<object>(this.OnValidate);
}
public Command<object> ValidateCommand { get; set; }
private void OnValidate(object dataForm)
{
    var dataFormLayout = dataForm as Syncfusion.XForms.DataForm.SfDataForm;
    dataFormLayout.Validate();
}
```

**XMAL**

**ValidateCommand** bind to **Button** form **ViewModel**

``` xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="0.9*"/>
        <RowDefinition Height="0.1*"/>
    </Grid.RowDefinitions>
    <dataForm:SfDataForm x:Name="dataForm" DataObject="{Binding LoginInfo}" Grid.Row="0" ValidationMode="LostFocus" CommitMode="LostFocus"/>
    <Button x:Name="validateButton" Grid.Row="1"  Text="Submit" 
        Command="{Binding Path=BindingContext.ValidateCommand, 
        Source={x:Reference Name=dataForm}}"                                                   
        CommandParameter="{Binding Source={x:Reference Name=dataForm}}"/>
</Grid>
```
**Output**

![ValidateAllDataForm](https://github.com/SyncfusionExamples/validate-all-editors-dataform-xamarin/blob/master/ScreenShot/ValidateAllDataForm.gif)
