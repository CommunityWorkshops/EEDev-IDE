using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEDev_IDE.Data.Models
{
    internal class AvailableProjects
    {

        public string ProjectTypeName { get; set; }
        public string ProjectTypeVariationName { get; set; }
        public string ProjectTypeVariationAuthor { get; set; }
        public string ProjectTypeVariationVersion { get; set; }
        public string ProjectTypeVariationWebsite { get; set; }
        public string ProjectTypeVariationSupport { get; set; }

        public AvailableProjects(string boardType, string boardVersion, string author, string version, string website,
            string support)
        {
            ProjectTypeName = boardType;
            ProjectTypeVariationName = boardVersion;
            ProjectTypeVariationAuthor = author;
            ProjectTypeVariationVersion = version;
            ProjectTypeVariationWebsite = website;
            ProjectTypeVariationSupport = support;
        }


    }
}
