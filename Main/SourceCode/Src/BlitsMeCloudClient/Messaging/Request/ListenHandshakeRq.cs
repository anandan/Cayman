﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using BlitsMe.Cloud.Messaging.Elements;

namespace BlitsMe.Cloud.Messaging.Request
{
    [DataContract]
    public class ListenHandshakeRq : BlitsMe.Cloud.Messaging.API.UserToUserRequest
    {
        public override String type
        {
            get { return "ListenHandshake-RQ"; }
            set { }
        }

        public ListenHandshakeRq()
        {
            internalEndPoints = new List<IpEndPointElement>();
        }

        [DataMember]
        public String internalEndpointIp
        {
            get { return internalEndPoints == null || internalEndPoints.Count == 0 ? null : internalEndPoints[0].address; }
            set
            {
                if (value != null)
                {
                    if (internalEndPoints.Count == 0)
                    {
                        internalEndPoints.Add(new IpEndPointElement() {address = value});
                    }
                    else
                    {
                        internalEndPoints[0].address = value;
                    }
                }
            }
        }
        [DataMember]
        public int internalEndpointPort
        {
            get { return internalEndPoints == null || internalEndPoints.Count == 0 ? 0 : internalEndPoints[0].port; }
            set
            {
                if (value != 0)
                {
                    if (internalEndPoints.Count == 0)
                    {
                        internalEndPoints.Add(new IpEndPointElement() {port = value});
                    }
                    else
                    {
                        internalEndPoints[0].port = value;
                    }
                }
            }

        }
        [DataMember]
        public List<IpEndPointElement> internalEndPoints { get; set; }
        [DataMember]
        public String externalEndpointIp
        {
            get { return externalEndPoint == null ? null : externalEndPoint.address; }
            set
            {
                if (value != null)
                {
                    if (externalEndPoint == null)
                    {
                        externalEndPoint = new IpEndPointElement() {address = value};
                    }
                    else
                    {
                        externalEndPoint.address = value;
                    }
                }
            }
        }
        [DataMember]
        public int externalEndpointPort
        {
            get { return externalEndPoint == null ? 0 : externalEndPoint.port; }
            set
            {
                if (value != 0)
                {
                    if (externalEndPoint == null)
                    {
                        externalEndPoint = new IpEndPointElement() {port = value};
                    }
                    else
                    {
                        externalEndPoint.port = value;
                    }
                }
            }
        }

        [DataMember]
        public IpEndPointElement externalEndPoint { get; set; }
        [DataMember]
        public String uniqueId { get; set; }
    }
}
