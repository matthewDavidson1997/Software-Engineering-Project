using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship_manager_administration_system
{
    class Idea
    {
        public String title, summary, description, instrument, majorSector, country, region, minorSector, productType, currency;
        public int riskRaiting;
        public DateTime expiary;
        public Idea(string title, string summary, string description, string instrument, string majorSector, string country, string region, string minorSector, string productType, int riskRaiting, DateTime expiary, string currency) {
            this.title = title;
            this.summary = summary;
            this.description = description;
            this.instrument = instrument;
            this.majorSector = majorSector;
            this.country = country;
            this.region = region;
            this.minorSector = minorSector;
            this.productType = productType;
            this.riskRaiting = riskRaiting;
            this.expiary = expiary;
            this.currency = currency;
        }
    }
}
