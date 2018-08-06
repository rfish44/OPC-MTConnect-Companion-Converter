/* ========================================================================
 * Copyright (c) 2005-2018 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.MTConnect
{
    #region CuttingToolsState Class
    #if (!OPCUA_EXCLUDE_CuttingToolsState)
    /// <summary>
    /// Stores an instance of the CuttingToolsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolsState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolsType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MTConnectVersion != null)
            {
                MTConnectVersion.Initialize(context, MTConnectVersion_InitializationString);
            }

            if (OPCUAMappingDate != null)
            {
                OPCUAMappingDate.Initialize(context, OPCUAMappingDate_InitializationString);
            }

            if (OPCUAVersion != null)
            {
                OPCUAVersion.Initialize(context, OPCUAVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string MTConnectVersion_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAE1UQ29ubmVjdFZlcnNpb24BAb46AC8AP746AAAADP////8BAf////8AAAAA";

        private const string OPCUAMappingDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAE9QQ1VBTWFwcGluZ0RhdGUBAb86AC8AP786AAAADf////8BAf////8AAAAA";

        private const string OPCUAVersion_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAE9QQ1VBVmVyc2lvbgEBwDoALwA/wDoAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GAAAAEN1dHRpbmdUb29sc1R5cGVJbnN0YW5jZQEBvToBAb06/////wMAAAAVYIkKAgAAAAEAEAAAAE1U" +
           "Q29ubmVjdFZlcnNpb24BAb46AC8AP746AAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABPUENV" +
           "QU1hcHBpbmdEYXRlAQG/OgAvAD+/OgAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAT1BDVUFW" +
           "ZXJzaW9uAQHAOgAvAD/AOgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MTConnectVersion Variable.
        /// </summary>
        public BaseDataVariableState<string> MTConnectVersion
        {
            get
            {
                return m_mTConnectVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTConnectVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTConnectVersion = value;
            }
        }

        /// <summary>
        /// A description for the OPCUAMappingDate Variable.
        /// </summary>
        public BaseDataVariableState<DateTime> OPCUAMappingDate
        {
            get
            {
                return m_oPCUAMappingDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAMappingDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAMappingDate = value;
            }
        }

        /// <summary>
        /// A description for the OPCUAVersion Variable.
        /// </summary>
        public BaseDataVariableState<string> OPCUAVersion
        {
            get
            {
                return m_oPCUAVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_oPCUAVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_oPCUAVersion = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTConnectVersion != null)
            {
                children.Add(m_mTConnectVersion);
            }

            if (m_oPCUAMappingDate != null)
            {
                children.Add(m_oPCUAMappingDate);
            }

            if (m_oPCUAVersion != null)
            {
                children.Add(m_oPCUAVersion);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MTConnectVersion:
                {
                    if (createOrReplace)
                    {
                        if (MTConnectVersion == null)
                        {
                            if (replacement == null)
                            {
                                MTConnectVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTConnectVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTConnectVersion;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.OPCUAMappingDate:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAMappingDate == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAMappingDate = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                OPCUAMappingDate = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = OPCUAMappingDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.OPCUAVersion:
                {
                    if (createOrReplace)
                    {
                        if (OPCUAVersion == null)
                        {
                            if (replacement == null)
                            {
                                OPCUAVersion = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                OPCUAVersion = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = OPCUAVersion;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTConnectVersion;
        private BaseDataVariableState<DateTime> m_oPCUAMappingDate;
        private BaseDataVariableState<string> m_oPCUAVersion;
        #endregion
    }
    #endif
    #endregion

    #region CuttingToolState Class
    #if (!OPCUA_EXCLUDE_CuttingToolState)
    /// <summary>
    /// Stores an instance of the CuttingToolType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }

            if (Conditions != null)
            {
                Conditions.Initialize(context, Conditions_InitializationString);
            }
        }

        #region Initialization String
        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQHHOgAuAETHOgAAAQAiAf////8BAf////8AAAAA";

        private const string Conditions_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CgAAAENvbmRpdGlvbnMBAco6AC8APco6AAD/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAEN1dHRpbmdUb29sVHlwZUluc3RhbmNlAQHBOgEBwTr/////CQAAABVgiQoCAAAAAQAMAAAAQXZh" +
           "aWxhYmlsaXR5AQHCOgAvAQA9CcI6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABNYW51ZmFj" +
           "dHVyZXIBAcU6AC4ARMU6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIB" +
           "AcY6AC4ARMY6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABTYW1wbGVJbnRlcnZhbAEBxzoA" +
           "LgBExzoAAAEAIgH/////AQH/////AAAAAARggAoBAAAAAQAJAAAARGF0YUl0ZW1zAQHIOgAvAD3IOgAA" +
           "/////wAAAAAEYIAKAQAAAAEACgAAAENvbXBvbmVudHMBAck6AC8APck6AAD/////AAAAAARggAoBAAAA" +
           "AQAKAAAAQ29uZGl0aW9ucwEByjoALwA9yjoAAP////8AAAAABGCACgEAAAABAAQAAABBeGVzAQG0OgAv" +
           "AQHXOrQ6AAD/////BQAAABVgiQoCAAAAAQABAAAAWAEBtToALwA/tToAAAAL/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAAQAAAFkBAbY6AC8AP7Y6AAAAC/////8BAf////8AAAAAFWCJCgIAAAABAAEAAABaAQG3" +
           "OgAvAD+3OgAAAAv/////AQH/////AAAAABVgiQoCAAAAAQABAAAAQwEBuDoALwA/uDoAAAAL/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEABQAAAFhMb2FkAQHBPQAvAQHOQsE9AAD/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBYj8DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARGI/AAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAWM/AwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERjPwAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBZD8DAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEZD8AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAWU/AwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEZT8AAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAWY/AwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARGY/AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFZ" +
           "SQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARFlJAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBWkkDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEWkkAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBW0kDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARFtJAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBXEkDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEXEkAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAV1JAC4ARF1JAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAV5JAC4ARF5JAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQFhSQAuAERhSQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAWJJAC4ARGJJAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAWNJAC4ARGNJ" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAWRJAC8BACMjZEkAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFlSQAuAERlSQAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBbUkALwEAKiNtSQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFuSQAuAERuSQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAW9JAC8BACojb0kAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBcEkALgBEcEkAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBcUkALwEAKiNxSQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFySQAuAERySQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AXNJAC4ARHNJAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQF0SQAvAQBEI3RJ" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAXVJAC8BAEMjdUkAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAXZJAC8BAEUjdkkAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQF3SQAuAER3SQAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBeEkALwA/eEkAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQF5SQAvAQAjI3lJAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBekkA" +
           "LgBEekkAAAAB/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAENvbnRyb2xsZXIBAYo9AC8BAY09ij0A" +
           "AP////8DAAAAFWCJCgIAAAABAA0AAABFbWVyZ2VuY3lTdG9wAQGLPQAvAQF2PIs9AAABAS49/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEABwAAAE1lc3NhZ2UBAYw9AC8BAYU8jD0AAAAM/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEABAAAAExpbmUBAa09AC8BAYA8rT0AAAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Availability Variable.
        /// </summary>
        public DataItemState<string> Availability
        {
            get
            {
                return m_availability;
            }

            set
            {
                if (!Object.ReferenceEquals(m_availability, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_availability = value;
            }
        }

        /// <summary>
        /// A description for the Manufacturer Property.
        /// </summary>
        public PropertyState<string> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <summary>
        /// A description for the SerialNumber Property.
        /// </summary>
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }

        /// <summary>
        /// A description for the DataItems Object.
        /// </summary>
        public FolderState DataItems
        {
            get
            {
                return m_dataItems;
            }

            set
            {
                if (!Object.ReferenceEquals(m_dataItems, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_dataItems = value;
            }
        }

        /// <summary>
        /// A description for the Components Object.
        /// </summary>
        public FolderState Components
        {
            get
            {
                return m_components;
            }

            set
            {
                if (!Object.ReferenceEquals(m_components, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_components = value;
            }
        }

        /// <summary>
        /// A description for the Conditions Object.
        /// </summary>
        public FolderState Conditions
        {
            get
            {
                return m_conditions;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conditions, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conditions = value;
            }
        }

        /// <summary>
        /// A description for the Axes Object.
        /// </summary>
        public CuttingToolAxesState Axes
        {
            get
            {
                return m_axes;
            }

            set
            {
                if (!Object.ReferenceEquals(m_axes, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_axes = value;
            }
        }

        /// <summary>
        /// A description for the Controller Object.
        /// </summary>
        public ControllerState Controller
        {
            get
            {
                return m_controller;
            }

            set
            {
                if (!Object.ReferenceEquals(m_controller, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_controller = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_availability != null)
            {
                children.Add(m_availability);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            if (m_dataItems != null)
            {
                children.Add(m_dataItems);
            }

            if (m_components != null)
            {
                children.Add(m_components);
            }

            if (m_conditions != null)
            {
                children.Add(m_conditions);
            }

            if (m_axes != null)
            {
                children.Add(m_axes);
            }

            if (m_controller != null)
            {
                children.Add(m_controller);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Availability:
                {
                    if (createOrReplace)
                    {
                        if (Availability == null)
                        {
                            if (replacement == null)
                            {
                                Availability = new DataItemState<string>(this);
                            }
                            else
                            {
                                Availability = (DataItemState<string>)replacement;
                            }
                        }
                    }

                    instance = Availability;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.DataItems:
                {
                    if (createOrReplace)
                    {
                        if (DataItems == null)
                        {
                            if (replacement == null)
                            {
                                DataItems = new FolderState(this);
                            }
                            else
                            {
                                DataItems = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DataItems;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Components:
                {
                    if (createOrReplace)
                    {
                        if (Components == null)
                        {
                            if (replacement == null)
                            {
                                Components = new FolderState(this);
                            }
                            else
                            {
                                Components = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Components;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Conditions:
                {
                    if (createOrReplace)
                    {
                        if (Conditions == null)
                        {
                            if (replacement == null)
                            {
                                Conditions = new FolderState(this);
                            }
                            else
                            {
                                Conditions = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Conditions;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Axes:
                {
                    if (createOrReplace)
                    {
                        if (Axes == null)
                        {
                            if (replacement == null)
                            {
                                Axes = new CuttingToolAxesState(this);
                            }
                            else
                            {
                                Axes = (CuttingToolAxesState)replacement;
                            }
                        }
                    }

                    instance = Axes;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Controller:
                {
                    if (createOrReplace)
                    {
                        if (Controller == null)
                        {
                            if (replacement == null)
                            {
                                Controller = new ControllerState(this);
                            }
                            else
                            {
                                Controller = (ControllerState)replacement;
                            }
                        }
                    }

                    instance = Controller;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private DataItemState<string> m_availability;
        private PropertyState<string> m_manufacturer;
        private PropertyState<string> m_serialNumber;
        private PropertyState<double> m_sampleInterval;
        private FolderState m_dataItems;
        private FolderState m_components;
        private FolderState m_conditions;
        private CuttingToolAxesState m_axes;
        private ControllerState m_controller;
        #endregion
    }
    #endif
    #endregion

    #region CuttingToolComponentState Class
    #if (!OPCUA_EXCLUDE_CuttingToolComponentState)
    /// <summary>
    /// Stores an instance of the CuttingToolComponentType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolComponentState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolComponentState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolComponentType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (Station != null)
            {
                Station.Initialize(context, Station_InitializationString);
            }
        }

        #region Initialization String
        private const string Model_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAE1vZGVsAQHVOgAuAETVOgAAAAz/////AQH/////AAAAAA==";

        private const string Station_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAFN0YXRpb24BAdY6AC4ARNY6AAABACIB/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAEN1dHRpbmdUb29sQ29tcG9uZW50VHlwZUluc3RhbmNlAQHLOgEByzr/////AgAAABVgiQoCAAAA" +
           "AQAFAAAATW9kZWwBAdU6AC4ARNU6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAcAAABTdGF0aW9u" +
           "AQHWOgAuAETWOgAAAQAiAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Model Property.
        /// </summary>
        public PropertyState<string> Model
        {
            get
            {
                return m_model;
            }

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        /// <summary>
        /// A description for the Station Property.
        /// </summary>
        public PropertyState<double> Station
        {
            get
            {
                return m_station;
            }

            set
            {
                if (!Object.ReferenceEquals(m_station, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_station = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_station != null)
            {
                children.Add(m_station);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<string>(this);
                            }
                            else
                            {
                                Model = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Station:
                {
                    if (createOrReplace)
                    {
                        if (Station == null)
                        {
                            if (replacement == null)
                            {
                                Station = new PropertyState<double>(this);
                            }
                            else
                            {
                                Station = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Station;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_model;
        private PropertyState<double> m_station;
        #endregion
    }
    #endif
    #endregion

    #region CuttingToolAxesState Class
    #if (!OPCUA_EXCLUDE_CuttingToolAxesState)
    /// <summary>
    /// Stores an instance of the CuttingToolAxesType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingToolAxesState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingToolAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CuttingToolAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAEN1dHRpbmdUb29sQXhlc1R5cGVJbnN0YW5jZQEB1zoBAdc6/////wUAAAAVYIkKAgAAAAEAAQAA" +
           "AFgBAbk6AC8AP7k6AAAAC/////8BAf////8AAAAAFWCJCgIAAAABAAEAAABZAQG6OgAvAD+6OgAAAAv/" +
           "////AQH/////AAAAABVgiQoCAAAAAQABAAAAWgEBuzoALwA/uzoAAAAL/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEAAQAAAEMBAbw6AC8AP7w6AAAAC/////8BAf////8AAAAABGCACgEAAAABAAUAAABYTG9hZAEB" +
           "yz0ALwEBzkLLPQAA/////xgAAAA1YIkKAgAAAAAABwAAAEV2ZW50SWQBAZJJAwAAAAArAAAAQSBnbG9i" +
           "YWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50LgAuAESSSQAAAA//////AQH/////AAAA" +
           "ADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGTSQMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdHlwZS4ALgBEk0kAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUB" +
           "AZRJAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARJRJAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGVSQMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNv" +
           "dXJjZSBvZiB0aGUgZXZlbnQuAC4ARJVJAAAADP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1l" +
           "AQGWSQMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3VycmVkLgAuAESWSQAAAQAmAf////8BAf////8A" +
           "AAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBl0kDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVj" +
           "ZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlpbmcgc3lzdGVtLgAuAESXSQAAAQAmAf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUBAZhJAwAAAAA8AAAASW5mb3JtYXRpb24gYWJv" +
           "dXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50IG9yaWdpbmF0ZWQuAC4ARJhJAAABANAi////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UBAZlJAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVz" +
           "Y3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAESZSQAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAA" +
           "U2V2ZXJpdHkBAZpJAwAAAAAhAAAASW5kaWNhdGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARJpJ" +
           "AAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lkAQGbSQAuAESbSQAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQGcSQAuAEScSQAA" +
           "ABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBn0kALgBEn0kAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElkAQGgSQAuAESgSQAAABH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAGAAAAUmV0YWluAQGhSQAuAEShSQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAARW5hYmxlZFN0YXRlAQGiSQAvAQAjI6JJAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBo0kALgBEo0kAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAatJAC8BACoj" +
           "q0kAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBrEkALgBErEkA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQGtSQAvAQAqI61JAAAA" +
           "Bf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAa5JAC4ARK5JAAABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1lbnQBAa9JAC8BACojr0kAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBsEkALgBEsEkAAAEAJgH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGxSQAuAESxSQAAAAz/////AQH/////AAAAAARh" +
           "ggoEAAAAAAAHAAAARGlzYWJsZQEBskkALwEARCOySQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAA" +
           "AAAGAAAARW5hYmxlAQGzSQAvAQBDI7NJAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABB" +
           "ZGRDb21tZW50AQG0SQAvAQBFI7RJAAABAQEAAAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1" +
           "dEFyZ3VtZW50cwEBtUkALgBEtUkAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAA" +
           "AAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABD" +
           "b21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9u" +
           "LgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAATVRDdXJyZW50U3RhdGUBAbZJAC8AP7ZJAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3RpdmVTdGF0ZQEBt0kALwEAIyO3SQAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAbhJAC4ARLhJAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the X Variable.
        /// </summary>
        public BaseDataVariableState<double> X
        {
            get
            {
                return m_x;
            }

            set
            {
                if (!Object.ReferenceEquals(m_x, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_x = value;
            }
        }

        /// <summary>
        /// A description for the Y Variable.
        /// </summary>
        public BaseDataVariableState<double> Y
        {
            get
            {
                return m_y;
            }

            set
            {
                if (!Object.ReferenceEquals(m_y, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_y = value;
            }
        }

        /// <summary>
        /// A description for the Z Variable.
        /// </summary>
        public BaseDataVariableState<double> Z
        {
            get
            {
                return m_z;
            }

            set
            {
                if (!Object.ReferenceEquals(m_z, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_z = value;
            }
        }

        /// <summary>
        /// A description for the C Variable.
        /// </summary>
        public BaseDataVariableState<double> C
        {
            get
            {
                return m_c;
            }

            set
            {
                if (!Object.ReferenceEquals(m_c, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_c = value;
            }
        }

        /// <summary>
        /// A description for the XLoad Object.
        /// </summary>
        public LoadConditionState XLoad
        {
            get
            {
                return m_xLoad;
            }

            set
            {
                if (!Object.ReferenceEquals(m_xLoad, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_xLoad = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_x != null)
            {
                children.Add(m_x);
            }

            if (m_y != null)
            {
                children.Add(m_y);
            }

            if (m_z != null)
            {
                children.Add(m_z);
            }

            if (m_c != null)
            {
                children.Add(m_c);
            }

            if (m_xLoad != null)
            {
                children.Add(m_xLoad);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.X:
                {
                    if (createOrReplace)
                    {
                        if (X == null)
                        {
                            if (replacement == null)
                            {
                                X = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                X = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = X;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Y:
                {
                    if (createOrReplace)
                    {
                        if (Y == null)
                        {
                            if (replacement == null)
                            {
                                Y = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Y = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Y;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Z:
                {
                    if (createOrReplace)
                    {
                        if (Z == null)
                        {
                            if (replacement == null)
                            {
                                Z = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Z = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Z;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.C:
                {
                    if (createOrReplace)
                    {
                        if (C == null)
                        {
                            if (replacement == null)
                            {
                                C = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                C = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = C;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.XLoad:
                {
                    if (createOrReplace)
                    {
                        if (XLoad == null)
                        {
                            if (replacement == null)
                            {
                                XLoad = new LoadConditionState(this);
                            }
                            else
                            {
                                XLoad = (LoadConditionState)replacement;
                            }
                        }
                    }

                    instance = XLoad;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_x;
        private BaseDataVariableState<double> m_y;
        private BaseDataVariableState<double> m_z;
        private BaseDataVariableState<double> m_c;
        private LoadConditionState m_xLoad;
        #endregion
    }
    #endif
    #endregion

    #region ControllerState Class
    #if (!OPCUA_EXCLUDE_ControllerState)
    /// <summary>
    /// Stores an instance of the ControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ControllerType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FgAAAENvbnRyb2xsZXJUeXBlSW5zdGFuY2UBAY09AQGNPf////8DAAAAFWCJCgIAAAABAA0AAABFbWVy" +
           "Z2VuY3lTdG9wAQGOPQAvAQF2PI49AAABAS49/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAE1lc3Nh" +
           "Z2UBAY89AC8BAYU8jz0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAExpbmUBAbI9AC8BAYA8" +
           "sj0AAAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the EmergencyStop Variable.
        /// </summary>
        public EmergencyStopState EmergencyStop
        {
            get
            {
                return m_emergencyStop;
            }

            set
            {
                if (!Object.ReferenceEquals(m_emergencyStop, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_emergencyStop = value;
            }
        }

        /// <summary>
        /// A description for the Message Variable.
        /// </summary>
        public MessageState Message
        {
            get
            {
                return m_message;
            }

            set
            {
                if (!Object.ReferenceEquals(m_message, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_message = value;
            }
        }

        /// <summary>
        /// A description for the Line Variable.
        /// </summary>
        public LineState Line
        {
            get
            {
                return m_line;
            }

            set
            {
                if (!Object.ReferenceEquals(m_line, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_line = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_emergencyStop != null)
            {
                children.Add(m_emergencyStop);
            }

            if (m_message != null)
            {
                children.Add(m_message);
            }

            if (m_line != null)
            {
                children.Add(m_line);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.EmergencyStop:
                {
                    if (createOrReplace)
                    {
                        if (EmergencyStop == null)
                        {
                            if (replacement == null)
                            {
                                EmergencyStop = new EmergencyStopState(this);
                            }
                            else
                            {
                                EmergencyStop = (EmergencyStopState)replacement;
                            }
                        }
                    }

                    instance = EmergencyStop;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Message:
                {
                    if (createOrReplace)
                    {
                        if (Message == null)
                        {
                            if (replacement == null)
                            {
                                Message = new MessageState(this);
                            }
                            else
                            {
                                Message = (MessageState)replacement;
                            }
                        }
                    }

                    instance = Message;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Line:
                {
                    if (createOrReplace)
                    {
                        if (Line == null)
                        {
                            if (replacement == null)
                            {
                                Line = new LineState(this);
                            }
                            else
                            {
                                Line = (LineState)replacement;
                            }
                        }
                    }

                    instance = Line;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private EmergencyStopState m_emergencyStop;
        private MessageState m_message;
        private LineState m_line;
        #endregion
    }
    #endif
    #endregion

    #region MTSampleDataItemState Class
    #if (!OPCUA_EXCLUDE_MTSampleDataItemState)
    /// <summary>
    /// Stores an instance of the MTSampleDataItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTSampleDataItemState : AnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MTSampleDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (NativeScale != null)
            {
                NativeScale.Initialize(context, NativeScale_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAENvb3JkaW5hdGVTeXN0ZW0BAac6AC4ARKc6AAABAas6/////wEB/////wAAAAA=";

        private const string NativeUnits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVVuaXRzAQGoOgAuAESoOgAAAQB3A/////8BAf////8AAAAA";

        private const string NativeScale_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVNjYWxlAQGpOgAuAESpOgAAAAr/////AQH/////AAAAAA==";

        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQGqOgAuAESqOgAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HAAAAE1UU2FtcGxlRGF0YUl0ZW1UeXBlSW5zdGFuY2UBAaE6AQGhOgAaAQH/////BQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBpToALgBEpToAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAQ29v" +
           "cmRpbmF0ZVN5c3RlbQEBpzoALgBEpzoAAAEBqzr/////AQH/////AAAAABVgiQoCAAAAAQALAAAATmF0" +
           "aXZlVW5pdHMBAag6AC4ARKg6AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE5hdGl2ZVNj" +
           "YWxlAQGpOgAuAESpOgAAAAr/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAU2FtcGxlSW50ZXJ2YWwB" +
           "Aao6AC4ARKo6AAABACIB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CoordinateSystem Property.
        /// </summary>
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <summary>
        /// A description for the NativeUnits Property.
        /// </summary>
        public PropertyState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <summary>
        /// A description for the NativeScale Property.
        /// </summary>
        public PropertyState<float> NativeScale
        {
            get
            {
                return m_nativeScale;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeScale, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeScale = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_nativeScale != null)
            {
                children.Add(m_nativeScale);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new PropertyState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (PropertyState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeScale:
                {
                    if (createOrReplace)
                    {
                        if (NativeScale == null)
                        {
                            if (replacement == null)
                            {
                                NativeScale = new PropertyState<float>(this);
                            }
                            else
                            {
                                NativeScale = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = NativeScale;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<EUInformation> m_nativeUnits;
        private PropertyState<float> m_nativeScale;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTSampleDataItemState<T> Class
    /// <summary>
    /// A typed version of the MTSampleDataItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTSampleDataItemState<T> : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MTSampleDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccelerationState Class
    #if (!OPCUA_EXCLUDE_AccelerationState)
    /// <summary>
    /// Stores an instance of the AccelerationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEFjY2VsZXJhdGlvblR5cGVJbnN0YW5jZQEBzDoBAcw6ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB0DoALgBE0DoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccelerationState<T> Class
    /// <summary>
    /// A typed version of the AccelerationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccelerationState<T> : AccelerationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AccumulatedTimeState Class
    #if (!OPCUA_EXCLUDE_AccumulatedTimeState)
    /// <summary>
    /// Stores an instance of the AccumulatedTimeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccumulatedTimeState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AccumulatedTimeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAEFjY3VtdWxhdGVkVGltZVR5cGVJbnN0YW5jZQEB2ToBAdk6ABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEB3ToALgBE3ToAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AccumulatedTimeState<T> Class
    /// <summary>
    /// A typed version of the AccumulatedTimeType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AccumulatedTimeState<T> : AccumulatedTimeState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AccumulatedTimeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AmperageState Class
    #if (!OPCUA_EXCLUDE_AmperageState)
    /// <summary>
    /// Stores an instance of the AmperageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AmperageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AmperageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAEFtcGVyYWdlVHlwZUluc3RhbmNlAQHjOgEB4zoAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQHnOgAuAETnOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AmperageState<T> Class
    /// <summary>
    /// A typed version of the AmperageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AmperageState<T> : AmperageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AmperageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngleState Class
    #if (!OPCUA_EXCLUDE_AngleState)
    /// <summary>
    /// Stores an instance of the AngleType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngleState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngleType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EQAAAEFuZ2xlVHlwZUluc3RhbmNlAQHtOgEB7ToAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHxOgAuAETxOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngleState<T> Class
    /// <summary>
    /// A typed version of the AngleType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngleState<T> : AngleState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngleState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularAccelerationState Class
    #if (!OPCUA_EXCLUDE_AngularAccelerationState)
    /// <summary>
    /// Stores an instance of the AngularAccelerationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularAccelerationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngularAccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HwAAAEFuZ3VsYXJBY2NlbGVyYXRpb25UeXBlSW5zdGFuY2UBAfc6AQH3OgAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAfs6AC4ARPs6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularAccelerationState<T> Class
    /// <summary>
    /// A typed version of the AngularAccelerationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularAccelerationState<T> : AngularAccelerationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngularAccelerationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AngularVelocityState Class
    #if (!OPCUA_EXCLUDE_AngularVelocityState)
    /// <summary>
    /// Stores an instance of the AngularVelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngularVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngularVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AngularVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAEFuZ3VsYXJWZWxvY2l0eVR5cGVJbnN0YW5jZQEBATsBAQE7ABr/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBBTsALgBEBTsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AngularVelocityState<T> Class
    /// <summary>
    /// A typed version of the AngularVelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AngularVelocityState<T> : AngularVelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AngularVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AxisFeedrateState Class
    #if (!OPCUA_EXCLUDE_AxisFeedrateState)
    /// <summary>
    /// Stores an instance of the AxisFeedrateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxisFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AxisFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF4aXNGZWVkcmF0ZVR5cGVJbnN0YW5jZQEBCzsBAQs7ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBDzsALgBEDzsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AxisFeedrateState<T> Class
    /// <summary>
    /// A typed version of the AxisFeedrateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AxisFeedrateState<T> : AxisFeedrateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AxisFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConcentrationState Class
    #if (!OPCUA_EXCLUDE_ConcentrationState)
    /// <summary>
    /// Stores an instance of the ConcentrationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConcentrationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ConcentrationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAENvbmNlbnRyYXRpb25UeXBlSW5zdGFuY2UBARU7AQEVOwAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBARk7AC4ARBk7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConcentrationState<T> Class
    /// <summary>
    /// A typed version of the ConcentrationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConcentrationState<T> : ConcentrationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ConcentrationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ConductivityState Class
    #if (!OPCUA_EXCLUDE_ConductivityState)
    /// <summary>
    /// Stores an instance of the ConductivityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConductivityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ConductivityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAENvbmR1Y3Rpdml0eVR5cGVJbnN0YW5jZQEBHzsBAR87ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBIzsALgBEIzsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ConductivityState<T> Class
    /// <summary>
    /// A typed version of the ConductivityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ConductivityState<T> : ConductivityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ConductivityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region DisplacementState Class
    #if (!OPCUA_EXCLUDE_DisplacementState)
    /// <summary>
    /// Stores an instance of the DisplacementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DisplacementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DisplacementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAERpc3BsYWNlbWVudFR5cGVJbnN0YW5jZQEBKTsBASk7ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBLTsALgBELTsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region DisplacementState<T> Class
    /// <summary>
    /// A typed version of the DisplacementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class DisplacementState<T> : DisplacementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public DisplacementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ElectricalEnergyState Class
    #if (!OPCUA_EXCLUDE_ElectricalEnergyState)
    /// <summary>
    /// Stores an instance of the ElectricalEnergyType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ElectricalEnergyState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ElectricalEnergyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HAAAAEVsZWN0cmljYWxFbmVyZ3lUeXBlSW5zdGFuY2UBATM7AQEzOwAa/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAABwAAAEVVUmFuZ2UBATc7AC4ARDc7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ElectricalEnergyState<T> Class
    /// <summary>
    /// A typed version of the ElectricalEnergyType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ElectricalEnergyState<T> : ElectricalEnergyState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ElectricalEnergyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FillLevelState Class
    #if (!OPCUA_EXCLUDE_FillLevelState)
    /// <summary>
    /// Stores an instance of the FillLevelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FillLevelState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FillLevelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FillLevelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEZpbGxMZXZlbFR5cGVJbnN0YW5jZQEBPTsBAT07ABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBQTsALgBEQTsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FillLevelState<T> Class
    /// <summary>
    /// A typed version of the FillLevelType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FillLevelState<T> : FillLevelState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FillLevelState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FlowState Class
    #if (!OPCUA_EXCLUDE_FlowState)
    /// <summary>
    /// Stores an instance of the FlowType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlowState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FlowType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAEZsb3dUeXBlSW5zdGFuY2UBAUc7AQFHOwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAUs7AC4AREs7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FlowState<T> Class
    /// <summary>
    /// A typed version of the FlowType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FlowState<T> : FlowState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FlowState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region FrequencyState Class
    #if (!OPCUA_EXCLUDE_FrequencyState)
    /// <summary>
    /// Stores an instance of the FrequencyType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FrequencyState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.FrequencyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEZyZXF1ZW5jeVR5cGVJbnN0YW5jZQEBWTsBAVk7ABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBXTsALgBEXTsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region FrequencyState<T> Class
    /// <summary>
    /// A typed version of the FrequencyType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class FrequencyState<T> : FrequencyState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public FrequencyState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LinearForceState Class
    #if (!OPCUA_EXCLUDE_LinearForceState)
    /// <summary>
    /// Stores an instance of the LinearForceType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LinearForceState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LinearForceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LinearForceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAExpbmVhckZvcmNlVHlwZUluc3RhbmNlAQFjOwEBYzsAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQFnOwAuAERnOwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LinearForceState<T> Class
    /// <summary>
    /// A typed version of the LinearForceType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LinearForceState<T> : LinearForceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LinearForceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LoadState Class
    #if (!OPCUA_EXCLUDE_LoadState)
    /// <summary>
    /// Stores an instance of the LoadType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LoadType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAExvYWRUeXBlSW5zdGFuY2UBAW07AQFtOwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAXE7AC4ARHE7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region LoadState<T> Class
    /// <summary>
    /// A typed version of the LoadType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LoadState<T> : LoadState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LoadState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MassState Class
    #if (!OPCUA_EXCLUDE_MassState)
    /// <summary>
    /// Stores an instance of the MassType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MassType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAE1hc3NUeXBlSW5zdGFuY2UBAXc7AQF3OwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAXs7AC4ARHs7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region MassState<T> Class
    /// <summary>
    /// A typed version of the MassType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MassState<T> : MassState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MassState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathFeedrateState Class
    #if (!OPCUA_EXCLUDE_PathFeedrateState)
    /// <summary>
    /// Stores an instance of the PathFeedrateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathFeedrateState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathFeedrateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAFBhdGhGZWVkcmF0ZVR5cGVJbnN0YW5jZQEBgTsBAYE7ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBhTsALgBEhTsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathFeedrateState<T> Class
    /// <summary>
    /// A typed version of the PathFeedrateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathFeedrateState<T> : PathFeedrateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PathFeedrateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PathPositionState Class
    #if (!OPCUA_EXCLUDE_PathPositionState)
    /// <summary>
    /// Stores an instance of the PathPositionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathPositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathPositionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathPositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAFBhdGhQb3NpdGlvblR5cGVJbnN0YW5jZQEBizsBAYs7ABr/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBjzsALgBEjzsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PathPositionState<T> Class
    /// <summary>
    /// A typed version of the PathPositionType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PathPositionState<T> : PathPositionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PathPositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PHState Class
    #if (!OPCUA_EXCLUDE_PHState)
    /// <summary>
    /// Stores an instance of the PHType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PHState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PHType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "DgAAAFBIVHlwZUluc3RhbmNlAQGVOwEBlTsAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQGZOwAuAESZOwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PHState<T> Class
    /// <summary>
    /// A typed version of the PHType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PHState<T> : PHState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PHState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PositionState Class
    #if (!OPCUA_EXCLUDE_PositionState)
    /// <summary>
    /// Stores an instance of the PositionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PositionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBvc2l0aW9uVHlwZUluc3RhbmNlAQGfOwEBnzsAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQGjOwAuAESjOwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PositionState<T> Class
    /// <summary>
    /// A typed version of the PositionType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PositionState<T> : PositionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PositionState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PowerFactorState Class
    #if (!OPCUA_EXCLUDE_PowerFactorState)
    /// <summary>
    /// Stores an instance of the PowerFactorType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerFactorState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PowerFactorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PowerFactorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFBvd2VyRmFjdG9yVHlwZUluc3RhbmNlAQGpOwEBqTsAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQGtOwAuAEStOwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PowerFactorState<T> Class
    /// <summary>
    /// A typed version of the PowerFactorType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PowerFactorState<T> : PowerFactorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PowerFactorState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region PressureState Class
    #if (!OPCUA_EXCLUDE_PressureState)
    /// <summary>
    /// Stores an instance of the PressureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PressureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFByZXNzdXJlVHlwZUluc3RhbmNlAQGzOwEBszsAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQG3OwAuAES3OwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region PressureState<T> Class
    /// <summary>
    /// A typed version of the PressureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class PressureState<T> : PressureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public PressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ResistanceState Class
    #if (!OPCUA_EXCLUDE_ResistanceState)
    /// <summary>
    /// Stores an instance of the ResistanceType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResistanceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ResistanceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFJlc2lzdGFuY2VUeXBlSW5zdGFuY2UBAb07AQG9OwAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAcE7AC4ARME7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ResistanceState<T> Class
    /// <summary>
    /// A typed version of the ResistanceType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ResistanceState<T> : ResistanceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ResistanceState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region RotationalVelocityState Class
    #if (!OPCUA_EXCLUDE_RotationalVelocityState)
    /// <summary>
    /// Stores an instance of the RotationalVelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotationalVelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.RotationalVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HgAAAFJvdGF0aW9uYWxWZWxvY2l0eVR5cGVJbnN0YW5jZQEBxzsBAcc7ABr/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEByzsALgBEyzsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region RotationalVelocityState<T> Class
    /// <summary>
    /// A typed version of the RotationalVelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class RotationalVelocityState<T> : RotationalVelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public RotationalVelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region SoundPressureState Class
    #if (!OPCUA_EXCLUDE_SoundPressureState)
    /// <summary>
    /// Stores an instance of the SoundPressureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SoundPressureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SoundPressureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.SoundPressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAFNvdW5kUHJlc3N1cmVUeXBlSW5zdGFuY2UBAdE7AQHROwAa/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAABwAAAEVVUmFuZ2UBAdU7AC4ARNU7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region SoundPressureState<T> Class
    /// <summary>
    /// A typed version of the SoundPressureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class SoundPressureState<T> : SoundPressureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public SoundPressureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region StrainState Class
    #if (!OPCUA_EXCLUDE_StrainState)
    /// <summary>
    /// Stores an instance of the StrainType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StrainState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.StrainType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFN0cmFpblR5cGVJbnN0YW5jZQEB2zsBAds7ABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEB3zsALgBE3zsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region StrainState<T> Class
    /// <summary>
    /// A typed version of the StrainType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class StrainState<T> : StrainState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public StrainState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TemperatureState Class
    #if (!OPCUA_EXCLUDE_TemperatureState)
    /// <summary>
    /// Stores an instance of the TemperatureType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TemperatureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFRlbXBlcmF0dXJlVHlwZUluc3RhbmNlAQHlOwEB5TsAGv////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQHpOwAuAETpOwAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TemperatureState<T> Class
    /// <summary>
    /// A typed version of the TemperatureType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TemperatureState<T> : TemperatureState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TemperatureState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TiltState Class
    #if (!OPCUA_EXCLUDE_TiltState)
    /// <summary>
    /// Stores an instance of the TiltType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TiltState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TiltType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAFRpbHRUeXBlSW5zdGFuY2UBAe87AQHvOwAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAfM7AC4ARPM7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TiltState<T> Class
    /// <summary>
    /// A typed version of the TiltType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TiltState<T> : TiltState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TiltState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region TorqueState Class
    #if (!OPCUA_EXCLUDE_TorqueState)
    /// <summary>
    /// Stores an instance of the TorqueType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TorqueState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.TorqueType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFRvcnF1ZVR5cGVJbnN0YW5jZQEB+TsBAfk7ABr/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEB/TsALgBE/TsAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region TorqueState<T> Class
    /// <summary>
    /// A typed version of the TorqueType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class TorqueState<T> : TorqueState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public TorqueState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VelocityState Class
    #if (!OPCUA_EXCLUDE_VelocityState)
    /// <summary>
    /// Stores an instance of the VelocityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VelocityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFZlbG9jaXR5VHlwZUluc3RhbmNlAQEDPAEBAzwAGv////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQEHPAAuAEQHPAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VelocityState<T> Class
    /// <summary>
    /// A typed version of the VelocityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VelocityState<T> : VelocityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VelocityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ViscosityState Class
    #if (!OPCUA_EXCLUDE_ViscosityState)
    /// <summary>
    /// Stores an instance of the ViscosityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ViscosityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ViscosityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAFZpc2Nvc2l0eVR5cGVJbnN0YW5jZQEBDTwBAQ08ABr/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEBETwALgBEETwAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region ViscosityState<T> Class
    /// <summary>
    /// A typed version of the ViscosityType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ViscosityState<T> : ViscosityState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ViscosityState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltageState Class
    #if (!OPCUA_EXCLUDE_VoltageState)
    /// <summary>
    /// Stores an instance of the VoltageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFZvbHRhZ2VUeXBlSW5zdGFuY2UBARc8AQEXPAAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBARs8AC4ARBs8AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltageState<T> Class
    /// <summary>
    /// A typed version of the VoltageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltageState<T> : VoltageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereState)
    /// <summary>
    /// Stores an instance of the VoltAmpereType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmpereState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltAmpereType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFZvbHRBbXBlcmVUeXBlSW5zdGFuY2UBASE8AQEhPAAa/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBASU8AC4ARCU8AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereState<T> Class
    /// <summary>
    /// A typed version of the VoltAmpereType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereState<T> : VoltAmpereState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltAmpereState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region VoltAmpereReactiveState Class
    #if (!OPCUA_EXCLUDE_VoltAmpereReactiveState)
    /// <summary>
    /// Stores an instance of the VoltAmpereReactiveType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmpereReactiveState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.VoltAmpereReactiveType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HgAAAFZvbHRBbXBlcmVSZWFjdGl2ZVR5cGVJbnN0YW5jZQEBKzwBASs8ABr/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBLzwALgBELzwAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region VoltAmpereReactiveState<T> Class
    /// <summary>
    /// A typed version of the VoltAmpereReactiveType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class VoltAmpereReactiveState<T> : VoltAmpereReactiveState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public VoltAmpereReactiveState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region WattageState Class
    #if (!OPCUA_EXCLUDE_WattageState)
    /// <summary>
    /// Stores an instance of the WattageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageState : MTSampleDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WattageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.WattageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFdhdHRhZ2VUeXBlSW5zdGFuY2UBATU8AQE1PAAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBATk8AC4ARDk8AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region WattageState<T> Class
    /// <summary>
    /// A typed version of the WattageType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class WattageState<T> : WattageState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public WattageState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MTEventDataItemState Class
    #if (!OPCUA_EXCLUDE_MTEventDataItemState)
    /// <summary>
    /// Stores an instance of the MTEventDataItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTEventDataItemState : DiscreteItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MTEventDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CoordinateSystem != null)
            {
                CoordinateSystem.Initialize(context, CoordinateSystem_InitializationString);
            }

            if (SampleInterval != null)
            {
                SampleInterval.Initialize(context, SampleInterval_InitializationString);
            }
        }

        #region Initialization String
        private const string CoordinateSystem_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EAAAAENvb3JkaW5hdGVTeXN0ZW0BAUI8AC4AREI8AAABAas6/////wEB/////wAAAAA=";

        private const string SampleInterval_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAFNhbXBsZUludGVydmFsAQFDPAAuAERDPAAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GwAAAE1URXZlbnREYXRhSXRlbVR5cGVJbnN0YW5jZQEBPzwBAT88ABj/////AQH/////AgAAABVgiQoC" +
           "AAAAAQAQAAAAQ29vcmRpbmF0ZVN5c3RlbQEBQjwALgBEQjwAAAEBqzr/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAOAAAAU2FtcGxlSW50ZXJ2YWwBAUM8AC4AREM8AAABACIB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CoordinateSystem Property.
        /// </summary>
        public PropertyState<CoordinateSystemTypeEnum> CoordinateSystem
        {
            get
            {
                return m_coordinateSystem;
            }

            set
            {
                if (!Object.ReferenceEquals(m_coordinateSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_coordinateSystem = value;
            }
        }

        /// <summary>
        /// A description for the SampleInterval Property.
        /// </summary>
        public PropertyState<double> SampleInterval
        {
            get
            {
                return m_sampleInterval;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sampleInterval, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sampleInterval = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_coordinateSystem != null)
            {
                children.Add(m_coordinateSystem);
            }

            if (m_sampleInterval != null)
            {
                children.Add(m_sampleInterval);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CoordinateSystem:
                {
                    if (createOrReplace)
                    {
                        if (CoordinateSystem == null)
                        {
                            if (replacement == null)
                            {
                                CoordinateSystem = new PropertyState<CoordinateSystemTypeEnum>(this);
                            }
                            else
                            {
                                CoordinateSystem = (PropertyState<CoordinateSystemTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CoordinateSystem;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.SampleInterval:
                {
                    if (createOrReplace)
                    {
                        if (SampleInterval == null)
                        {
                            if (replacement == null)
                            {
                                SampleInterval = new PropertyState<double>(this);
                            }
                            else
                            {
                                SampleInterval = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SampleInterval;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<CoordinateSystemTypeEnum> m_coordinateSystem;
        private PropertyState<double> m_sampleInterval;
        #endregion
    }

    #region MTEventDataItemState<T> Class
    /// <summary>
    /// A typed version of the MTEventDataItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MTEventDataItemState<T> : MTEventDataItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MTEventDataItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ActiveAxesState Class
    #if (!OPCUA_EXCLUDE_ActiveAxesState)
    /// <summary>
    /// Stores an instance of the ActiveAxesType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActiveAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActiveAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ActiveAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAEFjdGl2ZUF4ZXNUeXBlSW5zdGFuY2UBAUQ8AQFEPAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ActuatorStateState Class
    #if (!OPCUA_EXCLUDE_ActuatorStateState)
    /// <summary>
    /// Stores an instance of the ActuatorStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ActuatorStateState : MTEventDataItemState<ActuatorStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ActuatorStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ActuatorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ActuatorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAEFjdHVhdG9yU3RhdGVUeXBlSW5zdGFuY2UBAUk8AQFJPAEB+jz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AvailabilityState Class
    #if (!OPCUA_EXCLUDE_AvailabilityState)
    /// <summary>
    /// Stores an instance of the AvailabilityType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AvailabilityState : MTEventDataItemState<AvailabilityTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AvailabilityState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AvailabilityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.AvailabilityTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF2YWlsYWJpbGl0eVR5cGVJbnN0YW5jZQEBTjwBAU48AQECPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AxesCouplingState Class
    #if (!OPCUA_EXCLUDE_AxesCouplingState)
    /// <summary>
    /// Stores an instance of the AxesCouplingType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AxesCouplingState : MTEventDataItemState<AxesCouplingTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AxesCouplingState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AxesCouplingType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.AxesCouplingTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GAAAAEF4ZXNDb3VwbGluZ1R5cGVJbnN0YW5jZQEBUzwBAVM8AQEEPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BlockState Class
    #if (!OPCUA_EXCLUDE_BlockState)
    /// <summary>
    /// Stores an instance of the BlockType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlockState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BlockState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.BlockType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EQAAAEJsb2NrVHlwZUluc3RhbmNlAQFYPAEBWDwADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ClampStateState Class
    #if (!OPCUA_EXCLUDE_ClampStateState)
    /// <summary>
    /// Stores an instance of the ClampStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClampStateState : MTEventDataItemState<ClampStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ClampStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ClampStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ClampStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAENsYW1wU3RhdGVUeXBlSW5zdGFuY2UBAV08AQFdPAEBDT3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ControllerModeState Class
    #if (!OPCUA_EXCLUDE_ControllerModeState)
    /// <summary>
    /// Stores an instance of the ControllerModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ControllerModeState : MTEventDataItemState<ControllerModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ControllerModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ControllerModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ControllerModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GgAAAENvbnRyb2xsZXJNb2RlVHlwZUluc3RhbmNlAQFiPAEBYjwBARA9/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CoupledAxesState Class
    #if (!OPCUA_EXCLUDE_CoupledAxesState)
    /// <summary>
    /// Stores an instance of the CoupledAxesType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CoupledAxesState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CoupledAxesState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CoupledAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAENvdXBsZWRBeGVzVHlwZUluc3RhbmNlAQFnPAEBZzwADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionState Class
    #if (!OPCUA_EXCLUDE_DirectionState)
    /// <summary>
    /// Stores an instance of the DirectionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionState : MTEventDataItemState<DirectionTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DirectionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.DirectionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAERpcmVjdGlvblR5cGVJbnN0YW5jZQEBbDwBAWw8AQEnPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DoorStateState Class
    #if (!OPCUA_EXCLUDE_DoorStateState)
    /// <summary>
    /// Stores an instance of the DoorStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DoorStateState : MTEventDataItemState<DoorStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DoorStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.DoorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.DoorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAERvb3JTdGF0ZVR5cGVJbnN0YW5jZQEBcTwBAXE8AQEpPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region EmergencyStopState Class
    #if (!OPCUA_EXCLUDE_EmergencyStopState)
    /// <summary>
    /// Stores an instance of the EmergencyStopType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class EmergencyStopState : MTEventDataItemState<EmergencyStopTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public EmergencyStopState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.EmergencyStopType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.EmergencyStopTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAEVtZXJnZW5jeVN0b3BUeXBlSW5zdGFuY2UBAXY8AQF2PAEBLj3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ExecutionState Class
    #if (!OPCUA_EXCLUDE_ExecutionState)
    /// <summary>
    /// Stores an instance of the ExecutionType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ExecutionState : MTEventDataItemState<ExecutionTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ExecutionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ExecutionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ExecutionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAEV4ZWN1dGlvblR5cGVJbnN0YW5jZQEBezwBAXs8AQExPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LineState Class
    #if (!OPCUA_EXCLUDE_LineState)
    /// <summary>
    /// Stores an instance of the LineType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LineState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LineType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EAAAAExpbmVUeXBlSW5zdGFuY2UBAYA8AQGAPAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MessageState Class
    #if (!OPCUA_EXCLUDE_MessageState)
    /// <summary>
    /// Stores an instance of the MessageType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MessageState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MessageState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MessageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAE1lc3NhZ2VUeXBlSW5zdGFuY2UBAYU8AQGFPAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PalletIdState Class
    #if (!OPCUA_EXCLUDE_PalletIdState)
    /// <summary>
    /// Stores an instance of the PalletIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PalletIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PalletIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PalletIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBhbGxldElkVHlwZUluc3RhbmNlAQGKPAEBijwADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartCountState Class
    #if (!OPCUA_EXCLUDE_PartCountState)
    /// <summary>
    /// Stores an instance of the PartCountType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartCountState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PartCountState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PartCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FQAAAFBhcnRDb3VudFR5cGVJbnN0YW5jZQEBjzwBAY88AAX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PartIdState Class
    #if (!OPCUA_EXCLUDE_PartIdState)
    /// <summary>
    /// Stores an instance of the PartIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PartIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PartIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PartIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EgAAAFBhcnRJZFR5cGVJbnN0YW5jZQEBlDwBAZQ8AAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PathModeState Class
    #if (!OPCUA_EXCLUDE_PathModeState)
    /// <summary>
    /// Stores an instance of the PathModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PathModeState : MTEventDataItemState<PathModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PathModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PathModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.PathModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FAAAAFBhdGhNb2RlVHlwZUluc3RhbmNlAQGZPAEBmTwBAVU9/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PowerStateState Class
    #if (!OPCUA_EXCLUDE_PowerStateState)
    /// <summary>
    /// Stores an instance of the PowerStateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PowerStateState : MTEventDataItemState<PowerStateTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PowerStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.PowerStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.PowerStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFBvd2VyU3RhdGVUeXBlSW5zdGFuY2UBAZ48AQGePAEBVz3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ProgramState Class
    #if (!OPCUA_EXCLUDE_ProgramState)
    /// <summary>
    /// Stores an instance of the ProgramType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "EwAAAFByb2dyYW1UeXBlSW5zdGFuY2UBAaM8AQGjPAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RotaryModeState Class
    #if (!OPCUA_EXCLUDE_RotaryModeState)
    /// <summary>
    /// Stores an instance of the RotaryModeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RotaryModeState : MTEventDataItemState<RotaryModeTypeEnum>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RotaryModeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.RotaryModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.RotaryModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFJvdGFyeU1vZGVUeXBlSW5zdGFuY2UBAag8AQGoPAEBXj3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolAssetIdState Class
    #if (!OPCUA_EXCLUDE_ToolAssetIdState)
    /// <summary>
    /// Stores an instance of the ToolAssetIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolAssetIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ToolAssetIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ToolAssetIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAFRvb2xBc3NldElkVHlwZUluc3RhbmNlAQGtPAEBrTwADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ToolNumberState Class
    #if (!OPCUA_EXCLUDE_ToolNumberState)
    /// <summary>
    /// Stores an instance of the ToolNumberType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ToolNumberState : MTEventDataItemState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ToolNumberState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ToolNumberType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.UInt16, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FgAAAFRvb2xOdW1iZXJUeXBlSW5zdGFuY2UBAbI8AQGyPAAF/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WorkHoldingIdState Class
    #if (!OPCUA_EXCLUDE_WorkHoldingIdState)
    /// <summary>
    /// Stores an instance of the WorkHoldingIdType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WorkHoldingIdState : MTEventDataItemState<string>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WorkHoldingIdState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.WorkHoldingIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.String, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "GQAAAFdvcmtIb2xkaW5nSWRUeXBlSW5zdGFuY2UBAbc8AQG3PAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ChannelState Class
    #if (!OPCUA_EXCLUDE_ChannelState)
    /// <summary>
    /// Stores an instance of the ChannelType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ChannelState : BaseDataVariableState<ushort>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ChannelState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ChannelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.DataTypes.ChannelNumberDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (CalibrationDate != null)
            {
                CalibrationDate.Initialize(context, CalibrationDate_InitializationString);
            }

            if (NextCalibrationDate != null)
            {
                NextCalibrationDate.Initialize(context, NextCalibrationDate_InitializationString);
            }

            if (CalibrationInitials != null)
            {
                CalibrationInitials.Initialize(context, CalibrationInitials_InitializationString);
            }
        }

        #region Initialization String
        private const string CalibrationDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DwAAAENhbGlicmF0aW9uRGF0ZQEBvTwALgBEvTwAAAEBCD3/////AQH/////AAAAAA==";

        private const string NextCalibrationDate_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAE5leHRDYWxpYnJhdGlvbkRhdGUBAb48AC4ARL48AAABAQg9/////wEB/////wAAAAA=";

        private const string CalibrationInitials_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAENhbGlicmF0aW9uSW5pdGlhbHMBAb88AC4ARL88AAABAQk9/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "EwAAAENoYW5uZWxUeXBlSW5zdGFuY2UBAbw8AQG8PAEBDD0BAf////8DAAAAFWCJCgIAAAABAA8AAABD" +
           "YWxpYnJhdGlvbkRhdGUBAb08AC4ARL08AAABAQg9/////wEB/////wAAAAAVYIkKAgAAAAEAEwAAAE5l" +
           "eHRDYWxpYnJhdGlvbkRhdGUBAb48AC4ARL48AAABAQg9/////wEB/////wAAAAAVYIkKAgAAAAEAEwAA" +
           "AENhbGlicmF0aW9uSW5pdGlhbHMBAb88AC4ARL88AAABAQk9/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CalibrationDate Property.
        /// </summary>
        public PropertyState<string> CalibrationDate
        {
            get
            {
                return m_calibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationDate = value;
            }
        }

        /// <summary>
        /// A description for the NextCalibrationDate Property.
        /// </summary>
        public PropertyState<string> NextCalibrationDate
        {
            get
            {
                return m_nextCalibrationDate;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nextCalibrationDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nextCalibrationDate = value;
            }
        }

        /// <summary>
        /// A description for the CalibrationInitials Property.
        /// </summary>
        public PropertyState<string> CalibrationInitials
        {
            get
            {
                return m_calibrationInitials;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationInitials, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationInitials = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_calibrationDate != null)
            {
                children.Add(m_calibrationDate);
            }

            if (m_nextCalibrationDate != null)
            {
                children.Add(m_nextCalibrationDate);
            }

            if (m_calibrationInitials != null)
            {
                children.Add(m_calibrationInitials);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.CalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NextCalibrationDate:
                {
                    if (createOrReplace)
                    {
                        if (NextCalibrationDate == null)
                        {
                            if (replacement == null)
                            {
                                NextCalibrationDate = new PropertyState<string>(this);
                            }
                            else
                            {
                                NextCalibrationDate = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NextCalibrationDate;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.CalibrationInitials:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationInitials == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationInitials = new PropertyState<string>(this);
                            }
                            else
                            {
                                CalibrationInitials = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CalibrationInitials;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_calibrationDate;
        private PropertyState<string> m_nextCalibrationDate;
        private PropertyState<string> m_calibrationInitials;
        #endregion
    }
    #endif
    #endregion

    #region MeasurementState Class
    #if (!OPCUA_EXCLUDE_MeasurementState)
    /// <summary>
    /// Stores an instance of the MeasurementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeasurementState : AnalogItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.MeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (SignificantDigits != null)
            {
                SignificantDigits.Initialize(context, SignificantDigits_InitializationString);
            }

            if (Units != null)
            {
                Units.Initialize(context, Units_InitializationString);
            }

            if (NativeUnits != null)
            {
                NativeUnits.Initialize(context, NativeUnits_InitializationString);
            }

            if (LastChangeTimestamp != null)
            {
                LastChangeTimestamp.Initialize(context, LastChangeTimestamp_InitializationString);
            }

            if (Code != null)
            {
                Code.Initialize(context, Code_InitializationString);
            }

            if (Maximum != null)
            {
                Maximum.Initialize(context, Maximum_InitializationString);
            }

            if (Minimum != null)
            {
                Minimum.Initialize(context, Minimum_InitializationString);
            }

            if (Nominal != null)
            {
                Nominal.Initialize(context, Nominal_InitializationString);
            }
        }

        #region Initialization String
        private const string SignificantDigits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EQAAAFNpZ25pZmljYW50RGlnaXRzAQHGPAAuAETGPAAAAQFjPf////8BAf////8AAAAA";

        private const string Units_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAFVuaXRzAQHHPAAvAD/HPAAAAQB3A/////8BAf////8AAAAA";

        private const string NativeUnits_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAE5hdGl2ZVVuaXRzAQHIPAAvAD/IPAAAAQB3A/////8BAf////8AAAAA";

        private const string LastChangeTimestamp_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "EwAAAExhc3RDaGFuZ2VUaW1lc3RhbXABAck8AC4ARMk8AAAADf////8BAf////8AAAAA";

        private const string Code_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BAAAAENvZGUBAco8AC4ARMo8AAABARM9/////wEB/////wAAAAA=";

        private const string Maximum_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE1heGltdW0BAcs8AC4ARMs8AAABAUY9/////wEB/////wAAAAA=";

        private const string Minimum_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE1pbmltdW0BAcw8AC4ARMw8AAABAUY9/////wEB/////wAAAAA=";

        private const string Nominal_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BwAAAE5vbWluYWwBAc08AC4ARM08AAABAUY9/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "FwAAAE1lYXN1cmVtZW50VHlwZUluc3RhbmNlAQHAPAEBwDwAGv////8BAf////8JAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQHEPAAuAETEPAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABABEAAABTaWdu" +
           "aWZpY2FudERpZ2l0cwEBxjwALgBExjwAAAEBYz3/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5p" +
           "dHMBAcc8AC8AP8c8AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAE5hdGl2ZVVuaXRzAQHI" +
           "PAAvAD/IPAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAABABMAAABMYXN0Q2hhbmdlVGltZXN0YW1w" +
           "AQHJPAAuAETJPAAAAA3/////AQH/////AAAAABVgiQoCAAAAAQAEAAAAQ29kZQEByjwALgBEyjwAAAEB" +
           "Ez3/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEByzwALgBEyzwAAAEBRj3/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAHAAAATWluaW11bQEBzDwALgBEzDwAAAEBRj3/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAATm9taW5hbAEBzTwALgBEzTwAAAEBRj3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the SignificantDigits Property.
        /// </summary>
        public PropertyState SignificantDigits
        {
            get
            {
                return m_significantDigits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_significantDigits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_significantDigits = value;
            }
        }

        /// <summary>
        /// A description for the Units Variable.
        /// </summary>
        public BaseDataVariableState<EUInformation> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }

        /// <summary>
        /// A description for the NativeUnits Variable.
        /// </summary>
        public BaseDataVariableState<EUInformation> NativeUnits
        {
            get
            {
                return m_nativeUnits;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeUnits, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeUnits = value;
            }
        }

        /// <summary>
        /// A description for the LastChangeTimestamp Property.
        /// </summary>
        public PropertyState<DateTime> LastChangeTimestamp
        {
            get
            {
                return m_lastChangeTimestamp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lastChangeTimestamp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lastChangeTimestamp = value;
            }
        }

        /// <summary>
        /// A description for the Code Property.
        /// </summary>
        public PropertyState<string> Code
        {
            get
            {
                return m_code;
            }

            set
            {
                if (!Object.ReferenceEquals(m_code, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_code = value;
            }
        }

        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_significantDigits != null)
            {
                children.Add(m_significantDigits);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            if (m_nativeUnits != null)
            {
                children.Add(m_nativeUnits);
            }

            if (m_lastChangeTimestamp != null)
            {
                children.Add(m_lastChangeTimestamp);
            }

            if (m_code != null)
            {
                children.Add(m_code);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.SignificantDigits:
                {
                    if (createOrReplace)
                    {
                        if (SignificantDigits == null)
                        {
                            if (replacement == null)
                            {
                                SignificantDigits = new PropertyState(this);
                            }
                            else
                            {
                                SignificantDigits = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = SignificantDigits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                Units = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeUnits:
                {
                    if (createOrReplace)
                    {
                        if (NativeUnits == null)
                        {
                            if (replacement == null)
                            {
                                NativeUnits = new BaseDataVariableState<EUInformation>(this);
                            }
                            else
                            {
                                NativeUnits = (BaseDataVariableState<EUInformation>)replacement;
                            }
                        }
                    }

                    instance = NativeUnits;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LastChangeTimestamp:
                {
                    if (createOrReplace)
                    {
                        if (LastChangeTimestamp == null)
                        {
                            if (replacement == null)
                            {
                                LastChangeTimestamp = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                LastChangeTimestamp = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = LastChangeTimestamp;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Code:
                {
                    if (createOrReplace)
                    {
                        if (Code == null)
                        {
                            if (replacement == null)
                            {
                                Code = new PropertyState<string>(this);
                            }
                            else
                            {
                                Code = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Code;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_significantDigits;
        private BaseDataVariableState<EUInformation> m_units;
        private BaseDataVariableState<EUInformation> m_nativeUnits;
        private PropertyState<DateTime> m_lastChangeTimestamp;
        private PropertyState<string> m_code;
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region MeasurementState<T> Class
    /// <summary>
    /// A typed version of the MeasurementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class MeasurementState<T> : MeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public MeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CutterStatusState Class
    #if (!OPCUA_EXCLUDE_CutterStatusState)
    /// <summary>
    /// Stores an instance of the CutterStatusType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CutterStatusState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CutterStatusState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CutterStatusType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GAAAAEN1dHRlclN0YXR1c1R5cGVJbnN0YW5jZQEBzjwBAc48ABgBAf////8BAAAAFWCJCgIAAAABAAYA" +
           "AABTdGF0dXMBAc88AC4ARM88AAAADP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Status Property.
        /// </summary>
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_status != null)
            {
                children.Add(m_status);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new PropertyState<string>(this);
                            }
                            else
                            {
                                Status = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Status;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_status;
        #endregion
    }

    #region CutterStatusState<T> Class
    /// <summary>
    /// A typed version of the CutterStatusType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CutterStatusState<T> : CutterStatusState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public CutterStatusState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ReconditionCountState Class
    #if (!OPCUA_EXCLUDE_ReconditionCountState)
    /// <summary>
    /// Stores an instance of the ReconditionCountType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReconditionCountState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReconditionCountState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ReconditionCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (MaximumCount != null)
            {
                MaximumCount.Initialize(context, MaximumCount_InitializationString);
            }
        }

        #region Initialization String
        private const string MaximumCount_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAE1heGltdW1Db3VudAEB0TwALgBE0TwAAAEBRD3/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HAAAAFJlY29uZGl0aW9uQ291bnRUeXBlSW5zdGFuY2UBAdA8AQHQPAAYAQH/////AQAAABVgiQoCAAAA" +
           "AQAMAAAATWF4aW11bUNvdW50AQHRPAAuAETRPAAAAQFEPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MaximumCount Property.
        /// </summary>
        public PropertyState MaximumCount
        {
            get
            {
                return m_maximumCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximumCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximumCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximumCount != null)
            {
                children.Add(m_maximumCount);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MaximumCount:
                {
                    if (createOrReplace)
                    {
                        if (MaximumCount == null)
                        {
                            if (replacement == null)
                            {
                                MaximumCount = new PropertyState(this);
                            }
                            else
                            {
                                MaximumCount = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = MaximumCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_maximumCount;
        #endregion
    }

    #region ReconditionCountState<T> Class
    /// <summary>
    /// A typed version of the ReconditionCountType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ReconditionCountState<T> : ReconditionCountState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ReconditionCountState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LifeState Class
    #if (!OPCUA_EXCLUDE_LifeState)
    /// <summary>
    /// Stores an instance of the LifeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LifeState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LifeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LifeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (WarningLevel != null)
            {
                WarningLevel.Initialize(context, WarningLevel_InitializationString);
            }
        }

        #region Initialization String
        private const string WarningLevel_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DAAAAFdhcm5pbmdMZXZlbAEB1TwALgBE1TwAAAEBcT3/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "EAAAAExpZmVUeXBlSW5zdGFuY2UBAdI8AQHSPAAYAQH/////BAAAABVgiQoCAAAAAQAEAAAAVHlwZQEB" +
           "0zwALgBE0zwAAAEBbz3/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQ291bnREaXJlY3Rpb24BAdQ8" +
           "AC4ARNQ8AAABAW09/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFdhcm5pbmdMZXZlbAEB1TwALgBE" +
           "1TwAAAEBcT3/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATWF4aW11bQEB1jwALgBE1jwAAAEBcT3/" +
           "////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Type Property.
        /// </summary>
        public PropertyState<ToolLifeTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <summary>
        /// A description for the CountDirection Property.
        /// </summary>
        public PropertyState<ToolLifeDirectionTypeEnum> CountDirection
        {
            get
            {
                return m_countDirection;
            }

            set
            {
                if (!Object.ReferenceEquals(m_countDirection, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_countDirection = value;
            }
        }

        /// <summary>
        /// A description for the WarningLevel Property.
        /// </summary>
        public PropertyState<float> WarningLevel
        {
            get
            {
                return m_warningLevel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_warningLevel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningLevel = value;
            }
        }

        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_countDirection != null)
            {
                children.Add(m_countDirection);
            }

            if (m_warningLevel != null)
            {
                children.Add(m_warningLevel);
            }

            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<ToolLifeTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<ToolLifeTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.CountDirection:
                {
                    if (createOrReplace)
                    {
                        if (CountDirection == null)
                        {
                            if (replacement == null)
                            {
                                CountDirection = new PropertyState<ToolLifeDirectionTypeEnum>(this);
                            }
                            else
                            {
                                CountDirection = (PropertyState<ToolLifeDirectionTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = CountDirection;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.WarningLevel:
                {
                    if (createOrReplace)
                    {
                        if (WarningLevel == null)
                        {
                            if (replacement == null)
                            {
                                WarningLevel = new PropertyState<float>(this);
                            }
                            else
                            {
                                WarningLevel = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = WarningLevel;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<ToolLifeTypeEnum> m_type;
        private PropertyState<ToolLifeDirectionTypeEnum> m_countDirection;
        private PropertyState<float> m_warningLevel;
        private PropertyState<float> m_maximum;
        #endregion
    }

    #region LifeState<T> Class
    /// <summary>
    /// A typed version of the LifeType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LifeState<T> : LifeState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LifeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region LocationState Class
    #if (!OPCUA_EXCLUDE_LocationState)
    /// <summary>
    /// Stores an instance of the LocationType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LocationState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LocationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.LocationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "FAAAAExvY2F0aW9uVHlwZUluc3RhbmNlAQHXPAEB1zwAGAEB/////wMAAAAVYIkKAgAAAAEABAAAAFR5" +
           "cGUBAdg8AC4ARNg8AAABAT89/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE5lZ2F0aXZlT3Zlcmxh" +
           "cAEB2TwALgBE2TwAAAEBVD3/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUG9zaXRpdmVPdmVybGFw" +
           "AQHaPAAuAETaPAAAAQFUPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Type Property.
        /// </summary>
        public PropertyState<LocationsTypeEnum> Type
        {
            get
            {
                return m_type;
            }

            set
            {
                if (!Object.ReferenceEquals(m_type, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_type = value;
            }
        }

        /// <summary>
        /// A description for the NegativeOverlap Property.
        /// </summary>
        public PropertyState NegativeOverlap
        {
            get
            {
                return m_negativeOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_negativeOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_negativeOverlap = value;
            }
        }

        /// <summary>
        /// A description for the PositiveOverlap Property.
        /// </summary>
        public PropertyState PositiveOverlap
        {
            get
            {
                return m_positiveOverlap;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positiveOverlap, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positiveOverlap = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_type != null)
            {
                children.Add(m_type);
            }

            if (m_negativeOverlap != null)
            {
                children.Add(m_negativeOverlap);
            }

            if (m_positiveOverlap != null)
            {
                children.Add(m_positiveOverlap);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Type:
                {
                    if (createOrReplace)
                    {
                        if (Type == null)
                        {
                            if (replacement == null)
                            {
                                Type = new PropertyState<LocationsTypeEnum>(this);
                            }
                            else
                            {
                                Type = (PropertyState<LocationsTypeEnum>)replacement;
                            }
                        }
                    }

                    instance = Type;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NegativeOverlap:
                {
                    if (createOrReplace)
                    {
                        if (NegativeOverlap == null)
                        {
                            if (replacement == null)
                            {
                                NegativeOverlap = new PropertyState(this);
                            }
                            else
                            {
                                NegativeOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = NegativeOverlap;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.PositiveOverlap:
                {
                    if (createOrReplace)
                    {
                        if (PositiveOverlap == null)
                        {
                            if (replacement == null)
                            {
                                PositiveOverlap = new PropertyState(this);
                            }
                            else
                            {
                                PositiveOverlap = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = PositiveOverlap;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocationsTypeEnum> m_type;
        private PropertyState m_negativeOverlap;
        private PropertyState m_positiveOverlap;
        #endregion
    }

    #region LocationState<T> Class
    /// <summary>
    /// A typed version of the LocationType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class LocationState<T> : LocationState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public LocationState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramSpindleSpeedState Class
    #if (!OPCUA_EXCLUDE_ProgramSpindleSpeedState)
    /// <summary>
    /// Stores an instance of the ProgramSpindleSpeedType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramSpindleSpeedState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramSpindleSpeedType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "HwAAAFByb2dyYW1TcGluZGxlU3BlZWRUeXBlSW5zdGFuY2UBAds8AQHbPAAYAQH/////AwAAABVgiQoC" +
           "AAAAAQAHAAAATWF4aW11bQEB3DwALgBE3DwAAAEBRT3/////AQH/////AAAAABVgiQoCAAAAAQAHAAAA" +
           "TWluaW11bQEB3TwALgBE3TwAAAEBRz3/////AQH/////AAAAABVgiQoCAAAAAQAHAAAATm9taW5hbAEB" +
           "3jwALgBE3jwAAAEBTz3/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramSpindleSpeedState<T> Class
    /// <summary>
    /// A typed version of the ProgramSpindleSpeedType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramSpindleSpeedState<T> : ProgramSpindleSpeedState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProgramSpindleSpeedState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region ProgramFeedRateState Class
    #if (!OPCUA_EXCLUDE_ProgramFeedRateState)
    /// <summary>
    /// Stores an instance of the ProgramFeedRateType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramFeedRateState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.ProgramFeedRateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "GwAAAFByb2dyYW1GZWVkUmF0ZVR5cGVJbnN0YW5jZQEB3zwBAd88ABgBAf////8DAAAAFWCJCgIAAAAB" +
           "AAcAAABNYXhpbXVtAQHgPAAuAETgPAAAAQFFPf////8BAf////8AAAAAFWCJCgIAAAABAAcAAABNaW5p" +
           "bXVtAQHhPAAuAEThPAAAAQFHPf////8BAf////8AAAAAFWCJCgIAAAABAAcAAABOb21pbmFsAQHiPAAu" +
           "AETiPAAAAQFPPf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Maximum Property.
        /// </summary>
        public PropertyState<float> Maximum
        {
            get
            {
                return m_maximum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maximum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maximum = value;
            }
        }

        /// <summary>
        /// A description for the Minimum Property.
        /// </summary>
        public PropertyState<float> Minimum
        {
            get
            {
                return m_minimum;
            }

            set
            {
                if (!Object.ReferenceEquals(m_minimum, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_minimum = value;
            }
        }

        /// <summary>
        /// A description for the Nominal Property.
        /// </summary>
        public PropertyState<float> Nominal
        {
            get
            {
                return m_nominal;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nominal, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nominal = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_maximum != null)
            {
                children.Add(m_maximum);
            }

            if (m_minimum != null)
            {
                children.Add(m_minimum);
            }

            if (m_nominal != null)
            {
                children.Add(m_nominal);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Maximum:
                {
                    if (createOrReplace)
                    {
                        if (Maximum == null)
                        {
                            if (replacement == null)
                            {
                                Maximum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Maximum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Maximum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Minimum:
                {
                    if (createOrReplace)
                    {
                        if (Minimum == null)
                        {
                            if (replacement == null)
                            {
                                Minimum = new PropertyState<float>(this);
                            }
                            else
                            {
                                Minimum = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Minimum;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Nominal:
                {
                    if (createOrReplace)
                    {
                        if (Nominal == null)
                        {
                            if (replacement == null)
                            {
                                Nominal = new PropertyState<float>(this);
                            }
                            else
                            {
                                Nominal = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Nominal;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<float> m_maximum;
        private PropertyState<float> m_minimum;
        private PropertyState<float> m_nominal;
        #endregion
    }

    #region ProgramFeedRateState<T> Class
    /// <summary>
    /// A typed version of the ProgramFeedRateType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class ProgramFeedRateState<T> : ProgramFeedRateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public ProgramFeedRateState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region CuttingItemState Class
    #if (!OPCUA_EXCLUDE_CuttingItemState)
    /// <summary>
    /// Stores an instance of the CuttingItemType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CuttingItemState : BaseDataVariableState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CuttingItemState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.CuttingItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ItemId != null)
            {
                ItemId.Initialize(context, ItemId_InitializationString);
            }

            if (Grade != null)
            {
                Grade.Initialize(context, Grade_InitializationString);
            }

            if (Manufacturers != null)
            {
                Manufacturers.Initialize(context, Manufacturers_InitializationString);
            }

            if (Description != null)
            {
                Description.Initialize(context, Description_InitializationString);
            }

            if (Locus != null)
            {
                Locus.Initialize(context, Locus_InitializationString);
            }

            if (ItemLife != null)
            {
                ItemLife.Initialize(context, ItemLife_InitializationString);
            }

            if (Measurements != null)
            {
                Measurements.Initialize(context, Measurements_InitializationString);
            }
        }

        #region Initialization String
        private const string ItemId_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BgAAAEl0ZW1JZAEB5TwALgBE5TwAAAEBOT3/////AQH/////AAAAAA==";

        private const string Grade_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAEdyYWRlAQHmPAAuAETmPAAAAQE2Pf////8BAf////8AAAAA";

        private const string Manufacturers_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DQAAAE1hbnVmYWN0dXJlcnMBAec8AC4AROc8AAABAUI9/////wEB/////wAAAAA=";

        private const string Description_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CwAAAERlc2NyaXB0aW9uAQHoPAAuAEToPAAAAQH+PP////8BAf////8AAAAA";

        private const string Locus_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "BQAAAExvY3VzAQHpPAAuAETpPAAAAQFBPf////8BAf////8AAAAA";

        private const string ItemLife_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CAAAAEl0ZW1MaWZlAQHqPAAvAD3qPAAA/////wAAAAA=";

        private const string Measurements_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "DAAAAE1lYXN1cmVtZW50cwEB6zwALwA96zwAAP////8AAAAA";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIEAAgAAAAEA" +
           "FwAAAEN1dHRpbmdJdGVtVHlwZUluc3RhbmNlAQHjPAEB4zwAGAEB/////wgAAAAVYIkKAgAAAAEABwAA" +
           "AEluZGljZXMBAeQ8AC4AROQ8AAABATc9/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAEl0ZW1JZAEB" +
           "5TwALgBE5TwAAAEBOT3/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAR3JhZGUBAeY8AC4AROY8AAAB" +
           "ATY9/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAE1hbnVmYWN0dXJlcnMBAec8AC4AROc8AAABAUI9" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERlc2NyaXB0aW9uAQHoPAAuAEToPAAAAQH+PP////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAUAAABMb2N1cwEB6TwALgBE6TwAAAEBQT3/////AQH/////AAAAAARg" +
           "gAoBAAAAAQAIAAAASXRlbUxpZmUBAeo8AC8APeo8AAD/////AAAAAARggAoBAAAAAQAMAAAATWVhc3Vy" +
           "ZW1lbnRzAQHrPAAvAD3rPAAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Indices Property.
        /// </summary>
        public PropertyState<string> Indices
        {
            get
            {
                return m_indices;
            }

            set
            {
                if (!Object.ReferenceEquals(m_indices, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indices = value;
            }
        }

        /// <summary>
        /// A description for the ItemId Property.
        /// </summary>
        public PropertyState<string> ItemId
        {
            get
            {
                return m_itemId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemId = value;
            }
        }

        /// <summary>
        /// A description for the Grade Property.
        /// </summary>
        public PropertyState<string> Grade
        {
            get
            {
                return m_grade;
            }

            set
            {
                if (!Object.ReferenceEquals(m_grade, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_grade = value;
            }
        }

        /// <summary>
        /// A description for the Manufacturers Property.
        /// </summary>
        public PropertyState<string> Manufacturers
        {
            get
            {
                return m_manufacturers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturers = value;
            }
        }

        /// <summary>
        /// A description for the Description Property.
        /// </summary>
        public PropertyState<string> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <summary>
        /// A description for the Locus Property.
        /// </summary>
        public PropertyState<string> Locus
        {
            get
            {
                return m_locus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_locus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locus = value;
            }
        }

        /// <summary>
        /// A description for the ItemLife Object.
        /// </summary>
        public FolderState ItemLife
        {
            get
            {
                return m_itemLife;
            }

            set
            {
                if (!Object.ReferenceEquals(m_itemLife, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_itemLife = value;
            }
        }

        /// <summary>
        /// A description for the Measurements Object.
        /// </summary>
        public FolderState Measurements
        {
            get
            {
                return m_measurements;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurements, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurements = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_indices != null)
            {
                children.Add(m_indices);
            }

            if (m_itemId != null)
            {
                children.Add(m_itemId);
            }

            if (m_grade != null)
            {
                children.Add(m_grade);
            }

            if (m_manufacturers != null)
            {
                children.Add(m_manufacturers);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_locus != null)
            {
                children.Add(m_locus);
            }

            if (m_itemLife != null)
            {
                children.Add(m_itemLife);
            }

            if (m_measurements != null)
            {
                children.Add(m_measurements);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.Indices:
                {
                    if (createOrReplace)
                    {
                        if (Indices == null)
                        {
                            if (replacement == null)
                            {
                                Indices = new PropertyState<string>(this);
                            }
                            else
                            {
                                Indices = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Indices;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ItemId:
                {
                    if (createOrReplace)
                    {
                        if (ItemId == null)
                        {
                            if (replacement == null)
                            {
                                ItemId = new PropertyState<string>(this);
                            }
                            else
                            {
                                ItemId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ItemId;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Grade:
                {
                    if (createOrReplace)
                    {
                        if (Grade == null)
                        {
                            if (replacement == null)
                            {
                                Grade = new PropertyState<string>(this);
                            }
                            else
                            {
                                Grade = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Grade;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Manufacturers:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturers == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturers = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturers = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturers;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<string>(this);
                            }
                            else
                            {
                                Description = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Locus:
                {
                    if (createOrReplace)
                    {
                        if (Locus == null)
                        {
                            if (replacement == null)
                            {
                                Locus = new PropertyState<string>(this);
                            }
                            else
                            {
                                Locus = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Locus;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ItemLife:
                {
                    if (createOrReplace)
                    {
                        if (ItemLife == null)
                        {
                            if (replacement == null)
                            {
                                ItemLife = new FolderState(this);
                            }
                            else
                            {
                                ItemLife = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ItemLife;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.Measurements:
                {
                    if (createOrReplace)
                    {
                        if (Measurements == null)
                        {
                            if (replacement == null)
                            {
                                Measurements = new FolderState(this);
                            }
                            else
                            {
                                Measurements = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Measurements;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_indices;
        private PropertyState<string> m_itemId;
        private PropertyState<string> m_grade;
        private PropertyState<string> m_manufacturers;
        private PropertyState<string> m_description;
        private PropertyState<string> m_locus;
        private FolderState m_itemLife;
        private FolderState m_measurements;
        #endregion
    }

    #region CuttingItemState<T> Class
    /// <summary>
    /// A typed version of the CuttingItemType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class CuttingItemState<T> : CuttingItemState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public CuttingItemState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region AssemblyMeasurementState Class
    #if (!OPCUA_EXCLUDE_AssemblyMeasurementState)
    /// <summary>
    /// Stores an instance of the AssemblyMeasurementType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AssemblyMeasurementState : MeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.VariableTypes.AssemblyMeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkAAgAAAAEA" +
           "HwAAAEFzc2VtYmx5TWVhc3VyZW1lbnRUeXBlSW5zdGFuY2UBAew8AQHsPAAa/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAfA8AC4ARPA8AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region AssemblyMeasurementState<T> Class
    /// <summary>
    /// A typed version of the AssemblyMeasurementType variable.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public class AssemblyMeasurementState<T> : AssemblyMeasurementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the instance with its defalt attribute values.
        /// </summary>
        public AssemblyMeasurementState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        /// <summary>
        /// Initializes the instance with the default values.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        /// <summary>
        /// The value of the variable.
        /// </summary>
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(base.Value, true);
            }

            set
            {
                base.Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region MTConditionState Class
    #if (!OPCUA_EXCLUDE_MTConditionState)
    /// <summary>
    /// Stores an instance of the MTConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MTConditionState : ConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MTConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MTConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (LimitState != null)
            {
                LimitState.Initialize(context, LimitState_InitializationString);
            }

            if (NativeCode != null)
            {
                NativeCode.Initialize(context, NativeCode_InitializationString);
            }

            if (NativeSeverity != null)
            {
                NativeSeverity.Initialize(context, NativeSeverity_InitializationString);
            }
        }

        #region Initialization String
        private const string LimitState_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAKAQAAAAEA" +
           "CgAAAExpbWl0U3RhdGUBAQg+AC8BAGYkCD4AAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3Rh" +
           "dGUBAQk+AC8BAMgKCT4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEKPgAuAEQKPgAA" +
           "ABH/////AQH/////AAAAAA==";

        private const string NativeCode_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "CgAAAE5hdGl2ZUNvZGUBARY+AC4ARBY+AAAADP////8BAf////8AAAAA";

        private const string NativeSeverity_InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8VYIkKAgAAAAEA" +
           "DgAAAE5hdGl2ZVNldmVyaXR5AQEXPgAuAEQXPgAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAE1UQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHVPQEB1T3/////GwAAADVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEB1j0DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQu" +
           "AC4ARNY9AAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAdc9AwAAAAAiAAAA" +
           "VGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETXPQAAABH/////AQH/////AAAAADVg" +
           "iQoCAAAAAAAKAAAAU291cmNlTm9kZQEB2D0DAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBE2D0AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAdk9AwAAAAApAAAA" +
           "QSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE2T0AAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAdo9AwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJyZWQu" +
           "AC4ARNo9AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHbPQMAAAAA" +
           "PgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWluZyBz" +
           "eXN0ZW0uAC4ARNs9AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEB3D0D" +
           "AAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQgb3Jp" +
           "Z2luYXRlZC4ALgBE3D0AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEB3T0D" +
           "AAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARN09AAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB3j0DAAAAACEAAABJbmRpY2F0ZXMgaG93IHVy" +
           "Z2VudCBhbiBldmVudCBpcy4ALgBE3j0AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAd89AC4ARN89AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAeA9AC4AROA9AAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQHjPQAuAETjPQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAeQ9" +
           "AC4AROQ9AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAeU9AC4AROU9AAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAeY9AC8BACMj5j0AAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHnPQAuAETnPQAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEB7z0ALwEAKiPvPQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQHwPQAuAETwPQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAfE9AC8BACoj8T0AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEB8j0ALgBE8j0AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "8z0ALwEAKiPzPQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQH0" +
           "PQAuAET0PQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAfU9AC4A" +
           "RPU9AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQH2PQAvAQBEI/Y9AAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAfc9AC8BAEMj9z0AAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAfg9AC8BAEUj+D0AAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQH5PQAuAET5PQAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEB/j0ALwA//j0AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQH/PQAvAQAjI/89AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBAD4ALgBEAD4A" +
           "AAAB/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAExpbWl0U3RhdGUBAQg+AC8BAGYkCD4AAP////8B" +
           "AAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQk+AC8BAMgKCT4AAAAV/////wEB/////wEAAAAV" +
           "YIkKAgAAAAAAAgAAAElkAQEKPgAuAEQKPgAAABH/////AQH/////AAAAABVgiQoCAAAAAQAKAAAATmF0" +
           "aXZlQ29kZQEBFj4ALgBEFj4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADgAAAE5hdGl2ZVNldmVy" +
           "aXR5AQEXPgAuAEQXPgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MTCurrentState Variable.
        /// </summary>
        public BaseDataVariableState<string> MTCurrentState
        {
            get
            {
                return m_mTCurrentState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mTCurrentState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mTCurrentState = value;
            }
        }

        /// <summary>
        /// A description for the ActiveState Variable.
        /// </summary>
        public TwoStateVariableState ActiveState
        {
            get
            {
                return m_activeState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeState = value;
            }
        }

        /// <summary>
        /// A description for the LimitState Object.
        /// </summary>
        public ExclusiveLimitStateMachineState LimitState
        {
            get
            {
                return m_limitState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_limitState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitState = value;
            }
        }

        /// <summary>
        /// A description for the NativeCode Property.
        /// </summary>
        public PropertyState<string> NativeCode
        {
            get
            {
                return m_nativeCode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeCode = value;
            }
        }

        /// <summary>
        /// A description for the NativeSeverity Property.
        /// </summary>
        public PropertyState<string> NativeSeverity
        {
            get
            {
                return m_nativeSeverity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nativeSeverity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nativeSeverity = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_mTCurrentState != null)
            {
                children.Add(m_mTCurrentState);
            }

            if (m_activeState != null)
            {
                children.Add(m_activeState);
            }

            if (m_limitState != null)
            {
                children.Add(m_limitState);
            }

            if (m_nativeCode != null)
            {
                children.Add(m_nativeCode);
            }

            if (m_nativeSeverity != null)
            {
                children.Add(m_nativeSeverity);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.MTConnect.BrowseNames.MTCurrentState:
                {
                    if (createOrReplace)
                    {
                        if (MTCurrentState == null)
                        {
                            if (replacement == null)
                            {
                                MTCurrentState = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MTCurrentState = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MTCurrentState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.ActiveState:
                {
                    if (createOrReplace)
                    {
                        if (ActiveState == null)
                        {
                            if (replacement == null)
                            {
                                ActiveState = new TwoStateVariableState(this);
                            }
                            else
                            {
                                ActiveState = (TwoStateVariableState)replacement;
                            }
                        }
                    }

                    instance = ActiveState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.LimitState:
                {
                    if (createOrReplace)
                    {
                        if (LimitState == null)
                        {
                            if (replacement == null)
                            {
                                LimitState = new ExclusiveLimitStateMachineState(this);
                            }
                            else
                            {
                                LimitState = (ExclusiveLimitStateMachineState)replacement;
                            }
                        }
                    }

                    instance = LimitState;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeCode:
                {
                    if (createOrReplace)
                    {
                        if (NativeCode == null)
                        {
                            if (replacement == null)
                            {
                                NativeCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeCode;
                    break;
                }

                case Opc.Ua.MTConnect.BrowseNames.NativeSeverity:
                {
                    if (createOrReplace)
                    {
                        if (NativeSeverity == null)
                        {
                            if (replacement == null)
                            {
                                NativeSeverity = new PropertyState<string>(this);
                            }
                            else
                            {
                                NativeSeverity = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = NativeSeverity;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_mTCurrentState;
        private TwoStateVariableState m_activeState;
        private ExclusiveLimitStateMachineState m_limitState;
        private PropertyState<string> m_nativeCode;
        private PropertyState<string> m_nativeSeverity;
        #endregion
    }
    #endif
    #endregion

    #region AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_AccelerationConditionState)
    /// <summary>
    /// Stores an instance of the AccelerationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAEFjY2VsZXJhdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBGD4BARg+/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBARk+AwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAEQZPgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQEa" +
           "PgMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEGj4AAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBARs+AwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARBs+AAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEc" +
           "PgMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARBw+AAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQEdPgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAEQdPgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBHj4DAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAEQePgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAR8+AwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARB8+AAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBASA+AwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQg" +
           "PgAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBASE+AwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARCE+AAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQEiPgAuAEQiPgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEjPgAuAEQjPgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBJj4ALgBEJj4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQEnPgAuAEQnPgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEoPgAu" +
           "AEQoPgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEpPgAvAQAjIyk+" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBKj4ALgBEKj4AAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBATI+AC8BACojMj4AAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBMz4ALgBEMz4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQE0PgAvAQAqIzQ+AAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABATU+AC4ARDU+AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBATY+AC8BACojNj4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBNz4ALgBENz4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQE4PgAuAEQ4PgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBOT4ALwEA" +
           "RCM5PgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQE6PgAvAQBDIzo+AAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQE7PgAvAQBFIzs+AAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBPD4ALgBEPD4AAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAUE+AC8AP0E+AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBQj4ALwEAIyNCPgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AUM+AC4AREM+AAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Accumulated_TimeConditionState Class
    #if (!OPCUA_EXCLUDE_Accumulated_TimeConditionState)
    /// <summary>
    /// Stores an instance of the Accumulated_TimeConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Accumulated_TimeConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Accumulated_TimeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Accumulated_TimeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JQAAAEFjY3VtdWxhdGVkX1RpbWVDb25kaXRpb25UeXBlSW5zdGFuY2UBAVs+AQFbPv////8YAAAANWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQFcPgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIg" +
           "Zm9yIHRoZSBldmVudC4ALgBEXD4AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBXT4DAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARF0+AAAAEf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFePgMAAAAAGAAAAFRoZSBzb3VyY2Ug" +
           "b2YgdGhlIGV2ZW50LgAuAERePgAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBXz4DAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERf" +
           "PgAAAAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBYD4DAAAAABgAAABXaGVuIHRoZSBl" +
           "dmVudCBvY2N1cnJlZC4ALgBEYD4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2" +
           "ZVRpbWUBAWE+AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRo" +
           "ZSB1bmRlcmx5aW5nIHN5c3RlbS4ALgBEYT4AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAA" +
           "TG9jYWxUaW1lAQFiPgMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJl" +
           "IHRoZSBldmVudCBvcmlnaW5hdGVkLgAuAERiPgAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcA" +
           "AABNZXNzYWdlAQFjPgMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4A" +
           "LgBEYz4AAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFkPgMAAAAAIQAAAElu" +
           "ZGljYXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAERkPgAAAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBZT4ALgBEZT4AAAAR/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBZj4ALgBEZj4AAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADQAAAENvbmRpdGlvbk5hbWUBAWk+AC4ARGk+AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABCcmFuY2hJZAEBaj4ALgBEaj4AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB" +
           "az4ALgBEaz4AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBbD4ALwEA" +
           "IyNsPgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAW0+AC4ARG0+AAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQF1PgAvAQAqI3U+AAAAE/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAXY+AC4ARHY+AAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADAAAAExhc3RTZXZlcml0eQEBdz4ALwEAKiN3PgAAAAX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQF4PgAuAER4PgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABDb21tZW50AQF5PgAvAQAqI3k+AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAXo+AC4ARHo+AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVu" +
           "dFVzZXJJZAEBez4ALgBEez4AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAXw+" +
           "AC8BAEQjfD4AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBfT4ALwEAQyN9" +
           "PgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBfj4ALwEARSN+PgAA" +
           "AQEBAAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAX8+AC4ARH8+AACW" +
           "AgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQA" +
           "AABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQGEPgAvAD+EPgAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAYU+AC8BACMjhT4AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQGGPgAuAESGPgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_AmperageConditionState)
    /// <summary>
    /// Stores an instance of the AmperageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAEFtcGVyYWdlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGePgEBnj7/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBnz4DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARJ8+AAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAaA+AwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESgPgAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBoT4DAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEoT4AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAaI+AwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEoj4AAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAaM+AwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARKM+AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGk" +
           "PgMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARKQ+AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBpT4DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEpT4AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBpj4DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARKY+AAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBpz4DAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEpz4AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAag+AC4ARKg+AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAak+AC4ARKk+AAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQGsPgAuAESsPgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAa0+AC4ARK0+AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAa4+AC4ARK4+" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAa8+AC8BACMjrz4AAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGwPgAuAESwPgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBuD4ALwEAKiO4PgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQG5PgAuAES5PgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAbo+AC8BACojuj4AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBuz4ALgBEuz4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBvD4ALwEAKiO8PgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQG9PgAuAES9PgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "Ab4+AC4ARL4+AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQG/PgAvAQBEI78+" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAcA+AC8BAEMjwD4AAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAcE+AC8BAEUjwT4AAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHCPgAuAETCPgAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBxz4ALwA/xz4AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQHIPgAvAQAjI8g+AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEByT4A" +
           "LgBEyT4AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AngleConditionState Class
    #if (!OPCUA_EXCLUDE_AngleConditionState)
    /// <summary>
    /// Stores an instance of the AngleConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AngleConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AngleConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.AngleConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GgAAAEFuZ2xlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHhPgEB4T7/////GAAAADVgiQoCAAAAAAAHAAAA" +
           "RXZlbnRJZAEB4j4DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQuAC4AROI+AAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAeM+AwAAAAAi" +
           "AAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAETjPgAAABH/////AQH/////AAAA" +
           "ADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB5D4DAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVu" +
           "dC4ALgBE5D4AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAeU+AwAAAAAp" +
           "AAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE5T4AAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAeY+AwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJy" +
           "ZWQuAC4AROY+AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHnPgMA" +
           "AAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWlu" +
           "ZyBzeXN0ZW0uAC4AROc+AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEB" +
           "6D4DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQg" +
           "b3JpZ2luYXRlZC4ALgBE6D4AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEB" +
           "6T4DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4AROk+AAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB6j4DAAAAACEAAABJbmRpY2F0ZXMgaG93" +
           "IHVyZ2VudCBhbiBldmVudCBpcy4ALgBE6j4AAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENv" +
           "bmRpdGlvbkNsYXNzSWQBAes+AC4AROs+AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25k" +
           "aXRpb25DbGFzc05hbWUBAew+AC4AROw+AAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25k" +
           "aXRpb25OYW1lAQHvPgAuAETvPgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQB" +
           "AfA+AC4ARPA+AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAfE+AC4ARPE+AAAA" +
           "Af////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAfI+AC8BACMj8j4AAAAV////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHzPgAuAETzPgAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAUXVhbGl0eQEB+z4ALwEAKiP7PgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQH8PgAuAET8PgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABM" +
           "YXN0U2V2ZXJpdHkBAf0+AC8BACoj/T4AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEB/j4ALgBE/j4AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVu" +
           "dAEB/z4ALwEAKiP/PgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1w" +
           "AQEAPwAuAEQAPwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAQE/" +
           "AC4ARAE/AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQECPwAvAQBEIwI/AAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAQM/AC8BAEMjAz8AAAEBAQAAAAEA" +
           "+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAQQ/AC8BAEUjBD8AAAEBAQAAAAEA+QsA" +
           "AQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEFPwAuAEQFPwAAlgIAAAABACoBAUYA" +
           "AAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50" +
           "IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1l" +
           "bnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABN" +
           "VEN1cnJlbnRTdGF0ZQEBCj8ALwA/Cj8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2" +
           "ZVN0YXRlAQELPwAvAQAjIws/AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBDD8ALgBE" +
           "DD8AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular_AccelerationConditionState Class
    #if (!OPCUA_EXCLUDE_Angular_AccelerationConditionState)
    /// <summary>
    /// Stores an instance of the Angular_AccelerationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular_AccelerationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Angular_AccelerationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Angular_AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "KQAAAEFuZ3VsYXJfQWNjZWxlcmF0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEWSQEBFkn/////GAAA" +
           "ADVgiQoCAAAAAAAHAAAARXZlbnRJZAEBF0kDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlm" +
           "aWVyIGZvciB0aGUgZXZlbnQuAC4ARBdJAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBARhJAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQYSQAA" +
           "ABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBGUkDAAAAABgAAABUaGUgc291" +
           "cmNlIG9mIHRoZSBldmVudC4ALgBEGUkAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5hbWUBARpJAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBEGkkAAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBARtJAwAAAAAYAAAAV2hlbiB0" +
           "aGUgZXZlbnQgb2NjdXJyZWQuAC4ARBtJAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJl" +
           "Y2VpdmVUaW1lAQEcSQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJv" +
           "bSB0aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4ARBxJAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAA" +
           "CQAAAExvY2FsVGltZQEBHUkDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3" +
           "aGVyZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEHUkAAAEA0CL/////AQH/////AAAAADVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBHkkDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZl" +
           "bnQuAC4ARB5JAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBH0kDAAAAACEA" +
           "AABJbmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEH0kAAAAF/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBASBJAC4ARCBJAAAAEf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBASFJAC4ARCFJAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEkSQAuAEQkSQAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAQnJhbmNoSWQBASVJAC4ARCVJAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRh" +
           "aW4BASZJAC4ARCZJAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBASdJ" +
           "AC8BACMjJ0kAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEoSQAuAEQoSQAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBMEkALwEAKiMwSQAAABP/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQExSQAuAEQxSQAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBATJJAC8BACojMkkAAAAF/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBM0kALgBEM0kAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAQ29tbWVudAEBNEkALwEAKiM0SQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQE1SQAuAEQ1SQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABD" +
           "bGllbnRVc2VySWQBATZJAC4ARDZJAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxl" +
           "AQE3SQAvAQBEIzdJAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAThJAC8B" +
           "AEMjOEkAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBATlJAC8BAEUj" +
           "OUkAAAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE6SQAuAEQ6" +
           "SQAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmll" +
           "ciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAA" +
           "AAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAA" +
           "FWCJCgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBP0kALwA/P0kAAAAM/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAEFjdGl2ZVN0YXRlAQFASQAvAQAjI0BJAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBQUkALgBEQUkAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Angular_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Angular_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the Angular_VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Angular_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Angular_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Angular_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JQAAAEFuZ3VsYXJfVmVsb2NpdHlDb25kaXRpb25UeXBlSW5zdGFuY2UBAWc/AQFnP/////8YAAAANWCJ" +
           "CgIAAAAAAAcAAABFdmVudElkAQFoPwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIg" +
           "Zm9yIHRoZSBldmVudC4ALgBEaD8AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBaT8DAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARGk/AAAAEf//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFqPwMAAAAAGAAAAFRoZSBzb3VyY2Ug" +
           "b2YgdGhlIGV2ZW50LgAuAERqPwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBaz8DAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERr" +
           "PwAAAAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBbD8DAAAAABgAAABXaGVuIHRoZSBl" +
           "dmVudCBvY2N1cnJlZC4ALgBEbD8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2" +
           "ZVRpbWUBAW0/AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRo" +
           "ZSB1bmRlcmx5aW5nIHN5c3RlbS4ALgBEbT8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAA" +
           "TG9jYWxUaW1lAQFuPwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJl" +
           "IHRoZSBldmVudCBvcmlnaW5hdGVkLgAuAERuPwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcA" +
           "AABNZXNzYWdlAQFvPwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4A" +
           "LgBEbz8AAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFwPwMAAAAAIQAAAElu" +
           "ZGljYXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAERwPwAAAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBcT8ALgBEcT8AAAAR/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBcj8ALgBEcj8AAAAV/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADQAAAENvbmRpdGlvbk5hbWUBAXU/AC4ARHU/AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgA" +
           "AABCcmFuY2hJZAEBdj8ALgBEdj8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB" +
           "dz8ALgBEdz8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBeD8ALwEA" +
           "IyN4PwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAXk/AC4ARHk/AAAAAf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQGBPwAvAQAqI4E/AAAAE/////8BAf////8BAAAAFWCJ" +
           "CgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAYI/AC4ARII/AAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAADAAAAExhc3RTZXZlcml0eQEBgz8ALwEAKiODPwAAAAX/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQGEPwAuAESEPwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAcAAABDb21tZW50AQGFPwAvAQAqI4U/AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAYY/AC4ARIY/AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVu" +
           "dFVzZXJJZAEBhz8ALgBEhz8AAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAYg/" +
           "AC8BAEQjiD8AAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBiT8ALwEAQyOJ" +
           "PwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBij8ALwEARSOKPwAA" +
           "AQEBAAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYs/AC4ARIs/AACW" +
           "AgAAAAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQA" +
           "AABUaGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEADgAAAE1UQ3VycmVudFN0YXRlAQGQPwAvAD+QPwAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AQALAAAAQWN0aXZlU3RhdGUBAZE/AC8BACMjkT8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQGSPwAuAESSPwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CommunicationsConditionState Class
    #if (!OPCUA_EXCLUDE_CommunicationsConditionState)
    /// <summary>
    /// Stores an instance of the CommunicationsConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CommunicationsConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CommunicationsConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.CommunicationsConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IwAAAENvbW11bmljYXRpb25zQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGqPwEBqj//////GAAAADVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBqz8DAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQuAC4ARKs/AAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "Aaw/AwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESsPwAAABH/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBrT8DAAAAABgAAABUaGUgc291cmNlIG9m" +
           "IHRoZSBldmVudC4ALgBErT8AAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "Aa4/AwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBErj8A" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAa8/AwAAAAAYAAAAV2hlbiB0aGUgZXZl" +
           "bnQgb2NjdXJyZWQuAC4ARK8/AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVU" +
           "aW1lAQGwPwMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUg" +
           "dW5kZXJseWluZyBzeXN0ZW0uAC4ARLA/AAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExv" +
           "Y2FsVGltZQEBsT8DAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0" +
           "aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEsT8AAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAA" +
           "TWVzc2FnZQEBsj8DAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4A" +
           "RLI/AAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBsz8DAAAAACEAAABJbmRp" +
           "Y2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEsz8AAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAbQ/AC4ARLQ/AAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABIAAABDb25kaXRpb25DbGFzc05hbWUBAbU/AC4ARLU/AAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA0AAABDb25kaXRpb25OYW1lAQG4PwAuAES4PwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "QnJhbmNoSWQBAbk/AC4ARLk/AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAbo/" +
           "AC4ARLo/AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAbs/AC8BACMj" +
           "uz8AAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQG8PwAuAES8PwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBxD8ALwEAKiPEPwAAABP/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQHFPwAuAETFPwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABMYXN0U2V2ZXJpdHkBAcY/AC8BACojxj8AAAAF/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBxz8ALgBExz8AAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAQ29tbWVudAEByD8ALwEAKiPIPwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHJPwAuAETJPwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRV" +
           "c2VySWQBAco/AC4ARMo/AAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHLPwAv" +
           "AQBEI8s/AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAcw/AC8BAEMjzD8A" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAc0/AC8BAEUjzT8AAAEB" +
           "AQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHOPwAuAETOPwAAlgIA" +
           "AAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAA" +
           "VGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEB0z8ALwA/0z8AAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQHUPwAvAQAjI9Q/AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEB1T8ALgBE1T8AAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConcentrationConditionState Class
    #if (!OPCUA_EXCLUDE_ConcentrationConditionState)
    /// <summary>
    /// Stores an instance of the ConcentrationConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConcentrationConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConcentrationConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ConcentrationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAENvbmNlbnRyYXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAe0/AQHtP/////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHuPwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBE7j8AAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "7z8DAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARO8/AAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHwPwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAETwPwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "8T8DAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETxPwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB8j8DAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBE8j8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAfM/AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBE8z8AAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQH0PwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAET0PwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQH1PwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "9T8AAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQH2PwMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAET2PwAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB9z8ALgBE9z8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB+D8ALgBE+D8AAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAfs/AC4ARPs/AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEB/D8ALgBE/D8AAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB/T8A" +
           "LgBE/T8AAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB/j8ALwEAIyP+" +
           "PwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAf8/AC4ARP8/AAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQEHQAAvAQAqIwdAAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAQhAAC4ARAhAAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBCUAALwEAKiMJQAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQEKQAAuAEQKQAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQELQAAvAQAqIwtAAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAQxAAC4ARAxAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBDUAALgBEDUAAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAQ5AAC8B" +
           "AEQjDkAAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBD0AALwEAQyMPQAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBEEAALwEARSMQQAAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARFAAC4ARBFAAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQEWQAAvAD8WQAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBARdAAC8BACMjF0AAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQEYQAAuAEQYQAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConductivityConditionState Class
    #if (!OPCUA_EXCLUDE_ConductivityConditionState)
    /// <summary>
    /// Stores an instance of the ConductivityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConductivityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConductivityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ConductivityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAENvbmR1Y3Rpdml0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBMEABATBA/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBATFAAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAEQxQAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQEy" +
           "QAMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEMkAAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBATNAAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARDNAAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQE0" +
           "QAMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARDRAAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQE1QAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAEQ1QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBNkADAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAEQ2QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBATdAAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARDdAAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAThAAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQ4" +
           "QAAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBATlAAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARDlAAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQE6QAAuAEQ6QAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQE7QAAuAEQ7QAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBPkAALgBEPkAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQE/QAAuAEQ/QAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFAQAAu" +
           "AERAQAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFBQAAvAQAjI0FA" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBQkAALgBEQkAAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAUpAAC8BACojSkAAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBS0AALgBES0AAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQFMQAAvAQAqI0xAAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAU1AAC4ARE1AAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAU5AAC8BACojTkAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBT0AALgBET0AAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQFQQAAuAERQQAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBUUAALwEA" +
           "RCNRQAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFSQAAvAQBDI1JAAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFTQAAvAQBFI1NAAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBVEAALgBEVEAAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAVlAAC8AP1lAAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBWkAALwEAIyNaQAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AVtAAC4ARFtAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Data_RangeConditionState Class
    #if (!OPCUA_EXCLUDE_Data_RangeConditionState)
    /// <summary>
    /// Stores an instance of the Data_RangeConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Data_RangeConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Data_RangeConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Data_RangeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAERhdGFfUmFuZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAXNAAQFzQP////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQF0QAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBEdEAAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBdUAD" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARHVAAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQF2QAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAER2QAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBd0AD" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAER3QAAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBeEADAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEeEAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AXlAAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEeUAAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQF6QAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAER6QAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQF7QAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEe0AA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQF8QAMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAER8QAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBfUAALgBEfUAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBfkAALgBEfkAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAYFAAC4ARIFAAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBgkAALgBEgkAAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBg0AALgBE" +
           "g0AAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBhEAALwEAIyOEQAAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAYVAAC4ARIVAAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGNQAAvAQAqI41AAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAY5AAC4ARI5AAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBj0AALwEAKiOPQAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGQQAAuAESQQAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGRQAAvAQAqI5FAAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAZJAAC4ARJJAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBk0AALgBEk0AAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAZRAAC8BAEQj" +
           "lEAAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBlUAALwEAQyOVQAAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBlkAALwEARSOWQAAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZdAAC4ARJdAAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGcQAAvAD+cQAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAZ1AAC8BACMjnUAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGe" +
           "QAAuAESeQAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DirectionConditionState Class
    #if (!OPCUA_EXCLUDE_DirectionConditionState)
    /// <summary>
    /// Stores an instance of the DirectionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DirectionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DirectionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.DirectionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAERpcmVjdGlvbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBtkABAbZA/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAbdAAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAES3QAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQG4QAMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEuEAAAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAblAAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4ARLlAAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQG6QAMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARLpAAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQG7QAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAES7QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "vEADAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAES8QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBAb1AAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4ARL1AAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBAb5AAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAES+QAAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAb9AAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARL9AAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQHAQAAuAETAQAAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQHBQAAuAETBQAAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEBxEAALgBExEAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQHFQAAuAETFQAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHGQAAuAETG" +
           "QAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHHQAAvAQAjI8dAAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEByEAALgBEyEAAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAdBAAC8BACoj0EAAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEB0UAALgBE0UAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQHSQAAvAQAqI9JAAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAdNAAC4ARNNAAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAdRAAC8BACoj1EAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB1UAALgBE1UAAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQHWQAAuAETWQAAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB10AALwEARCPX" +
           "QAAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHYQAAvAQBDI9hAAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHZQAAvAQBFI9lAAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB2kAALgBE2kAAAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAd9AAC8AP99AAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEB4EAALwEAIyPgQAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAeFA" +
           "AC4AROFAAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DisplacementConditionState Class
    #if (!OPCUA_EXCLUDE_DisplacementConditionState)
    /// <summary>
    /// Stores an instance of the DisplacementConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DisplacementConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DisplacementConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.DisplacementConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAERpc3BsYWNlbWVudENvbmRpdGlvblR5cGVJbnN0YW5jZQEB+UABAflA/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAfpAAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAET6QAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQH7" +
           "QAMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBE+0AAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAfxAAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARPxAAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQH9" +
           "QAMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARP1AAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQH+QAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAET+QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEB/0ADAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAET/QAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAQBBAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARABBAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAQFBAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQB" +
           "QQAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAQJBAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARAJBAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQEDQQAuAEQDQQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEEQQAuAEQEQQAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBB0EALgBEB0EAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQEIQQAuAEQIQQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEJQQAu" +
           "AEQJQQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEKQQAvAQAjIwpB" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBC0EALgBEC0EAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBARNBAC8BACojE0EAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBFEEALgBEFEEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQEVQQAvAQAqIxVBAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABARZBAC4ARBZBAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBARdBAC8BACojF0EAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBGEEALgBEGEEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQEZQQAuAEQZQQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBGkEALwEA" +
           "RCMaQQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEbQQAvAQBDIxtBAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEcQQAvAQBFIxxBAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBHUEALgBEHUEAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBASJBAC8APyJBAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBI0EALwEAIyMjQQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "ASRBAC4ARCRBAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Electrical_EnergyConditionState Class
    #if (!OPCUA_EXCLUDE_Electrical_EnergyConditionState)
    /// <summary>
    /// Stores an instance of the Electrical_EnergyConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Electrical_EnergyConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Electrical_EnergyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Electrical_EnergyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JgAAAEVsZWN0cmljYWxfRW5lcmd5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQE8QQEBPEH/////GAAAADVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBPUEDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVy" +
           "IGZvciB0aGUgZXZlbnQuAC4ARD1BAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUBAT5BAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQ+QQAAABH/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBP0EDAAAAABgAAABUaGUgc291cmNl" +
           "IG9mIHRoZSBldmVudC4ALgBEP0EAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5h" +
           "bWUBAUBBAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE" +
           "QEEAAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAUFBAwAAAAAYAAAAV2hlbiB0aGUg" +
           "ZXZlbnQgb2NjdXJyZWQuAC4AREFBAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2Vp" +
           "dmVUaW1lAQFCQQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0" +
           "aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4AREJBAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAA" +
           "AExvY2FsVGltZQEBQ0EDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVy" +
           "ZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEQ0EAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAH" +
           "AAAATWVzc2FnZQEBREEDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQu" +
           "AC4ARERBAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBRUEDAAAAACEAAABJ" +
           "bmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBERUEAAAAF/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAUZBAC4AREZBAAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBAUdBAC4AREdBAAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAA0AAABDb25kaXRpb25OYW1lAQFKQQAuAERKQQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAI" +
           "AAAAQnJhbmNoSWQBAUtBAC4AREtBAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4B" +
           "AUxBAC4ARExBAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAU1BAC8B" +
           "ACMjTUEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFOQQAuAEROQQAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBVkEALwEAKiNWQQAAABP/////AQH/////AQAAABVg" +
           "iQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQFXQQAuAERXQQAAAQAmAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAVhBAC8BACojWEEAAAAF/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBWUEALgBEWUEAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAQ29tbWVudAEBWkEALwEAKiNaQQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFbQQAuAERbQQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGll" +
           "bnRVc2VySWQBAVxBAC4ARFxBAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFd" +
           "QQAvAQBEI11BAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAV5BAC8BAEMj" +
           "XkEAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAV9BAC8BAEUjX0EA" +
           "AAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFgQQAuAERgQQAA" +
           "lgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBm" +
           "b3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAk" +
           "AAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJ" +
           "CgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBZUEALwA/ZUEAAAAM/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAEFjdGl2ZVN0YXRlAQFmQQAvAQAjI2ZBAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIA" +
           "AABJZAEBZ0EALgBEZ0EAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Fill_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Fill_LevelConditionState)
    /// <summary>
    /// Stores an instance of the Fill_LevelConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Fill_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Fill_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Fill_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAEZpbGxfTGV2ZWxDb25kaXRpb25UeXBlSW5zdGFuY2UBAX9BAQF/Qf////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQGAQQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBEgEEAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBgUED" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARIFBAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQGCQQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAESCQQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBg0ED" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAESDQQAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBhEEDAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEhEEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AYVBAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEhUEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQGGQQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAESGQQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQGHQQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEh0EA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQGIQQMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAESIQQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBiUEALgBEiUEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBikEALgBEikEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAY1BAC4ARI1BAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBjkEALgBEjkEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBj0EALgBE" +
           "j0EAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBkEEALwEAIyOQQQAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAZFBAC4ARJFBAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGZQQAvAQAqI5lBAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAZpBAC4ARJpBAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBm0EALwEAKiObQQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGcQQAuAEScQQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGdQQAvAQAqI51BAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAZ5BAC4ARJ5BAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBn0EALgBEn0EAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAaBBAC8BAEQj" +
           "oEEAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBoUEALwEAQyOhQQAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBokEALwEARSOiQQAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAaNBAC4ARKNBAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGoQQAvAD+oQQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAalBAC8BACMjqUEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGq" +
           "QQAuAESqQQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FlowConditionState Class
    #if (!OPCUA_EXCLUDE_FlowConditionState)
    /// <summary>
    /// Stores an instance of the FlowConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlowConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.FlowConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAEZsb3dDb25kaXRpb25UeXBlSW5zdGFuY2UBAcJBAQHCQf////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQHDQQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEw0EAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBxEEDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARMRBAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHFQQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAETFQQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBxkEDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETGQQAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBx0EDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEx0EAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAchBAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEyEEAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQHJ" +
           "QQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAETJQQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQHK" +
           "QQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEykEAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHLQQMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAETLQQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBzEEALgBEzEEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBzUEALgBEzUEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAdBBAC4ARNBBAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "0UEALgBE0UEAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB0kEALgBE0kEAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB00EALwEAIyPTQQAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAdRBAC4ARNRBAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQHcQQAvAQAqI9xBAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAd1BAC4ARN1BAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEB3kEALwEAKiPeQQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHfQQAuAETfQQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQHgQQAvAQAqI+BBAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AeFBAC4AROFBAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB4kEA" +
           "LgBE4kEAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAeNBAC8BAEQj40EAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB5EEALwEAQyPkQQAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB5UEALwEARSPlQQAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAeZBAC4AROZBAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQHrQQAvAD/rQQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAexBAC8BACMj7EEAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHtQQAuAETt" +
           "QQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FrequencyConditionState Class
    #if (!OPCUA_EXCLUDE_FrequencyConditionState)
    /// <summary>
    /// Stores an instance of the FrequencyConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FrequencyConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FrequencyConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.FrequencyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAEZyZXF1ZW5jeUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBBUIBAQVC/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAQZCAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAEQGQgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQEHQgMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEB0IAAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAQhCAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4ARAhCAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQEJQgMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARAlCAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQEKQgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAEQKQgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "C0IDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAEQLQgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBAQxCAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4ARAxCAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBAQ1CAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQNQgAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAQ5CAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARA5CAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQEPQgAuAEQPQgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQEQQgAuAEQQQgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEBE0IALgBEE0IAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQEUQgAuAEQUQgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQEVQgAuAEQV" +
           "QgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQEWQgAvAQAjIxZCAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBF0IALgBEF0IAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAR9CAC8BACojH0IAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBIEIALgBEIEIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQEhQgAvAQAqIyFCAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABASJCAC4ARCJCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBASNCAC8BACojI0IAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEBJEIALgBEJEIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQElQgAuAEQlQgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBJkIALwEARCMm" +
           "QgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEnQgAvAQBDIydCAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEoQgAvAQBFIyhCAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBKUIALgBEKUIAAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAS5CAC8APy5CAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEBL0IALwEAIyMvQgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATBC" +
           "AC4ARDBCAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region HardwareConditionState Class
    #if (!OPCUA_EXCLUDE_HardwareConditionState)
    /// <summary>
    /// Stores an instance of the HardwareConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class HardwareConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public HardwareConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.HardwareConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAEhhcmR3YXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFIQgEBSEL/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBSUIDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARElCAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAUpCAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERKQgAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBS0IDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBES0IAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAUxCAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBETEIAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAU1CAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARE1CAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFO" +
           "QgMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARE5CAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBT0IDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBET0IAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBUEIDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARFBCAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBUUIDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEUUIAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAVJCAC4ARFJCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAVNCAC4ARFNCAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQFWQgAuAERWQgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAVdCAC4ARFdCAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAVhCAC4ARFhC" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAVlCAC8BACMjWUIAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFaQgAuAERaQgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBYkIALwEAKiNiQgAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFjQgAuAERjQgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAWRCAC8BACojZEIAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBZUIALgBEZUIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBZkIALwEAKiNmQgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFnQgAuAERnQgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AWhCAC4ARGhCAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFpQgAvAQBEI2lC" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAWpCAC8BAEMjakIAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAWtCAC8BAEUja0IAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFsQgAuAERsQgAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBcUIALwA/cUIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFyQgAvAQAjI3JCAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBc0IA" +
           "LgBEc0IAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Linear_ForceConditionState Class
    #if (!OPCUA_EXCLUDE_Linear_ForceConditionState)
    /// <summary>
    /// Stores an instance of the Linear_ForceConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Linear_ForceConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Linear_ForceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Linear_ForceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAExpbmVhcl9Gb3JjZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBi0IBAYtC/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAYxCAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAESMQgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGN" +
           "QgMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEjUIAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAY5CAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4ARI5CAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGP" +
           "QgMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARI9CAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQGQQgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAESQQgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEBkUIDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAESRQgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAZJCAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARJJCAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAZNCAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEST" +
           "QgAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAZRCAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARJRCAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQGVQgAuAESVQgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQGWQgAuAESWQgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBmUIALgBEmUIAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQGaQgAuAESaQgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGbQgAu" +
           "AESbQgAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGcQgAvAQAjI5xC" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBnUIALgBEnUIAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAaVCAC8BACojpUIAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBpkIALgBEpkIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQGnQgAvAQAqI6dCAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAahCAC4ARKhCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAalCAC8BACojqUIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBqkIALgBEqkIAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQGrQgAuAESrQgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBrEIALwEA" +
           "RCOsQgAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGtQgAvAQBDI61CAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGuQgAvAQBFI65CAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBr0IALgBEr0IAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAbRCAC8AP7RCAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBtUIALwEAIyO1QgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "AbZCAC4ARLZCAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadConditionState Class
    #if (!OPCUA_EXCLUDE_LoadConditionState)
    /// <summary>
    /// Stores an instance of the LoadConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.LoadConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAExvYWRDb25kaXRpb25UeXBlSW5zdGFuY2UBAc5CAQHOQv////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQHPQgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEz0IAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB0EIDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARNBCAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHRQgMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAETRQgAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB0kIDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETSQgAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB00IDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBE00IAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAdRCAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBE1EIAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQHV" +
           "QgMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAETVQgAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQHW" +
           "QgMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE1kIAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHXQgMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAETXQgAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEB2EIALgBE2EIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEB2UIALgBE2UIAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAdxCAC4ARNxCAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "3UIALgBE3UIAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB3kIALgBE3kIAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB30IALwEAIyPfQgAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAeBCAC4AROBCAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQHoQgAvAQAqI+hCAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAelCAC4AROlCAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEB6kIALwEAKiPqQgAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQHrQgAuAETrQgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQHsQgAvAQAqI+xCAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "Ae1CAC4ARO1CAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB7kIA" +
           "LgBE7kIAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAe9CAC8BAEQj70IAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB8EIALwEAQyPwQgAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB8UIALwEARSPxQgAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfJCAC4ARPJCAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQH3QgAvAD/3QgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAfhCAC8BACMj+EIAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQH5QgAuAET5" +
           "QgAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Logic_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Logic_ProgramConditionState)
    /// <summary>
    /// Stores an instance of the Logic_ProgramConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Logic_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Logic_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Logic_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAExvZ2ljX1Byb2dyYW1Db25kaXRpb25UeXBlSW5zdGFuY2UBARFDAQERQ/////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQESQwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBEEkMAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "E0MDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARBNDAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEUQwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAEQUQwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "FUMDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQVQwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBFkMDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBEFkMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBARdDAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBEF0MAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQEYQwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAEQYQwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQEZQwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "GUMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEaQwMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQaQwAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBG0MALgBEG0MAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBHEMALgBEHEMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAR9DAC4ARB9DAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBIEMALgBEIEMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBIUMA" +
           "LgBEIUMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBIkMALwEAIyMi" +
           "QwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASNDAC4ARCNDAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQErQwAvAQAqIytDAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABASxDAC4ARCxDAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBLUMALwEAKiMtQwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQEuQwAuAEQuQwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQEvQwAvAQAqIy9DAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABATBDAC4ARDBDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBMUMALgBEMUMAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBATJDAC8B" +
           "AEQjMkMAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBM0MALwEAQyMzQwAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBNEMALwEARSM0QwAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATVDAC4ARDVDAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQE6QwAvAD86QwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBATtDAC8BACMjO0MAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQE8QwAuAEQ8QwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MassConditionState Class
    #if (!OPCUA_EXCLUDE_MassConditionState)
    /// <summary>
    /// Stores an instance of the MassConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MassConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MassConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.MassConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAE1hc3NDb25kaXRpb25UeXBlSW5zdGFuY2UBAVRDAQFUQ/////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQFVQwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBEVUMAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBVkMDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARFZDAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFXQwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAERXQwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBWEMDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERYQwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBWUMDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEWUMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAVpDAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEWkMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQFb" +
           "QwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAERbQwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQFc" +
           "QwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEXEMAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFdQwMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAERdQwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBXkMALgBEXkMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBX0MALgBEX0MAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAWJDAC4ARGJDAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "Y0MALgBEY0MAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBZEMALgBEZEMAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBZUMALwEAIyNlQwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAWZDAC4ARGZDAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQFuQwAvAQAqI25DAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAW9DAC4ARG9DAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBcEMALwEAKiNwQwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQFxQwAuAERxQwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQFyQwAvAQAqI3JDAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AXNDAC4ARHNDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBdEMA" +
           "LgBEdEMAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAXVDAC8BAEQjdUMAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBdkMALwEAQyN2QwAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBd0MALwEARSN3QwAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXhDAC4ARHhDAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQF9QwAvAD99QwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAX5DAC8BACMjfkMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQF/QwAuAER/" +
           "QwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Motion_ProgramConditionState Class
    #if (!OPCUA_EXCLUDE_Motion_ProgramConditionState)
    /// <summary>
    /// Stores an instance of the Motion_ProgramConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Motion_ProgramConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Motion_ProgramConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Motion_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IwAAAE1vdGlvbl9Qcm9ncmFtQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGXQwEBl0P/////GAAAADVgiQoC" +
           "AAAAAAAHAAAARXZlbnRJZAEBmEMDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZv" +
           "ciB0aGUgZXZlbnQuAC4ARJhDAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AZlDAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESZQwAAABH/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBmkMDAAAAABgAAABUaGUgc291cmNlIG9m" +
           "IHRoZSBldmVudC4ALgBEmkMAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUB" +
           "AZtDAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEm0MA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAZxDAwAAAAAYAAAAV2hlbiB0aGUgZXZl" +
           "bnQgb2NjdXJyZWQuAC4ARJxDAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVU" +
           "aW1lAQGdQwMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUg" +
           "dW5kZXJseWluZyBzeXN0ZW0uAC4ARJ1DAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExv" +
           "Y2FsVGltZQEBnkMDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0" +
           "aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEnkMAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAA" +
           "TWVzc2FnZQEBn0MDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4A" +
           "RJ9DAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBoEMDAAAAACEAAABJbmRp" +
           "Y2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEoEMAAAAF/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAaFDAC4ARKFDAAAAEf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABIAAABDb25kaXRpb25DbGFzc05hbWUBAaJDAC4ARKJDAAAAFf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AA0AAABDb25kaXRpb25OYW1lAQGlQwAuAESlQwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAA" +
           "QnJhbmNoSWQBAaZDAC4ARKZDAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAadD" +
           "AC4ARKdDAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAahDAC8BACMj" +
           "qEMAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGpQwAuAESpQwAAAAH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBsUMALwEAKiOxQwAAABP/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGyQwAuAESyQwAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAwAAABMYXN0U2V2ZXJpdHkBAbNDAC8BACojs0MAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEBtEMALgBEtEMAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAH" +
           "AAAAQ29tbWVudAEBtUMALwEAKiO1QwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQG2QwAuAES2QwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRV" +
           "c2VySWQBAbdDAC4ARLdDAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQG4QwAv" +
           "AQBEI7hDAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAblDAC8BAEMjuUMA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAbpDAC8BAEUjukMAAAEB" +
           "AQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG7QwAuAES7QwAAlgIA" +
           "AAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAA" +
           "VGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIA" +
           "AAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBwEMALwA/wEMAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CwAAAEFjdGl2ZVN0YXRlAQHBQwAvAQAjI8FDAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJ" +
           "ZAEBwkMALgBEwkMAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_FeedrateConditionState Class
    #if (!OPCUA_EXCLUDE_Path_FeedrateConditionState)
    /// <summary>
    /// Stores an instance of the Path_FeedrateConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_FeedrateConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Path_FeedrateConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Path_FeedrateConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFBhdGhfRmVlZHJhdGVDb25kaXRpb25UeXBlSW5zdGFuY2UBAdpDAQHaQ/////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQHbQwMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBE20MAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "3EMDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARNxDAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHdQwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAETdQwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "3kMDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETeQwAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB30MDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBE30MAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAeBDAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBE4EMAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQHhQwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAEThQwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQHiQwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "4kMAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHjQwMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAETjQwAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEB5EMALgBE5EMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEB5UMALgBE5UMAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAehDAC4AROhDAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEB6UMALgBE6UMAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB6kMA" +
           "LgBE6kMAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB60MALwEAIyPr" +
           "QwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAexDAC4AROxDAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQH0QwAvAQAqI/RDAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAfVDAC4ARPVDAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEB9kMALwEAKiP2QwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQH3QwAuAET3QwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQH4QwAvAQAqI/hDAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAflDAC4ARPlDAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEB+kMALgBE+kMAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAftDAC8B" +
           "AEQj+0MAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB/EMALwEAQyP8QwAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB/UMALwEARSP9QwAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAf5DAC4ARP5DAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQEDRAAvAD8DRAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAQREAC8BACMjBEQAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQEFRAAuAEQFRAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Path_PositionConditionState Class
    #if (!OPCUA_EXCLUDE_Path_PositionConditionState)
    /// <summary>
    /// Stores an instance of the Path_PositionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Path_PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Path_PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Path_PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFBhdGhfUG9zaXRpb25Db25kaXRpb25UeXBlSW5zdGFuY2UBAR1EAQEdRP////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQEeRAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBEHkQAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "H0QDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARB9EAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEgRAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAEQgRAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "IUQDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQhRAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBIkQDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBEIkQAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBASNEAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBEI0QAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQEkRAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAEQkRAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQElRAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "JUQAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEmRAMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQmRAAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBJ0QALgBEJ0QAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBKEQALgBEKEQAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAStEAC4ARCtEAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBLEQALgBELEQAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBLUQA" +
           "LgBELUQAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBLkQALwEAIyMu" +
           "RAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAS9EAC4ARC9EAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQE3RAAvAQAqIzdEAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAThEAC4ARDhEAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBOUQALwEAKiM5RAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQE6RAAuAEQ6RAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQE7RAAvAQAqIztEAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABATxEAC4ARDxEAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBPUQALgBEPUQAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAT5EAC8B" +
           "AEQjPkQAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBP0QALwEAQyM/RAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBQEQALwEARSNARAAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUFEAC4AREFEAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQFGRAAvAD9GRAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAUdEAC8BACMjR0QAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQFIRAAuAERIRAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PHConditionState Class
    #if (!OPCUA_EXCLUDE_PHConditionState)
    /// <summary>
    /// Stores an instance of the PHConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PHConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PHConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PHConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "FwAAAFBIQ29uZGl0aW9uVHlwZUluc3RhbmNlAQFgRAEBYET/////GAAAADVgiQoCAAAAAAAHAAAARXZl" +
           "bnRJZAEBYUQDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQu" +
           "AC4ARGFEAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAWJEAwAAAAAiAAAA" +
           "VGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAERiRAAAABH/////AQH/////AAAAADVg" +
           "iQoCAAAAAAAKAAAAU291cmNlTm9kZQEBY0QDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBEY0QAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAWREAwAAAAApAAAA" +
           "QSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEZEQAAAAM/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAWVEAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2NjdXJyZWQu" +
           "AC4ARGVEAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFmRAMAAAAA" +
           "PgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJseWluZyBz" +
           "eXN0ZW0uAC4ARGZEAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGltZQEBZ0QD" +
           "AAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZlbnQgb3Jp" +
           "Z2luYXRlZC4ALgBEZ0QAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2FnZQEBaEQD" +
           "AAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARGhEAAAAFf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBaUQDAAAAACEAAABJbmRpY2F0ZXMgaG93IHVy" +
           "Z2VudCBhbiBldmVudCBpcy4ALgBEaUQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAAAENvbmRp" +
           "dGlvbkNsYXNzSWQBAWpEAC4ARGpEAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABDb25kaXRp" +
           "b25DbGFzc05hbWUBAWtEAC4ARGtEAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABDb25kaXRp" +
           "b25OYW1lAQFuRAAuAERuRAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNoSWQBAW9E" +
           "AC4ARG9EAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAXBEAC4ARHBEAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAXFEAC8BACMjcUQAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFyRAAuAERyRAAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAHAAAAUXVhbGl0eQEBekQALwEAKiN6RAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQF7RAAuAER7RAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABMYXN0" +
           "U2V2ZXJpdHkBAXxEAC8BACojfEQAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBfUQALgBEfUQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29tbWVudAEB" +
           "fkQALwEAKiN+RAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQF/" +
           "RAAuAER/RAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQBAYBEAC4A" +
           "RIBEAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGBRAAvAQBEI4FEAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAYJEAC8BAEMjgkQAAAEBAQAAAAEA+QsA" +
           "AQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAYNEAC8BAEUjg0QAAAEBAQAAAAEA+QsAAQAN" +
           "CwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGERAAuAESERAAAlgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4AAABNVEN1" +
           "cnJlbnRTdGF0ZQEBiUQALwA/iUQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFjdGl2ZVN0" +
           "YXRlAQGKRAAvAQAjI4pEAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBi0QALgBEi0QA" +
           "AAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PositionConditionState Class
    #if (!OPCUA_EXCLUDE_PositionConditionState)
    /// <summary>
    /// Stores an instance of the PositionConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PositionConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PositionConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFBvc2l0aW9uQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGjRAEBo0T/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBpEQDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARKREAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAaVEAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESlRAAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBpkQDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEpkQAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAadEAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEp0QAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAahEAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARKhEAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGp" +
           "RAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARKlEAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBqkQDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEqkQAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBq0QDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARKtEAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBrEQDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBErEQAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAa1EAC4ARK1EAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAa5EAC4ARK5EAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQGxRAAuAESxRAAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAbJEAC4ARLJEAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAbNEAC4ARLNE" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAbREAC8BACMjtEQAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQG1RAAuAES1RAAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBvUQALwEAKiO9RAAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQG+RAAuAES+RAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAb9EAC8BACojv0QAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBwEQALgBEwEQAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBwUQALwEAKiPBRAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQHCRAAuAETCRAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AcNEAC4ARMNEAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHERAAvAQBEI8RE" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAcVEAC8BAEMjxUQAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAcZEAC8BAEUjxkQAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHHRAAuAETHRAAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBzEQALwA/zEQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQHNRAAvAQAjI81EAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBzkQA" +
           "LgBEzkQAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Power_FactorConditionState Class
    #if (!OPCUA_EXCLUDE_Power_FactorConditionState)
    /// <summary>
    /// Stores an instance of the Power_FactorConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Power_FactorConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Power_FactorConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Power_FactorConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IQAAAFBvd2VyX0ZhY3RvckNvbmRpdGlvblR5cGVJbnN0YW5jZQEB5kQBAeZE/////xgAAAA1YIkKAgAA" +
           "AAAABwAAAEV2ZW50SWQBAedEAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3Ig" +
           "dGhlIGV2ZW50LgAuAETnRAAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHo" +
           "RAMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBE6EQAAAAR/////wEB" +
           "/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAelEAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0" +
           "aGUgZXZlbnQuAC4AROlEAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHq" +
           "RAMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4AROpEAAAA" +
           "DP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQHrRAMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50" +
           "IG9jY3VycmVkLgAuAETrRAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGlt" +
           "ZQEB7EQDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVu" +
           "ZGVybHlpbmcgc3lzdGVtLgAuAETsRAAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2Nh" +
           "bFRpbWUBAe1EAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhl" +
           "IGV2ZW50IG9yaWdpbmF0ZWQuAC4ARO1EAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1l" +
           "c3NhZ2UBAe5EAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAETu" +
           "RAAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAe9EAwAAAAAhAAAASW5kaWNh" +
           "dGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARO9EAAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQHwRAAuAETwRAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQHxRAAuAETxRAAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEB9EQALgBE9EQAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQH1RAAuAET1RAAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQH2RAAu" +
           "AET2RAAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQH3RAAvAQAjI/dE" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB+EQALgBE+EQAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAQBFAC8BACojAEUAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAUUALgBEAUUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQECRQAvAQAqIwJFAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAQNFAC4ARANFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAQRFAC8BACojBEUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBBUUALgBEBUUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQEGRQAuAEQGRQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBB0UALwEA" +
           "RCMHRQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQEIRQAvAQBDIwhFAAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEJRQAvAQBFIwlFAAABAQEA" +
           "AAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBCkUALgBECkUAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAOAAAATVRDdXJyZW50U3RhdGUBAQ9FAC8APw9FAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsA" +
           "AABBY3RpdmVTdGF0ZQEBEEUALwEAIyMQRQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQB" +
           "ARFFAC4ARBFFAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PressureConditionState Class
    #if (!OPCUA_EXCLUDE_PressureConditionState)
    /// <summary>
    /// Stores an instance of the PressureConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PressureConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PressureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.PressureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFByZXNzdXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQEpRQEBKUX/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBKkUDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARCpFAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAStFAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAEQrRQAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBLEUDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBELEUAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAS1FAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBELUUAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAS5FAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARC5FAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEv" +
           "RQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARC9FAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBMEUDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEMEUAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBMUUDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARDFFAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBMkUDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEMkUAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBATNFAC4ARDNFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBATRFAC4ARDRFAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQE3RQAuAEQ3RQAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAThFAC4ARDhFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BATlFAC4ARDlF" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBATpFAC8BACMjOkUAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE7RQAuAEQ7RQAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBQ0UALwEAKiNDRQAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFERQAuAERERQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAUVFAC8BACojRUUAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBRkUALgBERkUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBR0UALwEAKiNHRQAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQFIRQAuAERIRQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AUlFAC4ARElFAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQFKRQAvAQBEI0pF" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAUtFAC8BAEMjS0UAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAUxFAC8BAEUjTEUAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFNRQAuAERNRQAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBUkUALwA/UkUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQFTRQAvAQAjI1NFAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBVEUA" +
           "LgBEVEUAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ResistanceConditionState Class
    #if (!OPCUA_EXCLUDE_ResistanceConditionState)
    /// <summary>
    /// Stores an instance of the ResistanceConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResistanceConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResistanceConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ResistanceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HwAAAFJlc2lzdGFuY2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAWxFAQFsRf////8YAAAANWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAQFtRQMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudC4ALgBEbUUAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBbkUD" +
           "AAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARG5FAAAAEf////8BAf//" +
           "//8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFvRQMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhl" +
           "IGV2ZW50LgAuAERvRQAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBcEUD" +
           "AAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERwRQAAAAz/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBcUUDAAAAABgAAABXaGVuIHRoZSBldmVudCBv" +
           "Y2N1cnJlZC4ALgBEcUUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUB" +
           "AXJFAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRl" +
           "cmx5aW5nIHN5c3RlbS4ALgBEckUAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxU" +
           "aW1lAQFzRQMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBl" +
           "dmVudCBvcmlnaW5hdGVkLgAuAERzRQAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNz" +
           "YWdlAQF0RQMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEdEUA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQF1RQMAAAAAIQAAAEluZGljYXRl" +
           "cyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAER1RQAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQ" +
           "AAAAQ29uZGl0aW9uQ2xhc3NJZAEBdkUALgBEdkUAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAA" +
           "AENvbmRpdGlvbkNsYXNzTmFtZQEBd0UALgBEd0UAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAA" +
           "AENvbmRpdGlvbk5hbWUBAXpFAC4ARHpFAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBe0UALgBEe0UAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBfEUALgBE" +
           "fEUAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBfUUALwEAIyN9RQAA" +
           "ABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAX5FAC4ARH5FAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAcAAABRdWFsaXR5AQGGRQAvAQAqI4ZFAAAAE/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAYdFAC4ARIdFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DAAAAExhc3RTZXZlcml0eQEBiEUALwEAKiOIRQAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGJRQAuAESJRQAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABD" +
           "b21tZW50AQGKRQAvAQAqI4pFAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1l" +
           "c3RhbXABAYtFAC4ARItFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJ" +
           "ZAEBjEUALgBEjEUAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAY1FAC8BAEQj" +
           "jUUAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBjkUALwEAQyOORQAAAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBj0UALwEARSOPRQAAAQEBAAAA" +
           "AQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZBFAC4ARJBFAACWAgAAAAEA" +
           "KgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUg" +
           "Y29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAE1UQ3VycmVudFN0YXRlAQGVRQAvAD+VRQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAA" +
           "QWN0aXZlU3RhdGUBAZZFAC8BACMjlkUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGX" +
           "RQAuAESXRQAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Rotary_VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_Rotary_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the Rotary_VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Rotary_VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Rotary_VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Rotary_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "JAAAAFJvdGFyeV9WZWxvY2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBr0UBAa9F/////xgAAAA1YIkK" +
           "AgAAAAAABwAAAEV2ZW50SWQBAbBFAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBm" +
           "b3IgdGhlIGV2ZW50LgAuAESwRQAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AQGxRQMAAAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEsUUAAAAR////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAbJFAwAAAAAYAAAAVGhlIHNvdXJjZSBv" +
           "ZiB0aGUgZXZlbnQuAC4ARLJFAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1l" +
           "AQGzRQMAAAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARLNF" +
           "AAAADP////8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQG0RQMAAAAAGAAAAFdoZW4gdGhlIGV2" +
           "ZW50IG9jY3VycmVkLgAuAES0RQAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZl" +
           "VGltZQEBtUUDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhl" +
           "IHVuZGVybHlpbmcgc3lzdGVtLgAuAES1RQAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABM" +
           "b2NhbFRpbWUBAbZFAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUg" +
           "dGhlIGV2ZW50IG9yaWdpbmF0ZWQuAC4ARLZFAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAA" +
           "AE1lc3NhZ2UBAbdFAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAu" +
           "AES3RQAAABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAbhFAwAAAAAhAAAASW5k" +
           "aWNhdGVzIGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARLhFAAAABf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAABAAAABDb25kaXRpb25DbGFzc0lkAQG5RQAuAES5RQAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQG6RQAuAES6RQAAABX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAANAAAAQ29uZGl0aW9uTmFtZQEBvUUALgBEvUUAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAA" +
           "AEJyYW5jaElkAQG+RQAuAES+RQAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQG/" +
           "RQAuAES/RQAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHARQAvAQAj" +
           "I8BFAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBwUUALgBEwUUAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAclFAC8BACojyUUAAAAT/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBykUALgBEykUAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAMAAAATGFzdFNldmVyaXR5AQHLRQAvAQAqI8tFAAAABf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AA8AAABTb3VyY2VUaW1lc3RhbXABAcxFAC4ARMxFAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "BwAAAENvbW1lbnQBAc1FAC8BACojzUUAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJj" +
           "ZVRpbWVzdGFtcAEBzkUALgBEzkUAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50" +
           "VXNlcklkAQHPRQAuAETPRQAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB0EUA" +
           "LwEARCPQRQAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHRRQAvAQBDI9FF" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHSRQAvAQBFI9JFAAAB" +
           "AQEAAAABAPkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB00UALgBE00UAAJYC" +
           "AAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAA" +
           "AFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoC" +
           "AAAAAQAOAAAATVRDdXJyZW50U3RhdGUBAdhFAC8AP9hFAAAADP////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABBY3RpdmVTdGF0ZQEB2UUALwEAIyPZRQAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAA" +
           "SWQBAdpFAC4ARNpFAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Sound_LevelConditionState Class
    #if (!OPCUA_EXCLUDE_Sound_LevelConditionState)
    /// <summary>
    /// Stores an instance of the Sound_LevelConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Sound_LevelConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Sound_LevelConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Sound_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAFNvdW5kX0xldmVsQ29uZGl0aW9uVHlwZUluc3RhbmNlAQHyRQEB8kX/////GAAAADVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEB80UDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQuAC4ARPNFAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAfRF" +
           "AwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAET0RQAAABH/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEB9UUDAAAAABgAAABUaGUgc291cmNlIG9mIHRo" +
           "ZSBldmVudC4ALgBE9UUAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAfZF" +
           "AwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBE9kUAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAfdFAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQg" +
           "b2NjdXJyZWQuAC4ARPdFAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQH4RQMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5k" +
           "ZXJseWluZyBzeXN0ZW0uAC4ARPhFAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2Fs" +
           "VGltZQEB+UUDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUg" +
           "ZXZlbnQgb3JpZ2luYXRlZC4ALgBE+UUAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVz" +
           "c2FnZQEB+kUDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARPpF" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEB+0UDAAAAACEAAABJbmRpY2F0" +
           "ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBE+0UAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EAAAAENvbmRpdGlvbkNsYXNzSWQBAfxFAC4ARPxFAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIA" +
           "AABDb25kaXRpb25DbGFzc05hbWUBAf1FAC4ARP1FAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0A" +
           "AABDb25kaXRpb25OYW1lAQEARgAuAEQARgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJh" +
           "bmNoSWQBAQFGAC4ARAFGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAQJGAC4A" +
           "RAJGAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQNGAC8BACMjA0YA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEERgAuAEQERgAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBDEYALwEAKiMMRgAAABP/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQENRgAuAEQNRgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAwAAABMYXN0U2V2ZXJpdHkBAQ5GAC8BACojDkYAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBD0YALgBED0YAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "Q29tbWVudAEBEEYALwEAKiMQRgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQERRgAuAEQRRgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2Vy" +
           "SWQBARJGAC4ARBJGAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQETRgAvAQBE" +
           "IxNGAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBARRGAC8BAEMjFEYAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBARVGAC8BAEUjFUYAAAEBAQAA" +
           "AAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEWRgAuAEQWRgAAlgIAAAAB" +
           "ACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhl" +
           "IGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEBG0YALwA/G0YAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQEcRgAvAQAjIxxGAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "HUYALgBEHUYAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region StrainConditionState Class
    #if (!OPCUA_EXCLUDE_StrainConditionState)
    /// <summary>
    /// Stores an instance of the StrainConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StrainConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StrainConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.StrainConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFN0cmFpbkNvbmRpdGlvblR5cGVJbnN0YW5jZQEBNUYBATVG/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBATZGAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAEQ2RgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQE3RgMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEN0YAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAThGAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARDhGAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQE5RgMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARDlGAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQE6RgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAEQ6RgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBO0YD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAEQ7RgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "ATxGAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4ARDxGAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AT1GAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAEQ9RgAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAT5GAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARD5GAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQE/RgAuAEQ/RgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQFARgAuAERARgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEBQ0YALgBEQ0YAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQFERgAuAERERgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFFRgAuAERFRgAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFGRgAvAQAjI0ZGAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBR0YALgBER0YAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAU9GAC8BACojT0YAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBUEYALgBEUEYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQFRRgAvAQAqI1FGAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAVJGAC4ARFJGAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAVNGAC8BACojU0YAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBVEYALgBEVEYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFV" +
           "RgAuAERVRgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBVkYALwEARCNWRgAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFXRgAvAQBDI1dGAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFYRgAvAQBFI1hGAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWUYALgBEWUYAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAV5GAC8AP15GAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBX0YALwEAIyNfRgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAWBGAC4A" +
           "RGBGAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SystemConditionState Class
    #if (!OPCUA_EXCLUDE_SystemConditionState)
    /// <summary>
    /// Stores an instance of the SystemConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SystemConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SystemConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.SystemConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFN5c3RlbUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBeEYBAXhG/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAXlGAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAER5RgAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQF6RgMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEekYAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAXtGAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARHtGAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQF8RgMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARHxGAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQF9RgMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAER9RgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBfkYD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAER+RgAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "AX9GAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4ARH9GAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AYBGAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAESARgAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAYFGAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARIFGAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQGCRgAuAESCRgAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQGDRgAuAESDRgAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEBhkYALgBEhkYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQGHRgAuAESHRgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQGIRgAuAESIRgAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQGJRgAvAQAjI4lGAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBikYALgBEikYAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAZJGAC8BACojkkYAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBk0YALgBEk0YAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQGURgAvAQAqI5RGAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAZVGAC4ARJVGAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAZZGAC8BACojlkYAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBl0YALgBEl0YAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQGY" +
           "RgAuAESYRgAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBmUYALwEARCOZRgAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQGaRgAvAQBDI5pGAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQGbRgAvAQBFI5tGAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnEYALgBEnEYAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAaFGAC8AP6FGAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBokYALwEAIyOiRgAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAaNGAC4A" +
           "RKNGAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TemperatureConditionState Class
    #if (!OPCUA_EXCLUDE_TemperatureConditionState)
    /// <summary>
    /// Stores an instance of the TemperatureConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TemperatureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IAAAAFRlbXBlcmF0dXJlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQG7RgEBu0b/////GAAAADVgiQoCAAAA" +
           "AAAHAAAARXZlbnRJZAEBvEYDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQuAC4ARLxGAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAb1G" +
           "AwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAES9RgAAABH/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBvkYDAAAAABgAAABUaGUgc291cmNlIG9mIHRo" +
           "ZSBldmVudC4ALgBEvkYAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAb9G" +
           "AwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEv0YAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAcBGAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQg" +
           "b2NjdXJyZWQuAC4ARMBGAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1l" +
           "AQHBRgMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5k" +
           "ZXJseWluZyBzeXN0ZW0uAC4ARMFGAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2Fs" +
           "VGltZQEBwkYDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUg" +
           "ZXZlbnQgb3JpZ2luYXRlZC4ALgBEwkYAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVz" +
           "c2FnZQEBw0YDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARMNG" +
           "AAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBxEYDAAAAACEAAABJbmRpY2F0" +
           "ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBExEYAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EAAAAENvbmRpdGlvbkNsYXNzSWQBAcVGAC4ARMVGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIA" +
           "AABDb25kaXRpb25DbGFzc05hbWUBAcZGAC4ARMZGAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0A" +
           "AABDb25kaXRpb25OYW1lAQHJRgAuAETJRgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJh" +
           "bmNoSWQBAcpGAC4ARMpGAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BActGAC4A" +
           "RMtGAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAcxGAC8BACMjzEYA" +
           "AAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHNRgAuAETNRgAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEB1UYALwEAKiPVRgAAABP/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQHWRgAuAETWRgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "AAwAAABMYXN0U2V2ZXJpdHkBAddGAC8BACoj10YAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEB2EYALgBE2EYAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAA" +
           "Q29tbWVudAEB2UYALwEAKiPZRgAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGlt" +
           "ZXN0YW1wAQHaRgAuAETaRgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2Vy" +
           "SWQBAdtGAC4ARNtGAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQHcRgAvAQBE" +
           "I9xGAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAd1GAC8BAEMj3UYAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAd5GAC8BAEUj3kYAAAEBAQAA" +
           "AAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQHfRgAuAETfRgAAlgIAAAAB" +
           "ACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhl" +
           "IGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAAB" +
           "AA4AAABNVEN1cnJlbnRTdGF0ZQEB5EYALwA/5EYAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAA" +
           "AEFjdGl2ZVN0YXRlAQHlRgAvAQAjI+VGAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB" +
           "5kYALgBE5kYAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TiltConditionState Class
    #if (!OPCUA_EXCLUDE_TiltConditionState)
    /// <summary>
    /// Stores an instance of the TiltConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TiltConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TiltConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TiltConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GQAAAFRpbHRDb25kaXRpb25UeXBlSW5zdGFuY2UBAf5GAQH+Rv////8YAAAANWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAQH/RgMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dC4ALgBE/0YAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBAEcDAAAAACIA" +
           "AABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARABHAAAAEf////8BAf////8AAAAA" +
           "NWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEBRwMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50" +
           "LgAuAEQBRwAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBAkcDAAAAACkA" +
           "AABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQCRwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBA0cDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1cnJl" +
           "ZC4ALgBEA0cAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAQRHAwAA" +
           "AAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5aW5n" +
           "IHN5c3RlbS4ALgBEBEcAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1lAQEF" +
           "RwMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVudCBv" +
           "cmlnaW5hdGVkLgAuAEQFRwAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdlAQEG" +
           "RwMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEBkcAAAAV////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQEHRwMAAAAAIQAAAEluZGljYXRlcyBob3cg" +
           "dXJnZW50IGFuIGV2ZW50IGlzLgAuAEQHRwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NJZAEBCEcALgBECEcAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENvbmRp" +
           "dGlvbkNsYXNzTmFtZQEBCUcALgBECUcAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENvbmRp" +
           "dGlvbk5hbWUBAQxHAC4ARAxHAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "DUcALgBEDUcAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBDkcALgBEDkcAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBD0cALwEAIyMPRwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARBHAC4ARBBHAAAAAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABRdWFsaXR5AQEYRwAvAQAqIxhHAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABARlHAC4ARBlHAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAExh" +
           "c3RTZXZlcml0eQEBGkcALwEAKiMaRwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQEbRwAuAEQbRwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21tZW50" +
           "AQEcRwAvAQAqIxxHAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXAB" +
           "AR1HAC4ARB1HAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEBHkcA" +
           "LgBEHkcAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAR9HAC8BAEQjH0cAAAEB" +
           "AQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBIEcALwEAQyMgRwAAAQEBAAAAAQD5" +
           "CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBIUcALwEARSMhRwAAAQEBAAAAAQD5CwAB" +
           "AA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASJHAC4ARCJHAACWAgAAAAEAKgEBRgAA" +
           "AAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQg" +
           "dG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29tbWVu" +
           "dCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAAAE1U" +
           "Q3VycmVudFN0YXRlAQEnRwAvAD8nRwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0aXZl" +
           "U3RhdGUBAShHAC8BACMjKEcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEpRwAuAEQp" +
           "RwAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TorqueConditionState Class
    #if (!OPCUA_EXCLUDE_TorqueConditionState)
    /// <summary>
    /// Stores an instance of the TorqueConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TorqueConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TorqueConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.TorqueConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "GwAAAFRvcnF1ZUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBQUcBAUFH/////xgAAAA1YIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAUJHAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50LgAuAERCRwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQFDRwMAAAAA" +
           "IgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEQ0cAAAAR/////wEB/////wAA" +
           "AAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAURHAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUgZXZl" +
           "bnQuAC4ARERHAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQFFRwMAAAAA" +
           "KQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4AREVHAAAADP////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQFGRwMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9jY3Vy" +
           "cmVkLgAuAERGRwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBR0cD" +
           "AAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVybHlp" +
           "bmcgc3lzdGVtLgAuAERHRwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRpbWUB" +
           "AUhHAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2ZW50" +
           "IG9yaWdpbmF0ZWQuAC4AREhHAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3NhZ2UB" +
           "AUlHAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAERJRwAAABX/" +
           "////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAUpHAwAAAAAhAAAASW5kaWNhdGVzIGhv" +
           "dyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4AREpHAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAAAABD" +
           "b25kaXRpb25DbGFzc0lkAQFLRwAuAERLRwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAAQ29u" +
           "ZGl0aW9uQ2xhc3NOYW1lAQFMRwAuAERMRwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAAQ29u" +
           "ZGl0aW9uTmFtZQEBT0cALgBET0cAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5jaElk" +
           "AQFQRwAuAERQRwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFRRwAuAERRRwAA" +
           "AAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFSRwAvAQAjI1JHAAAAFf//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBU0cALgBEU0cAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAFF1YWxpdHkBAVtHAC8BACojW0cAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAADwAA" +
           "AFNvdXJjZVRpbWVzdGFtcAEBXEcALgBEXEcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAA" +
           "TGFzdFNldmVyaXR5AQFdRwAvAQAqI11HAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3Vy" +
           "Y2VUaW1lc3RhbXABAV5HAC4ARF5HAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENvbW1l" +
           "bnQBAV9HAC8BACojX0cAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFt" +
           "cAEBYEcALgBEYEcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklkAQFh" +
           "RwAuAERhRwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBYkcALwEARCNiRwAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFjRwAvAQBDI2NHAAABAQEAAAAB" +
           "APkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQFkRwAvAQBFI2RHAAABAQEAAAABAPkL" +
           "AAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBZUcALgBEZUcAAJYCAAAAAQAqAQFG" +
           "AAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVu" +
           "dCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21t" +
           "ZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "TVRDdXJyZW50U3RhdGUBAWpHAC8AP2pHAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBY3Rp" +
           "dmVTdGF0ZQEBa0cALwEAIyNrRwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAWxHAC4A" +
           "RGxHAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VelocityConditionState Class
    #if (!OPCUA_EXCLUDE_VelocityConditionState)
    /// <summary>
    /// Stores an instance of the VelocityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VelocityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VelocityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HQAAAFZlbG9jaXR5Q29uZGl0aW9uVHlwZUluc3RhbmNlAQGERwEBhEf/////GAAAADVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEBhUcDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlmaWVyIGZvciB0aGUg" +
           "ZXZlbnQuAC4ARIVHAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAYZHAwAA" +
           "AAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESGRwAAABH/////AQH/////" +
           "AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBh0cDAAAAABgAAABUaGUgc291cmNlIG9mIHRoZSBl" +
           "dmVudC4ALgBEh0cAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAYhHAwAA" +
           "AAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4ALgBEiEcAAAAM////" +
           "/wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAYlHAwAAAAAYAAAAV2hlbiB0aGUgZXZlbnQgb2Nj" +
           "dXJyZWQuAC4ARIlHAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQGK" +
           "RwMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJvbSB0aGUgdW5kZXJs" +
           "eWluZyBzeXN0ZW0uAC4ARIpHAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAExvY2FsVGlt" +
           "ZQEBi0cDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3aGVyZSB0aGUgZXZl" +
           "bnQgb3JpZ2luYXRlZC4ALgBEi0cAAAEA0CL/////AQH/////AAAAADVgiQoCAAAAAAAHAAAATWVzc2Fn" +
           "ZQEBjEcDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZlbnQuAC4ARIxHAAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBjUcDAAAAACEAAABJbmRpY2F0ZXMg" +
           "aG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEjUcAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAAEAAA" +
           "AENvbmRpdGlvbkNsYXNzSWQBAY5HAC4ARI5HAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAABIAAABD" +
           "b25kaXRpb25DbGFzc05hbWUBAY9HAC4ARI9HAAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQGSRwAuAESSRwAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAQnJhbmNo" +
           "SWQBAZNHAC4ARJNHAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRhaW4BAZRHAC4ARJRH" +
           "AAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAZVHAC8BACMjlUcAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGWRwAuAESWRwAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAAHAAAAUXVhbGl0eQEBnkcALwEAKiOeRwAAABP/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQGfRwAuAESfRwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAaBHAC8BACojoEcAAAAF/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNv" +
           "dXJjZVRpbWVzdGFtcAEBoUcALgBEoUcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAAQ29t" +
           "bWVudAEBokcALwEAKiOiRwAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQGjRwAuAESjRwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABDbGllbnRVc2VySWQB" +
           "AaRHAC4ARKRHAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxlAQGlRwAvAQBEI6VH" +
           "AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAaZHAC8BAEMjpkcAAAEBAQAA" +
           "AAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAadHAC8BAEUjp0cAAAEBAQAAAAEA" +
           "+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGoRwAuAESoRwAAlgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAAFWCJCgIAAAABAA4A" +
           "AABNVEN1cnJlbnRTdGF0ZQEBrUcALwA/rUcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAEFj" +
           "dGl2ZVN0YXRlAQGuRwAvAQAjI65HAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBr0cA" +
           "LgBEr0cAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ViscosityConditionState Class
    #if (!OPCUA_EXCLUDE_ViscosityConditionState)
    /// <summary>
    /// Stores an instance of the ViscosityConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ViscosityConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ViscosityConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.ViscosityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HgAAAFZpc2Nvc2l0eUNvbmRpdGlvblR5cGVJbnN0YW5jZQEBx0cBAcdH/////xgAAAA1YIkKAgAAAAAA" +
           "BwAAAEV2ZW50SWQBAchHAwAAAAArAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBmb3IgdGhl" +
           "IGV2ZW50LgAuAETIRwAAAA//////AQH/////AAAAADVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHJRwMA" +
           "AAAAIgAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZlbnQgdHlwZS4ALgBEyUcAAAAR/////wEB////" +
           "/wAAAAA1YIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAcpHAwAAAAAYAAAAVGhlIHNvdXJjZSBvZiB0aGUg" +
           "ZXZlbnQuAC4ARMpHAAAAEf////8BAf////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHLRwMA" +
           "AAAAKQAAAEEgZGVzY3JpcHRpb24gb2YgdGhlIHNvdXJjZSBvZiB0aGUgZXZlbnQuAC4ARMtHAAAADP//" +
           "//8BAf////8AAAAANWCJCgIAAAAAAAQAAABUaW1lAQHMRwMAAAAAGAAAAFdoZW4gdGhlIGV2ZW50IG9j" +
           "Y3VycmVkLgAuAETMRwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "zUcDAAAAAD4AAABXaGVuIHRoZSBzZXJ2ZXIgcmVjZWl2ZWQgdGhlIGV2ZW50IGZyb20gdGhlIHVuZGVy" +
           "bHlpbmcgc3lzdGVtLgAuAETNRwAAAQAmAf////8BAf////8AAAAANWCJCgIAAAAAAAkAAABMb2NhbFRp" +
           "bWUBAc5HAwAAAAA8AAAASW5mb3JtYXRpb24gYWJvdXQgdGhlIGxvY2FsIHRpbWUgd2hlcmUgdGhlIGV2" +
           "ZW50IG9yaWdpbmF0ZWQuAC4ARM5HAAABANAi/////wEB/////wAAAAA1YIkKAgAAAAAABwAAAE1lc3Nh" +
           "Z2UBAc9HAwAAAAAlAAAAQSBsb2NhbGl6ZWQgZGVzY3JpcHRpb24gb2YgdGhlIGV2ZW50LgAuAETPRwAA" +
           "ABX/////AQH/////AAAAADVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAdBHAwAAAAAhAAAASW5kaWNhdGVz" +
           "IGhvdyB1cmdlbnQgYW4gZXZlbnQgaXMuAC4ARNBHAAAABf////8BAf////8AAAAAFWCJCgIAAAAAABAA" +
           "AABDb25kaXRpb25DbGFzc0lkAQHRRwAuAETRRwAAABH/////AQH/////AAAAABVgiQoCAAAAAAASAAAA" +
           "Q29uZGl0aW9uQ2xhc3NOYW1lAQHSRwAuAETSRwAAABX/////AQH/////AAAAABVgiQoCAAAAAAANAAAA" +
           "Q29uZGl0aW9uTmFtZQEB1UcALgBE1UcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJyYW5j" +
           "aElkAQHWRwAuAETWRwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQHXRwAuAETX" +
           "RwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQHYRwAvAQAjI9hHAAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB2UcALgBE2UcAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFF1YWxpdHkBAeFHAC8BACoj4UcAAAAT/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "DwAAAFNvdXJjZVRpbWVzdGFtcAEB4kcALgBE4kcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAM" +
           "AAAATGFzdFNldmVyaXR5AQHjRwAvAQAqI+NHAAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABT" +
           "b3VyY2VUaW1lc3RhbXABAeRHAC4ARORHAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAENv" +
           "bW1lbnQBAeVHAC8BACoj5UcAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVz" +
           "dGFtcAEB5kcALgBE5kcAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNlcklk" +
           "AQHnRwAuAETnRwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEB6EcALwEARCPo" +
           "RwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQHpRwAvAQBDI+lHAAABAQEA" +
           "AAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQHqRwAvAQBFI+pHAAABAQEAAAAB" +
           "APkLAAEADQsBAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB60cALgBE60cAAJYCAAAAAQAq" +
           "AQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBj" +
           "b21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQH/////AAAAABVgiQoCAAAAAQAO" +
           "AAAATVRDdXJyZW50U3RhdGUBAfBHAC8AP/BHAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABB" +
           "Y3RpdmVTdGF0ZQEB8UcALwEAIyPxRwAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAfJH" +
           "AC4ARPJHAAAAAf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltageConditionState Class
    #if (!OPCUA_EXCLUDE_VoltageConditionState)
    /// <summary>
    /// Stores an instance of the VoltageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VoltageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HAAAAFZvbHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAQpIAQEKSP////8YAAAANWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQELSAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudC4ALgBEC0gAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBDEgDAAAA" +
           "ACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARAxIAAAAEf////8BAf////8A" +
           "AAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQENSAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2" +
           "ZW50LgAuAEQNSAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEBDkgDAAAA" +
           "ACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAEQOSAAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBD0gDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1" +
           "cnJlZC4ALgBED0gAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBARBI" +
           "AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5" +
           "aW5nIHN5c3RlbS4ALgBEEEgAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1l" +
           "AQERSAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVu" +
           "dCBvcmlnaW5hdGVkLgAuAEQRSAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdl" +
           "AQESSAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBEEkgAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQETSAMAAAAAIQAAAEluZGljYXRlcyBo" +
           "b3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAEQTSAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBFEgALgBEFEgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBFUgALgBEFUgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBARhIAC4ARBhIAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBGUgALgBEGUgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBGkgALgBEGkgA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBG0gALwEAIyMbSAAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBARxIAC4ARBxIAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQEkSAAvAQAqIyRIAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABASVIAC4ARCVIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBJkgALwEAKiMmSAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQEnSAAuAEQnSAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQEoSAAvAQAqIyhIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABASlIAC4ARClIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "KkgALgBEKkgAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAStIAC8BAEQjK0gA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBLEgALwEAQyMsSAAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBLUgALwEARSMtSAAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAS5IAC4ARC5IAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQEzSAAvAD8zSAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBATRIAC8BACMjNEgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQE1SAAu" +
           "AEQ1SAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region Volt_AmperageConditionState Class
    #if (!OPCUA_EXCLUDE_Volt_AmperageConditionState)
    /// <summary>
    /// Stores an instance of the Volt_AmperageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Volt_AmperageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Volt_AmperageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.Volt_AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "IgAAAFZvbHRfQW1wZXJhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAU1IAQFNSP////8YAAAANWCJCgIA" +
           "AAAAAAcAAABFdmVudElkAQFOSAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9y" +
           "IHRoZSBldmVudC4ALgBETkgAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "T0gDAAAAACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARE9IAAAAEf////8B" +
           "Af////8AAAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQFQSAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2Yg" +
           "dGhlIGV2ZW50LgAuAERQSAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB" +
           "UUgDAAAAACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAERRSAAA" +
           "AAz/////AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEBUkgDAAAAABgAAABXaGVuIHRoZSBldmVu" +
           "dCBvY2N1cnJlZC4ALgBEUkgAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRp" +
           "bWUBAVNIAwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1" +
           "bmRlcmx5aW5nIHN5c3RlbS4ALgBEU0gAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9j" +
           "YWxUaW1lAQFUSAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRo" +
           "ZSBldmVudCBvcmlnaW5hdGVkLgAuAERUSAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABN" +
           "ZXNzYWdlAQFVSAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE" +
           "VUgAAAAV/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQFWSAMAAAAAIQAAAEluZGlj" +
           "YXRlcyBob3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAERWSAAAAAX/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBV0gALgBEV0gAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "EgAAAENvbmRpdGlvbkNsYXNzTmFtZQEBWEgALgBEWEgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DQAAAENvbmRpdGlvbk5hbWUBAVtIAC4ARFtIAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABC" +
           "cmFuY2hJZAEBXEgALgBEXEgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBXUgA" +
           "LgBEXUgAAAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBXkgALwEAIyNe" +
           "SAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAV9IAC4ARF9IAAAAAf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAcAAABRdWFsaXR5AQFnSAAvAQAqI2dIAAAAE/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAAA8AAABTb3VyY2VUaW1lc3RhbXABAWhIAC4ARGhIAAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAADAAAAExhc3RTZXZlcml0eQEBaUgALwEAKiNpSAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAP" +
           "AAAAU291cmNlVGltZXN0YW1wAQFqSAAuAERqSAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcA" +
           "AABDb21tZW50AQFrSAAvAQAqI2tIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VU" +
           "aW1lc3RhbXABAWxIAC4ARGxIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVz" +
           "ZXJJZAEBbUgALgBEbUgAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAW5IAC8B" +
           "AEQjbkgAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBb0gALwEAQyNvSAAA" +
           "AQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBcEgALwEARSNwSAAAAQEB" +
           "AAAAAQD5CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAXFIAC4ARHFIAACWAgAA" +
           "AAEAKgEBRgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0" +
           "aGUgZXZlbnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABU" +
           "aGUgY29tbWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADgAAAE1UQ3VycmVudFN0YXRlAQF2SAAvAD92SAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAL" +
           "AAAAQWN0aXZlU3RhdGUBAXdIAC8BACMjd0gAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElk" +
           "AQF4SAAuAER4SAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region VoltAmperageReactiveConditionState Class
    #if (!OPCUA_EXCLUDE_VoltAmperageReactiveConditionState)
    /// <summary>
    /// Stores an instance of the VoltAmperageReactiveConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VoltAmperageReactiveConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VoltAmperageReactiveConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.VoltAmperageReactiveConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "KQAAAFZvbHRBbXBlcmFnZVJlYWN0aXZlQ29uZGl0aW9uVHlwZUluc3RhbmNlAQGQSAEBkEj/////GAAA" +
           "ADVgiQoCAAAAAAAHAAAARXZlbnRJZAEBkUgDAAAAACsAAABBIGdsb2JhbGx5IHVuaXF1ZSBpZGVudGlm" +
           "aWVyIGZvciB0aGUgZXZlbnQuAC4ARJFIAAAAD/////8BAf////8AAAAANWCJCgIAAAAAAAkAAABFdmVu" +
           "dFR5cGUBAZJIAwAAAAAiAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0eXBlLgAuAESSSAAA" +
           "ABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBk0gDAAAAABgAAABUaGUgc291" +
           "cmNlIG9mIHRoZSBldmVudC4ALgBEk0gAAAAR/////wEB/////wAAAAA1YIkKAgAAAAAACgAAAFNvdXJj" +
           "ZU5hbWUBAZRIAwAAAAApAAAAQSBkZXNjcmlwdGlvbiBvZiB0aGUgc291cmNlIG9mIHRoZSBldmVudC4A" +
           "LgBElEgAAAAM/////wEB/////wAAAAA1YIkKAgAAAAAABAAAAFRpbWUBAZVIAwAAAAAYAAAAV2hlbiB0" +
           "aGUgZXZlbnQgb2NjdXJyZWQuAC4ARJVIAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAACwAAAFJl" +
           "Y2VpdmVUaW1lAQGWSAMAAAAAPgAAAFdoZW4gdGhlIHNlcnZlciByZWNlaXZlZCB0aGUgZXZlbnQgZnJv" +
           "bSB0aGUgdW5kZXJseWluZyBzeXN0ZW0uAC4ARJZIAAABACYB/////wEB/////wAAAAA1YIkKAgAAAAAA" +
           "CQAAAExvY2FsVGltZQEBl0gDAAAAADwAAABJbmZvcm1hdGlvbiBhYm91dCB0aGUgbG9jYWwgdGltZSB3" +
           "aGVyZSB0aGUgZXZlbnQgb3JpZ2luYXRlZC4ALgBEl0gAAAEA0CL/////AQH/////AAAAADVgiQoCAAAA" +
           "AAAHAAAATWVzc2FnZQEBmEgDAAAAACUAAABBIGxvY2FsaXplZCBkZXNjcmlwdGlvbiBvZiB0aGUgZXZl" +
           "bnQuAC4ARJhIAAAAFf////8BAf////8AAAAANWCJCgIAAAAAAAgAAABTZXZlcml0eQEBmUgDAAAAACEA" +
           "AABJbmRpY2F0ZXMgaG93IHVyZ2VudCBhbiBldmVudCBpcy4ALgBEmUgAAAAF/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAAEAAAAENvbmRpdGlvbkNsYXNzSWQBAZpIAC4ARJpIAAAAEf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAABIAAABDb25kaXRpb25DbGFzc05hbWUBAZtIAC4ARJtIAAAAFf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAA0AAABDb25kaXRpb25OYW1lAQGeSAAuAESeSAAAAAz/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAIAAAAQnJhbmNoSWQBAZ9IAC4ARJ9IAAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAYAAABSZXRh" +
           "aW4BAaBIAC4ARKBIAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABFbmFibGVkU3RhdGUBAaFI" +
           "AC8BACMjoUgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGiSAAuAESiSAAAAAH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAAUXVhbGl0eQEBqkgALwEAKiOqSAAAABP/////AQH/////AQAA" +
           "ABVgiQoCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQGrSAAuAESrSAAAAQAmAf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAaxIAC8BACojrEgAAAAF/////wEB/////wEAAAAVYIkK" +
           "AgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBrUgALgBErUgAAAEAJgH/////AQH/////AAAAABVgiQoC" +
           "AAAAAAAHAAAAQ29tbWVudAEBrkgALwEAKiOuSAAAABX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAA" +
           "U291cmNlVGltZXN0YW1wAQGvSAAuAESvSAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABD" +
           "bGllbnRVc2VySWQBAbBIAC4ARLBIAAAADP////8BAf////8AAAAABGGCCgQAAAAAAAcAAABEaXNhYmxl" +
           "AQGxSAAvAQBEI7FIAAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAYAAABFbmFibGUBAbJIAC8B" +
           "AEMjskgAAAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAACgAAAEFkZENvbW1lbnQBAbNIAC8BAEUj" +
           "s0gAAAEBAQAAAAEA+QsAAQANCwEAAAAVYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG0SAAuAES0" +
           "SAAAlgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmll" +
           "ciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAA" +
           "AAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAf////8AAAAA" +
           "FWCJCgIAAAABAA4AAABNVEN1cnJlbnRTdGF0ZQEBuUgALwA/uUgAAAAM/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAEFjdGl2ZVN0YXRlAQG6SAAvAQAjI7pIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAIAAABJZAEBu0gALgBEu0gAAAAB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region WattageConditionState Class
    #if (!OPCUA_EXCLUDE_WattageConditionState)
    /// <summary>
    /// Stores an instance of the WattageConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WattageConditionState : MTConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WattageConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.MTConnect.ObjectTypes.WattageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTVRDb25uZWN0L/////8EYIAAAQAAAAEA" +
           "HAAAAFdhdHRhZ2VDb25kaXRpb25UeXBlSW5zdGFuY2UBAdNIAQHTSP////8YAAAANWCJCgIAAAAAAAcA" +
           "AABFdmVudElkAQHUSAMAAAAAKwAAAEEgZ2xvYmFsbHkgdW5pcXVlIGlkZW50aWZpZXIgZm9yIHRoZSBl" +
           "dmVudC4ALgBE1EgAAAAP/////wEB/////wAAAAA1YIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB1UgDAAAA" +
           "ACIAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHR5cGUuAC4ARNVIAAAAEf////8BAf////8A" +
           "AAAANWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHWSAMAAAAAGAAAAFRoZSBzb3VyY2Ugb2YgdGhlIGV2" +
           "ZW50LgAuAETWSAAAABH/////AQH/////AAAAADVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB10gDAAAA" +
           "ACkAAABBIGRlc2NyaXB0aW9uIG9mIHRoZSBzb3VyY2Ugb2YgdGhlIGV2ZW50LgAuAETXSAAAAAz/////" +
           "AQH/////AAAAADVgiQoCAAAAAAAEAAAAVGltZQEB2EgDAAAAABgAAABXaGVuIHRoZSBldmVudCBvY2N1" +
           "cnJlZC4ALgBE2EgAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAdlI" +
           "AwAAAAA+AAAAV2hlbiB0aGUgc2VydmVyIHJlY2VpdmVkIHRoZSBldmVudCBmcm9tIHRoZSB1bmRlcmx5" +
           "aW5nIHN5c3RlbS4ALgBE2UgAAAEAJgH/////AQH/////AAAAADVgiQoCAAAAAAAJAAAATG9jYWxUaW1l" +
           "AQHaSAMAAAAAPAAAAEluZm9ybWF0aW9uIGFib3V0IHRoZSBsb2NhbCB0aW1lIHdoZXJlIHRoZSBldmVu" +
           "dCBvcmlnaW5hdGVkLgAuAETaSAAAAQDQIv////8BAf////8AAAAANWCJCgIAAAAAAAcAAABNZXNzYWdl" +
           "AQHbSAMAAAAAJQAAAEEgbG9jYWxpemVkIGRlc2NyaXB0aW9uIG9mIHRoZSBldmVudC4ALgBE20gAAAAV" +
           "/////wEB/////wAAAAA1YIkKAgAAAAAACAAAAFNldmVyaXR5AQHcSAMAAAAAIQAAAEluZGljYXRlcyBo" +
           "b3cgdXJnZW50IGFuIGV2ZW50IGlzLgAuAETcSAAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEB3UgALgBE3UgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEB3kgALgBE3kgAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBAeFIAC4AROFIAAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEB4kgALgBE4kgAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEB40gALgBE40gA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEB5EgALwEAIyPkSAAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAeVIAC4AROVIAAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQHtSAAvAQAqI+1IAAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAe5IAC4ARO5IAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEB70gALwEAKiPvSAAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQHwSAAuAETwSAAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQHxSAAvAQAqI/FIAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAfJIAC4ARPJIAAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "80gALgBE80gAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAfRIAC8BAEQj9EgA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEB9UgALwEAQyP1SAAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEB9kgALwEARSP2SAAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABVgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfdIAC4ARPdIAACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AE1UQ3VycmVudFN0YXRlAQH8SAAvAD/8SAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAQWN0" +
           "aXZlU3RhdGUBAf1IAC8BACMj/UgAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQH+SAAu" +
           "AET+SAAAAAH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}
