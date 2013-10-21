using System.Runtime.Serialization;

namespace BlitsMe.Cloud.Messaging.Elements
{
    [DataContract]
    public class ResultElement
    {
        [DataMember] public UserElement user = new UserElement();
    }

    //public class ResultElements
    //{
    //    public ResultElements()
    //    {
            
    //    }

    //    public UserElement user { get; set; }
    //}
}