// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> An Azure Machine Learning Model. </summary>
    public partial class Model
    {
        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="name"> The Model name. </param>
        /// <param name="url"> The URL of the Model. Usually a SAS URL. </param>
        /// <param name="mimeType"> The MIME type of Model content. For more details about MIME type, please open https://www.iana.org/assignments/media-types/media-types.xhtml. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="url"/>, or <paramref name="mimeType"/> is null. </exception>
        public Model(string name, string url, string mimeType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (mimeType == null)
            {
                throw new ArgumentNullException(nameof(mimeType));
            }

            Name = name;
            Datasets = new ChangeTrackingList<DatasetReference>();
            Url = url;
            MimeType = mimeType;
            KvTags = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
            DerivedModelIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="id"> The Model Id. </param>
        /// <param name="name"> The Model name. </param>
        /// <param name="framework"> The Model framework. </param>
        /// <param name="frameworkVersion"> The Model framework version. </param>
        /// <param name="version"> The Model version assigned by Model Management Service. </param>
        /// <param name="datasets"> The list of datasets associated with the model. </param>
        /// <param name="url"> The URL of the Model. Usually a SAS URL. </param>
        /// <param name="mimeType"> The MIME type of Model content. For more details about MIME type, please open https://www.iana.org/assignments/media-types/media-types.xhtml. </param>
        /// <param name="description"> The Model description text. </param>
        /// <param name="createdTime"> The Model creation time (UTC). </param>
        /// <param name="modifiedTime"> The Model last modified time (UTC). </param>
        /// <param name="unpack"> Indicates whether we need to unpack the Model during docker Image creation. </param>
        /// <param name="parentModelId"> The Parent Model Id. </param>
        /// <param name="runId"> The RunId that created this model. </param>
        /// <param name="experimentName"> The name of the experiment where this model was created. </param>
        /// <param name="kvTags"> The Model tag dictionary. Items are mutable. </param>
        /// <param name="properties"> The Model property dictionary. Properties are immutable. </param>
        /// <param name="derivedModelIds"> Models derived from this model. </param>
        /// <param name="sampleInputData"> Sample Input Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}. </param>
        /// <param name="sampleOutputData"> Sample Output Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}. </param>
        /// <param name="resourceRequirements"> Resource requirements for the model. </param>
        internal Model(string id, string name, string framework, string frameworkVersion, long? version, IList<DatasetReference> datasets, string url, string mimeType, string description, DateTimeOffset? createdTime, DateTimeOffset? modifiedTime, bool? unpack, string parentModelId, string runId, string experimentName, IDictionary<string, string> kvTags, IDictionary<string, string> properties, IList<string> derivedModelIds, string sampleInputData, string sampleOutputData, ContainerResourceRequirements resourceRequirements)
        {
            Id = id;
            Name = name;
            Framework = framework;
            FrameworkVersion = frameworkVersion;
            Version = version;
            Datasets = datasets;
            Url = url;
            MimeType = mimeType;
            Description = description;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            Unpack = unpack;
            ParentModelId = parentModelId;
            RunId = runId;
            ExperimentName = experimentName;
            KvTags = kvTags;
            Properties = properties;
            DerivedModelIds = derivedModelIds;
            SampleInputData = sampleInputData;
            SampleOutputData = sampleOutputData;
            ResourceRequirements = resourceRequirements;
        }

        /// <summary> The Model Id. </summary>
        public string Id { get; set; }
        /// <summary> The Model name. </summary>
        public string Name { get; set; }
        /// <summary> The Model framework. </summary>
        public string Framework { get; set; }
        /// <summary> The Model framework version. </summary>
        public string FrameworkVersion { get; set; }
        /// <summary> The Model version assigned by Model Management Service. </summary>
        public long? Version { get; set; }
        /// <summary> The list of datasets associated with the model. </summary>
        public IList<DatasetReference> Datasets { get; }
        /// <summary> The URL of the Model. Usually a SAS URL. </summary>
        public string Url { get; set; }
        /// <summary> The MIME type of Model content. For more details about MIME type, please open https://www.iana.org/assignments/media-types/media-types.xhtml. </summary>
        public string MimeType { get; set; }
        /// <summary> The Model description text. </summary>
        public string Description { get; set; }
        /// <summary> The Model creation time (UTC). </summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary> The Model last modified time (UTC). </summary>
        public DateTimeOffset? ModifiedTime { get; set; }
        /// <summary> Indicates whether we need to unpack the Model during docker Image creation. </summary>
        public bool? Unpack { get; set; }
        /// <summary> The Parent Model Id. </summary>
        public string ParentModelId { get; set; }
        /// <summary> The RunId that created this model. </summary>
        public string RunId { get; set; }
        /// <summary> The name of the experiment where this model was created. </summary>
        public string ExperimentName { get; set; }
        /// <summary> The Model tag dictionary. Items are mutable. </summary>
        public IDictionary<string, string> KvTags { get; }
        /// <summary> The Model property dictionary. Properties are immutable. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Models derived from this model. </summary>
        public IList<string> DerivedModelIds { get; }
        /// <summary> Sample Input Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}. </summary>
        public string SampleInputData { get; set; }
        /// <summary> Sample Output Data for the Model. A reference to a dataset in the workspace in the format aml://dataset/{datasetId}. </summary>
        public string SampleOutputData { get; set; }
        /// <summary> Resource requirements for the model. </summary>
        public ContainerResourceRequirements ResourceRequirements { get; set; }
    }
}
