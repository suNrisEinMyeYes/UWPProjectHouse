/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace class1
{
	[XmlRoot(ElementName = "businessEntity", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class BusinessEntity
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "enterprise", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class Enterprise
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "consignor", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Consignor
	{
		[XmlElement(ElementName = "businessEntity", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public BusinessEntity BusinessEntity { get; set; }
		[XmlElement(ElementName = "enterprise", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Enterprise Enterprise { get; set; }
	}

	[XmlRoot(ElementName = "consignee", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Consignee
	{
		[XmlElement(ElementName = "businessEntity", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public BusinessEntity BusinessEntity { get; set; }
		[XmlElement(ElementName = "enterprise", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Enterprise Enterprise { get; set; }
	}

	[XmlRoot(ElementName = "transportNumber", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class TransportNumber
	{
		[XmlElement(ElementName = "vehicleNumber", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string VehicleNumber { get; set; }
	}

	[XmlRoot(ElementName = "transportInfo", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class TransportInfo
	{
		[XmlElement(ElementName = "transportType", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string TransportType { get; set; }
		[XmlElement(ElementName = "transportNumber", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public TransportNumber TransportNumber { get; set; }
	}

	[XmlRoot(ElementName = "product", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Product
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "subProduct", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class SubProduct
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "productItem", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class ProductItem
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "globalID", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string GlobalID { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
		[XmlElement(ElementName = "code", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Code { get; set; }
	}

	[XmlRoot(ElementName = "unit", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Unit
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "firstDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class FirstDate
	{
		[XmlElement(ElementName = "year", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Year { get; set; }
		[XmlElement(ElementName = "month", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Month { get; set; }
		[XmlElement(ElementName = "day", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Day { get; set; }
	}

	[XmlRoot(ElementName = "dateOfProduction", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class DateOfProduction
	{
		[XmlElement(ElementName = "firstDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public FirstDate FirstDate { get; set; }
	}

	[XmlRoot(ElementName = "expiryDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class ExpiryDate
	{
		[XmlElement(ElementName = "firstDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public FirstDate FirstDate { get; set; }
	}

	[XmlRoot(ElementName = "country", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Country
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "producer", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Producer
	{
		[XmlElement(ElementName = "enterprise", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Enterprise Enterprise { get; set; }
		[XmlElement(ElementName = "role", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Role { get; set; }
	}

	[XmlRoot(ElementName = "origin", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Origin
	{
		[XmlElement(ElementName = "productItem", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public ProductItem ProductItem { get; set; }
		[XmlElement(ElementName = "country", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Country Country { get; set; }
		[XmlElement(ElementName = "producer", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Producer Producer { get; set; }
	}

	[XmlRoot(ElementName = "packingType", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class PackingType
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "globalID", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string GlobalID { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "productMarks", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class ProductMarks
	{
		[XmlAttribute(AttributeName = "class")]
		public string Class { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "package", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class Package
	{
		[XmlElement(ElementName = "level", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Level { get; set; }
		[XmlElement(ElementName = "packingType", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public PackingType PackingType { get; set; }
		[XmlElement(ElementName = "quantity", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Quantity { get; set; }
		[XmlElement(ElementName = "productMarks", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public ProductMarks ProductMarks { get; set; }
	}

	[XmlRoot(ElementName = "packageList", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class PackageList
	{
		[XmlElement(ElementName = "package", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Package Package { get; set; }
	}

	[XmlRoot(ElementName = "applicableClassifications", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class ApplicableClassifications
	{
		[XmlElement(ElementName = "nonFoodSource", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string NonFoodSource { get; set; }
	}

	[XmlRoot(ElementName = "batch", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Batch
	{
		[XmlElement(ElementName = "productType", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string ProductType { get; set; }
		[XmlElement(ElementName = "product", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Product Product { get; set; }
		[XmlElement(ElementName = "subProduct", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public SubProduct SubProduct { get; set; }
		[XmlElement(ElementName = "productItem", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public ProductItem ProductItem { get; set; }
		[XmlElement(ElementName = "volume", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Volume { get; set; }
		[XmlElement(ElementName = "unit", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Unit Unit { get; set; }
		[XmlElement(ElementName = "dateOfProduction", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public DateOfProduction DateOfProduction { get; set; }
		[XmlElement(ElementName = "expiryDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public ExpiryDate ExpiryDate { get; set; }
		[XmlElement(ElementName = "batchID", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string BatchID { get; set; }
		[XmlElement(ElementName = "perishable", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Perishable { get; set; }
		[XmlElement(ElementName = "origin", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Origin Origin { get; set; }
		[XmlElement(ElementName = "lowGradeCargo", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string LowGradeCargo { get; set; }
		[XmlElement(ElementName = "packageList", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public PackageList PackageList { get; set; }
		[XmlElement(ElementName = "applicableClassifications", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public ApplicableClassifications ApplicableClassifications { get; set; }
	}

	[XmlRoot(ElementName = "certifiedConsignment", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class CertifiedConsignment
	{
		[XmlElement(ElementName = "consignor", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Consignor Consignor { get; set; }
		[XmlElement(ElementName = "consignee", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Consignee Consignee { get; set; }
		[XmlElement(ElementName = "transportInfo", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public TransportInfo TransportInfo { get; set; }
		[XmlElement(ElementName = "transportStorageType", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string TransportStorageType { get; set; }
		[XmlElement(ElementName = "batch", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Batch Batch { get; set; }
	}

	[XmlRoot(ElementName = "purpose", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Purpose
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
	}

	[XmlRoot(ElementName = "operator", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Operator
	{
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "referencedDocument", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class ReferencedDocument
	{
		[XmlElement(ElementName = "type", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Type { get; set; }
		[XmlElement(ElementName = "issueNumber", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string IssueNumber { get; set; }
		[XmlElement(ElementName = "issueDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string IssueDate { get; set; }
		[XmlElement(ElementName = "relationshipType", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string RelationshipType { get; set; }
	}

	[XmlRoot(ElementName = "indicator", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Indicator
	{
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "laboratoryResearch", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class LaboratoryResearch
	{
		[XmlElement(ElementName = "ID", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string ID { get; set; }
		[XmlElement(ElementName = "type", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Type { get; set; }
		[XmlElement(ElementName = "actualDateTime", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string ActualDateTime { get; set; }
		[XmlElement(ElementName = "operator", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Operator Operator { get; set; }
		[XmlElement(ElementName = "referencedDocument", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public ReferencedDocument ReferencedDocument { get; set; }
		[XmlElement(ElementName = "expertiseID", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string ExpertiseID { get; set; }
		[XmlElement(ElementName = "indicator", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Indicator Indicator { get; set; }
		[XmlElement(ElementName = "result", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Result { get; set; }
		[XmlElement(ElementName = "conclusion", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Conclusion { get; set; }
	}

	[XmlRoot(ElementName = "authentication", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Authentication
	{
		[XmlElement(ElementName = "purpose", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Purpose Purpose { get; set; }
		[XmlElement(ElementName = "cargoInspected", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string CargoInspected { get; set; }
		[XmlElement(ElementName = "cargoExpertized", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string CargoExpertized { get; set; }
		[XmlElement(ElementName = "locationProsperity", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string LocationProsperity { get; set; }
		[XmlElement(ElementName = "laboratoryResearch", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public List<LaboratoryResearch> LaboratoryResearch { get; set; }
	}

	[XmlRoot(ElementName = "country", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class Country2
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "region", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class Region
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "guid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Guid { get; set; }
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "address", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
	public class Address
	{
		[XmlElement(ElementName = "country", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Country2 Country2 { get; set; }
		[XmlElement(ElementName = "region", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Region Region { get; set; }
		[XmlElement(ElementName = "addressView", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string AddressView { get; set; }
	}

	[XmlRoot(ElementName = "organization", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class Organization
	{
		[XmlElement(ElementName = "name", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public string Name { get; set; }
		[XmlElement(ElementName = "address", Namespace = "http://api.vetrf.ru/schema/cdm/dictionary/v2")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "specifiedPerson", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class SpecifiedPerson
	{
		[XmlElement(ElementName = "fio", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Fio { get; set; }
		[XmlElement(ElementName = "organization", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Organization Organization { get; set; }
		[XmlElement(ElementName = "workPhone", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string WorkPhone { get; set; }
	}

	[XmlRoot(ElementName = "statusChange", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class StatusChange
	{
		[XmlElement(ElementName = "status", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Status { get; set; }
		[XmlElement(ElementName = "specifiedPerson", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public SpecifiedPerson SpecifiedPerson { get; set; }
		[XmlElement(ElementName = "actualDateTime", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string ActualDateTime { get; set; }
		[XmlElement(ElementName = "reason", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string Reason { get; set; }
	}

	[XmlRoot(ElementName = "vetDocument", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class VetDocument
	{
		[XmlElement(ElementName = "uuid", Namespace = "http://api.vetrf.ru/schema/cdm/base")]
		public string Uuid { get; set; }
		[XmlElement(ElementName = "issueDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string IssueDate { get; set; }
		[XmlElement(ElementName = "vetDForm", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string VetDForm { get; set; }
		[XmlElement(ElementName = "vetDType", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string VetDType { get; set; }
		[XmlElement(ElementName = "vetDStatus", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string VetDStatus { get; set; }
		[XmlElement(ElementName = "lastUpdateDate", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public string LastUpdateDate { get; set; }
		[XmlElement(ElementName = "certifiedConsignment", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public CertifiedConsignment CertifiedConsignment { get; set; }
		[XmlElement(ElementName = "authentication", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public Authentication Authentication { get; set; }
		[XmlElement(ElementName = "referencedDocument", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public List<ReferencedDocument> ReferencedDocument { get; set; }
		[XmlElement(ElementName = "statusChange", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public List<StatusChange> StatusChange { get; set; }
	}

	[XmlRoot(ElementName = "vetDocumentList", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
	public class VetDocumentList
	{
		[XmlElement(ElementName = "vetDocument", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public List<VetDocument> VetDocument { get; set; }
		[XmlAttribute(AttributeName = "count")]
		public string Count { get; set; }
		[XmlAttribute(AttributeName = "total")]
		public string Total { get; set; }
		[XmlAttribute(AttributeName = "offset")]
		public string Offset { get; set; }
	}

	[XmlRoot(ElementName = "getVetDocumentChangesListResponse", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2")]
	public class GetVetDocumentChangesListResponse
	{
		[XmlElement(ElementName = "vetDocumentList", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2")]
		public VetDocumentList VetDocumentList { get; set; }
		[XmlAttribute(AttributeName = "ns1", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Ns1 { get; set; }
		[XmlAttribute(AttributeName = "bs", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Bs { get; set; }
		[XmlAttribute(AttributeName = "vd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Vd { get; set; }
		[XmlAttribute(AttributeName = "dt", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Dt { get; set; }
	}

	[XmlRoot(ElementName = "result", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
	public class Result
	{
		[XmlElement(ElementName = "getVetDocumentChangesListResponse", Namespace = "http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2")]
		public GetVetDocumentChangesListResponse GetVetDocumentChangesListResponse { get; set; }
	}

	[XmlRoot(ElementName = "application", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
	public class Application
	{
		[XmlElement(ElementName = "applicationId", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string ApplicationId { get; set; }
		[XmlElement(ElementName = "status", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string Status { get; set; }
		[XmlElement(ElementName = "serviceId", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string ServiceId { get; set; }
		[XmlElement(ElementName = "issuerId", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string IssuerId { get; set; }
		[XmlElement(ElementName = "issueDate", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string IssueDate { get; set; }
		[XmlElement(ElementName = "rcvDate", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string RcvDate { get; set; }
		[XmlElement(ElementName = "prdcRsltDate", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public string PrdcRsltDate { get; set; }
		[XmlElement(ElementName = "result", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public Result Result { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "receiveApplicationResultResponse", Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
	public class ReceiveApplicationResultResponse
	{
		[XmlElement(ElementName = "application", Namespace = "http://api.vetrf.ru/schema/cdm/application")]
		public Application Application { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public class Body
	{
		[XmlElement(ElementName = "receiveApplicationResultResponse", Namespace = "http://api.vetrf.ru/schema/cdm/application/ws-definitions")]
		public ReceiveApplicationResultResponse ReceiveApplicationResultResponse { get; set; }
	}

	[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
	public class Envelope
	{
		[XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
		public Body Body { get; set; }
		[XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Soap { get; set; }
	}

}
