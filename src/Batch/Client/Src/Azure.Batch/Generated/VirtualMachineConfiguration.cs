// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for compute nodes in a pool based on the Azure Virtual Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration : ITransportObjectProvider<Models.VirtualMachineConfiguration>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<ImageReference> ImageReferenceProperty;
            public readonly PropertyAccessor<string> NodeAgentSkuIdProperty;
            public readonly PropertyAccessor<OSDisk> OSDiskProperty;
            public readonly PropertyAccessor<WindowsConfiguration> WindowsConfigurationProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ImageReferenceProperty = this.CreatePropertyAccessor<ImageReference>("ImageReference", BindingAccess.Read | BindingAccess.Write);
                this.NodeAgentSkuIdProperty = this.CreatePropertyAccessor<string>("NodeAgentSkuId", BindingAccess.Read | BindingAccess.Write);
                this.OSDiskProperty = this.CreatePropertyAccessor<OSDisk>("OSDisk", BindingAccess.Read | BindingAccess.Write);
                this.WindowsConfigurationProperty = this.CreatePropertyAccessor<WindowsConfiguration>("WindowsConfiguration", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.VirtualMachineConfiguration protocolObject) : base(BindingState.Bound)
            {
                this.ImageReferenceProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ImageReference, o => new ImageReference(o)),
                    "ImageReference",
                    BindingAccess.Read | BindingAccess.Write);
                this.NodeAgentSkuIdProperty = this.CreatePropertyAccessor(
                    protocolObject.NodeAgentSKUId,
                    "NodeAgentSkuId",
                    BindingAccess.Read | BindingAccess.Write);
                this.OSDiskProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.OsDisk, o => new OSDisk(o)),
                    "OSDisk",
                    BindingAccess.Read | BindingAccess.Write);
                this.WindowsConfigurationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.WindowsConfiguration, o => new WindowsConfiguration(o)),
                    "WindowsConfiguration",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineConfiguration"/> class.
        /// </summary>
        /// <param name='nodeAgentSkuId'>The SKU of Batch Node Agent to be provisioned on the compute node.</param>
        /// <param name='imageReference'>A reference to the Azure Virtual Machines Marketplace image to use.</param>
        /// <param name='osDisk'>A reference to the OS disk image to use.</param>
        /// <param name='windowsConfiguration'>Windows operating system settings on the virtual machine. This property must not be specified if the ImageReference 
        /// property specifies a Linux OS image.</param>
        public VirtualMachineConfiguration(
            string nodeAgentSkuId,
            ImageReference imageReference = default(ImageReference),
            OSDisk osDisk = default(OSDisk),
            WindowsConfiguration windowsConfiguration = default(WindowsConfiguration))
        {
            this.propertyContainer = new PropertyContainer();
            this.NodeAgentSkuId = nodeAgentSkuId;
            this.ImageReference = imageReference;
            this.OSDisk = osDisk;
            this.WindowsConfiguration = windowsConfiguration;
        }

        internal VirtualMachineConfiguration(Models.VirtualMachineConfiguration protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region VirtualMachineConfiguration

        /// <summary>
        /// Gets or sets a reference to the Azure Virtual Machines Marketplace image to use.
        /// </summary>
        /// <remarks>
        /// This property and <see cref="OSDisk"/> are mutually exclusive and one of the properties must be specified.
        /// </remarks>
        public ImageReference ImageReference
        {
            get { return this.propertyContainer.ImageReferenceProperty.Value; }
            set { this.propertyContainer.ImageReferenceProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the SKU of Batch Node Agent to be provisioned on the compute node.
        /// </summary>
        /// <remarks>
        /// The Batch node agent is a program that runs on each node in the pool, and provides the command-and-control interface 
        /// between the node and the Batch service. There are different implementations of the node agent, known as SKUs, 
        /// for different operating systems.
        /// </remarks>
        public string NodeAgentSkuId
        {
            get { return this.propertyContainer.NodeAgentSkuIdProperty.Value; }
            set { this.propertyContainer.NodeAgentSkuIdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a reference to the OS disk image to use.
        /// </summary>
        /// <remarks>
        /// This property can be specified only if the Batch account was created with its poolAllocationMode property set 
        /// to 'UserSubscription'. This property and <see cref="ImageReference"/> are mutually exclusive and one of the properties 
        /// must be specified.
        /// </remarks>
        public OSDisk OSDisk
        {
            get { return this.propertyContainer.OSDiskProperty.Value; }
            set { this.propertyContainer.OSDiskProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets windows operating system settings on the virtual machine. This property must not be specified if 
        /// the ImageReference property specifies a Linux OS image.
        /// </summary>
        public WindowsConfiguration WindowsConfiguration
        {
            get { return this.propertyContainer.WindowsConfigurationProperty.Value; }
            set { this.propertyContainer.WindowsConfigurationProperty.Value = value; }
        }

        #endregion // VirtualMachineConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.VirtualMachineConfiguration ITransportObjectProvider<Models.VirtualMachineConfiguration>.GetTransportObject()
        {
            Models.VirtualMachineConfiguration result = new Models.VirtualMachineConfiguration()
            {
                ImageReference = UtilitiesInternal.CreateObjectWithNullCheck(this.ImageReference, (o) => o.GetTransportObject()),
                NodeAgentSKUId = this.NodeAgentSkuId,
                OsDisk = UtilitiesInternal.CreateObjectWithNullCheck(this.OSDisk, (o) => o.GetTransportObject()),
                WindowsConfiguration = UtilitiesInternal.CreateObjectWithNullCheck(this.WindowsConfiguration, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}