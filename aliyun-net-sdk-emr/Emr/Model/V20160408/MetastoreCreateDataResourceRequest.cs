/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class MetastoreCreateDataResourceRequest : RpcAcsRequest<MetastoreCreateDataResourceResponse>
    {
        public MetastoreCreateDataResourceRequest()
            : base("Emr", "2016-04-08", "MetastoreCreateDataResource", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private bool? _default;

		private string accessType;

		private string regionId;

		private string name;

		private string description;

		private string metaType;

		private string clusterId;

		private string accessKeyId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public bool? _Default
		{
			get
			{
				return _default;
			}
			set	
			{
				_default = value;
				DictionaryUtil.Add(QueryParameters, "Default", value.ToString());
			}
		}

		public string AccessType
		{
			get
			{
				return accessType;
			}
			set	
			{
				accessType = value;
				DictionaryUtil.Add(QueryParameters, "AccessType", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string MetaType
		{
			get
			{
				return metaType;
			}
			set	
			{
				metaType = value;
				DictionaryUtil.Add(QueryParameters, "MetaType", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override MetastoreCreateDataResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MetastoreCreateDataResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
