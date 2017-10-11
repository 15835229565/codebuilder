using System;
using System.ComponentModel;
using CodeBuilder.Core.Source;

[SchemaExtension(typeof(Column))]
public class ColumnExtForEasyUI
{
    [Category("EasyUI")]
    [Description("EasyUI�ؼ����")]
    public EasyUIFieldType ControlType { get; set; }

    [Category("EasyUI")]
    [Description("�Ƿ�������")]
    [DefaultValue(true)]
    public bool GenerateField { get; set; }
}

public enum EasyUIFieldType
{
    TextBox,
    NumberBox,
    ComboBox,
    ComboTree,
    DateBox,
    DateTimeBox,
}