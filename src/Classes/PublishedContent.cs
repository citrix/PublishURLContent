using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishContent.Classes
{
    class PublishedContent
    {
        public string name { get; set; }
        public string uuid { get; set; }
        public string commandlineexec { get; set; }
        public string commandlineargs { get; set; }
        public string browsername { get; set; }
        public int iconuid { get; set; }
        public Bitmap icon { get; set; }
        public string associateddesktopgroupuids { get; set; }
        public string description { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
