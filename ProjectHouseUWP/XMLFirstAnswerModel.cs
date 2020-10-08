// Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
public partial class Envelope
{

    private EnvelopeBody bodyField;

    /// <remarks/>
    public EnvelopeBody Body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody
{

    private submitApplicationResponse submitApplicationResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
    public submitApplicationResponse submitApplicationResponse
    {
        get
        {
            return this.submitApplicationResponseField;
        }
        set
        {
            this.submitApplicationResponseField = value;
        }
    }

    private receiveApplicationResultResponse receiveApplicationResultResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
    public receiveApplicationResultResponse receiveApplicationResultResponse
    {
        get
        {
            return this.receiveApplicationResultResponseField;
        }
        set
        {
            this.receiveApplicationResultResponseField = value;
        }
    }
}
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions", IsNullable = false)]
public partial class receiveApplicationResultResponse
{

    private application applicationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application")]
    public application application
    {
        get
        {
            return this.applicationField;
        }
        set
        {
            this.applicationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions", IsNullable = false)]
public partial class submitApplicationResponse
{

    private application applicationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application")]
    public application application
    {
        get
        {
            return this.applicationField;
        }
        set
        {
            this.applicationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/application")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/application", IsNullable = false)]
public partial class application
{

    private string applicationIdField;

    private string statusField;

    private string serviceIdField;

    private string issuerIdField;

    private System.DateTime issueDateField;

    private System.DateTime rcvDateField;

    /// <remarks/>
    public string applicationId
    {
        get
        {
            return this.applicationIdField;
        }
        set
        {
            this.applicationIdField = value;
        }
    }

    /// <remarks/>
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string serviceId
    {
        get
        {
            return this.serviceIdField;
        }
        set
        {
            this.serviceIdField = value;
        }
    }

    /// <remarks/>
    public string issuerId
    {
        get
        {
            return this.issuerIdField;
        }
        set
        {
            this.issuerIdField = value;
        }
    }

    /// <remarks/>
    public System.DateTime issueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    public System.DateTime rcvDate
    {
        get
        {
            return this.rcvDateField;
        }
        set
        {
            this.rcvDateField = value;
        }
    }
}
