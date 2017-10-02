using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.ConfigElement
{
    [ConfigurationCollection(typeof(PHPFrameworkElement), AddItemName = "testSetting", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class PHPFrameworkElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PHPFrameworkElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as PHPFrameworkElement).Name;
        }

        public new PHPFrameworkElement this[string type]
        {
            get
            {
                return (PHPFrameworkElement)base.BaseGet(type);
            }
        }
    }
}
