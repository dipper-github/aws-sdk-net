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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// BootstrapActionDetailUnmarshaller
      /// </summary>
      internal class BootstrapActionDetailUnmarshaller : IUnmarshaller<BootstrapActionDetail, XmlUnmarshallerContext>, IUnmarshaller<BootstrapActionDetail, JsonUnmarshallerContext>
      {
        BootstrapActionDetail IUnmarshaller<BootstrapActionDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public BootstrapActionDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            BootstrapActionDetail bootstrapActionDetail = new BootstrapActionDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("BootstrapActionConfig", targetDepth))
              {
                bootstrapActionDetail.BootstrapActionConfig = BootstrapActionConfigUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return bootstrapActionDetail;
        }

        private static BootstrapActionDetailUnmarshaller instance;
        public static BootstrapActionDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new BootstrapActionDetailUnmarshaller();
            return instance;
        }
    }
}
  