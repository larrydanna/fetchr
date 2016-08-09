using System;
using System.Runtime.Serialization;

namespace fetchr.Entities
{
    [DataContract]
    public class Ask
    {
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}