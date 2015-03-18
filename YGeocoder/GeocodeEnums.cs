

namespace Yandex
{
    public enum LangType : byte { ru_RU, uk_UA, be_BY, en_US, en_BR, tr_TR }

    public enum KindType : byte { house, street, metro, district, locality, area, province, country, hydro, railway, route, vegetation, airport, other }

    public enum PrecisionType : byte { exact, number, near, range, street, other }

    public enum ScoType : byte { longlat, latlong }
}
