// Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
using System;
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

    private applicationResult resultField;

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
    public applicationResult result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

}
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/application")]
public partial class applicationResult
{

    private getVetDocumentChangesListResponse getVetDocumentChangesListResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2")]
    public getVetDocumentChangesListResponse getVetDocumentChangesListResponse
    {
        get
        {
            return this.getVetDocumentChangesListResponseField;
        }
        set
        {
            this.getVetDocumentChangesListResponseField = value;
        }
    }
}
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2", IsNullable = false)]
public partial class getVetDocumentChangesListResponse
{

    private vetDocumentList vetDocumentListField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
    public vetDocumentList vetDocumentList
    {
        get
        {
            return this.vetDocumentListField;
        }
        set
        {
            this.vetDocumentListField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2", IsNullable = false)]
public partial class vetDocumentList
{

    private vetDocumentListVetDocument[] vetDocumentField;

    private byte countField;

    private ushort totalField;

    private byte offsetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("vetDocument")]
    public vetDocumentListVetDocument[] vetDocument
    {
        get
        {
            return this.vetDocumentField;
        }
        set
        {
            this.vetDocumentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte offset
    {
        get
        {
            return this.offsetField;
        }
        set
        {
            this.offsetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocument
{

    private string uuidField;

    private System.DateTime issueDateField;

    private string vetDFormField;

    private string vetDTypeField;

    private string vetDStatusField;

    private System.DateTime lastUpdateDateField;

    private vetDocumentListVetDocumentCertifiedConsignment certifiedConsignmentField;

    private vetDocumentListVetDocumentAuthentication authenticationField;

    private vetDocumentListVetDocumentReferencedDocument[] referencedDocumentField;

    private vetDocumentListVetDocumentStatusChange[] statusChangeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
    public string vetDForm
    {
        get
        {
            return this.vetDFormField;
        }
        set
        {
            this.vetDFormField = value;
        }
    }

    /// <remarks/>
    public string vetDType
    {
        get
        {
            return this.vetDTypeField;
        }
        set
        {
            this.vetDTypeField = value;
        }
    }

    /// <remarks/>
    public string vetDStatus
    {
        get
        {
            return this.vetDStatusField;
        }
        set
        {
            this.vetDStatusField = value;
        }
    }

    /// <remarks/>
    public System.DateTime lastUpdateDate
    {
        get
        {
            return this.lastUpdateDateField;
        }
        set
        {
            this.lastUpdateDateField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignment certifiedConsignment
    {
        get
        {
            return this.certifiedConsignmentField;
        }
        set
        {
            this.certifiedConsignmentField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentAuthentication authentication
    {
        get
        {
            return this.authenticationField;
        }
        set
        {
            this.authenticationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("referencedDocument")]
    public vetDocumentListVetDocumentReferencedDocument[] referencedDocument
    {
        get
        {
            return this.referencedDocumentField;
        }
        set
        {
            this.referencedDocumentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("statusChange")]
    public vetDocumentListVetDocumentStatusChange[] statusChange
    {
        get
        {
            return this.statusChangeField;
        }
        set
        {
            this.statusChangeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignment
{

    private vetDocumentListVetDocumentCertifiedConsignmentConsignor consignorField;

    private vetDocumentListVetDocumentCertifiedConsignmentConsignee consigneeField;

    private vetDocumentListVetDocumentCertifiedConsignmentTransportInfo transportInfoField;

    private string transportStorageTypeField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatch batchField;

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentConsignor consignor
    {
        get
        {
            return this.consignorField;
        }
        set
        {
            this.consignorField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentConsignee consignee
    {
        get
        {
            return this.consigneeField;
        }
        set
        {
            this.consigneeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentTransportInfo transportInfo
    {
        get
        {
            return this.transportInfoField;
        }
        set
        {
            this.transportInfoField = value;
        }
    }

    /// <remarks/>
    public string transportStorageType
    {
        get
        {
            return this.transportStorageTypeField;
        }
        set
        {
            this.transportStorageTypeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatch batch
    {
        get
        {
            return this.batchField;
        }
        set
        {
            this.batchField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentConsignor
{

    private businessEntity businessEntityField;

    private enterprise enterpriseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public businessEntity businessEntity
    {
        get
        {
            return this.businessEntityField;
        }
        set
        {
            this.businessEntityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public enterprise enterprise
    {
        get
        {
            return this.enterpriseField;
        }
        set
        {
            this.enterpriseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2", IsNullable = false)]
public partial class businessEntity
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2", IsNullable = false)]
public partial class enterprise
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentConsignee
{

    private businessEntity businessEntityField;

    private enterprise enterpriseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public businessEntity businessEntity
    {
        get
        {
            return this.businessEntityField;
        }
        set
        {
            this.businessEntityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public enterprise enterprise
    {
        get
        {
            return this.enterpriseField;
        }
        set
        {
            this.enterpriseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentTransportInfo
{

    private byte transportTypeField;

    private vetDocumentListVetDocumentCertifiedConsignmentTransportInfoTransportNumber transportNumberField;

    /// <remarks/>
    public byte transportType
    {
        get
        {
            return this.transportTypeField;
        }
        set
        {
            this.transportTypeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentTransportInfoTransportNumber transportNumber
    {
        get
        {
            return this.transportNumberField;
        }
        set
        {
            this.transportNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentTransportInfoTransportNumber
{

    private string vehicleNumberField;

    /// <remarks/>
    public string vehicleNumber
    {
        get
        {
            return this.vehicleNumberField;
        }
        set
        {
            this.vehicleNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatch
{

    private byte productTypeField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchProduct productField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchSubProduct subProductField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchProductItem productItemField;

    private decimal volumeField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchUnit unitField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProduction dateOfProductionField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDate expiryDateField;

    private string batchIDField;

    private bool perishableField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchOrigin originField;

    private bool lowGradeCargoField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchPackageList packageListField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchApplicableClassifications applicableClassificationsField;

    /// <remarks/>
    public byte productType
    {
        get
        {
            return this.productTypeField;
        }
        set
        {
            this.productTypeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchProduct product
    {
        get
        {
            return this.productField;
        }
        set
        {
            this.productField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchSubProduct subProduct
    {
        get
        {
            return this.subProductField;
        }
        set
        {
            this.subProductField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchProductItem productItem
    {
        get
        {
            return this.productItemField;
        }
        set
        {
            this.productItemField = value;
        }
    }

    /// <remarks/>
    public decimal volume
    {
        get
        {
            return this.volumeField;
        }
        set
        {
            this.volumeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchUnit unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProduction dateOfProduction
    {
        get
        {
            return this.dateOfProductionField;
        }
        set
        {
            this.dateOfProductionField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDate expiryDate
    {
        get
        {
            return this.expiryDateField;
        }
        set
        {
            this.expiryDateField = value;
        }
    }

    /// <remarks/>
    public string batchID
    {
        get
        {
            return this.batchIDField;
        }
        set
        {
            this.batchIDField = value;
        }
    }

    /// <remarks/>
    public bool perishable
    {
        get
        {
            return this.perishableField;
        }
        set
        {
            this.perishableField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchOrigin origin
    {
        get
        {
            return this.originField;
        }
        set
        {
            this.originField = value;
        }
    }

    /// <remarks/>
    public bool lowGradeCargo
    {
        get
        {
            return this.lowGradeCargoField;
        }
        set
        {
            this.lowGradeCargoField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchPackageList packageList
    {
        get
        {
            return this.packageListField;
        }
        set
        {
            this.packageListField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchApplicableClassifications applicableClassifications
    {
        get
        {
            return this.applicableClassificationsField;
        }
        set
        {
            this.applicableClassificationsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchProduct
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchSubProduct
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchProductItem
{

    private string uuidField;

    private string guidField;

    private ulong globalIDField;

    private string nameField;

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public ulong globalID
    {
        get
        {
            return this.globalIDField;
        }
        set
        {
            this.globalIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchUnit
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProduction
{

    private vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProductionFirstDate firstDateField;

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProductionFirstDate firstDate
    {
        get
        {
            return this.firstDateField;
        }
        set
        {
            this.firstDateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchDateOfProductionFirstDate
{

    private ushort yearField;

    private byte monthField;

    private byte dayField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public ushort year
    {
        get
        {
            return this.yearField;
        }
        set
        {
            this.yearField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public byte month
    {
        get
        {
            return this.monthField;
        }
        set
        {
            this.monthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public byte day
    {
        get
        {
            return this.dayField;
        }
        set
        {
            this.dayField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDate
{

    private vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDateFirstDate firstDateField;

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDateFirstDate firstDate
    {
        get
        {
            return this.firstDateField;
        }
        set
        {
            this.firstDateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchExpiryDateFirstDate
{

    private ushort yearField;

    private byte monthField;

    private byte dayField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public ushort year
    {
        get
        {
            return this.yearField;
        }
        set
        {
            this.yearField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public byte month
    {
        get
        {
            return this.monthField;
        }
        set
        {
            this.monthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public byte day
    {
        get
        {
            return this.dayField;
        }
        set
        {
            this.dayField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchOrigin
{

    private vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProductItem productItemField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchOriginCountry countryField;

    private vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProducer producerField;

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProductItem productItem
    {
        get
        {
            return this.productItemField;
        }
        set
        {
            this.productItemField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchOriginCountry country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProducer producer
    {
        get
        {
            return this.producerField;
        }
        set
        {
            this.producerField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProductItem
{

    private string uuidField;

    private string guidField;

    private ulong globalIDField;

    private string nameField;

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public ulong globalID
    {
        get
        {
            return this.globalIDField;
        }
        set
        {
            this.globalIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchOriginCountry
{

    private string uuidField;

    private string guidField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchOriginProducer
{

    private enterprise enterpriseField;

    private string roleField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public enterprise enterprise
    {
        get
        {
            return this.enterpriseField;
        }
        set
        {
            this.enterpriseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchPackageList
{

    private package packageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public package package
    {
        get
        {
            return this.packageField;
        }
        set
        {
            this.packageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2", IsNullable = false)]
public partial class package
{

    private byte levelField;

    private packagePackingType packingTypeField;

    private ushort quantityField;

    private packageProductMarks productMarksField;

    /// <remarks/>
    public byte level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }

    /// <remarks/>
    public packagePackingType packingType
    {
        get
        {
            return this.packingTypeField;
        }
        set
        {
            this.packingTypeField = value;
        }
    }

    /// <remarks/>
    public ushort quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    public packageProductMarks productMarks
    {
        get
        {
            return this.productMarksField;
        }
        set
        {
            this.productMarksField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
public partial class packagePackingType
{

    private string uuidField;

    private string guidField;

    private string globalIDField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    public string globalID
    {
        get
        {
            return this.globalIDField;
        }
        set
        {
            this.globalIDField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
public partial class packageProductMarks
{

    private string classField;

    private ulong valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @class
    {
        get
        {
            return this.classField;
        }
        set
        {
            this.classField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ulong Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentCertifiedConsignmentBatchApplicableClassifications
{

    private string nonFoodSourceField;

    /// <remarks/>
    public string nonFoodSource
    {
        get
        {
            return this.nonFoodSourceField;
        }
        set
        {
            this.nonFoodSourceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthentication
{

    private vetDocumentListVetDocumentAuthenticationPurpose purposeField;

    private bool cargoInspectedField;

    private string cargoExpertizedField;

    private string locationProsperityField;

    private vetDocumentListVetDocumentAuthenticationLaboratoryResearch[] laboratoryResearchField;

    /// <remarks/>
    public vetDocumentListVetDocumentAuthenticationPurpose purpose
    {
        get
        {
            return this.purposeField;
        }
        set
        {
            this.purposeField = value;
        }
    }

    /// <remarks/>
    public bool cargoInspected
    {
        get
        {
            return this.cargoInspectedField;
        }
        set
        {
            this.cargoInspectedField = value;
        }
    }

    /// <remarks/>
    public string cargoExpertized
    {
        get
        {
            return this.cargoExpertizedField;
        }
        set
        {
            this.cargoExpertizedField = value;
        }
    }

    /// <remarks/>
    public string locationProsperity
    {
        get
        {
            return this.locationProsperityField;
        }
        set
        {
            this.locationProsperityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("laboratoryResearch")]
    public vetDocumentListVetDocumentAuthenticationLaboratoryResearch[] laboratoryResearch
    {
        get
        {
            return this.laboratoryResearchField;
        }
        set
        {
            this.laboratoryResearchField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthenticationPurpose
{

    private string uuidField;

    private string guidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthenticationLaboratoryResearch
{

    private string idField;

    private string typeField;

    private System.DateTime actualDateTimeField;

    private vetDocumentListVetDocumentAuthenticationLaboratoryResearchOperator operatorField;

    private vetDocumentListVetDocumentAuthenticationLaboratoryResearchReferencedDocument referencedDocumentField;

    private string expertiseIDField;

    private vetDocumentListVetDocumentAuthenticationLaboratoryResearchIndicator indicatorField;

    private string resultField;

    private string conclusionField;

    /// <remarks/>
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public System.DateTime actualDateTime
    {
        get
        {
            return this.actualDateTimeField;
        }
        set
        {
            this.actualDateTimeField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentAuthenticationLaboratoryResearchOperator @operator
    {
        get
        {
            return this.operatorField;
        }
        set
        {
            this.operatorField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentAuthenticationLaboratoryResearchReferencedDocument referencedDocument
    {
        get
        {
            return this.referencedDocumentField;
        }
        set
        {
            this.referencedDocumentField = value;
        }
    }

    /// <remarks/>
    public string expertiseID
    {
        get
        {
            return this.expertiseIDField;
        }
        set
        {
            this.expertiseIDField = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentAuthenticationLaboratoryResearchIndicator indicator
    {
        get
        {
            return this.indicatorField;
        }
        set
        {
            this.indicatorField = value;
        }
    }

    /// <remarks/>
    public string result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    public string conclusion
    {
        get
        {
            return this.conclusionField;
        }
        set
        {
            this.conclusionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthenticationLaboratoryResearchOperator
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthenticationLaboratoryResearchReferencedDocument
{

    private byte typeField;

    /// <remarks/>
    public byte type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentAuthenticationLaboratoryResearchIndicator
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentReferencedDocument
{

    private UInt16 issueNumberField;

    private System.DateTime issueDateField;

    private byte typeField;

    private byte relationshipTypeField;

    /// <remarks/>
    public UInt16 issueNumber
    {
        get
        {
            return this.issueNumberField;
        }
        set
        {
            this.issueNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
    public byte type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public byte relationshipType
    {
        get
        {
            return this.relationshipTypeField;
        }
        set
        {
            this.relationshipTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentStatusChange
{

    private string statusField;

    private vetDocumentListVetDocumentStatusChangeSpecifiedPerson specifiedPersonField;

    private System.DateTime actualDateTimeField;

    private string reasonField;

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
    public vetDocumentListVetDocumentStatusChangeSpecifiedPerson specifiedPerson
    {
        get
        {
            return this.specifiedPersonField;
        }
        set
        {
            this.specifiedPersonField = value;
        }
    }

    /// <remarks/>
    public System.DateTime actualDateTime
    {
        get
        {
            return this.actualDateTimeField;
        }
        set
        {
            this.actualDateTimeField = value;
        }
    }

    /// <remarks/>
    public string reason
    {
        get
        {
            return this.reasonField;
        }
        set
        {
            this.reasonField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentStatusChangeSpecifiedPerson
{

    private string fioField;

    private ulong workPhoneField;

    private bool workPhoneFieldSpecified;

    private vetDocumentListVetDocumentStatusChangeSpecifiedPersonOrganization organizationField;

    /// <remarks/>
    public string fio
    {
        get
        {
            return this.fioField;
        }
        set
        {
            this.fioField = value;
        }
    }

    /// <remarks/>
    public ulong workPhone
    {
        get
        {
            return this.workPhoneField;
        }
        set
        {
            this.workPhoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool workPhoneSpecified
    {
        get
        {
            return this.workPhoneFieldSpecified;
        }
        set
        {
            this.workPhoneFieldSpecified = value;
        }
    }

    /// <remarks/>
    public vetDocumentListVetDocumentStatusChangeSpecifiedPersonOrganization organization
    {
        get
        {
            return this.organizationField;
        }
        set
        {
            this.organizationField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
public partial class vetDocumentListVetDocumentStatusChangeSpecifiedPersonOrganization
{

    private string nameField;

    private address addressField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
    public address address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2", IsNullable = false)]
public partial class address
{

    private addressCountry countryField;

    private addressRegion regionField;

    private string addressViewField;

    /// <remarks/>
    public addressCountry country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public addressRegion region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }

    /// <remarks/>
    public string addressView
    {
        get
        {
            return this.addressViewField;
        }
        set
        {
            this.addressViewField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
public partial class addressCountry
{

    private string uuidField;

    private string guidField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
public partial class addressRegion
{

    private string uuidField;

    private string guidField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string uuid
    {
        get
        {
            return this.uuidField;
        }
        set
        {
            this.uuidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api.vetrf.ru/schema/cdm/base")]
    public string guid
    {
        get
        {
            return this.guidField;
        }
        set
        {
            this.guidField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}
