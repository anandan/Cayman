﻿using System;
using System.Runtime.Serialization;

namespace BlitsMe.Cloud.Messaging.Request
{
    [DataContract]
    public class LoginRq : API.Request
    {
        public override String type
        {
            get { return "Login-RQ"; }
            set { }
        }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string passwordDigest { get; set; }
        [DataMember]
        public string profile { get; set; }
        [DataMember]
        public string workstation { get; set; }
        [DataMember]
        public string version { get; set; }
    }
}
