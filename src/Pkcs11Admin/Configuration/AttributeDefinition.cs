

using System.Runtime.Serialization;

namespace Net.Pkcs11Admin.Configuration
{
    [DataContract(Namespace = Pkcs11AdminConfig.Namespace)]
    public class AttributeDefinition
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = true)]
        public ulong Value
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = false)]
        public string Description // TODO - How should this be used ???
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = true)]
        public AttributeType Type
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = false)]
        public string Enum
        {
            get;
            set;
        }
    }
}
