using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataHubPOI.Models
{

    public class ODHActivityPoi
    {
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public object PreviousPage { get; set; }
        public string NextPage { get; set; }
        public object Seed { get; set; }
        public Item[] Items { get; set; }
    }

    public class Item
    {
        public string Id { get; set; }
        public string Self { get; set; }
        public string Type { get; set; }
        public int? AgeTo { get; set; }
        public object[] Areas { get; set; }
        public string SmgId { get; set; }
        public _Meta _Meta { get; set; }
        public bool Active { get; set; }
        public object AreaId { get; set; }
        public Detail Detail { get; set; }
        public bool? IsOpen { get; set; }
        public object Number { get; set; }
        public string Source { get; set; }
        public object Webcam { get; set; }
        public int? AgeFrom { get; set; }
        public object AreaIds { get; set; }
        public Gpsinfo[] GpsInfo { get; set; }
        public Ltstag[] LTSTags { get; set; }
        public Mapping Mapping { get; set; }
        public Odhtag[] ODHTags { get; set; }
        public string PoiType { get; set; }
        public object Ratings { get; set; }
        public string[] SmgTags { get; set; }
        public string SubType { get; set; }
        public object CustomId { get; set; }
        public object GpsTrack { get; set; }
        public object OwnerRid { get; set; }
        public object DishRates { get; set; }
        public bool? FeetClimb { get; set; }
        public Gpspoints GpsPoints { get; set; }
        public bool? Highlight { get; set; }
        public bool OdhActive { get; set; }
        public string Shortname { get; set; }
        public bool SmgActive { get; set; }
        public int? WayNumber { get; set; }
        public object Difficulty { get; set; }
        public object Exposition { get; set; }
        public object Facilities { get; set; }
        public bool? HasRentals { get; set; }
        public bool? IsPrepared { get; set; }
        public DateTime LastChange { get; set; }
        public object ChildPoiIds { get; set; }
        public DateTime FirstImport { get; set; }
        public string[] HasLanguage { get; set; }
        public bool? IsWithLigth { get; set; }
        public Licenseinfo LicenseInfo { get; set; }
        public Poiproperty PoiProperty { get; set; }
        public object[] PoiServices { get; set; }
        public string[] PublishedOn { get; set; }
        public bool? RunToValley { get; set; }
        public Contactinfos ContactInfos { get; set; }
        public Distanceinfo DistanceInfo { get; set; }
        public object[] ImageGallery { get; set; }
        public Locationinfo LocationInfo { get; set; }
        public object MasterPoiIds { get; set; }
        public float? AltitudeSumUp { get; set; }
        public bool? BikeTransport { get; set; }
        public object CategoryCodes { get; set; }
        public bool? LiftAvailable { get; set; }
        public float? DistanceLength { get; set; }
        public object RelatedContent { get; set; }
        public string SyncUpdateMode { get; set; }
        public float? AltitudeSumDown { get; set; }
        public bool? HasFreeEntrance { get; set; }
        public object OutdooractiveID { get; set; }
        public object CapacityCeremony { get; set; }
        public object CopyrightChecked { get; set; }
        public float? DistanceDuration { get; set; }
        public object AdditionalContact { get; set; }
        public object OperationSchedule { get; set; }
        public Additionalpoiinfos AdditionalPoiInfos { get; set; }
        public float? AltitudeDifference { get; set; }
        public int? MaxSeatingCapacity { get; set; }
        public float? AltitudeLowestPoint { get; set; }
        public Odhactivitypoitype[] ODHActivityPoiTypes { get; set; }
        public string SyncSourceInterface { get; set; }
        public float? AltitudeHighestPoint { get; set; }
        public string TourismorganizationId { get; set; }
        public object OutdooractiveElevationID { get; set; }
    }

    public class _Meta
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public bool Reduced { get; set; }
        public DateTime LastUpdate { get; set; }
    }

    public class Detail
    {
        public De de { get; set; }
        public En en { get; set; }
        public It it { get; set; }
    }

    public class De
    {
        public string Title { get; set; }
        public object Header { get; set; }
        public string BaseText { get; set; }
        public object Keywords { get; set; }
        public string Language { get; set; }
        public string MetaDesc { get; set; }
        public object AuthorTip { get; set; }
        public string IntroText { get; set; }
        public string MetaTitle { get; set; }
        public object SubHeader { get; set; }
        public object SafetyInfo { get; set; }
        public object ParkingInfo { get; set; }
        public object GetThereText { get; set; }
        public object EquipmentInfo { get; set; }
        public object AdditionalText { get; set; }
        public object PublicTransportationInfo { get; set; }
    }

    public class En
    {
        public string Title { get; set; }
        public object Header { get; set; }
        public string BaseText { get; set; }
        public object Keywords { get; set; }
        public string Language { get; set; }
        public string MetaDesc { get; set; }
        public object AuthorTip { get; set; }
        public object IntroText { get; set; }
        public string MetaTitle { get; set; }
        public object SubHeader { get; set; }
        public object SafetyInfo { get; set; }
        public object ParkingInfo { get; set; }
        public object GetThereText { get; set; }
        public object EquipmentInfo { get; set; }
        public object AdditionalText { get; set; }
        public object PublicTransportationInfo { get; set; }
    }

    public class It
    {
        public string Title { get; set; }
        public object Header { get; set; }
        public string BaseText { get; set; }
        public object Keywords { get; set; }
        public string Language { get; set; }
        public string MetaDesc { get; set; }
        public object AuthorTip { get; set; }
        public string IntroText { get; set; }
        public string MetaTitle { get; set; }
        public object SubHeader { get; set; }
        public object SafetyInfo { get; set; }
        public object ParkingInfo { get; set; }
        public object GetThereText { get; set; }
        public object EquipmentInfo { get; set; }
        public object AdditionalText { get; set; }
        public object PublicTransportationInfo { get; set; }
    }

    public class Mapping
    {
    }

    public class Gpspoints
    {
        public Position position { get; set; }
        public Startingandarrivalpoint startingandarrivalpoint { get; set; }
        public Arrivalpoint arrivalpoint { get; set; }
        public Startingpoint startingpoint { get; set; }
    }

    public class Position
    {
        public string Gpstype { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string AltitudeUnitofMeasure { get; set; }
    }

    public class Startingandarrivalpoint
    {
        public string Gpstype { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string AltitudeUnitofMeasure { get; set; }
    }

    public class Arrivalpoint
    {
        public string Gpstype { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string AltitudeUnitofMeasure { get; set; }
    }

    public class Startingpoint
    {
        public string Gpstype { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string AltitudeUnitofMeasure { get; set; }
    }

    public class Licenseinfo
    {
        public string Author { get; set; }
        public string License { get; set; }
        public bool ClosedData { get; set; }
        public string LicenseHolder { get; set; }
    }

    public class Poiproperty
    {
    }

    public class Contactinfos
    {
        public De1 de { get; set; }
        public En1 en { get; set; }
        public It1 it { get; set; }
    }

    public class De1
    {
        public object Tax { get; set; }
        public string Url { get; set; }
        public object Vat { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public object LogoUrl { get; set; }
        public object Surname { get; set; }
        public string ZipCode { get; set; }
        public string Language { get; set; }
        public object Faxnumber { get; set; }
        public object Givenname { get; set; }
        public object NamePrefix { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Phonenumber { get; set; }
    }

    public class En1
    {
        public object Tax { get; set; }
        public string Url { get; set; }
        public object Vat { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public object LogoUrl { get; set; }
        public object Surname { get; set; }
        public string ZipCode { get; set; }
        public string Language { get; set; }
        public object Faxnumber { get; set; }
        public object Givenname { get; set; }
        public object NamePrefix { get; set; }
        public string CompanyName { get; set; }
        public object CountryCode { get; set; }
        public object CountryName { get; set; }
        public string Phonenumber { get; set; }
    }

    public class It1
    {
        public object Tax { get; set; }
        public string Url { get; set; }
        public object Vat { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public object LogoUrl { get; set; }
        public object Surname { get; set; }
        public string ZipCode { get; set; }
        public string Language { get; set; }
        public object Faxnumber { get; set; }
        public object Givenname { get; set; }
        public object NamePrefix { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Phonenumber { get; set; }
    }

    public class Distanceinfo
    {
        public float DistanceToDistrict { get; set; }
        public float DistanceToMunicipality { get; set; }
    }

    public class Locationinfo
    {
        public Tvinfo TvInfo { get; set; }
        public object AreaInfo { get; set; }
        public Regioninfo RegionInfo { get; set; }
        public Districtinfo DistrictInfo { get; set; }
        public Municipalityinfo MunicipalityInfo { get; set; }
    }

    public class Tvinfo
    {
        public string Id { get; set; }
        public Name Name { get; set; }
        public string Self { get; set; }
    }

    public class Name
    {
        public string cs { get; set; }
        public string de { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string nl { get; set; }
        public string pl { get; set; }
        public string ru { get; set; }
    }

    public class Regioninfo
    {
        public string Id { get; set; }
        public Name1 Name { get; set; }
        public string Self { get; set; }
    }

    public class Name1
    {
        public string cs { get; set; }
        public string de { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string nl { get; set; }
        public string pl { get; set; }
        public string ru { get; set; }
    }

    public class Districtinfo
    {
        public string Id { get; set; }
        public Name2 Name { get; set; }
        public string Self { get; set; }
    }

    public class Name2
    {
        public string cs { get; set; }
        public string de { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string nl { get; set; }
        public string pl { get; set; }
        public string ru { get; set; }
    }

    public class Municipalityinfo
    {
        public string Id { get; set; }
        public Name3 Name { get; set; }
        public string Self { get; set; }
    }

    public class Name3
    {
        public string cs { get; set; }
        public string de { get; set; }
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string nl { get; set; }
        public string pl { get; set; }
        public string ru { get; set; }
    }

    public class Additionalpoiinfos
    {
        public Cs cs { get; set; }
        public De2 de { get; set; }
        public En2 en { get; set; }
        public Fr fr { get; set; }
        public It2 it { get; set; }
        public Nl nl { get; set; }
        public Pl pl { get; set; }
        public Ru ru { get; set; }
    }

    public class Cs
    {
        public string Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class De2
    {
        public object Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class En2
    {
        public object Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class Fr
    {
        public string Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class It2
    {
        public object Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class Nl
    {
        public string Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class Pl
    {
        public string Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class Ru
    {
        public string Novelty { get; set; }
        public string PoiType { get; set; }
        public string SubType { get; set; }
        public string Language { get; set; }
        public string MainType { get; set; }
        public string[] Categories { get; set; }
    }

    public class Gpsinfo
    {
        public string Gpstype { get; set; }
        public float Altitude { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string AltitudeUnitofMeasure { get; set; }
    }

    public class Ltstag
    {
        public string Id { get; set; }
        public string Self { get; set; }
        public int Level { get; set; }
        public string LTSRID { get; set; }
        public object LTSTins { get; set; }
        public Tagname TagName { get; set; }
    }

    public class Tagname
    {
        public string de { get; set; }
        public string en { get; set; }
        public string it { get; set; }
    }

    public class Odhtag
    {
        public string Id { get; set; }
        public string Self { get; set; }
    }

    public class Odhactivitypoitype
    {
        public string Id { get; set; }
        public string Self { get; set; }
        public string Type { get; set; }
    }

}
