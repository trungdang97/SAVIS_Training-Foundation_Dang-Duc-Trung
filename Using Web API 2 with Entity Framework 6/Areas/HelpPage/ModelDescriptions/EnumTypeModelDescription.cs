using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Using_Web_API_2_with_Entity_Framework_6.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}