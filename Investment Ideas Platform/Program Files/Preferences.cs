using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship_manager_administration_system
{
    class Preferences
    {
        public string majorSector, minorSector, currency, country, productType;
        public int riskRaiting;

        public Preferences(string majorSector, string minorSector, string currency, string country, string productType, int riskRaiting) {
            this.majorSector = majorSector;
            this.minorSector = minorSector;
            this.currency = currency;
            this.country = country;
            this.productType = productType;
            this.riskRaiting = riskRaiting;
        }
    }
}
