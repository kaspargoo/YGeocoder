using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
using System.Xml;

namespace Yandex
{
    public class GeoObjectCollection : IEnumerable<GeoObject>
    {
        List<GeoObject> _geo_objects;
        //ToDo:
            //GeocoderResponseMetaData

        public GeoObjectCollection()
        {
            _geo_objects = new List<GeoObject>();
        }

        public GeoObjectCollection(string xml)
        {
            _geo_objects = new List<GeoObject>();
            ParseXml(xml);
        }

        // ToDo: not best specification realise
        //       - null varibles and geo varibles
        //       - null response
        //       + ll,spn bounds
        private void ParseXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("ns", "http://maps.yandex.ru/ymaps/1.x");
            ns.AddNamespace("opengis", "http://www.opengis.net/gml");
            ns.AddNamespace("geocoder", "http://maps.yandex.ru/geocoder/1.x");
//            ns.AddNamespace("addressdetails", "urn:oasis:names:tc:ciq:xsdschema:xAL:2.0");

            // select geo objects
            XmlNodeList nodes = doc.SelectNodes("//ns:ymaps/ns:GeoObjectCollection/opengis:featureMember/ns:GeoObject", ns);
            foreach (XmlNode node in nodes)
            {
                var point_node = node.SelectSingleNode("opengis:Point/opengis:pos", ns);
                var bounds_node = node.SelectSingleNode("opengis:boundedBy/opengis:Envelope", ns);
                var meta_node = node.SelectSingleNode("opengis:metaDataProperty/geocoder:GeocoderMetaData", ns);

                GeoObject obj = new GeoObject {
                    Point = point_node == null ? new GeoPoint() : GeoPoint.Parse(point_node.InnerText),
                    BoundedBy = bounds_node == null ? new GeoBound() : new GeoBound(
                        GeoPoint.Parse(bounds_node["lowerCorner"].InnerText), GeoPoint.Parse(bounds_node["upperCorner"].InnerText)
                        ),
                    GeocoderMetaData = new GeoMetaData(meta_node["text"].InnerText, meta_node["kind"].InnerText, meta_node["precision"].InnerText)

                };
                _geo_objects.Add(obj);
            }
        }

        public GeoObject this[int i]
        {
            get
            {
                return _geo_objects[i];
            }
        }

        public IEnumerator<GeoObject> GetEnumerator()
        {
            return _geo_objects.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _geo_objects.GetEnumerator();
        }
    }

    public class GeoObject
    {
        public GeoPoint Point;
        public GeoBound BoundedBy;
        public GeoMetaData GeocoderMetaData;
    }

    public class GeoMetaData
    {
        public KindType Kind = KindType.other; //.locality;
        public PrecisionType Precision = PrecisionType.other;
        public string Text = string.Empty;
        public AddressDetails AddrDetails;
        //ToDo:
            //AddressDetails
        public GeoMetaData() { }
        public GeoMetaData(string text)
        {
            this.Text = text;
        }
        public GeoMetaData(string text, string kind, string precision)
        {
            this.Text = text;
            this.Kind = ParseKind(kind);
            this.Precision = ParsePrecision(precision);
            this.AddrDetails = new AddressDetails();
        }
        public GeoMetaData(string text, KindType kind, PrecisionType precision)
        {
            this.Text = text;
            this.Kind = kind;
            this.Precision = precision;
            this.AddrDetails = new AddressDetails();
        }

        public static KindType ParseKind(string kind)
        {
            KindType result;
            if (!Enum.TryParse<KindType>(kind, out result)) result = KindType.other;
            return result;
        }

        public static PrecisionType ParsePrecision(string precision)
        {
            PrecisionType result;
            if (!Enum.TryParse<PrecisionType>(precision, out result)) result = PrecisionType.other;
            return result;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public struct AddressDetails
    {
        public string countryNameCode, countryName, administrativeAreaName, subAdministrativeAreaName, localityName, thoroughfareName, premiseNumber;
    }
    
    public struct GeoPoint
    {
        public delegate string ToStringFunc(double x, double y);
        public double Long, Lat;

        public static GeoPoint Parse(string point)
        {
            string[] splitted = point.Split(new char[] { ' ' }, count: 2);
            return new GeoPoint(double.Parse(splitted[0], CultureInfo.InvariantCulture), double.Parse(splitted[1], CultureInfo.InvariantCulture));
        }

        public GeoPoint(double Long, double Lat)
        {
            this.Long = Long;
            this.Lat = Lat;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", this.Long.ToString(CultureInfo.InvariantCulture), this.Lat.ToString(CultureInfo.InvariantCulture));
        }
        public string ToString(string format)
        {
            return string.Format(format, this.Long.ToString(CultureInfo.InvariantCulture), this.Lat.ToString(CultureInfo.InvariantCulture));
        }

        public string ToString(ToStringFunc formatFunc)
        {
            return formatFunc(Long, Lat);
        }
    }

    public struct GeoBound
    {
        public GeoPoint LowerCorner, UpperCorner;
        public GeoBound(GeoPoint lowerCorner,GeoPoint upperCorner)
        {
            this.LowerCorner = lowerCorner;
            this.UpperCorner = upperCorner;
        }

        public override string ToString()
        {
            return string.Format("[{0}] [{1}]", LowerCorner.ToString(), UpperCorner.ToString());
        }
    }

    public struct SearchArea
    {
        public GeoPoint LongLat, Spread;
        public SearchArea(GeoPoint CenterLongLat, GeoPoint Spread)
        {
            this.LongLat = CenterLongLat;
            this.Spread = Spread;
        }
    }


}
