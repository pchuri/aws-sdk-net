/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Listener Unmarshaller
     /// </summary>
    internal class ListenerUnmarshaller : IUnmarshaller<Listener, XmlUnmarshallerContext>, IUnmarshaller<Listener, JsonUnmarshallerContext> 
    {
        public Listener Unmarshall(XmlUnmarshallerContext context) 
        {
            Listener listener = new Listener();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Protocol", targetDepth))
                    {
                        listener.Protocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LoadBalancerPort", targetDepth))
                    {
                        listener.LoadBalancerPort = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("InstanceProtocol", targetDepth))
                    {
                        listener.InstanceProtocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("InstancePort", targetDepth))
                    {
                        listener.InstancePort = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SSLCertificateId", targetDepth))
                    {
                        listener.SSLCertificateId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listener;
                }
            }
                        


            return listener;
        }

        public Listener Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListenerUnmarshaller instance;

        public static ListenerUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListenerUnmarshaller();

            return instance;
        }
    }
}
    