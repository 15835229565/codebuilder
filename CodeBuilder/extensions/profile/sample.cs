using System.ComponentModel;

public class ProfileExt1
{
    [Description("�����ռ䡣")]
    public string Namespace { get; set; }
	
    [Description("��Ŀ���ơ�")]
    public string ProjectName { get; set; }
	
    [Description("��˾���ơ�")]
    public string CompanyName { get; set; }

    [Description("���ߡ�")]
    public string Author { get; set; }
    
    [Description("����ת�������滻����")]
    public string TableRegex { get; set; }
        
    [Description("�ֶ���ת�������滻����")]
    public string ColumneRegex { get; set; }

    [Description("Mvc����������ơ�")]
    public string MvcArea { get; set; }

    [Description("ʵ��ģ�͡�LighEntity ������ʵ�壻DependProperty ��������ģʽ��")]
    public EntityMode EntityMode { get; set; }

    [Description("������ʽ��Pascal ����ĸ��д����������-�ָ���������Extend ����ԭʼ���ơ�")]
    public NameMode NameMode { get; set; }
}

public enum EntityMode
{
    LighEntity,
    DependProperty
}

public enum NameMode
{
    Extend, //����
    Pascal //����ĸ��д����������-�ָ�������
}