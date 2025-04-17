using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class CustomerInfo
    {
        private string name;
        private string contactInfo;
        private string licenseInfo;
        private string insuranceInfo;

        public string Name { get { return name; } set { name = value; } }
        public string ContactInfo { get { return contactInfo; } set { contactInfo = value; } }
        public string LicenseInfo { get { return licenseInfo; } set { licenseInfo = value; } }
        public string InsuranceInfo { get {return insuranceInfo; } set { insuranceInfo = value; } }

    }
}
