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

/*
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Contains the PolicyType, PolicyId, and the ObjectIdentifier to which it is attached.
    /// </summary>
    public partial class PolicyAttachment
    {
        private string _objectIdentifier;
        private string _policyId;
        private string _policyType;

        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// The ObjectIdentifier associated with PolicyAttachment.
        /// </para>
        /// </summary>
        public string ObjectIdentifier
        {
            get { return this._objectIdentifier; }
            set { this._objectIdentifier = value; }
        }

        // Check to see if ObjectIdentifier property is set
        internal bool IsSetObjectIdentifier()
        {
            return this._objectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of PolicyAttachment.
        /// </para>
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that can be associated with PolicyAttachment.
        /// </para>
        /// </summary>
        public string PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}