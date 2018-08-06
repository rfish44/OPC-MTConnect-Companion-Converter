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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.MTConnect
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the ActuatorStateTypeEnum DataType.
        /// </summary>
        public const uint ActuatorStateTypeEnum = 15610;

        /// <summary>
        /// The identifier for the AlarmStateTypeEnum DataType.
        /// </summary>
        public const uint AlarmStateTypeEnum = 15612;

        /// <summary>
        /// The identifier for the AssetDescriptionType DataType.
        /// </summary>
        public const uint AssetDescriptionType = 15614;

        /// <summary>
        /// The identifier for the AssetAttrDataType DataType.
        /// </summary>
        public const uint AssetAttrDataType = 15615;

        /// <summary>
        /// The identifier for the AssetBufferSizeDataType DataType.
        /// </summary>
        public const uint AssetBufferSizeDataType = 15616;

        /// <summary>
        /// The identifier for the AssetIdDataType DataType.
        /// </summary>
        public const uint AssetIdDataType = 15617;

        /// <summary>
        /// The identifier for the AvailabilityTypeEnum DataType.
        /// </summary>
        public const uint AvailabilityTypeEnum = 15618;

        /// <summary>
        /// The identifier for the AxesCouplingTypeEnum DataType.
        /// </summary>
        public const uint AxesCouplingTypeEnum = 15620;

        /// <summary>
        /// The identifier for the AxesListValueDataType DataType.
        /// </summary>
        public const uint AxesListValueDataType = 15622;

        /// <summary>
        /// The identifier for the BufferSizeDataType DataType.
        /// </summary>
        public const uint BufferSizeDataType = 15623;

        /// <summary>
        /// The identifier for the CalibrationDateDataType DataType.
        /// </summary>
        public const uint CalibrationDateDataType = 15624;

        /// <summary>
        /// The identifier for the CalibrationInitialsDataType DataType.
        /// </summary>
        public const uint CalibrationInitialsDataType = 15625;

        /// <summary>
        /// The identifier for the CategoryTypeEnum DataType.
        /// </summary>
        public const uint CategoryTypeEnum = 15626;

        /// <summary>
        /// The identifier for the ChannelNumberDataType DataType.
        /// </summary>
        public const uint ChannelNumberDataType = 15628;

        /// <summary>
        /// The identifier for the ClampStateTypeEnum DataType.
        /// </summary>
        public const uint ClampStateTypeEnum = 15629;

        /// <summary>
        /// The identifier for the ConditionDescriptionDataType DataType.
        /// </summary>
        public const uint ConditionDescriptionDataType = 15631;

        /// <summary>
        /// The identifier for the ControllerModeTypeEnum DataType.
        /// </summary>
        public const uint ControllerModeTypeEnum = 15632;

        /// <summary>
        /// The identifier for the CoordinateSystemTypeEnum DataType.
        /// </summary>
        public const uint CoordinateSystemTypeEnum = 15019;

        /// <summary>
        /// The identifier for the IDDataType DataType.
        /// </summary>
        public const uint IDDataType = 15634;

        /// <summary>
        /// The identifier for the CodeDataType DataType.
        /// </summary>
        public const uint CodeDataType = 15635;

        /// <summary>
        /// The identifier for the ComponentIdDataType DataType.
        /// </summary>
        public const uint ComponentIdDataType = 15636;

        /// <summary>
        /// The identifier for the ConnectionCodeMachineSideDataType DataType.
        /// </summary>
        public const uint ConnectionCodeMachineSideDataType = 15637;

        /// <summary>
        /// The identifier for the CountValueDataType DataType.
        /// </summary>
        public const uint CountValueDataType = 15638;

        /// <summary>
        /// The identifier for the CreationTimeDataType DataType.
        /// </summary>
        public const uint CreationTimeDataType = 15639;

        /// <summary>
        /// The identifier for the CutterStatusValueTypeEnum DataType.
        /// </summary>
        public const uint CutterStatusValueTypeEnum = 15640;

        /// <summary>
        /// The identifier for the DataItemEnumDataType DataType.
        /// </summary>
        public const uint DataItemEnumDataType = 15642;

        /// <summary>
        /// The identifier for the DataItemEnumTypeEnum DataType.
        /// </summary>
        public const uint DataItemEnumTypeEnum = 15643;

        /// <summary>
        /// The identifier for the DataItemIdDataType DataType.
        /// </summary>
        public const uint DataItemIdDataType = 15645;

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType DataType.
        /// </summary>
        public const uint DataItemStatisticsDataType = 15646;

        /// <summary>
        /// The identifier for the DataItemStatisticsTypeEnum DataType.
        /// </summary>
        public const uint DataItemStatisticsTypeEnum = 15647;

        /// <summary>
        /// The identifier for the DataItemSubEnumTypeEnum DataType.
        /// </summary>
        public const uint DataItemSubEnumTypeEnum = 15649;

        /// <summary>
        /// The identifier for the DefinitionFormatTypeEnum DataType.
        /// </summary>
        public const uint DefinitionFormatTypeEnum = 15651;

        /// <summary>
        /// The identifier for the DecibelValueDataType DataType.
        /// </summary>
        public const uint DecibelValueDataType = 15653;

        /// <summary>
        /// The identifier for the DescriptionTextDataType DataType.
        /// </summary>
        public const uint DescriptionTextDataType = 15654;

        /// <summary>
        /// The identifier for the DirectionTypeEnum DataType.
        /// </summary>
        public const uint DirectionTypeEnum = 15655;

        /// <summary>
        /// The identifier for the DoorStateTypeEnum DataType.
        /// </summary>
        public const uint DoorStateTypeEnum = 15657;

        /// <summary>
        /// The identifier for the DurationTimeDataType DataType.
        /// </summary>
        public const uint DurationTimeDataType = 15659;

        /// <summary>
        /// The identifier for the DurationValueDataType DataType.
        /// </summary>
        public const uint DurationValueDataType = 15660;

        /// <summary>
        /// The identifier for the EdgeCountDataType DataType.
        /// </summary>
        public const uint EdgeCountDataType = 15661;

        /// <summary>
        /// The identifier for the EmergencyStopTypeEnum DataType.
        /// </summary>
        public const uint EmergencyStopTypeEnum = 15662;

        /// <summary>
        /// The identifier for the EnergyValueDataType DataType.
        /// </summary>
        public const uint EnergyValueDataType = 15664;

        /// <summary>
        /// The identifier for the ExecutionTypeEnum DataType.
        /// </summary>
        public const uint ExecutionTypeEnum = 15665;

        /// <summary>
        /// The identifier for the FeedrateValueDataType DataType.
        /// </summary>
        public const uint FeedrateValueDataType = 15667;

        /// <summary>
        /// The identifier for the FirmwareVersionDataType DataType.
        /// </summary>
        public const uint FirmwareVersionDataType = 15668;

        /// <summary>
        /// The identifier for the ForceValueDataType DataType.
        /// </summary>
        public const uint ForceValueDataType = 15669;

        /// <summary>
        /// The identifier for the GradeDataType DataType.
        /// </summary>
        public const uint GradeDataType = 15670;

        /// <summary>
        /// The identifier for the IndexRangeDataType DataType.
        /// </summary>
        public const uint IndexRangeDataType = 15671;

        /// <summary>
        /// The identifier for the InstanceIdDataType DataType.
        /// </summary>
        public const uint InstanceIdDataType = 15672;

        /// <summary>
        /// The identifier for the ItemIdDataType DataType.
        /// </summary>
        public const uint ItemIdDataType = 15673;

        /// <summary>
        /// The identifier for the InterfaceStateTypeEnum DataType.
        /// </summary>
        public const uint InterfaceStateTypeEnum = 15674;

        /// <summary>
        /// The identifier for the ItemSourceDataType DataType.
        /// </summary>
        public const uint ItemSourceDataType = 15676;

        /// <summary>
        /// The identifier for the LocationSizeDataType DataType.
        /// </summary>
        public const uint LocationSizeDataType = 15677;

        /// <summary>
        /// The identifier for the LocationValueDataType DataType.
        /// </summary>
        public const uint LocationValueDataType = 15678;

        /// <summary>
        /// The identifier for the LocationsTypeEnum DataType.
        /// </summary>
        public const uint LocationsTypeEnum = 15679;

        /// <summary>
        /// The identifier for the LocusDataType DataType.
        /// </summary>
        public const uint LocusDataType = 15681;

        /// <summary>
        /// The identifier for the ManufacturersDataType DataType.
        /// </summary>
        public const uint ManufacturersDataType = 15682;

        /// <summary>
        /// The identifier for the MassValueDataType DataType.
        /// </summary>
        public const uint MassValueDataType = 15683;

        /// <summary>
        /// The identifier for the MaximumCountDataType DataType.
        /// </summary>
        public const uint MaximumCountDataType = 15684;

        /// <summary>
        /// The identifier for the MaximumDataType DataType.
        /// </summary>
        public const uint MaximumDataType = 15685;

        /// <summary>
        /// The identifier for the MeasurementValueDataType DataType.
        /// </summary>
        public const uint MeasurementValueDataType = 15686;

        /// <summary>
        /// The identifier for the MinimumDataType DataType.
        /// </summary>
        public const uint MinimumDataType = 15687;

        /// <summary>
        /// The identifier for the ModelDataType DataType.
        /// </summary>
        public const uint ModelDataType = 15688;

        /// <summary>
        /// The identifier for the NameDataType DataType.
        /// </summary>
        public const uint NameDataType = 15689;

        /// <summary>
        /// The identifier for the NativeCodeDataType DataType.
        /// </summary>
        public const uint NativeCodeDataType = 15690;

        /// <summary>
        /// The identifier for the NativeNotifcationCodeDataType DataType.
        /// </summary>
        public const uint NativeNotifcationCodeDataType = 15691;

        /// <summary>
        /// The identifier for the NativeScaleDataType DataType.
        /// </summary>
        public const uint NativeScaleDataType = 15692;

        /// <summary>
        /// The identifier for the NativeSeverityDataType DataType.
        /// </summary>
        public const uint NativeSeverityDataType = 15693;

        /// <summary>
        /// The identifier for the NextCalibrationDateDataType DataType.
        /// </summary>
        public const uint NextCalibrationDateDataType = 15694;

        /// <summary>
        /// The identifier for the NominalDataType DataType.
        /// </summary>
        public const uint NominalDataType = 15695;

        /// <summary>
        /// The identifier for the NotificationCodeTypeEnum DataType.
        /// </summary>
        public const uint NotificationCodeTypeEnum = 15696;

        /// <summary>
        /// The identifier for the NotificationDescriptionDataType DataType.
        /// </summary>
        public const uint NotificationDescriptionDataType = 15698;

        /// <summary>
        /// The identifier for the OccurrenceTimeDataType DataType.
        /// </summary>
        public const uint OccurrenceTimeDataType = 15699;

        /// <summary>
        /// The identifier for the OverlapDataType DataType.
        /// </summary>
        public const uint OverlapDataType = 15700;

        /// <summary>
        /// The identifier for the PathModeTypeEnum DataType.
        /// </summary>
        public const uint PathModeTypeEnum = 15701;

        /// <summary>
        /// The identifier for the PowerStateTypeEnum DataType.
        /// </summary>
        public const uint PowerStateTypeEnum = 15703;

        /// <summary>
        /// The identifier for the ProgramToolNumberDataType DataType.
        /// </summary>
        public const uint ProgramToolNumberDataType = 15705;

        /// <summary>
        /// The identifier for the QualifierTypeEnum DataType.
        /// </summary>
        public const uint QualifierTypeEnum = 15706;

        /// <summary>
        /// The identifier for the RateDataType DataType.
        /// </summary>
        public const uint RateDataType = 15708;

        /// <summary>
        /// The identifier for the ReconditionCountValueDataType DataType.
        /// </summary>
        public const uint ReconditionCountValueDataType = 15709;

        /// <summary>
        /// The identifier for the RotaryModeTypeEnum DataType.
        /// </summary>
        public const uint RotaryModeTypeEnum = 15710;

        /// <summary>
        /// The identifier for the SampleRateDataType DataType.
        /// </summary>
        public const uint SampleRateDataType = 15712;

        /// <summary>
        /// The identifier for the SeverityTypeEnum DataType.
        /// </summary>
        public const uint SeverityTypeEnum = 15713;

        /// <summary>
        /// The identifier for the SignificantDigitsValueDataType DataType.
        /// </summary>
        public const uint SignificantDigitsValueDataType = 15715;

        /// <summary>
        /// The identifier for the StationDataType DataType.
        /// </summary>
        public const uint StationDataType = 15716;

        /// <summary>
        /// The identifier for the SenderDataType DataType.
        /// </summary>
        public const uint SenderDataType = 15717;

        /// <summary>
        /// The identifier for the SequenceDataType DataType.
        /// </summary>
        public const uint SequenceDataType = 15718;

        /// <summary>
        /// The identifier for the SerialNumberDataType DataType.
        /// </summary>
        public const uint SerialNumberDataType = 15719;

        /// <summary>
        /// The identifier for the SpeedDataType DataType.
        /// </summary>
        public const uint SpeedDataType = 15720;

        /// <summary>
        /// The identifier for the TestIndicatorDataType DataType.
        /// </summary>
        public const uint TestIndicatorDataType = 15721;

        /// <summary>
        /// The identifier for the ToolEventValueDataType DataType.
        /// </summary>
        public const uint ToolEventValueDataType = 15722;

        /// <summary>
        /// The identifier for the ToolGroupDataType DataType.
        /// </summary>
        public const uint ToolGroupDataType = 15723;

        /// <summary>
        /// The identifier for the ToolIdDataType DataType.
        /// </summary>
        public const uint ToolIdDataType = 15724;

        /// <summary>
        /// The identifier for the ToolLifeDirectionTypeEnum DataType.
        /// </summary>
        public const uint ToolLifeDirectionTypeEnum = 15725;

        /// <summary>
        /// The identifier for the ToolLifeTypeEnum DataType.
        /// </summary>
        public const uint ToolLifeTypeEnum = 15727;

        /// <summary>
        /// The identifier for the ToolLifeValueDataType DataType.
        /// </summary>
        public const uint ToolLifeValueDataType = 15729;

        /// <summary>
        /// The identifier for the UnitsExtDataType DataType.
        /// </summary>
        public const uint UnitsExtDataType = 15730;

        /// <summary>
        /// The identifier for the VersionDataType DataType.
        /// </summary>
        public const uint VersionDataType = 15731;

        /// <summary>
        /// The identifier for the VibrationValueDataType DataType.
        /// </summary>
        public const uint VibrationValueDataType = 15732;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Disable Method.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Disable = 16180;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Enable Method.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Enable = 16181;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_AddComment Method.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_AddComment = 16182;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Disable Method.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Disable = 18804;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Enable Method.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Enable = 18805;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_AddComment Method.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_AddComment = 18806;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Disable Method.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Disable = 18866;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Enable Method.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Enable = 18867;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_AddComment Method.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_AddComment = 18868;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Memex_3Axis Object.
        /// </summary>
        public const uint Memex_3Axis = 15001;

        /// <summary>
        /// The identifier for the Memex_3Axis_DataItems Object.
        /// </summary>
        public const uint Memex_3Axis_DataItems = 15008;

        /// <summary>
        /// The identifier for the Memex_3Axis_Components Object.
        /// </summary>
        public const uint Memex_3Axis_Components = 15021;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes Object.
        /// </summary>
        public const uint Memex_3Axis_Axes = 15023;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad Object.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad = 15751;

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller Object.
        /// </summary>
        public const uint Memex_3Axis_Controller = 16210;

        /// <summary>
        /// The identifier for the CuttingToolType_DataItems Object.
        /// </summary>
        public const uint CuttingToolType_DataItems = 15048;

        /// <summary>
        /// The identifier for the CuttingToolType_Components Object.
        /// </summary>
        public const uint CuttingToolType_Components = 15049;

        /// <summary>
        /// The identifier for the CuttingToolType_Conditions Object.
        /// </summary>
        public const uint CuttingToolType_Conditions = 15050;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes Object.
        /// </summary>
        public const uint CuttingToolType_Axes = 15028;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad Object.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad = 15809;

        /// <summary>
        /// The identifier for the CuttingToolType_Controller Object.
        /// </summary>
        public const uint CuttingToolType_Controller = 15754;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad Object.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad = 15819;

        /// <summary>
        /// The identifier for the CuttingItemType_ItemLife Object.
        /// </summary>
        public const uint CuttingItemType_ItemLife = 15594;

        /// <summary>
        /// The identifier for the CuttingItemType_Measurements Object.
        /// </summary>
        public const uint CuttingItemType_Measurements = 15595;

        /// <summary>
        /// The identifier for the MTConditionType_LimitState Object.
        /// </summary>
        public const uint MTConditionType_LimitState = 15880;

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint DataItemEnumDataType_Encoding_DefaultBinary = 15733;

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint DataItemStatisticsDataType_Encoding_DefaultBinary = 15734;

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint DataItemEnumDataType_Encoding_DefaultXml = 15741;

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint DataItemStatisticsDataType_Encoding_DefaultXml = 15742;

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint DataItemEnumDataType_Encoding_DefaultJson = 15749;

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint DataItemStatisticsDataType_Encoding_DefaultJson = 15750;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CuttingToolsType ObjectType.
        /// </summary>
        public const uint CuttingToolsType = 15037;

        /// <summary>
        /// The identifier for the CuttingToolType ObjectType.
        /// </summary>
        public const uint CuttingToolType = 15041;

        /// <summary>
        /// The identifier for the CuttingToolComponentType ObjectType.
        /// </summary>
        public const uint CuttingToolComponentType = 15051;

        /// <summary>
        /// The identifier for the CuttingToolAxesType ObjectType.
        /// </summary>
        public const uint CuttingToolAxesType = 15063;

        /// <summary>
        /// The identifier for the ControllerType ObjectType.
        /// </summary>
        public const uint ControllerType = 15757;

        /// <summary>
        /// The identifier for the MTConditionType ObjectType.
        /// </summary>
        public const uint MTConditionType = 15829;

        /// <summary>
        /// The identifier for the AccelerationConditionType ObjectType.
        /// </summary>
        public const uint AccelerationConditionType = 15896;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType ObjectType.
        /// </summary>
        public const uint Accumulated_TimeConditionType = 15963;

        /// <summary>
        /// The identifier for the AmperageConditionType ObjectType.
        /// </summary>
        public const uint AmperageConditionType = 16030;

        /// <summary>
        /// The identifier for the AngleConditionType ObjectType.
        /// </summary>
        public const uint AngleConditionType = 16097;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType ObjectType.
        /// </summary>
        public const uint Angular_AccelerationConditionType = 18710;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType ObjectType.
        /// </summary>
        public const uint Angular_VelocityConditionType = 16231;

        /// <summary>
        /// The identifier for the CommunicationsConditionType ObjectType.
        /// </summary>
        public const uint CommunicationsConditionType = 16298;

        /// <summary>
        /// The identifier for the ConcentrationConditionType ObjectType.
        /// </summary>
        public const uint ConcentrationConditionType = 16365;

        /// <summary>
        /// The identifier for the ConductivityConditionType ObjectType.
        /// </summary>
        public const uint ConductivityConditionType = 16432;

        /// <summary>
        /// The identifier for the Data_RangeConditionType ObjectType.
        /// </summary>
        public const uint Data_RangeConditionType = 16499;

        /// <summary>
        /// The identifier for the DirectionConditionType ObjectType.
        /// </summary>
        public const uint DirectionConditionType = 16566;

        /// <summary>
        /// The identifier for the DisplacementConditionType ObjectType.
        /// </summary>
        public const uint DisplacementConditionType = 16633;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType ObjectType.
        /// </summary>
        public const uint Electrical_EnergyConditionType = 16700;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType ObjectType.
        /// </summary>
        public const uint Fill_LevelConditionType = 16767;

        /// <summary>
        /// The identifier for the FlowConditionType ObjectType.
        /// </summary>
        public const uint FlowConditionType = 16834;

        /// <summary>
        /// The identifier for the FrequencyConditionType ObjectType.
        /// </summary>
        public const uint FrequencyConditionType = 16901;

        /// <summary>
        /// The identifier for the HardwareConditionType ObjectType.
        /// </summary>
        public const uint HardwareConditionType = 16968;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType ObjectType.
        /// </summary>
        public const uint Linear_ForceConditionType = 17035;

        /// <summary>
        /// The identifier for the LoadConditionType ObjectType.
        /// </summary>
        public const uint LoadConditionType = 17102;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType ObjectType.
        /// </summary>
        public const uint Logic_ProgramConditionType = 17169;

        /// <summary>
        /// The identifier for the MassConditionType ObjectType.
        /// </summary>
        public const uint MassConditionType = 17236;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType ObjectType.
        /// </summary>
        public const uint Motion_ProgramConditionType = 17303;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType ObjectType.
        /// </summary>
        public const uint Path_FeedrateConditionType = 17370;

        /// <summary>
        /// The identifier for the Path_PositionConditionType ObjectType.
        /// </summary>
        public const uint Path_PositionConditionType = 17437;

        /// <summary>
        /// The identifier for the PHConditionType ObjectType.
        /// </summary>
        public const uint PHConditionType = 17504;

        /// <summary>
        /// The identifier for the PositionConditionType ObjectType.
        /// </summary>
        public const uint PositionConditionType = 17571;

        /// <summary>
        /// The identifier for the Power_FactorConditionType ObjectType.
        /// </summary>
        public const uint Power_FactorConditionType = 17638;

        /// <summary>
        /// The identifier for the PressureConditionType ObjectType.
        /// </summary>
        public const uint PressureConditionType = 17705;

        /// <summary>
        /// The identifier for the ResistanceConditionType ObjectType.
        /// </summary>
        public const uint ResistanceConditionType = 17772;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType ObjectType.
        /// </summary>
        public const uint Rotary_VelocityConditionType = 17839;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType ObjectType.
        /// </summary>
        public const uint Sound_LevelConditionType = 17906;

        /// <summary>
        /// The identifier for the StrainConditionType ObjectType.
        /// </summary>
        public const uint StrainConditionType = 17973;

        /// <summary>
        /// The identifier for the SystemConditionType ObjectType.
        /// </summary>
        public const uint SystemConditionType = 18040;

        /// <summary>
        /// The identifier for the TemperatureConditionType ObjectType.
        /// </summary>
        public const uint TemperatureConditionType = 18107;

        /// <summary>
        /// The identifier for the TiltConditionType ObjectType.
        /// </summary>
        public const uint TiltConditionType = 18174;

        /// <summary>
        /// The identifier for the TorqueConditionType ObjectType.
        /// </summary>
        public const uint TorqueConditionType = 18241;

        /// <summary>
        /// The identifier for the VelocityConditionType ObjectType.
        /// </summary>
        public const uint VelocityConditionType = 18308;

        /// <summary>
        /// The identifier for the ViscosityConditionType ObjectType.
        /// </summary>
        public const uint ViscosityConditionType = 18375;

        /// <summary>
        /// The identifier for the VoltageConditionType ObjectType.
        /// </summary>
        public const uint VoltageConditionType = 18442;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType ObjectType.
        /// </summary>
        public const uint Volt_AmperageConditionType = 18509;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType ObjectType.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType = 18576;

        /// <summary>
        /// The identifier for the WattageConditionType ObjectType.
        /// </summary>
        public const uint WattageConditionType = 18643;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the Memex_3Axis_Availability Variable.
        /// </summary>
        public const uint Memex_3Axis_Availability = 15002;

        /// <summary>
        /// The identifier for the Memex_3Axis_Manufacturer Variable.
        /// </summary>
        public const uint Memex_3Axis_Manufacturer = 15005;

        /// <summary>
        /// The identifier for the Memex_3Axis_SerialNumber Variable.
        /// </summary>
        public const uint Memex_3Axis_SerialNumber = 15006;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_X Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_X = 15024;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_Y Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_Y = 15025;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_Z Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_Z = 15026;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_C Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_C = 15027;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EventId Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_EventId = 15752;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EventType Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_EventType = 15753;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_SourceNode Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_SourceNode = 15760;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_SourceName Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_SourceName = 15761;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Time Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Time = 15766;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ReceiveTime Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ReceiveTime = 15767;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LocalTime Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LocalTime = 15772;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Message Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Message = 15773;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Severity Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Severity = 15774;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionClassId Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ConditionClassId = 15775;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionClassName Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ConditionClassName = 15784;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionName Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ConditionName = 15787;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_BranchId Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_BranchId = 15788;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Retain Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Retain = 15799;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EnabledState Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_EnabledState = 16164;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EnabledState_Id Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_EnabledState_Id = 16165;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Quality Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Quality = 16173;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Quality_SourceTimestamp = 16174;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LastSeverity Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LastSeverity = 16175;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LastSeverity_SourceTimestamp = 16176;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Comment Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Comment = 16177;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_Comment_SourceTimestamp = 16178;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ClientUserId Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ClientUserId = 16179;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_AddComment_InputArguments = 16183;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_MTCurrentState Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_MTCurrentState = 16184;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ActiveState Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ActiveState = 16185;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ActiveState_Id Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_ActiveState_Id = 16186;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LimitState_CurrentState = 16195;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LimitState_CurrentState_Id = 16196;

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Memex_3Axis_Axes_XLoad_LimitState_LastTransition_Id = 16201;

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_EmergencyStop Variable.
        /// </summary>
        public const uint Memex_3Axis_Controller_EmergencyStop = 16211;

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_Message Variable.
        /// </summary>
        public const uint Memex_3Axis_Controller_Message = 16216;

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_Line Variable.
        /// </summary>
        public const uint Memex_3Axis_Controller_Line = 16221;

        /// <summary>
        /// The identifier for the CuttingToolsType_MTConnectVersion Variable.
        /// </summary>
        public const uint CuttingToolsType_MTConnectVersion = 15038;

        /// <summary>
        /// The identifier for the CuttingToolsType_OPCUAMappingDate Variable.
        /// </summary>
        public const uint CuttingToolsType_OPCUAMappingDate = 15039;

        /// <summary>
        /// The identifier for the CuttingToolsType_OPCUAVersion Variable.
        /// </summary>
        public const uint CuttingToolsType_OPCUAVersion = 15040;

        /// <summary>
        /// The identifier for the CuttingToolType_Availability Variable.
        /// </summary>
        public const uint CuttingToolType_Availability = 15042;

        /// <summary>
        /// The identifier for the CuttingToolType_Manufacturer Variable.
        /// </summary>
        public const uint CuttingToolType_Manufacturer = 15045;

        /// <summary>
        /// The identifier for the CuttingToolType_SerialNumber Variable.
        /// </summary>
        public const uint CuttingToolType_SerialNumber = 15046;

        /// <summary>
        /// The identifier for the CuttingToolType_SampleInterval Variable.
        /// </summary>
        public const uint CuttingToolType_SampleInterval = 15047;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_X Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_X = 15029;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_Y Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_Y = 15030;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_Z Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_Z = 15031;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_C Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_C = 15032;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EventId Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_EventId = 16226;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EventType Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_EventType = 16227;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_SourceNode Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_SourceNode = 16228;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_SourceName Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_SourceName = 16229;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Time Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Time = 16230;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ReceiveTime Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ReceiveTime = 18777;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LocalTime Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LocalTime = 18778;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Message Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Message = 18779;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Severity Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Severity = 18780;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionClassId Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ConditionClassId = 18781;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionClassName Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ConditionClassName = 18782;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionName Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ConditionName = 18785;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_BranchId Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_BranchId = 18786;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Retain Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Retain = 18787;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EnabledState Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_EnabledState = 18788;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EnabledState_Id Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_EnabledState_Id = 18789;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Quality Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Quality = 18797;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Quality_SourceTimestamp = 18798;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LastSeverity Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LastSeverity = 18799;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LastSeverity_SourceTimestamp = 18800;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Comment Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Comment = 18801;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_Comment_SourceTimestamp = 18802;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ClientUserId Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ClientUserId = 18803;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_AddComment_InputArguments = 18807;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_MTCurrentState Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_MTCurrentState = 18808;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ActiveState Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ActiveState = 18809;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ActiveState_Id Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_ActiveState_Id = 18810;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LimitState_CurrentState = 18819;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LimitState_CurrentState_Id = 18820;

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint CuttingToolType_Axes_XLoad_LimitState_LastTransition_Id = 18825;

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_EmergencyStop Variable.
        /// </summary>
        public const uint CuttingToolType_Controller_EmergencyStop = 15755;

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_Message Variable.
        /// </summary>
        public const uint CuttingToolType_Controller_Message = 15756;

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_Line Variable.
        /// </summary>
        public const uint CuttingToolType_Controller_Line = 15789;

        /// <summary>
        /// The identifier for the CuttingToolComponentType_Model Variable.
        /// </summary>
        public const uint CuttingToolComponentType_Model = 15061;

        /// <summary>
        /// The identifier for the CuttingToolComponentType_Station Variable.
        /// </summary>
        public const uint CuttingToolComponentType_Station = 15062;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_X Variable.
        /// </summary>
        public const uint CuttingToolAxesType_X = 15033;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_Y Variable.
        /// </summary>
        public const uint CuttingToolAxesType_Y = 15034;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_Z Variable.
        /// </summary>
        public const uint CuttingToolAxesType_Z = 15035;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_C Variable.
        /// </summary>
        public const uint CuttingToolAxesType_C = 15036;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EventId Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_EventId = 18834;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EventType Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_EventType = 18835;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_SourceNode Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_SourceNode = 18836;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_SourceName Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_SourceName = 18837;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Time Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Time = 18838;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ReceiveTime Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ReceiveTime = 18839;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LocalTime Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LocalTime = 18840;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Message Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Message = 18841;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Severity Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Severity = 18842;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionClassId Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ConditionClassId = 18843;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionClassName Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ConditionClassName = 18844;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionName Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ConditionName = 18847;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_BranchId Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_BranchId = 18848;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Retain Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Retain = 18849;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EnabledState Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_EnabledState = 18850;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EnabledState_Id Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_EnabledState_Id = 18851;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Quality Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Quality = 18859;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Quality_SourceTimestamp = 18860;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LastSeverity Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LastSeverity = 18861;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LastSeverity_SourceTimestamp = 18862;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Comment Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Comment = 18863;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_Comment_SourceTimestamp = 18864;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ClientUserId Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ClientUserId = 18865;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_AddComment_InputArguments = 18869;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_MTCurrentState Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_MTCurrentState = 18870;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ActiveState Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ActiveState = 18871;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ActiveState_Id Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_ActiveState_Id = 18872;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LimitState_CurrentState = 18881;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LimitState_CurrentState_Id = 18882;

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint CuttingToolAxesType_XLoad_LimitState_LastTransition_Id = 18887;

        /// <summary>
        /// The identifier for the ControllerType_EmergencyStop Variable.
        /// </summary>
        public const uint ControllerType_EmergencyStop = 15758;

        /// <summary>
        /// The identifier for the ControllerType_Message Variable.
        /// </summary>
        public const uint ControllerType_Message = 15759;

        /// <summary>
        /// The identifier for the ControllerType_Line Variable.
        /// </summary>
        public const uint ControllerType_Line = 15794;

        /// <summary>
        /// The identifier for the MTSampleDataItemType_CoordinateSystem Variable.
        /// </summary>
        public const uint MTSampleDataItemType_CoordinateSystem = 15015;

        /// <summary>
        /// The identifier for the MTSampleDataItemType_NativeUnits Variable.
        /// </summary>
        public const uint MTSampleDataItemType_NativeUnits = 15016;

        /// <summary>
        /// The identifier for the MTSampleDataItemType_NativeScale Variable.
        /// </summary>
        public const uint MTSampleDataItemType_NativeScale = 15017;

        /// <summary>
        /// The identifier for the MTSampleDataItemType_SampleInterval Variable.
        /// </summary>
        public const uint MTSampleDataItemType_SampleInterval = 15018;

        /// <summary>
        /// The identifier for the MTEventDataItemType_CoordinateSystem Variable.
        /// </summary>
        public const uint MTEventDataItemType_CoordinateSystem = 15426;

        /// <summary>
        /// The identifier for the MTEventDataItemType_SampleInterval Variable.
        /// </summary>
        public const uint MTEventDataItemType_SampleInterval = 15427;

        /// <summary>
        /// The identifier for the ChannelType_CalibrationDate Variable.
        /// </summary>
        public const uint ChannelType_CalibrationDate = 15549;

        /// <summary>
        /// The identifier for the ChannelType_NextCalibrationDate Variable.
        /// </summary>
        public const uint ChannelType_NextCalibrationDate = 15550;

        /// <summary>
        /// The identifier for the ChannelType_CalibrationInitials Variable.
        /// </summary>
        public const uint ChannelType_CalibrationInitials = 15551;

        /// <summary>
        /// The identifier for the MeasurementType_SignificantDigits Variable.
        /// </summary>
        public const uint MeasurementType_SignificantDigits = 15558;

        /// <summary>
        /// The identifier for the MeasurementType_Units Variable.
        /// </summary>
        public const uint MeasurementType_Units = 15559;

        /// <summary>
        /// The identifier for the MeasurementType_NativeUnits Variable.
        /// </summary>
        public const uint MeasurementType_NativeUnits = 15560;

        /// <summary>
        /// The identifier for the MeasurementType_LastChangeTimestamp Variable.
        /// </summary>
        public const uint MeasurementType_LastChangeTimestamp = 15561;

        /// <summary>
        /// The identifier for the MeasurementType_Code Variable.
        /// </summary>
        public const uint MeasurementType_Code = 15562;

        /// <summary>
        /// The identifier for the MeasurementType_Maximum Variable.
        /// </summary>
        public const uint MeasurementType_Maximum = 15563;

        /// <summary>
        /// The identifier for the MeasurementType_Minimum Variable.
        /// </summary>
        public const uint MeasurementType_Minimum = 15564;

        /// <summary>
        /// The identifier for the MeasurementType_Nominal Variable.
        /// </summary>
        public const uint MeasurementType_Nominal = 15565;

        /// <summary>
        /// The identifier for the CutterStatusType_Status Variable.
        /// </summary>
        public const uint CutterStatusType_Status = 15567;

        /// <summary>
        /// The identifier for the ReconditionCountType_MaximumCount Variable.
        /// </summary>
        public const uint ReconditionCountType_MaximumCount = 15569;

        /// <summary>
        /// The identifier for the LifeType_Type Variable.
        /// </summary>
        public const uint LifeType_Type = 15571;

        /// <summary>
        /// The identifier for the LifeType_CountDirection Variable.
        /// </summary>
        public const uint LifeType_CountDirection = 15572;

        /// <summary>
        /// The identifier for the LifeType_WarningLevel Variable.
        /// </summary>
        public const uint LifeType_WarningLevel = 15573;

        /// <summary>
        /// The identifier for the LifeType_Maximum Variable.
        /// </summary>
        public const uint LifeType_Maximum = 15574;

        /// <summary>
        /// The identifier for the LocationType_Type Variable.
        /// </summary>
        public const uint LocationType_Type = 15576;

        /// <summary>
        /// The identifier for the LocationType_NegativeOverlap Variable.
        /// </summary>
        public const uint LocationType_NegativeOverlap = 15577;

        /// <summary>
        /// The identifier for the LocationType_PositiveOverlap Variable.
        /// </summary>
        public const uint LocationType_PositiveOverlap = 15578;

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Maximum Variable.
        /// </summary>
        public const uint ProgramSpindleSpeedType_Maximum = 15580;

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Minimum Variable.
        /// </summary>
        public const uint ProgramSpindleSpeedType_Minimum = 15581;

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Nominal Variable.
        /// </summary>
        public const uint ProgramSpindleSpeedType_Nominal = 15582;

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Maximum Variable.
        /// </summary>
        public const uint ProgramFeedRateType_Maximum = 15584;

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Minimum Variable.
        /// </summary>
        public const uint ProgramFeedRateType_Minimum = 15585;

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Nominal Variable.
        /// </summary>
        public const uint ProgramFeedRateType_Nominal = 15586;

        /// <summary>
        /// The identifier for the CuttingItemType_Indices Variable.
        /// </summary>
        public const uint CuttingItemType_Indices = 15588;

        /// <summary>
        /// The identifier for the CuttingItemType_ItemId Variable.
        /// </summary>
        public const uint CuttingItemType_ItemId = 15589;

        /// <summary>
        /// The identifier for the CuttingItemType_Grade Variable.
        /// </summary>
        public const uint CuttingItemType_Grade = 15590;

        /// <summary>
        /// The identifier for the CuttingItemType_Manufacturers Variable.
        /// </summary>
        public const uint CuttingItemType_Manufacturers = 15591;

        /// <summary>
        /// The identifier for the CuttingItemType_Description Variable.
        /// </summary>
        public const uint CuttingItemType_Description = 15592;

        /// <summary>
        /// The identifier for the CuttingItemType_Locus Variable.
        /// </summary>
        public const uint CuttingItemType_Locus = 15593;

        /// <summary>
        /// The identifier for the ActuatorStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ActuatorStateTypeEnum_EnumValues = 15611;

        /// <summary>
        /// The identifier for the AlarmStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint AlarmStateTypeEnum_EnumValues = 15613;

        /// <summary>
        /// The identifier for the AvailabilityTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint AvailabilityTypeEnum_EnumValues = 15619;

        /// <summary>
        /// The identifier for the AxesCouplingTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint AxesCouplingTypeEnum_EnumValues = 15621;

        /// <summary>
        /// The identifier for the CategoryTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint CategoryTypeEnum_EnumValues = 15627;

        /// <summary>
        /// The identifier for the ClampStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ClampStateTypeEnum_EnumValues = 15630;

        /// <summary>
        /// The identifier for the ControllerModeTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ControllerModeTypeEnum_EnumValues = 15633;

        /// <summary>
        /// The identifier for the CoordinateSystemTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint CoordinateSystemTypeEnum_EnumValues = 15020;

        /// <summary>
        /// The identifier for the CutterStatusValueTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint CutterStatusValueTypeEnum_EnumValues = 15641;

        /// <summary>
        /// The identifier for the DataItemEnumTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DataItemEnumTypeEnum_EnumValues = 15644;

        /// <summary>
        /// The identifier for the DataItemStatisticsTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DataItemStatisticsTypeEnum_EnumValues = 15648;

        /// <summary>
        /// The identifier for the DataItemSubEnumTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DataItemSubEnumTypeEnum_EnumValues = 15650;

        /// <summary>
        /// The identifier for the DefinitionFormatTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DefinitionFormatTypeEnum_EnumValues = 15652;

        /// <summary>
        /// The identifier for the DirectionTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DirectionTypeEnum_EnumValues = 15656;

        /// <summary>
        /// The identifier for the DoorStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint DoorStateTypeEnum_EnumValues = 15658;

        /// <summary>
        /// The identifier for the EmergencyStopTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint EmergencyStopTypeEnum_EnumValues = 15663;

        /// <summary>
        /// The identifier for the ExecutionTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ExecutionTypeEnum_EnumValues = 15666;

        /// <summary>
        /// The identifier for the InterfaceStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint InterfaceStateTypeEnum_EnumValues = 15675;

        /// <summary>
        /// The identifier for the LocationsTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint LocationsTypeEnum_EnumValues = 15680;

        /// <summary>
        /// The identifier for the NotificationCodeTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint NotificationCodeTypeEnum_EnumValues = 15697;

        /// <summary>
        /// The identifier for the PathModeTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint PathModeTypeEnum_EnumValues = 15702;

        /// <summary>
        /// The identifier for the PowerStateTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint PowerStateTypeEnum_EnumValues = 15704;

        /// <summary>
        /// The identifier for the QualifierTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint QualifierTypeEnum_EnumValues = 15707;

        /// <summary>
        /// The identifier for the RotaryModeTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint RotaryModeTypeEnum_EnumValues = 15711;

        /// <summary>
        /// The identifier for the SeverityTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint SeverityTypeEnum_EnumValues = 15714;

        /// <summary>
        /// The identifier for the ToolLifeDirectionTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ToolLifeDirectionTypeEnum_EnumValues = 15726;

        /// <summary>
        /// The identifier for the ToolLifeTypeEnum_EnumValues Variable.
        /// </summary>
        public const uint ToolLifeTypeEnum_EnumValues = 15728;

        /// <summary>
        /// The identifier for the MTConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint MTConditionType_EnabledState_Id = 15847;

        /// <summary>
        /// The identifier for the MTConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint MTConditionType_Quality_SourceTimestamp = 15856;

        /// <summary>
        /// The identifier for the MTConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint MTConditionType_LastSeverity_SourceTimestamp = 15858;

        /// <summary>
        /// The identifier for the MTConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint MTConditionType_Comment_SourceTimestamp = 15860;

        /// <summary>
        /// The identifier for the MTConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint MTConditionType_AddComment_InputArguments = 15865;

        /// <summary>
        /// The identifier for the MTConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint MTConditionType_ConditionRefresh_InputArguments = 15867;

        /// <summary>
        /// The identifier for the MTConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint MTConditionType_ConditionRefresh2_InputArguments = 15869;

        /// <summary>
        /// The identifier for the MTConditionType_MTCurrentState Variable.
        /// </summary>
        public const uint MTConditionType_MTCurrentState = 15870;

        /// <summary>
        /// The identifier for the MTConditionType_ActiveState Variable.
        /// </summary>
        public const uint MTConditionType_ActiveState = 15871;

        /// <summary>
        /// The identifier for the MTConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint MTConditionType_ActiveState_Id = 15872;

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint MTConditionType_LimitState_CurrentState = 15881;

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint MTConditionType_LimitState_CurrentState_Id = 15882;

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint MTConditionType_LimitState_LastTransition_Id = 15887;

        /// <summary>
        /// The identifier for the MTConditionType_NativeCode Variable.
        /// </summary>
        public const uint MTConditionType_NativeCode = 15894;

        /// <summary>
        /// The identifier for the MTConditionType_NativeSeverity Variable.
        /// </summary>
        public const uint MTConditionType_NativeSeverity = 15895;

        /// <summary>
        /// The identifier for the AccelerationConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint AccelerationConditionType_EnabledState_Id = 15914;

        /// <summary>
        /// The identifier for the AccelerationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint AccelerationConditionType_Quality_SourceTimestamp = 15923;

        /// <summary>
        /// The identifier for the AccelerationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint AccelerationConditionType_LastSeverity_SourceTimestamp = 15925;

        /// <summary>
        /// The identifier for the AccelerationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint AccelerationConditionType_Comment_SourceTimestamp = 15927;

        /// <summary>
        /// The identifier for the AccelerationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint AccelerationConditionType_AddComment_InputArguments = 15932;

        /// <summary>
        /// The identifier for the AccelerationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint AccelerationConditionType_ConditionRefresh_InputArguments = 15934;

        /// <summary>
        /// The identifier for the AccelerationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint AccelerationConditionType_ConditionRefresh2_InputArguments = 15936;

        /// <summary>
        /// The identifier for the AccelerationConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint AccelerationConditionType_ActiveState_Id = 15939;

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint AccelerationConditionType_LimitState_CurrentState = 15948;

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint AccelerationConditionType_LimitState_CurrentState_Id = 15949;

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint AccelerationConditionType_LimitState_LastTransition_Id = 15954;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_EnabledState_Id = 15981;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_Quality_SourceTimestamp = 15990;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_LastSeverity_SourceTimestamp = 15992;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_Comment_SourceTimestamp = 15994;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_AddComment_InputArguments = 15999;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_ConditionRefresh_InputArguments = 16001;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_ConditionRefresh2_InputArguments = 16003;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_ActiveState_Id = 16006;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_LimitState_CurrentState = 16015;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_LimitState_CurrentState_Id = 16016;

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Accumulated_TimeConditionType_LimitState_LastTransition_Id = 16021;

        /// <summary>
        /// The identifier for the AmperageConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint AmperageConditionType_EnabledState_Id = 16048;

        /// <summary>
        /// The identifier for the AmperageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint AmperageConditionType_Quality_SourceTimestamp = 16057;

        /// <summary>
        /// The identifier for the AmperageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint AmperageConditionType_LastSeverity_SourceTimestamp = 16059;

        /// <summary>
        /// The identifier for the AmperageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint AmperageConditionType_Comment_SourceTimestamp = 16061;

        /// <summary>
        /// The identifier for the AmperageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint AmperageConditionType_AddComment_InputArguments = 16066;

        /// <summary>
        /// The identifier for the AmperageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint AmperageConditionType_ConditionRefresh_InputArguments = 16068;

        /// <summary>
        /// The identifier for the AmperageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint AmperageConditionType_ConditionRefresh2_InputArguments = 16070;

        /// <summary>
        /// The identifier for the AmperageConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint AmperageConditionType_ActiveState_Id = 16073;

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint AmperageConditionType_LimitState_CurrentState = 16082;

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint AmperageConditionType_LimitState_CurrentState_Id = 16083;

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint AmperageConditionType_LimitState_LastTransition_Id = 16088;

        /// <summary>
        /// The identifier for the AngleConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint AngleConditionType_EnabledState_Id = 16115;

        /// <summary>
        /// The identifier for the AngleConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint AngleConditionType_Quality_SourceTimestamp = 16124;

        /// <summary>
        /// The identifier for the AngleConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint AngleConditionType_LastSeverity_SourceTimestamp = 16126;

        /// <summary>
        /// The identifier for the AngleConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint AngleConditionType_Comment_SourceTimestamp = 16128;

        /// <summary>
        /// The identifier for the AngleConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint AngleConditionType_AddComment_InputArguments = 16133;

        /// <summary>
        /// The identifier for the AngleConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint AngleConditionType_ConditionRefresh_InputArguments = 16135;

        /// <summary>
        /// The identifier for the AngleConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint AngleConditionType_ConditionRefresh2_InputArguments = 16137;

        /// <summary>
        /// The identifier for the AngleConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint AngleConditionType_ActiveState_Id = 16140;

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint AngleConditionType_LimitState_CurrentState = 16149;

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint AngleConditionType_LimitState_CurrentState_Id = 16150;

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint AngleConditionType_LimitState_LastTransition_Id = 16155;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_EnabledState_Id = 18728;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_Quality_SourceTimestamp = 18737;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_LastSeverity_SourceTimestamp = 18739;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_Comment_SourceTimestamp = 18741;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_AddComment_InputArguments = 18746;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_ConditionRefresh_InputArguments = 18748;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_ConditionRefresh2_InputArguments = 18750;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_ActiveState_Id = 18753;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_LimitState_CurrentState = 18762;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_LimitState_CurrentState_Id = 18763;

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Angular_AccelerationConditionType_LimitState_LastTransition_Id = 18768;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_EnabledState_Id = 16249;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_Quality_SourceTimestamp = 16258;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_LastSeverity_SourceTimestamp = 16260;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_Comment_SourceTimestamp = 16262;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_AddComment_InputArguments = 16267;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_ConditionRefresh_InputArguments = 16269;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_ConditionRefresh2_InputArguments = 16271;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_ActiveState_Id = 16274;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_LimitState_CurrentState = 16283;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_LimitState_CurrentState_Id = 16284;

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Angular_VelocityConditionType_LimitState_LastTransition_Id = 16289;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint CommunicationsConditionType_EnabledState_Id = 16316;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CommunicationsConditionType_Quality_SourceTimestamp = 16325;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CommunicationsConditionType_LastSeverity_SourceTimestamp = 16327;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CommunicationsConditionType_Comment_SourceTimestamp = 16329;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CommunicationsConditionType_AddComment_InputArguments = 16334;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint CommunicationsConditionType_ConditionRefresh_InputArguments = 16336;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint CommunicationsConditionType_ConditionRefresh2_InputArguments = 16338;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint CommunicationsConditionType_ActiveState_Id = 16341;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint CommunicationsConditionType_LimitState_CurrentState = 16350;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint CommunicationsConditionType_LimitState_CurrentState_Id = 16351;

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint CommunicationsConditionType_LimitState_LastTransition_Id = 16356;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint ConcentrationConditionType_EnabledState_Id = 16383;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint ConcentrationConditionType_Quality_SourceTimestamp = 16392;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint ConcentrationConditionType_LastSeverity_SourceTimestamp = 16394;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint ConcentrationConditionType_Comment_SourceTimestamp = 16396;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint ConcentrationConditionType_AddComment_InputArguments = 16401;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint ConcentrationConditionType_ConditionRefresh_InputArguments = 16403;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint ConcentrationConditionType_ConditionRefresh2_InputArguments = 16405;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint ConcentrationConditionType_ActiveState_Id = 16408;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint ConcentrationConditionType_LimitState_CurrentState = 16417;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint ConcentrationConditionType_LimitState_CurrentState_Id = 16418;

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint ConcentrationConditionType_LimitState_LastTransition_Id = 16423;

        /// <summary>
        /// The identifier for the ConductivityConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint ConductivityConditionType_EnabledState_Id = 16450;

        /// <summary>
        /// The identifier for the ConductivityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint ConductivityConditionType_Quality_SourceTimestamp = 16459;

        /// <summary>
        /// The identifier for the ConductivityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint ConductivityConditionType_LastSeverity_SourceTimestamp = 16461;

        /// <summary>
        /// The identifier for the ConductivityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint ConductivityConditionType_Comment_SourceTimestamp = 16463;

        /// <summary>
        /// The identifier for the ConductivityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint ConductivityConditionType_AddComment_InputArguments = 16468;

        /// <summary>
        /// The identifier for the ConductivityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint ConductivityConditionType_ConditionRefresh_InputArguments = 16470;

        /// <summary>
        /// The identifier for the ConductivityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint ConductivityConditionType_ConditionRefresh2_InputArguments = 16472;

        /// <summary>
        /// The identifier for the ConductivityConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint ConductivityConditionType_ActiveState_Id = 16475;

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint ConductivityConditionType_LimitState_CurrentState = 16484;

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint ConductivityConditionType_LimitState_CurrentState_Id = 16485;

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint ConductivityConditionType_LimitState_LastTransition_Id = 16490;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_RangeConditionType_EnabledState_Id = 16517;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_RangeConditionType_Quality_SourceTimestamp = 16526;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_RangeConditionType_LastSeverity_SourceTimestamp = 16528;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_RangeConditionType_Comment_SourceTimestamp = 16530;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_RangeConditionType_AddComment_InputArguments = 16535;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Data_RangeConditionType_ConditionRefresh_InputArguments = 16537;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Data_RangeConditionType_ConditionRefresh2_InputArguments = 16539;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Data_RangeConditionType_ActiveState_Id = 16542;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Data_RangeConditionType_LimitState_CurrentState = 16551;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Data_RangeConditionType_LimitState_CurrentState_Id = 16552;

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Data_RangeConditionType_LimitState_LastTransition_Id = 16557;

        /// <summary>
        /// The identifier for the DirectionConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint DirectionConditionType_EnabledState_Id = 16584;

        /// <summary>
        /// The identifier for the DirectionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint DirectionConditionType_Quality_SourceTimestamp = 16593;

        /// <summary>
        /// The identifier for the DirectionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint DirectionConditionType_LastSeverity_SourceTimestamp = 16595;

        /// <summary>
        /// The identifier for the DirectionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint DirectionConditionType_Comment_SourceTimestamp = 16597;

        /// <summary>
        /// The identifier for the DirectionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint DirectionConditionType_AddComment_InputArguments = 16602;

        /// <summary>
        /// The identifier for the DirectionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint DirectionConditionType_ConditionRefresh_InputArguments = 16604;

        /// <summary>
        /// The identifier for the DirectionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint DirectionConditionType_ConditionRefresh2_InputArguments = 16606;

        /// <summary>
        /// The identifier for the DirectionConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint DirectionConditionType_ActiveState_Id = 16609;

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint DirectionConditionType_LimitState_CurrentState = 16618;

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint DirectionConditionType_LimitState_CurrentState_Id = 16619;

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint DirectionConditionType_LimitState_LastTransition_Id = 16624;

        /// <summary>
        /// The identifier for the DisplacementConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint DisplacementConditionType_EnabledState_Id = 16651;

        /// <summary>
        /// The identifier for the DisplacementConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint DisplacementConditionType_Quality_SourceTimestamp = 16660;

        /// <summary>
        /// The identifier for the DisplacementConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint DisplacementConditionType_LastSeverity_SourceTimestamp = 16662;

        /// <summary>
        /// The identifier for the DisplacementConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint DisplacementConditionType_Comment_SourceTimestamp = 16664;

        /// <summary>
        /// The identifier for the DisplacementConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint DisplacementConditionType_AddComment_InputArguments = 16669;

        /// <summary>
        /// The identifier for the DisplacementConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint DisplacementConditionType_ConditionRefresh_InputArguments = 16671;

        /// <summary>
        /// The identifier for the DisplacementConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint DisplacementConditionType_ConditionRefresh2_InputArguments = 16673;

        /// <summary>
        /// The identifier for the DisplacementConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint DisplacementConditionType_ActiveState_Id = 16676;

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint DisplacementConditionType_LimitState_CurrentState = 16685;

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint DisplacementConditionType_LimitState_CurrentState_Id = 16686;

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint DisplacementConditionType_LimitState_LastTransition_Id = 16691;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_EnabledState_Id = 16718;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_Quality_SourceTimestamp = 16727;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_LastSeverity_SourceTimestamp = 16729;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_Comment_SourceTimestamp = 16731;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_AddComment_InputArguments = 16736;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_ConditionRefresh_InputArguments = 16738;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_ConditionRefresh2_InputArguments = 16740;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_ActiveState_Id = 16743;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_LimitState_CurrentState = 16752;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_LimitState_CurrentState_Id = 16753;

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Electrical_EnergyConditionType_LimitState_LastTransition_Id = 16758;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_EnabledState_Id = 16785;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_Quality_SourceTimestamp = 16794;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_LastSeverity_SourceTimestamp = 16796;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_Comment_SourceTimestamp = 16798;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_AddComment_InputArguments = 16803;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_ConditionRefresh_InputArguments = 16805;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_ConditionRefresh2_InputArguments = 16807;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_ActiveState_Id = 16810;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_LimitState_CurrentState = 16819;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_LimitState_CurrentState_Id = 16820;

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Fill_LevelConditionType_LimitState_LastTransition_Id = 16825;

        /// <summary>
        /// The identifier for the FlowConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint FlowConditionType_EnabledState_Id = 16852;

        /// <summary>
        /// The identifier for the FlowConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint FlowConditionType_Quality_SourceTimestamp = 16861;

        /// <summary>
        /// The identifier for the FlowConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint FlowConditionType_LastSeverity_SourceTimestamp = 16863;

        /// <summary>
        /// The identifier for the FlowConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint FlowConditionType_Comment_SourceTimestamp = 16865;

        /// <summary>
        /// The identifier for the FlowConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint FlowConditionType_AddComment_InputArguments = 16870;

        /// <summary>
        /// The identifier for the FlowConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint FlowConditionType_ConditionRefresh_InputArguments = 16872;

        /// <summary>
        /// The identifier for the FlowConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint FlowConditionType_ConditionRefresh2_InputArguments = 16874;

        /// <summary>
        /// The identifier for the FlowConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint FlowConditionType_ActiveState_Id = 16877;

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint FlowConditionType_LimitState_CurrentState = 16886;

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint FlowConditionType_LimitState_CurrentState_Id = 16887;

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint FlowConditionType_LimitState_LastTransition_Id = 16892;

        /// <summary>
        /// The identifier for the FrequencyConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint FrequencyConditionType_EnabledState_Id = 16919;

        /// <summary>
        /// The identifier for the FrequencyConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint FrequencyConditionType_Quality_SourceTimestamp = 16928;

        /// <summary>
        /// The identifier for the FrequencyConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint FrequencyConditionType_LastSeverity_SourceTimestamp = 16930;

        /// <summary>
        /// The identifier for the FrequencyConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint FrequencyConditionType_Comment_SourceTimestamp = 16932;

        /// <summary>
        /// The identifier for the FrequencyConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint FrequencyConditionType_AddComment_InputArguments = 16937;

        /// <summary>
        /// The identifier for the FrequencyConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint FrequencyConditionType_ConditionRefresh_InputArguments = 16939;

        /// <summary>
        /// The identifier for the FrequencyConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint FrequencyConditionType_ConditionRefresh2_InputArguments = 16941;

        /// <summary>
        /// The identifier for the FrequencyConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint FrequencyConditionType_ActiveState_Id = 16944;

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint FrequencyConditionType_LimitState_CurrentState = 16953;

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint FrequencyConditionType_LimitState_CurrentState_Id = 16954;

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint FrequencyConditionType_LimitState_LastTransition_Id = 16959;

        /// <summary>
        /// The identifier for the HardwareConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint HardwareConditionType_EnabledState_Id = 16986;

        /// <summary>
        /// The identifier for the HardwareConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint HardwareConditionType_Quality_SourceTimestamp = 16995;

        /// <summary>
        /// The identifier for the HardwareConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint HardwareConditionType_LastSeverity_SourceTimestamp = 16997;

        /// <summary>
        /// The identifier for the HardwareConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint HardwareConditionType_Comment_SourceTimestamp = 16999;

        /// <summary>
        /// The identifier for the HardwareConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint HardwareConditionType_AddComment_InputArguments = 17004;

        /// <summary>
        /// The identifier for the HardwareConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint HardwareConditionType_ConditionRefresh_InputArguments = 17006;

        /// <summary>
        /// The identifier for the HardwareConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint HardwareConditionType_ConditionRefresh2_InputArguments = 17008;

        /// <summary>
        /// The identifier for the HardwareConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint HardwareConditionType_ActiveState_Id = 17011;

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint HardwareConditionType_LimitState_CurrentState = 17020;

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint HardwareConditionType_LimitState_CurrentState_Id = 17021;

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint HardwareConditionType_LimitState_LastTransition_Id = 17026;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_EnabledState_Id = 17053;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_Quality_SourceTimestamp = 17062;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_LastSeverity_SourceTimestamp = 17064;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_Comment_SourceTimestamp = 17066;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_AddComment_InputArguments = 17071;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_ConditionRefresh_InputArguments = 17073;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_ConditionRefresh2_InputArguments = 17075;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_ActiveState_Id = 17078;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_LimitState_CurrentState = 17087;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_LimitState_CurrentState_Id = 17088;

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Linear_ForceConditionType_LimitState_LastTransition_Id = 17093;

        /// <summary>
        /// The identifier for the LoadConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint LoadConditionType_EnabledState_Id = 17120;

        /// <summary>
        /// The identifier for the LoadConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint LoadConditionType_Quality_SourceTimestamp = 17129;

        /// <summary>
        /// The identifier for the LoadConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint LoadConditionType_LastSeverity_SourceTimestamp = 17131;

        /// <summary>
        /// The identifier for the LoadConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint LoadConditionType_Comment_SourceTimestamp = 17133;

        /// <summary>
        /// The identifier for the LoadConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint LoadConditionType_AddComment_InputArguments = 17138;

        /// <summary>
        /// The identifier for the LoadConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint LoadConditionType_ConditionRefresh_InputArguments = 17140;

        /// <summary>
        /// The identifier for the LoadConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint LoadConditionType_ConditionRefresh2_InputArguments = 17142;

        /// <summary>
        /// The identifier for the LoadConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint LoadConditionType_ActiveState_Id = 17145;

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint LoadConditionType_LimitState_CurrentState = 17154;

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint LoadConditionType_LimitState_CurrentState_Id = 17155;

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint LoadConditionType_LimitState_LastTransition_Id = 17160;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_EnabledState_Id = 17187;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_Quality_SourceTimestamp = 17196;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_LastSeverity_SourceTimestamp = 17198;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_Comment_SourceTimestamp = 17200;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_AddComment_InputArguments = 17205;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_ConditionRefresh_InputArguments = 17207;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_ConditionRefresh2_InputArguments = 17209;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_ActiveState_Id = 17212;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_LimitState_CurrentState = 17221;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_LimitState_CurrentState_Id = 17222;

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Logic_ProgramConditionType_LimitState_LastTransition_Id = 17227;

        /// <summary>
        /// The identifier for the MassConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint MassConditionType_EnabledState_Id = 17254;

        /// <summary>
        /// The identifier for the MassConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint MassConditionType_Quality_SourceTimestamp = 17263;

        /// <summary>
        /// The identifier for the MassConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint MassConditionType_LastSeverity_SourceTimestamp = 17265;

        /// <summary>
        /// The identifier for the MassConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint MassConditionType_Comment_SourceTimestamp = 17267;

        /// <summary>
        /// The identifier for the MassConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint MassConditionType_AddComment_InputArguments = 17272;

        /// <summary>
        /// The identifier for the MassConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint MassConditionType_ConditionRefresh_InputArguments = 17274;

        /// <summary>
        /// The identifier for the MassConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint MassConditionType_ConditionRefresh2_InputArguments = 17276;

        /// <summary>
        /// The identifier for the MassConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint MassConditionType_ActiveState_Id = 17279;

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint MassConditionType_LimitState_CurrentState = 17288;

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint MassConditionType_LimitState_CurrentState_Id = 17289;

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint MassConditionType_LimitState_LastTransition_Id = 17294;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_EnabledState_Id = 17321;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_Quality_SourceTimestamp = 17330;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_LastSeverity_SourceTimestamp = 17332;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_Comment_SourceTimestamp = 17334;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_AddComment_InputArguments = 17339;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_ConditionRefresh_InputArguments = 17341;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_ConditionRefresh2_InputArguments = 17343;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_ActiveState_Id = 17346;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_LimitState_CurrentState = 17355;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_LimitState_CurrentState_Id = 17356;

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Motion_ProgramConditionType_LimitState_LastTransition_Id = 17361;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_EnabledState_Id = 17388;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_Quality_SourceTimestamp = 17397;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_LastSeverity_SourceTimestamp = 17399;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_Comment_SourceTimestamp = 17401;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_AddComment_InputArguments = 17406;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_ConditionRefresh_InputArguments = 17408;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_ConditionRefresh2_InputArguments = 17410;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_ActiveState_Id = 17413;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_LimitState_CurrentState = 17422;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_LimitState_CurrentState_Id = 17423;

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Path_FeedrateConditionType_LimitState_LastTransition_Id = 17428;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Path_PositionConditionType_EnabledState_Id = 17455;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_PositionConditionType_Quality_SourceTimestamp = 17464;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_PositionConditionType_LastSeverity_SourceTimestamp = 17466;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Path_PositionConditionType_Comment_SourceTimestamp = 17468;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Path_PositionConditionType_AddComment_InputArguments = 17473;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Path_PositionConditionType_ConditionRefresh_InputArguments = 17475;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Path_PositionConditionType_ConditionRefresh2_InputArguments = 17477;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Path_PositionConditionType_ActiveState_Id = 17480;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Path_PositionConditionType_LimitState_CurrentState = 17489;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Path_PositionConditionType_LimitState_CurrentState_Id = 17490;

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Path_PositionConditionType_LimitState_LastTransition_Id = 17495;

        /// <summary>
        /// The identifier for the PHConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint PHConditionType_EnabledState_Id = 17522;

        /// <summary>
        /// The identifier for the PHConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint PHConditionType_Quality_SourceTimestamp = 17531;

        /// <summary>
        /// The identifier for the PHConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint PHConditionType_LastSeverity_SourceTimestamp = 17533;

        /// <summary>
        /// The identifier for the PHConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint PHConditionType_Comment_SourceTimestamp = 17535;

        /// <summary>
        /// The identifier for the PHConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint PHConditionType_AddComment_InputArguments = 17540;

        /// <summary>
        /// The identifier for the PHConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint PHConditionType_ConditionRefresh_InputArguments = 17542;

        /// <summary>
        /// The identifier for the PHConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint PHConditionType_ConditionRefresh2_InputArguments = 17544;

        /// <summary>
        /// The identifier for the PHConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint PHConditionType_ActiveState_Id = 17547;

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint PHConditionType_LimitState_CurrentState = 17556;

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint PHConditionType_LimitState_CurrentState_Id = 17557;

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint PHConditionType_LimitState_LastTransition_Id = 17562;

        /// <summary>
        /// The identifier for the PositionConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint PositionConditionType_EnabledState_Id = 17589;

        /// <summary>
        /// The identifier for the PositionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint PositionConditionType_Quality_SourceTimestamp = 17598;

        /// <summary>
        /// The identifier for the PositionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint PositionConditionType_LastSeverity_SourceTimestamp = 17600;

        /// <summary>
        /// The identifier for the PositionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint PositionConditionType_Comment_SourceTimestamp = 17602;

        /// <summary>
        /// The identifier for the PositionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint PositionConditionType_AddComment_InputArguments = 17607;

        /// <summary>
        /// The identifier for the PositionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint PositionConditionType_ConditionRefresh_InputArguments = 17609;

        /// <summary>
        /// The identifier for the PositionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint PositionConditionType_ConditionRefresh2_InputArguments = 17611;

        /// <summary>
        /// The identifier for the PositionConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint PositionConditionType_ActiveState_Id = 17614;

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint PositionConditionType_LimitState_CurrentState = 17623;

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint PositionConditionType_LimitState_CurrentState_Id = 17624;

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint PositionConditionType_LimitState_LastTransition_Id = 17629;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Power_FactorConditionType_EnabledState_Id = 17656;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Power_FactorConditionType_Quality_SourceTimestamp = 17665;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Power_FactorConditionType_LastSeverity_SourceTimestamp = 17667;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Power_FactorConditionType_Comment_SourceTimestamp = 17669;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Power_FactorConditionType_AddComment_InputArguments = 17674;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Power_FactorConditionType_ConditionRefresh_InputArguments = 17676;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Power_FactorConditionType_ConditionRefresh2_InputArguments = 17678;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Power_FactorConditionType_ActiveState_Id = 17681;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Power_FactorConditionType_LimitState_CurrentState = 17690;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Power_FactorConditionType_LimitState_CurrentState_Id = 17691;

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Power_FactorConditionType_LimitState_LastTransition_Id = 17696;

        /// <summary>
        /// The identifier for the PressureConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint PressureConditionType_EnabledState_Id = 17723;

        /// <summary>
        /// The identifier for the PressureConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint PressureConditionType_Quality_SourceTimestamp = 17732;

        /// <summary>
        /// The identifier for the PressureConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint PressureConditionType_LastSeverity_SourceTimestamp = 17734;

        /// <summary>
        /// The identifier for the PressureConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint PressureConditionType_Comment_SourceTimestamp = 17736;

        /// <summary>
        /// The identifier for the PressureConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint PressureConditionType_AddComment_InputArguments = 17741;

        /// <summary>
        /// The identifier for the PressureConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint PressureConditionType_ConditionRefresh_InputArguments = 17743;

        /// <summary>
        /// The identifier for the PressureConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint PressureConditionType_ConditionRefresh2_InputArguments = 17745;

        /// <summary>
        /// The identifier for the PressureConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint PressureConditionType_ActiveState_Id = 17748;

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint PressureConditionType_LimitState_CurrentState = 17757;

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint PressureConditionType_LimitState_CurrentState_Id = 17758;

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint PressureConditionType_LimitState_LastTransition_Id = 17763;

        /// <summary>
        /// The identifier for the ResistanceConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint ResistanceConditionType_EnabledState_Id = 17790;

        /// <summary>
        /// The identifier for the ResistanceConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint ResistanceConditionType_Quality_SourceTimestamp = 17799;

        /// <summary>
        /// The identifier for the ResistanceConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint ResistanceConditionType_LastSeverity_SourceTimestamp = 17801;

        /// <summary>
        /// The identifier for the ResistanceConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint ResistanceConditionType_Comment_SourceTimestamp = 17803;

        /// <summary>
        /// The identifier for the ResistanceConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint ResistanceConditionType_AddComment_InputArguments = 17808;

        /// <summary>
        /// The identifier for the ResistanceConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint ResistanceConditionType_ConditionRefresh_InputArguments = 17810;

        /// <summary>
        /// The identifier for the ResistanceConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint ResistanceConditionType_ConditionRefresh2_InputArguments = 17812;

        /// <summary>
        /// The identifier for the ResistanceConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint ResistanceConditionType_ActiveState_Id = 17815;

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint ResistanceConditionType_LimitState_CurrentState = 17824;

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint ResistanceConditionType_LimitState_CurrentState_Id = 17825;

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint ResistanceConditionType_LimitState_LastTransition_Id = 17830;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_EnabledState_Id = 17857;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_Quality_SourceTimestamp = 17866;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_LastSeverity_SourceTimestamp = 17868;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_Comment_SourceTimestamp = 17870;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_AddComment_InputArguments = 17875;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_ConditionRefresh_InputArguments = 17877;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_ConditionRefresh2_InputArguments = 17879;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_ActiveState_Id = 17882;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_LimitState_CurrentState = 17891;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_LimitState_CurrentState_Id = 17892;

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Rotary_VelocityConditionType_LimitState_LastTransition_Id = 17897;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_EnabledState_Id = 17924;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_Quality_SourceTimestamp = 17933;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_LastSeverity_SourceTimestamp = 17935;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_Comment_SourceTimestamp = 17937;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_AddComment_InputArguments = 17942;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_ConditionRefresh_InputArguments = 17944;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_ConditionRefresh2_InputArguments = 17946;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_ActiveState_Id = 17949;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_LimitState_CurrentState = 17958;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_LimitState_CurrentState_Id = 17959;

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Sound_LevelConditionType_LimitState_LastTransition_Id = 17964;

        /// <summary>
        /// The identifier for the StrainConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint StrainConditionType_EnabledState_Id = 17991;

        /// <summary>
        /// The identifier for the StrainConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint StrainConditionType_Quality_SourceTimestamp = 18000;

        /// <summary>
        /// The identifier for the StrainConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint StrainConditionType_LastSeverity_SourceTimestamp = 18002;

        /// <summary>
        /// The identifier for the StrainConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint StrainConditionType_Comment_SourceTimestamp = 18004;

        /// <summary>
        /// The identifier for the StrainConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint StrainConditionType_AddComment_InputArguments = 18009;

        /// <summary>
        /// The identifier for the StrainConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint StrainConditionType_ConditionRefresh_InputArguments = 18011;

        /// <summary>
        /// The identifier for the StrainConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint StrainConditionType_ConditionRefresh2_InputArguments = 18013;

        /// <summary>
        /// The identifier for the StrainConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint StrainConditionType_ActiveState_Id = 18016;

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint StrainConditionType_LimitState_CurrentState = 18025;

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint StrainConditionType_LimitState_CurrentState_Id = 18026;

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint StrainConditionType_LimitState_LastTransition_Id = 18031;

        /// <summary>
        /// The identifier for the SystemConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint SystemConditionType_EnabledState_Id = 18058;

        /// <summary>
        /// The identifier for the SystemConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint SystemConditionType_Quality_SourceTimestamp = 18067;

        /// <summary>
        /// The identifier for the SystemConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint SystemConditionType_LastSeverity_SourceTimestamp = 18069;

        /// <summary>
        /// The identifier for the SystemConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint SystemConditionType_Comment_SourceTimestamp = 18071;

        /// <summary>
        /// The identifier for the SystemConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint SystemConditionType_AddComment_InputArguments = 18076;

        /// <summary>
        /// The identifier for the SystemConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint SystemConditionType_ConditionRefresh_InputArguments = 18078;

        /// <summary>
        /// The identifier for the SystemConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint SystemConditionType_ConditionRefresh2_InputArguments = 18080;

        /// <summary>
        /// The identifier for the SystemConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint SystemConditionType_ActiveState_Id = 18083;

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint SystemConditionType_LimitState_CurrentState = 18092;

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint SystemConditionType_LimitState_CurrentState_Id = 18093;

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint SystemConditionType_LimitState_LastTransition_Id = 18098;

        /// <summary>
        /// The identifier for the TemperatureConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint TemperatureConditionType_EnabledState_Id = 18125;

        /// <summary>
        /// The identifier for the TemperatureConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureConditionType_Quality_SourceTimestamp = 18134;

        /// <summary>
        /// The identifier for the TemperatureConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureConditionType_LastSeverity_SourceTimestamp = 18136;

        /// <summary>
        /// The identifier for the TemperatureConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TemperatureConditionType_Comment_SourceTimestamp = 18138;

        /// <summary>
        /// The identifier for the TemperatureConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TemperatureConditionType_AddComment_InputArguments = 18143;

        /// <summary>
        /// The identifier for the TemperatureConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint TemperatureConditionType_ConditionRefresh_InputArguments = 18145;

        /// <summary>
        /// The identifier for the TemperatureConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint TemperatureConditionType_ConditionRefresh2_InputArguments = 18147;

        /// <summary>
        /// The identifier for the TemperatureConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint TemperatureConditionType_ActiveState_Id = 18150;

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TemperatureConditionType_LimitState_CurrentState = 18159;

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TemperatureConditionType_LimitState_CurrentState_Id = 18160;

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TemperatureConditionType_LimitState_LastTransition_Id = 18165;

        /// <summary>
        /// The identifier for the TiltConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint TiltConditionType_EnabledState_Id = 18192;

        /// <summary>
        /// The identifier for the TiltConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TiltConditionType_Quality_SourceTimestamp = 18201;

        /// <summary>
        /// The identifier for the TiltConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TiltConditionType_LastSeverity_SourceTimestamp = 18203;

        /// <summary>
        /// The identifier for the TiltConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TiltConditionType_Comment_SourceTimestamp = 18205;

        /// <summary>
        /// The identifier for the TiltConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TiltConditionType_AddComment_InputArguments = 18210;

        /// <summary>
        /// The identifier for the TiltConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint TiltConditionType_ConditionRefresh_InputArguments = 18212;

        /// <summary>
        /// The identifier for the TiltConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint TiltConditionType_ConditionRefresh2_InputArguments = 18214;

        /// <summary>
        /// The identifier for the TiltConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint TiltConditionType_ActiveState_Id = 18217;

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TiltConditionType_LimitState_CurrentState = 18226;

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TiltConditionType_LimitState_CurrentState_Id = 18227;

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TiltConditionType_LimitState_LastTransition_Id = 18232;

        /// <summary>
        /// The identifier for the TorqueConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint TorqueConditionType_EnabledState_Id = 18259;

        /// <summary>
        /// The identifier for the TorqueConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TorqueConditionType_Quality_SourceTimestamp = 18268;

        /// <summary>
        /// The identifier for the TorqueConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TorqueConditionType_LastSeverity_SourceTimestamp = 18270;

        /// <summary>
        /// The identifier for the TorqueConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TorqueConditionType_Comment_SourceTimestamp = 18272;

        /// <summary>
        /// The identifier for the TorqueConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TorqueConditionType_AddComment_InputArguments = 18277;

        /// <summary>
        /// The identifier for the TorqueConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint TorqueConditionType_ConditionRefresh_InputArguments = 18279;

        /// <summary>
        /// The identifier for the TorqueConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint TorqueConditionType_ConditionRefresh2_InputArguments = 18281;

        /// <summary>
        /// The identifier for the TorqueConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint TorqueConditionType_ActiveState_Id = 18284;

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TorqueConditionType_LimitState_CurrentState = 18293;

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TorqueConditionType_LimitState_CurrentState_Id = 18294;

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TorqueConditionType_LimitState_LastTransition_Id = 18299;

        /// <summary>
        /// The identifier for the VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint VelocityConditionType_EnabledState_Id = 18326;

        /// <summary>
        /// The identifier for the VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint VelocityConditionType_Quality_SourceTimestamp = 18335;

        /// <summary>
        /// The identifier for the VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint VelocityConditionType_LastSeverity_SourceTimestamp = 18337;

        /// <summary>
        /// The identifier for the VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint VelocityConditionType_Comment_SourceTimestamp = 18339;

        /// <summary>
        /// The identifier for the VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint VelocityConditionType_AddComment_InputArguments = 18344;

        /// <summary>
        /// The identifier for the VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint VelocityConditionType_ConditionRefresh_InputArguments = 18346;

        /// <summary>
        /// The identifier for the VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint VelocityConditionType_ConditionRefresh2_InputArguments = 18348;

        /// <summary>
        /// The identifier for the VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint VelocityConditionType_ActiveState_Id = 18351;

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint VelocityConditionType_LimitState_CurrentState = 18360;

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint VelocityConditionType_LimitState_CurrentState_Id = 18361;

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint VelocityConditionType_LimitState_LastTransition_Id = 18366;

        /// <summary>
        /// The identifier for the ViscosityConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint ViscosityConditionType_EnabledState_Id = 18393;

        /// <summary>
        /// The identifier for the ViscosityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint ViscosityConditionType_Quality_SourceTimestamp = 18402;

        /// <summary>
        /// The identifier for the ViscosityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint ViscosityConditionType_LastSeverity_SourceTimestamp = 18404;

        /// <summary>
        /// The identifier for the ViscosityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint ViscosityConditionType_Comment_SourceTimestamp = 18406;

        /// <summary>
        /// The identifier for the ViscosityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint ViscosityConditionType_AddComment_InputArguments = 18411;

        /// <summary>
        /// The identifier for the ViscosityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint ViscosityConditionType_ConditionRefresh_InputArguments = 18413;

        /// <summary>
        /// The identifier for the ViscosityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint ViscosityConditionType_ConditionRefresh2_InputArguments = 18415;

        /// <summary>
        /// The identifier for the ViscosityConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint ViscosityConditionType_ActiveState_Id = 18418;

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint ViscosityConditionType_LimitState_CurrentState = 18427;

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint ViscosityConditionType_LimitState_CurrentState_Id = 18428;

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint ViscosityConditionType_LimitState_LastTransition_Id = 18433;

        /// <summary>
        /// The identifier for the VoltageConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint VoltageConditionType_EnabledState_Id = 18460;

        /// <summary>
        /// The identifier for the VoltageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltageConditionType_Quality_SourceTimestamp = 18469;

        /// <summary>
        /// The identifier for the VoltageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltageConditionType_LastSeverity_SourceTimestamp = 18471;

        /// <summary>
        /// The identifier for the VoltageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltageConditionType_Comment_SourceTimestamp = 18473;

        /// <summary>
        /// The identifier for the VoltageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint VoltageConditionType_AddComment_InputArguments = 18478;

        /// <summary>
        /// The identifier for the VoltageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint VoltageConditionType_ConditionRefresh_InputArguments = 18480;

        /// <summary>
        /// The identifier for the VoltageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint VoltageConditionType_ConditionRefresh2_InputArguments = 18482;

        /// <summary>
        /// The identifier for the VoltageConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint VoltageConditionType_ActiveState_Id = 18485;

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint VoltageConditionType_LimitState_CurrentState = 18494;

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint VoltageConditionType_LimitState_CurrentState_Id = 18495;

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint VoltageConditionType_LimitState_LastTransition_Id = 18500;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_EnabledState_Id = 18527;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_Quality_SourceTimestamp = 18536;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_LastSeverity_SourceTimestamp = 18538;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_Comment_SourceTimestamp = 18540;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_AddComment_InputArguments = 18545;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_ConditionRefresh_InputArguments = 18547;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_ConditionRefresh2_InputArguments = 18549;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_ActiveState_Id = 18552;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_LimitState_CurrentState = 18561;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_LimitState_CurrentState_Id = 18562;

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint Volt_AmperageConditionType_LimitState_LastTransition_Id = 18567;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_EnabledState_Id = 18594;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_Quality_SourceTimestamp = 18603;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp = 18605;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_Comment_SourceTimestamp = 18607;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_AddComment_InputArguments = 18612;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments = 18614;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments = 18616;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_ActiveState_Id = 18619;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_LimitState_CurrentState = 18628;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_LimitState_CurrentState_Id = 18629;

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint VoltAmperageReactiveConditionType_LimitState_LastTransition_Id = 18634;

        /// <summary>
        /// The identifier for the WattageConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint WattageConditionType_EnabledState_Id = 18661;

        /// <summary>
        /// The identifier for the WattageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint WattageConditionType_Quality_SourceTimestamp = 18670;

        /// <summary>
        /// The identifier for the WattageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint WattageConditionType_LastSeverity_SourceTimestamp = 18672;

        /// <summary>
        /// The identifier for the WattageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint WattageConditionType_Comment_SourceTimestamp = 18674;

        /// <summary>
        /// The identifier for the WattageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint WattageConditionType_AddComment_InputArguments = 18679;

        /// <summary>
        /// The identifier for the WattageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint WattageConditionType_ConditionRefresh_InputArguments = 18681;

        /// <summary>
        /// The identifier for the WattageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint WattageConditionType_ConditionRefresh2_InputArguments = 18683;

        /// <summary>
        /// The identifier for the WattageConditionType_ActiveState_Id Variable.
        /// </summary>
        public const uint WattageConditionType_ActiveState_Id = 18686;

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public const uint WattageConditionType_LimitState_CurrentState = 18695;

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint WattageConditionType_LimitState_CurrentState_Id = 18696;

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint WattageConditionType_LimitState_LastTransition_Id = 18701;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaMTConnect_BinarySchema = 15185;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaMTConnect_BinarySchema_NamespaceUri = 15187;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaMTConnect_BinarySchema_Deprecated = 15188;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_DataItemEnumDataType Variable.
        /// </summary>
        public const uint OpcUaMTConnect_BinarySchema_DataItemEnumDataType = 15735;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_DataItemStatisticsDataType Variable.
        /// </summary>
        public const uint OpcUaMTConnect_BinarySchema_DataItemStatisticsDataType = 15738;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaMTConnect_XmlSchema = 15189;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaMTConnect_XmlSchema_NamespaceUri = 15191;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaMTConnect_XmlSchema_Deprecated = 15192;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_DataItemEnumDataType Variable.
        /// </summary>
        public const uint OpcUaMTConnect_XmlSchema_DataItemEnumDataType = 15743;

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_DataItemStatisticsDataType Variable.
        /// </summary>
        public const uint OpcUaMTConnect_XmlSchema_DataItemStatisticsDataType = 15746;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the MTSampleDataItemType VariableType.
        /// </summary>
        public const uint MTSampleDataItemType = 15009;

        /// <summary>
        /// The identifier for the AccelerationType VariableType.
        /// </summary>
        public const uint AccelerationType = 15052;

        /// <summary>
        /// The identifier for the AccumulatedTimeType VariableType.
        /// </summary>
        public const uint AccumulatedTimeType = 15065;

        /// <summary>
        /// The identifier for the AmperageType VariableType.
        /// </summary>
        public const uint AmperageType = 15075;

        /// <summary>
        /// The identifier for the AngleType VariableType.
        /// </summary>
        public const uint AngleType = 15085;

        /// <summary>
        /// The identifier for the AngularAccelerationType VariableType.
        /// </summary>
        public const uint AngularAccelerationType = 15095;

        /// <summary>
        /// The identifier for the AngularVelocityType VariableType.
        /// </summary>
        public const uint AngularVelocityType = 15105;

        /// <summary>
        /// The identifier for the AxisFeedrateType VariableType.
        /// </summary>
        public const uint AxisFeedrateType = 15115;

        /// <summary>
        /// The identifier for the ConcentrationType VariableType.
        /// </summary>
        public const uint ConcentrationType = 15125;

        /// <summary>
        /// The identifier for the ConductivityType VariableType.
        /// </summary>
        public const uint ConductivityType = 15135;

        /// <summary>
        /// The identifier for the DisplacementType VariableType.
        /// </summary>
        public const uint DisplacementType = 15145;

        /// <summary>
        /// The identifier for the ElectricalEnergyType VariableType.
        /// </summary>
        public const uint ElectricalEnergyType = 15155;

        /// <summary>
        /// The identifier for the FillLevelType VariableType.
        /// </summary>
        public const uint FillLevelType = 15165;

        /// <summary>
        /// The identifier for the FlowType VariableType.
        /// </summary>
        public const uint FlowType = 15175;

        /// <summary>
        /// The identifier for the FrequencyType VariableType.
        /// </summary>
        public const uint FrequencyType = 15193;

        /// <summary>
        /// The identifier for the LinearForceType VariableType.
        /// </summary>
        public const uint LinearForceType = 15203;

        /// <summary>
        /// The identifier for the LoadType VariableType.
        /// </summary>
        public const uint LoadType = 15213;

        /// <summary>
        /// The identifier for the MassType VariableType.
        /// </summary>
        public const uint MassType = 15223;

        /// <summary>
        /// The identifier for the PathFeedrateType VariableType.
        /// </summary>
        public const uint PathFeedrateType = 15233;

        /// <summary>
        /// The identifier for the PathPositionType VariableType.
        /// </summary>
        public const uint PathPositionType = 15243;

        /// <summary>
        /// The identifier for the PHType VariableType.
        /// </summary>
        public const uint PHType = 15253;

        /// <summary>
        /// The identifier for the PositionType VariableType.
        /// </summary>
        public const uint PositionType = 15263;

        /// <summary>
        /// The identifier for the PowerFactorType VariableType.
        /// </summary>
        public const uint PowerFactorType = 15273;

        /// <summary>
        /// The identifier for the PressureType VariableType.
        /// </summary>
        public const uint PressureType = 15283;

        /// <summary>
        /// The identifier for the ResistanceType VariableType.
        /// </summary>
        public const uint ResistanceType = 15293;

        /// <summary>
        /// The identifier for the RotationalVelocityType VariableType.
        /// </summary>
        public const uint RotationalVelocityType = 15303;

        /// <summary>
        /// The identifier for the SoundPressureType VariableType.
        /// </summary>
        public const uint SoundPressureType = 15313;

        /// <summary>
        /// The identifier for the StrainType VariableType.
        /// </summary>
        public const uint StrainType = 15323;

        /// <summary>
        /// The identifier for the TemperatureType VariableType.
        /// </summary>
        public const uint TemperatureType = 15333;

        /// <summary>
        /// The identifier for the TiltType VariableType.
        /// </summary>
        public const uint TiltType = 15343;

        /// <summary>
        /// The identifier for the TorqueType VariableType.
        /// </summary>
        public const uint TorqueType = 15353;

        /// <summary>
        /// The identifier for the VelocityType VariableType.
        /// </summary>
        public const uint VelocityType = 15363;

        /// <summary>
        /// The identifier for the ViscosityType VariableType.
        /// </summary>
        public const uint ViscosityType = 15373;

        /// <summary>
        /// The identifier for the VoltageType VariableType.
        /// </summary>
        public const uint VoltageType = 15383;

        /// <summary>
        /// The identifier for the VoltAmpereType VariableType.
        /// </summary>
        public const uint VoltAmpereType = 15393;

        /// <summary>
        /// The identifier for the VoltAmpereReactiveType VariableType.
        /// </summary>
        public const uint VoltAmpereReactiveType = 15403;

        /// <summary>
        /// The identifier for the WattageType VariableType.
        /// </summary>
        public const uint WattageType = 15413;

        /// <summary>
        /// The identifier for the MTEventDataItemType VariableType.
        /// </summary>
        public const uint MTEventDataItemType = 15423;

        /// <summary>
        /// The identifier for the ActiveAxesType VariableType.
        /// </summary>
        public const uint ActiveAxesType = 15428;

        /// <summary>
        /// The identifier for the ActuatorStateType VariableType.
        /// </summary>
        public const uint ActuatorStateType = 15433;

        /// <summary>
        /// The identifier for the AvailabilityType VariableType.
        /// </summary>
        public const uint AvailabilityType = 15438;

        /// <summary>
        /// The identifier for the AxesCouplingType VariableType.
        /// </summary>
        public const uint AxesCouplingType = 15443;

        /// <summary>
        /// The identifier for the BlockType VariableType.
        /// </summary>
        public const uint BlockType = 15448;

        /// <summary>
        /// The identifier for the ClampStateType VariableType.
        /// </summary>
        public const uint ClampStateType = 15453;

        /// <summary>
        /// The identifier for the ControllerModeType VariableType.
        /// </summary>
        public const uint ControllerModeType = 15458;

        /// <summary>
        /// The identifier for the CoupledAxesType VariableType.
        /// </summary>
        public const uint CoupledAxesType = 15463;

        /// <summary>
        /// The identifier for the DirectionType VariableType.
        /// </summary>
        public const uint DirectionType = 15468;

        /// <summary>
        /// The identifier for the DoorStateType VariableType.
        /// </summary>
        public const uint DoorStateType = 15473;

        /// <summary>
        /// The identifier for the EmergencyStopType VariableType.
        /// </summary>
        public const uint EmergencyStopType = 15478;

        /// <summary>
        /// The identifier for the ExecutionType VariableType.
        /// </summary>
        public const uint ExecutionType = 15483;

        /// <summary>
        /// The identifier for the LineType VariableType.
        /// </summary>
        public const uint LineType = 15488;

        /// <summary>
        /// The identifier for the MessageType VariableType.
        /// </summary>
        public const uint MessageType = 15493;

        /// <summary>
        /// The identifier for the PalletIdType VariableType.
        /// </summary>
        public const uint PalletIdType = 15498;

        /// <summary>
        /// The identifier for the PartCountType VariableType.
        /// </summary>
        public const uint PartCountType = 15503;

        /// <summary>
        /// The identifier for the PartIdType VariableType.
        /// </summary>
        public const uint PartIdType = 15508;

        /// <summary>
        /// The identifier for the PathModeType VariableType.
        /// </summary>
        public const uint PathModeType = 15513;

        /// <summary>
        /// The identifier for the PowerStateType VariableType.
        /// </summary>
        public const uint PowerStateType = 15518;

        /// <summary>
        /// The identifier for the ProgramType VariableType.
        /// </summary>
        public const uint ProgramType = 15523;

        /// <summary>
        /// The identifier for the RotaryModeType VariableType.
        /// </summary>
        public const uint RotaryModeType = 15528;

        /// <summary>
        /// The identifier for the ToolAssetIdType VariableType.
        /// </summary>
        public const uint ToolAssetIdType = 15533;

        /// <summary>
        /// The identifier for the ToolNumberType VariableType.
        /// </summary>
        public const uint ToolNumberType = 15538;

        /// <summary>
        /// The identifier for the WorkHoldingIdType VariableType.
        /// </summary>
        public const uint WorkHoldingIdType = 15543;

        /// <summary>
        /// The identifier for the ChannelType VariableType.
        /// </summary>
        public const uint ChannelType = 15548;

        /// <summary>
        /// The identifier for the MeasurementType VariableType.
        /// </summary>
        public const uint MeasurementType = 15552;

        /// <summary>
        /// The identifier for the CutterStatusType VariableType.
        /// </summary>
        public const uint CutterStatusType = 15566;

        /// <summary>
        /// The identifier for the ReconditionCountType VariableType.
        /// </summary>
        public const uint ReconditionCountType = 15568;

        /// <summary>
        /// The identifier for the LifeType VariableType.
        /// </summary>
        public const uint LifeType = 15570;

        /// <summary>
        /// The identifier for the LocationType VariableType.
        /// </summary>
        public const uint LocationType = 15575;

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType VariableType.
        /// </summary>
        public const uint ProgramSpindleSpeedType = 15579;

        /// <summary>
        /// The identifier for the ProgramFeedRateType VariableType.
        /// </summary>
        public const uint ProgramFeedRateType = 15583;

        /// <summary>
        /// The identifier for the CuttingItemType VariableType.
        /// </summary>
        public const uint CuttingItemType = 15587;

        /// <summary>
        /// The identifier for the AssemblyMeasurementType VariableType.
        /// </summary>
        public const uint AssemblyMeasurementType = 15596;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the ActuatorStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ActuatorStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ActuatorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AlarmStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId AlarmStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AlarmStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AssetDescriptionType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AssetDescriptionType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AssetDescriptionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AssetAttrDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AssetAttrDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AssetAttrDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AssetBufferSizeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AssetBufferSizeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AssetBufferSizeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AssetIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AssetIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AssetIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AvailabilityTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId AvailabilityTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AvailabilityTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AxesCouplingTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId AxesCouplingTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AxesCouplingTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AxesListValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AxesListValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.AxesListValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the BufferSizeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId BufferSizeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.BufferSizeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CalibrationDateDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CalibrationDateDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CalibrationDateDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CalibrationInitialsDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CalibrationInitialsDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CalibrationInitialsDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CategoryTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId CategoryTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CategoryTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ChannelNumberDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ChannelNumberDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ChannelNumberDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ClampStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ClampStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ClampStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConditionDescriptionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ConditionDescriptionDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ConditionDescriptionDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerModeTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ControllerModeTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ControllerModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CoordinateSystemTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId CoordinateSystemTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CoordinateSystemTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the IDDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId IDDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.IDDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CodeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CodeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CodeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ComponentIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ComponentIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ComponentIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConnectionCodeMachineSideDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionCodeMachineSideDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ConnectionCodeMachineSideDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CountValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CountValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CountValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CreationTimeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CreationTimeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CreationTimeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CutterStatusValueTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId CutterStatusValueTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.CutterStatusValueTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemEnumDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemEnumTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemStatisticsDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemStatisticsTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemSubEnumTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DataItemSubEnumTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DataItemSubEnumTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DefinitionFormatTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DefinitionFormatTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DefinitionFormatTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DecibelValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DecibelValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DecibelValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DescriptionTextDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DescriptionTextDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DescriptionTextDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DirectionTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DirectionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DoorStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId DoorStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DoorStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DurationTimeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DurationTimeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DurationTimeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DurationValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DurationValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.DurationValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the EdgeCountDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId EdgeCountDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.EdgeCountDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the EmergencyStopTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId EmergencyStopTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.EmergencyStopTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the EnergyValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId EnergyValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.EnergyValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ExecutionTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ExecutionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FeedrateValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FeedrateValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.FeedrateValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FirmwareVersionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FirmwareVersionDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.FirmwareVersionDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ForceValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ForceValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ForceValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the GradeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId GradeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.GradeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the IndexRangeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId IndexRangeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.IndexRangeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the InstanceIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId InstanceIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.InstanceIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ItemIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ItemIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ItemIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the InterfaceStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId InterfaceStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.InterfaceStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ItemSourceDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ItemSourceDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ItemSourceDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationSizeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocationSizeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.LocationSizeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocationValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.LocationValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationsTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocationsTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.LocationsTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocusDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocusDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.LocusDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ManufacturersDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ManufacturersDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ManufacturersDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MassValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.MassValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MaximumCountDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MaximumCountDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.MaximumCountDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MaximumDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MaximumDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.MaximumDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.MeasurementValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MinimumDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId MinimumDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.MinimumDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ModelDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ModelDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ModelDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NameDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NameDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NameDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NativeCodeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NativeCodeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NativeCodeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NativeNotifcationCodeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NativeNotifcationCodeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NativeNotifcationCodeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NativeScaleDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NativeScaleDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NativeScaleDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NativeSeverityDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NativeSeverityDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NativeSeverityDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NextCalibrationDateDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NextCalibrationDateDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NextCalibrationDateDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NominalDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NominalDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NominalDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NotificationCodeTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId NotificationCodeTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NotificationCodeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NotificationDescriptionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NotificationDescriptionDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.NotificationDescriptionDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OccurrenceTimeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OccurrenceTimeDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.OccurrenceTimeDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OverlapDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OverlapDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.OverlapDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PathModeTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId PathModeTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.PathModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PowerStateTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId PowerStateTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.PowerStateTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramToolNumberDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramToolNumberDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ProgramToolNumberDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the QualifierTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId QualifierTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.QualifierTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the RateDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RateDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.RateDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ReconditionCountValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ReconditionCountValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ReconditionCountValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the RotaryModeTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId RotaryModeTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.RotaryModeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SampleRateDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SampleRateDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SampleRateDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SeverityTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId SeverityTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SeverityTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SignificantDigitsValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SignificantDigitsValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SignificantDigitsValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StationDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId StationDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.StationDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SenderDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SenderDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SenderDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SequenceDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SequenceDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SequenceDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SerialNumberDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SerialNumberDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SerialNumberDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SpeedDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SpeedDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.SpeedDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TestIndicatorDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId TestIndicatorDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.TestIndicatorDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolEventValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolEventValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolEventValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolGroupDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolGroupDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolGroupDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolIdDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolIdDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolLifeDirectionTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolLifeDirectionTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolLifeDirectionTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolLifeTypeEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolLifeTypeEnum = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolLifeTypeEnum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolLifeValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ToolLifeValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.ToolLifeValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the UnitsExtDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UnitsExtDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.UnitsExtDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VersionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId VersionDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.VersionDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VibrationValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId VibrationValueDataType = new ExpandedNodeId(Opc.Ua.MTConnect.DataTypes.VibrationValueDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Disable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.Memex_3Axis_Axes_XLoad_Disable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Enable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.Memex_3Axis_Axes_XLoad_Enable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_AddComment = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.Memex_3Axis_Axes_XLoad_AddComment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Disable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolType_Axes_XLoad_Disable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Enable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolType_Axes_XLoad_Enable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_AddComment = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolType_Axes_XLoad_AddComment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Disable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolAxesType_XLoad_Disable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Enable = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolAxesType_XLoad_Enable, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_AddComment = new ExpandedNodeId(Opc.Ua.MTConnect.Methods.CuttingToolAxesType_XLoad_AddComment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Memex_3Axis Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_DataItems Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_DataItems = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis_DataItems, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Components Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Components = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis_Components, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis_Axes, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis_Axes_XLoad, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller Object.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Controller = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.Memex_3Axis_Controller, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_DataItems Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_DataItems = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_DataItems, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Components Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Components = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_Components, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Conditions Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Conditions = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_Conditions, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_Axes, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_Axes_XLoad, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Controller Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Controller = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolType_Controller, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingToolAxesType_XLoad, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_ItemLife Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_ItemLife = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingItemType_ItemLife, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Measurements Object.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Measurements = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.CuttingItemType_Measurements, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_LimitState = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.MTConditionType_LimitState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemEnumDataType_Encoding_DefaultBinary, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemStatisticsDataType_Encoding_DefaultBinary, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemEnumDataType_Encoding_DefaultXml, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemStatisticsDataType_Encoding_DefaultXml, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemEnumDataType_Encoding_DefaultJson, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.MTConnect.Objects.DataItemStatisticsDataType_Encoding_DefaultJson, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the CuttingToolsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolsType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.CuttingToolsType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.CuttingToolType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolComponentType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.CuttingToolComponentType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.CuttingToolAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ControllerType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.ControllerType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.MTConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Accumulated_TimeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.AngleConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Angular_AccelerationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Angular_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.CommunicationsConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.ConcentrationConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.ConductivityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Data_RangeConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.DirectionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.DisplacementConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Electrical_EnergyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Fill_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.FlowConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.FrequencyConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.HardwareConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Linear_ForceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.LoadConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Logic_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.MassConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Motion_ProgramConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Path_FeedrateConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Path_PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.PHConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.PositionConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Power_FactorConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.PressureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.ResistanceConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Rotary_VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Sound_LevelConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.StrainConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.SystemConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.TemperatureConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.TiltConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.TorqueConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.VelocityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.ViscosityConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.VoltageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.Volt_AmperageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.VoltAmperageReactiveConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType = new ExpandedNodeId(Opc.Ua.MTConnect.ObjectTypes.WattageConditionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the Memex_3Axis_Availability Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Availability = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Availability, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Manufacturer = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Manufacturer, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_SerialNumber = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_SerialNumber, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_X = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_X, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_Y = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_Y, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_Z = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_Z, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_C = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_C, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_EventId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_EventId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_EventType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_EventType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_SourceNode = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_SourceNode, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_SourceName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_SourceName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Time = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Time, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ReceiveTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ReceiveTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LocalTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LocalTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Severity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Severity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ConditionClassId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ConditionClassId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ConditionClassName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ConditionClassName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ConditionName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ConditionName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_BranchId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_BranchId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Retain = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Retain, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_EnabledState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_EnabledState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Quality = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Quality, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LastSeverity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LastSeverity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Comment = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Comment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ClientUserId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ClientUserId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_MTCurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_MTCurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_MTCurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ActiveState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ActiveState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Axes_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Axes_XLoad_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Axes_XLoad_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_EmergencyStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Controller_EmergencyStop = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Controller_EmergencyStop, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Controller_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Controller_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Memex_3Axis_Controller_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId Memex_3Axis_Controller_Line = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Memex_3Axis_Controller_Line, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolsType_MTConnectVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolsType_MTConnectVersion = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolsType_MTConnectVersion, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolsType_OPCUAMappingDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolsType_OPCUAMappingDate = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolsType_OPCUAMappingDate, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolsType_OPCUAVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolsType_OPCUAVersion = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolsType_OPCUAVersion, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Availability Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Availability = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Availability, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Manufacturer = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Manufacturer, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_SerialNumber = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_SerialNumber, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_SampleInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_SampleInterval = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_SampleInterval, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_X = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_X, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_Y = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_Y, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_Z = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_Z, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_C = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_C, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_EventId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_EventId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_EventType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_EventType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_SourceNode = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_SourceNode, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_SourceName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_SourceName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Time = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Time, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ReceiveTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ReceiveTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LocalTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LocalTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Severity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Severity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ConditionClassId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ConditionClassId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ConditionClassName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ConditionClassName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ConditionName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ConditionName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_BranchId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_BranchId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Retain = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Retain, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_EnabledState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_EnabledState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Quality = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Quality, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LastSeverity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LastSeverity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Comment = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Comment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ClientUserId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ClientUserId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_MTCurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_MTCurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_MTCurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ActiveState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ActiveState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Axes_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Axes_XLoad_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Axes_XLoad_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_EmergencyStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Controller_EmergencyStop = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Controller_EmergencyStop, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Controller_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Controller_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolType_Controller_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolType_Controller_Line = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolType_Controller_Line, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolComponentType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolComponentType_Model = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolComponentType_Model, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolComponentType_Station Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolComponentType_Station = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolComponentType_Station, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_X Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_X = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_X, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_Y Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_Y = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_Y, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_Z Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_Z = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_Z, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_C Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_C = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_C, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_EventId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_EventId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_EventType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_EventType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_SourceNode = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_SourceNode, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_SourceName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_SourceName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Time = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Time, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ReceiveTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ReceiveTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LocalTime = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LocalTime, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Severity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Severity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ConditionClassId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ConditionClassId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ConditionClassName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ConditionClassName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ConditionName = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ConditionName, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_BranchId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_BranchId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Retain = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Retain, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_EnabledState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_EnabledState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Quality = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Quality, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LastSeverity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LastSeverity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Comment = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Comment, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ClientUserId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ClientUserId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_MTCurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_MTCurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_MTCurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ActiveState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ActiveState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingToolAxesType_XLoad_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingToolAxesType_XLoad_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingToolAxesType_XLoad_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerType_EmergencyStop Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllerType_EmergencyStop = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ControllerType_EmergencyStop, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerType_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllerType_Message = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ControllerType_Message, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerType_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllerType_Line = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ControllerType_Line, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTSampleDataItemType_CoordinateSystem Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTSampleDataItemType_CoordinateSystem = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTSampleDataItemType_CoordinateSystem, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTSampleDataItemType_NativeUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTSampleDataItemType_NativeUnits = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTSampleDataItemType_NativeUnits, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTSampleDataItemType_NativeScale Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTSampleDataItemType_NativeScale = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTSampleDataItemType_NativeScale, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTSampleDataItemType_SampleInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTSampleDataItemType_SampleInterval = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTSampleDataItemType_SampleInterval, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTEventDataItemType_CoordinateSystem Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTEventDataItemType_CoordinateSystem = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTEventDataItemType_CoordinateSystem, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTEventDataItemType_SampleInterval Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTEventDataItemType_SampleInterval = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTEventDataItemType_SampleInterval, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ChannelType_CalibrationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChannelType_CalibrationDate = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ChannelType_CalibrationDate, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ChannelType_NextCalibrationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChannelType_NextCalibrationDate = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ChannelType_NextCalibrationDate, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ChannelType_CalibrationInitials Variable.
        /// </summary>
        public static readonly ExpandedNodeId ChannelType_CalibrationInitials = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ChannelType_CalibrationInitials, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_SignificantDigits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_SignificantDigits = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_SignificantDigits, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_Units = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_Units, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_NativeUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_NativeUnits = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_NativeUnits, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_LastChangeTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_LastChangeTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_LastChangeTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_Code Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_Code = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_Code, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_Maximum Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_Maximum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_Maximum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_Minimum Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_Minimum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_Minimum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType_Nominal Variable.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType_Nominal = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MeasurementType_Nominal, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CutterStatusType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId CutterStatusType_Status = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CutterStatusType_Status, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ReconditionCountType_MaximumCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReconditionCountType_MaximumCount = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ReconditionCountType_MaximumCount, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LifeType_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId LifeType_Type = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LifeType_Type, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LifeType_CountDirection Variable.
        /// </summary>
        public static readonly ExpandedNodeId LifeType_CountDirection = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LifeType_CountDirection, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LifeType_WarningLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId LifeType_WarningLevel = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LifeType_WarningLevel, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LifeType_Maximum Variable.
        /// </summary>
        public static readonly ExpandedNodeId LifeType_Maximum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LifeType_Maximum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationType_Type Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationType_Type = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LocationType_Type, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationType_NegativeOverlap Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationType_NegativeOverlap = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LocationType_NegativeOverlap, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationType_PositiveOverlap Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationType_PositiveOverlap = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LocationType_PositiveOverlap, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Maximum Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Maximum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramSpindleSpeedType_Maximum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Minimum Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Minimum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramSpindleSpeedType_Minimum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType_Nominal Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramSpindleSpeedType_Nominal = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramSpindleSpeedType_Nominal, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Maximum Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramFeedRateType_Maximum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramFeedRateType_Maximum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Minimum Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramFeedRateType_Minimum = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramFeedRateType_Minimum, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramFeedRateType_Nominal Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramFeedRateType_Nominal = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ProgramFeedRateType_Nominal, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Indices Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Indices = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_Indices, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_ItemId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_ItemId = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_ItemId, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Grade Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Grade = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_Grade, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Manufacturers Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Manufacturers = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_Manufacturers, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Description = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_Description, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType_Locus Variable.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType_Locus = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CuttingItemType_Locus, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ActuatorStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ActuatorStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ActuatorStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AlarmStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId AlarmStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AlarmStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AvailabilityTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId AvailabilityTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AvailabilityTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AxesCouplingTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId AxesCouplingTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AxesCouplingTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CategoryTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CategoryTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CategoryTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ClampStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ClampStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ClampStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerModeTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllerModeTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ControllerModeTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CoordinateSystemTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CoordinateSystemTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CoordinateSystemTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CutterStatusValueTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId CutterStatusValueTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CutterStatusValueTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemEnumTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DataItemEnumTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DataItemEnumTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemStatisticsTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DataItemStatisticsTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DataItemStatisticsTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DataItemSubEnumTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DataItemSubEnumTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DataItemSubEnumTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DefinitionFormatTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefinitionFormatTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DefinitionFormatTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DoorStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoorStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DoorStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the EmergencyStopTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId EmergencyStopTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.EmergencyStopTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ExecutionTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ExecutionTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the InterfaceStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId InterfaceStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.InterfaceStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationsTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationsTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LocationsTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the NotificationCodeTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId NotificationCodeTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.NotificationCodeTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PathModeTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PathModeTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PathModeTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PowerStateTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerStateTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PowerStateTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the QualifierTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId QualifierTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.QualifierTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the RotaryModeTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId RotaryModeTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.RotaryModeTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SeverityTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId SeverityTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SeverityTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolLifeDirectionTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolLifeDirectionTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ToolLifeDirectionTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolLifeTypeEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ToolLifeTypeEnum_EnumValues = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ToolLifeTypeEnum_EnumValues, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_MTCurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_MTCurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_MTCurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_ActiveState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_ActiveState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_NativeCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_NativeCode = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_NativeCode, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTConditionType_NativeSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId MTConditionType_NativeSeverity = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MTConditionType_NativeSeverity, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AccelerationConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Accumulated_TimeConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Accumulated_TimeConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Accumulated_TimeConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AmperageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AmperageConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AngleConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.AngleConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_AccelerationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_AccelerationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_AccelerationConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Angular_VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Angular_VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Angular_VelocityConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CommunicationsConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CommunicationsConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.CommunicationsConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConcentrationConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ConductivityConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Data_RangeConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_RangeConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Data_RangeConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DirectionConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.DisplacementConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Electrical_EnergyConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Electrical_EnergyConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Electrical_EnergyConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Fill_LevelConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Fill_LevelConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Fill_LevelConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FlowConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FlowConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.FrequencyConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the HardwareConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId HardwareConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.HardwareConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Linear_ForceConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Linear_ForceConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Linear_ForceConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.LoadConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Logic_ProgramConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Logic_ProgramConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Logic_ProgramConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MassConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.MassConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Motion_ProgramConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Motion_ProgramConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Motion_ProgramConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_FeedrateConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_FeedrateConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_FeedrateConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Path_PositionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Path_PositionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Path_PositionConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PHConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PHConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PositionConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PositionConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Power_FactorConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Power_FactorConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Power_FactorConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PressureConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.PressureConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ResistanceConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Rotary_VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rotary_VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Rotary_VelocityConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Sound_LevelConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Sound_LevelConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Sound_LevelConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId StrainConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.StrainConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SystemConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.SystemConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TemperatureConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TiltConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TiltConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TorqueConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.TorqueConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VelocityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VelocityConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.ViscosityConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltageConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the Volt_AmperageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Volt_AmperageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.Volt_AmperageConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmperageReactiveConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmperageReactiveConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.VoltAmperageReactiveConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_EnabledState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_Quality_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_LastSeverity_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_Comment_SourceTimestamp, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_AddComment_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_ConditionRefresh_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_ConditionRefresh2_InputArguments, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_ActiveState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_LimitState_CurrentState = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_LimitState_CurrentState, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_LimitState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_LimitState_CurrentState_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageConditionType_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId WattageConditionType_LimitState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.WattageConditionType_LimitState_LastTransition_Id, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_BinarySchema = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_BinarySchema, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_BinarySchema_NamespaceUri, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_BinarySchema_Deprecated = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_BinarySchema_Deprecated, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_DataItemEnumDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_BinarySchema_DataItemEnumDataType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_BinarySchema_DataItemEnumDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_BinarySchema_DataItemStatisticsDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_BinarySchema_DataItemStatisticsDataType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_BinarySchema_DataItemStatisticsDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_XmlSchema = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_XmlSchema, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_XmlSchema_NamespaceUri, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_XmlSchema_Deprecated = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_XmlSchema_Deprecated, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_DataItemEnumDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_XmlSchema_DataItemEnumDataType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_XmlSchema_DataItemEnumDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the OpcUaMTConnect_XmlSchema_DataItemStatisticsDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaMTConnect_XmlSchema_DataItemStatisticsDataType = new ExpandedNodeId(Opc.Ua.MTConnect.Variables.OpcUaMTConnect_XmlSchema_DataItemStatisticsDataType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the MTSampleDataItemType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MTSampleDataItemType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.MTSampleDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccelerationType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AccelerationType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AccumulatedTimeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AccumulatedTimeType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AccumulatedTimeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AmperageType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AmperageType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AmperageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngleType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AngleType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AngleType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngularAccelerationType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AngularAccelerationType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AngularAccelerationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AngularVelocityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AngularVelocityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AngularVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AxisFeedrateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AxisFeedrateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AxisFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConcentrationType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ConcentrationType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ConcentrationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ConductivityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ConductivityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ConductivityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DisplacementType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId DisplacementType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.DisplacementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ElectricalEnergyType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ElectricalEnergyType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ElectricalEnergyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FillLevelType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId FillLevelType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.FillLevelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FlowType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId FlowType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.FlowType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the FrequencyType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId FrequencyType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.FrequencyType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LinearForceType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LinearForceType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.LinearForceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LoadType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LoadType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.LoadType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MassType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MassType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.MassType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PathFeedrateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PathFeedrateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PathFeedrateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PathPositionType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PathPositionType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PathPositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PHType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PHType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PHType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PositionType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PositionType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PositionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PowerFactorType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PowerFactorType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PowerFactorType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PressureType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PressureType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ResistanceType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ResistanceType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ResistanceType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the RotationalVelocityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId RotationalVelocityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.RotationalVelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the SoundPressureType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId SoundPressureType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.SoundPressureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the StrainType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId StrainType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.StrainType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TemperatureType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.TemperatureType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TiltType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId TiltType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.TiltType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the TorqueType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId TorqueType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.TorqueType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VelocityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId VelocityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.VelocityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ViscosityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ViscosityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ViscosityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltageType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId VoltageType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.VoltageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmpereType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmpereType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.VoltAmpereType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the VoltAmpereReactiveType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId VoltAmpereReactiveType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.VoltAmpereReactiveType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WattageType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId WattageType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.WattageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MTEventDataItemType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MTEventDataItemType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.MTEventDataItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ActiveAxesType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ActiveAxesType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ActiveAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ActuatorStateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ActuatorStateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ActuatorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AvailabilityType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AvailabilityType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AvailabilityType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AxesCouplingType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AxesCouplingType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AxesCouplingType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the BlockType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId BlockType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.BlockType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ClampStateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ClampStateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ClampStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ControllerModeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ControllerModeType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ControllerModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CoupledAxesType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId CoupledAxesType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.CoupledAxesType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DirectionType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId DirectionType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.DirectionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the DoorStateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId DoorStateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.DoorStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the EmergencyStopType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId EmergencyStopType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.EmergencyStopType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ExecutionType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ExecutionType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ExecutionType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LineType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LineType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.LineType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MessageType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MessageType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.MessageType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PalletIdType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PalletIdType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PalletIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PartCountType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PartCountType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PartCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PartIdType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PartIdType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PartIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PathModeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PathModeType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PathModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the PowerStateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId PowerStateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.PowerStateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ProgramType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the RotaryModeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId RotaryModeType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.RotaryModeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolAssetIdType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ToolAssetIdType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ToolAssetIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ToolNumberType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ToolNumberType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ToolNumberType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the WorkHoldingIdType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId WorkHoldingIdType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.WorkHoldingIdType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ChannelType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ChannelType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ChannelType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the MeasurementType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MeasurementType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.MeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CutterStatusType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId CutterStatusType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.CutterStatusType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ReconditionCountType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ReconditionCountType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ReconditionCountType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LifeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LifeType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.LifeType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the LocationType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LocationType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.LocationType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramSpindleSpeedType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramSpindleSpeedType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ProgramSpindleSpeedType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the ProgramFeedRateType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramFeedRateType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.ProgramFeedRateType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the CuttingItemType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId CuttingItemType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.CuttingItemType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);

        /// <summary>
        /// The identifier for the AssemblyMeasurementType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId AssemblyMeasurementType = new ExpandedNodeId(Opc.Ua.MTConnect.VariableTypes.AssemblyMeasurementType, Opc.Ua.MTConnect.Namespaces.OpcUaMTConnect);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AccelerationConditionType component.
        /// </summary>
        public const string AccelerationConditionType = "AccelerationConditionType";

        /// <summary>
        /// The BrowseName for the AccelerationType component.
        /// </summary>
        public const string AccelerationType = "AccelerationType";

        /// <summary>
        /// The BrowseName for the Accumulated_TimeConditionType component.
        /// </summary>
        public const string Accumulated_TimeConditionType = "Accumulated_TimeConditionType";

        /// <summary>
        /// The BrowseName for the AccumulatedTimeType component.
        /// </summary>
        public const string AccumulatedTimeType = "AccumulatedTimeType";

        /// <summary>
        /// The BrowseName for the ActiveAxesType component.
        /// </summary>
        public const string ActiveAxesType = "ActiveAxesType";

        /// <summary>
        /// The BrowseName for the ActiveState component.
        /// </summary>
        public const string ActiveState = "ActiveState";

        /// <summary>
        /// The BrowseName for the ActuatorStateType component.
        /// </summary>
        public const string ActuatorStateType = "ActuatorStateType";

        /// <summary>
        /// The BrowseName for the ActuatorStateTypeEnum component.
        /// </summary>
        public const string ActuatorStateTypeEnum = "ActuatorStateTypeEnum";

        /// <summary>
        /// The BrowseName for the AlarmStateTypeEnum component.
        /// </summary>
        public const string AlarmStateTypeEnum = "AlarmStateTypeEnum";

        /// <summary>
        /// The BrowseName for the AmperageConditionType component.
        /// </summary>
        public const string AmperageConditionType = "AmperageConditionType";

        /// <summary>
        /// The BrowseName for the AmperageType component.
        /// </summary>
        public const string AmperageType = "AmperageType";

        /// <summary>
        /// The BrowseName for the AngleConditionType component.
        /// </summary>
        public const string AngleConditionType = "AngleConditionType";

        /// <summary>
        /// The BrowseName for the AngleType component.
        /// </summary>
        public const string AngleType = "AngleType";

        /// <summary>
        /// The BrowseName for the Angular_AccelerationConditionType component.
        /// </summary>
        public const string Angular_AccelerationConditionType = "Angular_AccelerationConditionType";

        /// <summary>
        /// The BrowseName for the Angular_VelocityConditionType component.
        /// </summary>
        public const string Angular_VelocityConditionType = "Angular_VelocityConditionType";

        /// <summary>
        /// The BrowseName for the AngularAccelerationType component.
        /// </summary>
        public const string AngularAccelerationType = "AngularAccelerationType";

        /// <summary>
        /// The BrowseName for the AngularVelocityType component.
        /// </summary>
        public const string AngularVelocityType = "AngularVelocityType";

        /// <summary>
        /// The BrowseName for the AssemblyMeasurementType component.
        /// </summary>
        public const string AssemblyMeasurementType = "AssemblyMeasurementType";

        /// <summary>
        /// The BrowseName for the AssetAttrDataType component.
        /// </summary>
        public const string AssetAttrDataType = "AssetAttrDataType";

        /// <summary>
        /// The BrowseName for the AssetBufferSizeDataType component.
        /// </summary>
        public const string AssetBufferSizeDataType = "AssetBufferSizeDataType";

        /// <summary>
        /// The BrowseName for the AssetDescriptionType component.
        /// </summary>
        public const string AssetDescriptionType = "AssetDescriptionType";

        /// <summary>
        /// The BrowseName for the AssetIdDataType component.
        /// </summary>
        public const string AssetIdDataType = "AssetIdDataType";

        /// <summary>
        /// The BrowseName for the Availability component.
        /// </summary>
        public const string Availability = "Availability";

        /// <summary>
        /// The BrowseName for the AvailabilityType component.
        /// </summary>
        public const string AvailabilityType = "AvailabilityType";

        /// <summary>
        /// The BrowseName for the AvailabilityTypeEnum component.
        /// </summary>
        public const string AvailabilityTypeEnum = "AvailabilityTypeEnum";

        /// <summary>
        /// The BrowseName for the Axes component.
        /// </summary>
        public const string Axes = "Axes";

        /// <summary>
        /// The BrowseName for the AxesCouplingType component.
        /// </summary>
        public const string AxesCouplingType = "AxesCouplingType";

        /// <summary>
        /// The BrowseName for the AxesCouplingTypeEnum component.
        /// </summary>
        public const string AxesCouplingTypeEnum = "AxesCouplingTypeEnum";

        /// <summary>
        /// The BrowseName for the AxesListValueDataType component.
        /// </summary>
        public const string AxesListValueDataType = "AxesListValueDataType";

        /// <summary>
        /// The BrowseName for the AxisFeedrateType component.
        /// </summary>
        public const string AxisFeedrateType = "AxisFeedrateType";

        /// <summary>
        /// The BrowseName for the BlockType component.
        /// </summary>
        public const string BlockType = "BlockType";

        /// <summary>
        /// The BrowseName for the BufferSizeDataType component.
        /// </summary>
        public const string BufferSizeDataType = "BufferSizeDataType";

        /// <summary>
        /// The BrowseName for the C component.
        /// </summary>
        public const string C = "C";

        /// <summary>
        /// The BrowseName for the CalibrationDate component.
        /// </summary>
        public const string CalibrationDate = "CalibrationDate";

        /// <summary>
        /// The BrowseName for the CalibrationDateDataType component.
        /// </summary>
        public const string CalibrationDateDataType = "CalibrationDateDataType";

        /// <summary>
        /// The BrowseName for the CalibrationInitials component.
        /// </summary>
        public const string CalibrationInitials = "CalibrationInitials";

        /// <summary>
        /// The BrowseName for the CalibrationInitialsDataType component.
        /// </summary>
        public const string CalibrationInitialsDataType = "CalibrationInitialsDataType";

        /// <summary>
        /// The BrowseName for the CategoryTypeEnum component.
        /// </summary>
        public const string CategoryTypeEnum = "CategoryTypeEnum";

        /// <summary>
        /// The BrowseName for the ChannelNumberDataType component.
        /// </summary>
        public const string ChannelNumberDataType = "ChannelNumberDataType";

        /// <summary>
        /// The BrowseName for the ChannelType component.
        /// </summary>
        public const string ChannelType = "ChannelType";

        /// <summary>
        /// The BrowseName for the ClampStateType component.
        /// </summary>
        public const string ClampStateType = "ClampStateType";

        /// <summary>
        /// The BrowseName for the ClampStateTypeEnum component.
        /// </summary>
        public const string ClampStateTypeEnum = "ClampStateTypeEnum";

        /// <summary>
        /// The BrowseName for the Code component.
        /// </summary>
        public const string Code = "Code";

        /// <summary>
        /// The BrowseName for the CodeDataType component.
        /// </summary>
        public const string CodeDataType = "CodeDataType";

        /// <summary>
        /// The BrowseName for the CommunicationsConditionType component.
        /// </summary>
        public const string CommunicationsConditionType = "CommunicationsConditionType";

        /// <summary>
        /// The BrowseName for the ComponentIdDataType component.
        /// </summary>
        public const string ComponentIdDataType = "ComponentIdDataType";

        /// <summary>
        /// The BrowseName for the Components component.
        /// </summary>
        public const string Components = "Components";

        /// <summary>
        /// The BrowseName for the ConcentrationConditionType component.
        /// </summary>
        public const string ConcentrationConditionType = "ConcentrationConditionType";

        /// <summary>
        /// The BrowseName for the ConcentrationType component.
        /// </summary>
        public const string ConcentrationType = "ConcentrationType";

        /// <summary>
        /// The BrowseName for the ConditionDescriptionDataType component.
        /// </summary>
        public const string ConditionDescriptionDataType = "ConditionDescriptionDataType";

        /// <summary>
        /// The BrowseName for the Conditions component.
        /// </summary>
        public const string Conditions = "Conditions";

        /// <summary>
        /// The BrowseName for the ConductivityConditionType component.
        /// </summary>
        public const string ConductivityConditionType = "ConductivityConditionType";

        /// <summary>
        /// The BrowseName for the ConductivityType component.
        /// </summary>
        public const string ConductivityType = "ConductivityType";

        /// <summary>
        /// The BrowseName for the ConnectionCodeMachineSideDataType component.
        /// </summary>
        public const string ConnectionCodeMachineSideDataType = "ConnectionCodeMachineSideDataType";

        /// <summary>
        /// The BrowseName for the Controller component.
        /// </summary>
        public const string Controller = "Controller";

        /// <summary>
        /// The BrowseName for the ControllerModeType component.
        /// </summary>
        public const string ControllerModeType = "ControllerModeType";

        /// <summary>
        /// The BrowseName for the ControllerModeTypeEnum component.
        /// </summary>
        public const string ControllerModeTypeEnum = "ControllerModeTypeEnum";

        /// <summary>
        /// The BrowseName for the ControllerType component.
        /// </summary>
        public const string ControllerType = "ControllerType";

        /// <summary>
        /// The BrowseName for the CoordinateSystem component.
        /// </summary>
        public const string CoordinateSystem = "CoordinateSystem";

        /// <summary>
        /// The BrowseName for the CoordinateSystemTypeEnum component.
        /// </summary>
        public const string CoordinateSystemTypeEnum = "CoordinateSystemTypeEnum";

        /// <summary>
        /// The BrowseName for the CountDirection component.
        /// </summary>
        public const string CountDirection = "CountDirection";

        /// <summary>
        /// The BrowseName for the CountValueDataType component.
        /// </summary>
        public const string CountValueDataType = "CountValueDataType";

        /// <summary>
        /// The BrowseName for the CoupledAxesType component.
        /// </summary>
        public const string CoupledAxesType = "CoupledAxesType";

        /// <summary>
        /// The BrowseName for the CreationTimeDataType component.
        /// </summary>
        public const string CreationTimeDataType = "CreationTimeDataType";

        /// <summary>
        /// The BrowseName for the CutterStatusType component.
        /// </summary>
        public const string CutterStatusType = "CutterStatusType";

        /// <summary>
        /// The BrowseName for the CutterStatusValueTypeEnum component.
        /// </summary>
        public const string CutterStatusValueTypeEnum = "CutterStatusValueTypeEnum";

        /// <summary>
        /// The BrowseName for the CuttingItemType component.
        /// </summary>
        public const string CuttingItemType = "CuttingItemType";

        /// <summary>
        /// The BrowseName for the CuttingToolAxesType component.
        /// </summary>
        public const string CuttingToolAxesType = "CuttingToolAxesType";

        /// <summary>
        /// The BrowseName for the CuttingToolComponentType component.
        /// </summary>
        public const string CuttingToolComponentType = "CuttingToolComponentType";

        /// <summary>
        /// The BrowseName for the CuttingToolsType component.
        /// </summary>
        public const string CuttingToolsType = "CuttingToolsType";

        /// <summary>
        /// The BrowseName for the CuttingToolType component.
        /// </summary>
        public const string CuttingToolType = "CuttingToolType";

        /// <summary>
        /// The BrowseName for the Data_RangeConditionType component.
        /// </summary>
        public const string Data_RangeConditionType = "Data_RangeConditionType";

        /// <summary>
        /// The BrowseName for the DataItemEnumDataType component.
        /// </summary>
        public const string DataItemEnumDataType = "DataItemEnumDataType";

        /// <summary>
        /// The BrowseName for the DataItemEnumTypeEnum component.
        /// </summary>
        public const string DataItemEnumTypeEnum = "DataItemEnumTypeEnum";

        /// <summary>
        /// The BrowseName for the DataItemIdDataType component.
        /// </summary>
        public const string DataItemIdDataType = "DataItemIdDataType";

        /// <summary>
        /// The BrowseName for the DataItems component.
        /// </summary>
        public const string DataItems = "DataItems";

        /// <summary>
        /// The BrowseName for the DataItemStatisticsDataType component.
        /// </summary>
        public const string DataItemStatisticsDataType = "DataItemStatisticsDataType";

        /// <summary>
        /// The BrowseName for the DataItemStatisticsTypeEnum component.
        /// </summary>
        public const string DataItemStatisticsTypeEnum = "DataItemStatisticsTypeEnum";

        /// <summary>
        /// The BrowseName for the DataItemSubEnumTypeEnum component.
        /// </summary>
        public const string DataItemSubEnumTypeEnum = "DataItemSubEnumTypeEnum";

        /// <summary>
        /// The BrowseName for the DecibelValueDataType component.
        /// </summary>
        public const string DecibelValueDataType = "DecibelValueDataType";

        /// <summary>
        /// The BrowseName for the DefinitionFormatTypeEnum component.
        /// </summary>
        public const string DefinitionFormatTypeEnum = "DefinitionFormatTypeEnum";

        /// <summary>
        /// The BrowseName for the Description component.
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// The BrowseName for the DescriptionTextDataType component.
        /// </summary>
        public const string DescriptionTextDataType = "DescriptionTextDataType";

        /// <summary>
        /// The BrowseName for the DirectionConditionType component.
        /// </summary>
        public const string DirectionConditionType = "DirectionConditionType";

        /// <summary>
        /// The BrowseName for the DirectionType component.
        /// </summary>
        public const string DirectionType = "DirectionType";

        /// <summary>
        /// The BrowseName for the DirectionTypeEnum component.
        /// </summary>
        public const string DirectionTypeEnum = "DirectionTypeEnum";

        /// <summary>
        /// The BrowseName for the DisplacementConditionType component.
        /// </summary>
        public const string DisplacementConditionType = "DisplacementConditionType";

        /// <summary>
        /// The BrowseName for the DisplacementType component.
        /// </summary>
        public const string DisplacementType = "DisplacementType";

        /// <summary>
        /// The BrowseName for the DoorStateType component.
        /// </summary>
        public const string DoorStateType = "DoorStateType";

        /// <summary>
        /// The BrowseName for the DoorStateTypeEnum component.
        /// </summary>
        public const string DoorStateTypeEnum = "DoorStateTypeEnum";

        /// <summary>
        /// The BrowseName for the DurationTimeDataType component.
        /// </summary>
        public const string DurationTimeDataType = "DurationTimeDataType";

        /// <summary>
        /// The BrowseName for the DurationValueDataType component.
        /// </summary>
        public const string DurationValueDataType = "DurationValueDataType";

        /// <summary>
        /// The BrowseName for the EdgeCountDataType component.
        /// </summary>
        public const string EdgeCountDataType = "EdgeCountDataType";

        /// <summary>
        /// The BrowseName for the Electrical_EnergyConditionType component.
        /// </summary>
        public const string Electrical_EnergyConditionType = "Electrical_EnergyConditionType";

        /// <summary>
        /// The BrowseName for the ElectricalEnergyType component.
        /// </summary>
        public const string ElectricalEnergyType = "ElectricalEnergyType";

        /// <summary>
        /// The BrowseName for the EmergencyStop component.
        /// </summary>
        public const string EmergencyStop = "EmergencyStop";

        /// <summary>
        /// The BrowseName for the EmergencyStopType component.
        /// </summary>
        public const string EmergencyStopType = "EmergencyStopType";

        /// <summary>
        /// The BrowseName for the EmergencyStopTypeEnum component.
        /// </summary>
        public const string EmergencyStopTypeEnum = "EmergencyStopTypeEnum";

        /// <summary>
        /// The BrowseName for the EnergyValueDataType component.
        /// </summary>
        public const string EnergyValueDataType = "EnergyValueDataType";

        /// <summary>
        /// The BrowseName for the ExecutionType component.
        /// </summary>
        public const string ExecutionType = "ExecutionType";

        /// <summary>
        /// The BrowseName for the ExecutionTypeEnum component.
        /// </summary>
        public const string ExecutionTypeEnum = "ExecutionTypeEnum";

        /// <summary>
        /// The BrowseName for the FeedrateValueDataType component.
        /// </summary>
        public const string FeedrateValueDataType = "FeedrateValueDataType";

        /// <summary>
        /// The BrowseName for the Fill_LevelConditionType component.
        /// </summary>
        public const string Fill_LevelConditionType = "Fill_LevelConditionType";

        /// <summary>
        /// The BrowseName for the FillLevelType component.
        /// </summary>
        public const string FillLevelType = "FillLevelType";

        /// <summary>
        /// The BrowseName for the FirmwareVersionDataType component.
        /// </summary>
        public const string FirmwareVersionDataType = "FirmwareVersionDataType";

        /// <summary>
        /// The BrowseName for the FlowConditionType component.
        /// </summary>
        public const string FlowConditionType = "FlowConditionType";

        /// <summary>
        /// The BrowseName for the FlowType component.
        /// </summary>
        public const string FlowType = "FlowType";

        /// <summary>
        /// The BrowseName for the ForceValueDataType component.
        /// </summary>
        public const string ForceValueDataType = "ForceValueDataType";

        /// <summary>
        /// The BrowseName for the FrequencyConditionType component.
        /// </summary>
        public const string FrequencyConditionType = "FrequencyConditionType";

        /// <summary>
        /// The BrowseName for the FrequencyType component.
        /// </summary>
        public const string FrequencyType = "FrequencyType";

        /// <summary>
        /// The BrowseName for the Grade component.
        /// </summary>
        public const string Grade = "Grade";

        /// <summary>
        /// The BrowseName for the GradeDataType component.
        /// </summary>
        public const string GradeDataType = "GradeDataType";

        /// <summary>
        /// The BrowseName for the HardwareConditionType component.
        /// </summary>
        public const string HardwareConditionType = "HardwareConditionType";

        /// <summary>
        /// The BrowseName for the IDDataType component.
        /// </summary>
        public const string IDDataType = "IDDataType";

        /// <summary>
        /// The BrowseName for the IndexRangeDataType component.
        /// </summary>
        public const string IndexRangeDataType = "IndexRangeDataType";

        /// <summary>
        /// The BrowseName for the Indices component.
        /// </summary>
        public const string Indices = "Indices";

        /// <summary>
        /// The BrowseName for the InstanceIdDataType component.
        /// </summary>
        public const string InstanceIdDataType = "InstanceIdDataType";

        /// <summary>
        /// The BrowseName for the InterfaceStateTypeEnum component.
        /// </summary>
        public const string InterfaceStateTypeEnum = "InterfaceStateTypeEnum";

        /// <summary>
        /// The BrowseName for the ItemId component.
        /// </summary>
        public const string ItemId = "ItemId";

        /// <summary>
        /// The BrowseName for the ItemIdDataType component.
        /// </summary>
        public const string ItemIdDataType = "ItemIdDataType";

        /// <summary>
        /// The BrowseName for the ItemLife component.
        /// </summary>
        public const string ItemLife = "ItemLife";

        /// <summary>
        /// The BrowseName for the ItemSourceDataType component.
        /// </summary>
        public const string ItemSourceDataType = "ItemSourceDataType";

        /// <summary>
        /// The BrowseName for the LastChangeTimestamp component.
        /// </summary>
        public const string LastChangeTimestamp = "LastChangeTimestamp";

        /// <summary>
        /// The BrowseName for the LifeType component.
        /// </summary>
        public const string LifeType = "LifeType";

        /// <summary>
        /// The BrowseName for the LimitState component.
        /// </summary>
        public const string LimitState = "LimitState";

        /// <summary>
        /// The BrowseName for the Line component.
        /// </summary>
        public const string Line = "Line";

        /// <summary>
        /// The BrowseName for the Linear_ForceConditionType component.
        /// </summary>
        public const string Linear_ForceConditionType = "Linear_ForceConditionType";

        /// <summary>
        /// The BrowseName for the LinearForceType component.
        /// </summary>
        public const string LinearForceType = "LinearForceType";

        /// <summary>
        /// The BrowseName for the LineType component.
        /// </summary>
        public const string LineType = "LineType";

        /// <summary>
        /// The BrowseName for the LoadConditionType component.
        /// </summary>
        public const string LoadConditionType = "LoadConditionType";

        /// <summary>
        /// The BrowseName for the LoadType component.
        /// </summary>
        public const string LoadType = "LoadType";

        /// <summary>
        /// The BrowseName for the LocationSizeDataType component.
        /// </summary>
        public const string LocationSizeDataType = "LocationSizeDataType";

        /// <summary>
        /// The BrowseName for the LocationsTypeEnum component.
        /// </summary>
        public const string LocationsTypeEnum = "LocationsTypeEnum";

        /// <summary>
        /// The BrowseName for the LocationType component.
        /// </summary>
        public const string LocationType = "LocationType";

        /// <summary>
        /// The BrowseName for the LocationValueDataType component.
        /// </summary>
        public const string LocationValueDataType = "LocationValueDataType";

        /// <summary>
        /// The BrowseName for the Locus component.
        /// </summary>
        public const string Locus = "Locus";

        /// <summary>
        /// The BrowseName for the LocusDataType component.
        /// </summary>
        public const string LocusDataType = "LocusDataType";

        /// <summary>
        /// The BrowseName for the Logic_ProgramConditionType component.
        /// </summary>
        public const string Logic_ProgramConditionType = "Logic_ProgramConditionType";

        /// <summary>
        /// The BrowseName for the Manufacturer component.
        /// </summary>
        public const string Manufacturer = "Manufacturer";

        /// <summary>
        /// The BrowseName for the Manufacturers component.
        /// </summary>
        public const string Manufacturers = "Manufacturers";

        /// <summary>
        /// The BrowseName for the ManufacturersDataType component.
        /// </summary>
        public const string ManufacturersDataType = "ManufacturersDataType";

        /// <summary>
        /// The BrowseName for the MassConditionType component.
        /// </summary>
        public const string MassConditionType = "MassConditionType";

        /// <summary>
        /// The BrowseName for the MassType component.
        /// </summary>
        public const string MassType = "MassType";

        /// <summary>
        /// The BrowseName for the MassValueDataType component.
        /// </summary>
        public const string MassValueDataType = "MassValueDataType";

        /// <summary>
        /// The BrowseName for the Maximum component.
        /// </summary>
        public const string Maximum = "Maximum";

        /// <summary>
        /// The BrowseName for the MaximumCount component.
        /// </summary>
        public const string MaximumCount = "MaximumCount";

        /// <summary>
        /// The BrowseName for the MaximumCountDataType component.
        /// </summary>
        public const string MaximumCountDataType = "MaximumCountDataType";

        /// <summary>
        /// The BrowseName for the MaximumDataType component.
        /// </summary>
        public const string MaximumDataType = "MaximumDataType";

        /// <summary>
        /// The BrowseName for the Measurements component.
        /// </summary>
        public const string Measurements = "Measurements";

        /// <summary>
        /// The BrowseName for the MeasurementType component.
        /// </summary>
        public const string MeasurementType = "MeasurementType";

        /// <summary>
        /// The BrowseName for the MeasurementValueDataType component.
        /// </summary>
        public const string MeasurementValueDataType = "MeasurementValueDataType";

        /// <summary>
        /// The BrowseName for the Memex_3Axis component.
        /// </summary>
        public const string Memex_3Axis = "Memex_3Axis";

        /// <summary>
        /// The BrowseName for the Message component.
        /// </summary>
        public const string Message = "Message";

        /// <summary>
        /// The BrowseName for the MessageType component.
        /// </summary>
        public const string MessageType = "MessageType";

        /// <summary>
        /// The BrowseName for the Minimum component.
        /// </summary>
        public const string Minimum = "Minimum";

        /// <summary>
        /// The BrowseName for the MinimumDataType component.
        /// </summary>
        public const string MinimumDataType = "MinimumDataType";

        /// <summary>
        /// The BrowseName for the Model component.
        /// </summary>
        public const string Model = "Model";

        /// <summary>
        /// The BrowseName for the ModelDataType component.
        /// </summary>
        public const string ModelDataType = "ModelDataType";

        /// <summary>
        /// The BrowseName for the Motion_ProgramConditionType component.
        /// </summary>
        public const string Motion_ProgramConditionType = "Motion_ProgramConditionType";

        /// <summary>
        /// The BrowseName for the MTConditionType component.
        /// </summary>
        public const string MTConditionType = "MTConditionType";

        /// <summary>
        /// The BrowseName for the MTConnectVersion component.
        /// </summary>
        public const string MTConnectVersion = "MTConnectVersion";

        /// <summary>
        /// The BrowseName for the MTCurrentState component.
        /// </summary>
        public const string MTCurrentState = "MTCurrentState";

        /// <summary>
        /// The BrowseName for the MTEventDataItemType component.
        /// </summary>
        public const string MTEventDataItemType = "MTEventDataItemType";

        /// <summary>
        /// The BrowseName for the MTSampleDataItemType component.
        /// </summary>
        public const string MTSampleDataItemType = "MTSampleDataItemType";

        /// <summary>
        /// The BrowseName for the NameDataType component.
        /// </summary>
        public const string NameDataType = "NameDataType";

        /// <summary>
        /// The BrowseName for the NativeCode component.
        /// </summary>
        public const string NativeCode = "NativeCode";

        /// <summary>
        /// The BrowseName for the NativeCodeDataType component.
        /// </summary>
        public const string NativeCodeDataType = "NativeCodeDataType";

        /// <summary>
        /// The BrowseName for the NativeNotifcationCodeDataType component.
        /// </summary>
        public const string NativeNotifcationCodeDataType = "NativeNotifcationCodeDataType";

        /// <summary>
        /// The BrowseName for the NativeScale component.
        /// </summary>
        public const string NativeScale = "NativeScale";

        /// <summary>
        /// The BrowseName for the NativeScaleDataType component.
        /// </summary>
        public const string NativeScaleDataType = "NativeScaleDataType";

        /// <summary>
        /// The BrowseName for the NativeSeverity component.
        /// </summary>
        public const string NativeSeverity = "NativeSeverity";

        /// <summary>
        /// The BrowseName for the NativeSeverityDataType component.
        /// </summary>
        public const string NativeSeverityDataType = "NativeSeverityDataType";

        /// <summary>
        /// The BrowseName for the NativeUnits component.
        /// </summary>
        public const string NativeUnits = "NativeUnits";

        /// <summary>
        /// The BrowseName for the NegativeOverlap component.
        /// </summary>
        public const string NegativeOverlap = "NegativeOverlap";

        /// <summary>
        /// The BrowseName for the NextCalibrationDate component.
        /// </summary>
        public const string NextCalibrationDate = "NextCalibrationDate";

        /// <summary>
        /// The BrowseName for the NextCalibrationDateDataType component.
        /// </summary>
        public const string NextCalibrationDateDataType = "NextCalibrationDateDataType";

        /// <summary>
        /// The BrowseName for the Nominal component.
        /// </summary>
        public const string Nominal = "Nominal";

        /// <summary>
        /// The BrowseName for the NominalDataType component.
        /// </summary>
        public const string NominalDataType = "NominalDataType";

        /// <summary>
        /// The BrowseName for the NotificationCodeTypeEnum component.
        /// </summary>
        public const string NotificationCodeTypeEnum = "NotificationCodeTypeEnum";

        /// <summary>
        /// The BrowseName for the NotificationDescriptionDataType component.
        /// </summary>
        public const string NotificationDescriptionDataType = "NotificationDescriptionDataType";

        /// <summary>
        /// The BrowseName for the OccurrenceTimeDataType component.
        /// </summary>
        public const string OccurrenceTimeDataType = "OccurrenceTimeDataType";

        /// <summary>
        /// The BrowseName for the OPCUAMappingDate component.
        /// </summary>
        public const string OPCUAMappingDate = "OPCUAMappingDate";

        /// <summary>
        /// The BrowseName for the OpcUaMTConnect_BinarySchema component.
        /// </summary>
        public const string OpcUaMTConnect_BinarySchema = "Opc.Ua.MTConnect";

        /// <summary>
        /// The BrowseName for the OpcUaMTConnect_XmlSchema component.
        /// </summary>
        public const string OpcUaMTConnect_XmlSchema = "Opc.Ua.MTConnect";

        /// <summary>
        /// The BrowseName for the OPCUAVersion component.
        /// </summary>
        public const string OPCUAVersion = "OPCUAVersion";

        /// <summary>
        /// The BrowseName for the OverlapDataType component.
        /// </summary>
        public const string OverlapDataType = "OverlapDataType";

        /// <summary>
        /// The BrowseName for the PalletIdType component.
        /// </summary>
        public const string PalletIdType = "PalletIdType";

        /// <summary>
        /// The BrowseName for the PartCountType component.
        /// </summary>
        public const string PartCountType = "PartCountType";

        /// <summary>
        /// The BrowseName for the PartIdType component.
        /// </summary>
        public const string PartIdType = "PartIdType";

        /// <summary>
        /// The BrowseName for the Path_FeedrateConditionType component.
        /// </summary>
        public const string Path_FeedrateConditionType = "Path_FeedrateConditionType";

        /// <summary>
        /// The BrowseName for the Path_PositionConditionType component.
        /// </summary>
        public const string Path_PositionConditionType = "Path_PositionConditionType";

        /// <summary>
        /// The BrowseName for the PathFeedrateType component.
        /// </summary>
        public const string PathFeedrateType = "PathFeedrateType";

        /// <summary>
        /// The BrowseName for the PathModeType component.
        /// </summary>
        public const string PathModeType = "PathModeType";

        /// <summary>
        /// The BrowseName for the PathModeTypeEnum component.
        /// </summary>
        public const string PathModeTypeEnum = "PathModeTypeEnum";

        /// <summary>
        /// The BrowseName for the PathPositionType component.
        /// </summary>
        public const string PathPositionType = "PathPositionType";

        /// <summary>
        /// The BrowseName for the PHConditionType component.
        /// </summary>
        public const string PHConditionType = "PHConditionType";

        /// <summary>
        /// The BrowseName for the PHType component.
        /// </summary>
        public const string PHType = "PHType";

        /// <summary>
        /// The BrowseName for the PositionConditionType component.
        /// </summary>
        public const string PositionConditionType = "PositionConditionType";

        /// <summary>
        /// The BrowseName for the PositionType component.
        /// </summary>
        public const string PositionType = "PositionType";

        /// <summary>
        /// The BrowseName for the PositiveOverlap component.
        /// </summary>
        public const string PositiveOverlap = "PositiveOverlap";

        /// <summary>
        /// The BrowseName for the Power_FactorConditionType component.
        /// </summary>
        public const string Power_FactorConditionType = "Power_FactorConditionType";

        /// <summary>
        /// The BrowseName for the PowerFactorType component.
        /// </summary>
        public const string PowerFactorType = "PowerFactorType";

        /// <summary>
        /// The BrowseName for the PowerStateType component.
        /// </summary>
        public const string PowerStateType = "PowerStateType";

        /// <summary>
        /// The BrowseName for the PowerStateTypeEnum component.
        /// </summary>
        public const string PowerStateTypeEnum = "PowerStateTypeEnum";

        /// <summary>
        /// The BrowseName for the PressureConditionType component.
        /// </summary>
        public const string PressureConditionType = "PressureConditionType";

        /// <summary>
        /// The BrowseName for the PressureType component.
        /// </summary>
        public const string PressureType = "PressureType";

        /// <summary>
        /// The BrowseName for the ProgramFeedRateType component.
        /// </summary>
        public const string ProgramFeedRateType = "ProgramFeedRateType";

        /// <summary>
        /// The BrowseName for the ProgramSpindleSpeedType component.
        /// </summary>
        public const string ProgramSpindleSpeedType = "ProgramSpindleSpeedType";

        /// <summary>
        /// The BrowseName for the ProgramToolNumberDataType component.
        /// </summary>
        public const string ProgramToolNumberDataType = "ProgramToolNumberDataType";

        /// <summary>
        /// The BrowseName for the ProgramType component.
        /// </summary>
        public const string ProgramType = "ProgramType";

        /// <summary>
        /// The BrowseName for the QualifierTypeEnum component.
        /// </summary>
        public const string QualifierTypeEnum = "QualifierTypeEnum";

        /// <summary>
        /// The BrowseName for the RateDataType component.
        /// </summary>
        public const string RateDataType = "RateDataType";

        /// <summary>
        /// The BrowseName for the ReconditionCountType component.
        /// </summary>
        public const string ReconditionCountType = "ReconditionCountType";

        /// <summary>
        /// The BrowseName for the ReconditionCountValueDataType component.
        /// </summary>
        public const string ReconditionCountValueDataType = "ReconditionCountValueDataType";

        /// <summary>
        /// The BrowseName for the ResistanceConditionType component.
        /// </summary>
        public const string ResistanceConditionType = "ResistanceConditionType";

        /// <summary>
        /// The BrowseName for the ResistanceType component.
        /// </summary>
        public const string ResistanceType = "ResistanceType";

        /// <summary>
        /// The BrowseName for the Rotary_VelocityConditionType component.
        /// </summary>
        public const string Rotary_VelocityConditionType = "Rotary_VelocityConditionType";

        /// <summary>
        /// The BrowseName for the RotaryModeType component.
        /// </summary>
        public const string RotaryModeType = "RotaryModeType";

        /// <summary>
        /// The BrowseName for the RotaryModeTypeEnum component.
        /// </summary>
        public const string RotaryModeTypeEnum = "RotaryModeTypeEnum";

        /// <summary>
        /// The BrowseName for the RotationalVelocityType component.
        /// </summary>
        public const string RotationalVelocityType = "RotationalVelocityType";

        /// <summary>
        /// The BrowseName for the SampleInterval component.
        /// </summary>
        public const string SampleInterval = "SampleInterval";

        /// <summary>
        /// The BrowseName for the SampleRateDataType component.
        /// </summary>
        public const string SampleRateDataType = "SampleRateDataType";

        /// <summary>
        /// The BrowseName for the SenderDataType component.
        /// </summary>
        public const string SenderDataType = "SenderDataType";

        /// <summary>
        /// The BrowseName for the SequenceDataType component.
        /// </summary>
        public const string SequenceDataType = "SequenceDataType";

        /// <summary>
        /// The BrowseName for the SerialNumber component.
        /// </summary>
        public const string SerialNumber = "SerialNumber";

        /// <summary>
        /// The BrowseName for the SerialNumberDataType component.
        /// </summary>
        public const string SerialNumberDataType = "SerialNumberDataType";

        /// <summary>
        /// The BrowseName for the SeverityTypeEnum component.
        /// </summary>
        public const string SeverityTypeEnum = "SeverityTypeEnum";

        /// <summary>
        /// The BrowseName for the SignificantDigits component.
        /// </summary>
        public const string SignificantDigits = "SignificantDigits";

        /// <summary>
        /// The BrowseName for the SignificantDigitsValueDataType component.
        /// </summary>
        public const string SignificantDigitsValueDataType = "SignificantDigitsValueDataType";

        /// <summary>
        /// The BrowseName for the Sound_LevelConditionType component.
        /// </summary>
        public const string Sound_LevelConditionType = "Sound_LevelConditionType";

        /// <summary>
        /// The BrowseName for the SoundPressureType component.
        /// </summary>
        public const string SoundPressureType = "SoundPressureType";

        /// <summary>
        /// The BrowseName for the SpeedDataType component.
        /// </summary>
        public const string SpeedDataType = "SpeedDataType";

        /// <summary>
        /// The BrowseName for the Station component.
        /// </summary>
        public const string Station = "Station";

        /// <summary>
        /// The BrowseName for the StationDataType component.
        /// </summary>
        public const string StationDataType = "StationDataType";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the StrainConditionType component.
        /// </summary>
        public const string StrainConditionType = "StrainConditionType";

        /// <summary>
        /// The BrowseName for the StrainType component.
        /// </summary>
        public const string StrainType = "StrainType";

        /// <summary>
        /// The BrowseName for the SystemConditionType component.
        /// </summary>
        public const string SystemConditionType = "SystemConditionType";

        /// <summary>
        /// The BrowseName for the TemperatureConditionType component.
        /// </summary>
        public const string TemperatureConditionType = "TemperatureConditionType";

        /// <summary>
        /// The BrowseName for the TemperatureType component.
        /// </summary>
        public const string TemperatureType = "TemperatureType";

        /// <summary>
        /// The BrowseName for the TestIndicatorDataType component.
        /// </summary>
        public const string TestIndicatorDataType = "TestIndicatorDataType";

        /// <summary>
        /// The BrowseName for the TiltConditionType component.
        /// </summary>
        public const string TiltConditionType = "TiltConditionType";

        /// <summary>
        /// The BrowseName for the TiltType component.
        /// </summary>
        public const string TiltType = "TiltType";

        /// <summary>
        /// The BrowseName for the ToolAssetIdType component.
        /// </summary>
        public const string ToolAssetIdType = "ToolAssetIdType";

        /// <summary>
        /// The BrowseName for the ToolEventValueDataType component.
        /// </summary>
        public const string ToolEventValueDataType = "ToolEventValueDataType";

        /// <summary>
        /// The BrowseName for the ToolGroupDataType component.
        /// </summary>
        public const string ToolGroupDataType = "ToolGroupDataType";

        /// <summary>
        /// The BrowseName for the ToolIdDataType component.
        /// </summary>
        public const string ToolIdDataType = "ToolIdDataType";

        /// <summary>
        /// The BrowseName for the ToolLifeDirectionTypeEnum component.
        /// </summary>
        public const string ToolLifeDirectionTypeEnum = "ToolLifeDirectionTypeEnum";

        /// <summary>
        /// The BrowseName for the ToolLifeTypeEnum component.
        /// </summary>
        public const string ToolLifeTypeEnum = "ToolLifeTypeEnum";

        /// <summary>
        /// The BrowseName for the ToolLifeValueDataType component.
        /// </summary>
        public const string ToolLifeValueDataType = "ToolLifeValueDataType";

        /// <summary>
        /// The BrowseName for the ToolNumberType component.
        /// </summary>
        public const string ToolNumberType = "ToolNumberType";

        /// <summary>
        /// The BrowseName for the TorqueConditionType component.
        /// </summary>
        public const string TorqueConditionType = "TorqueConditionType";

        /// <summary>
        /// The BrowseName for the TorqueType component.
        /// </summary>
        public const string TorqueType = "TorqueType";

        /// <summary>
        /// The BrowseName for the Type component.
        /// </summary>
        public const string Type = "Type";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

        /// <summary>
        /// The BrowseName for the UnitsExtDataType component.
        /// </summary>
        public const string UnitsExtDataType = "UnitsExtDataType";

        /// <summary>
        /// The BrowseName for the VelocityConditionType component.
        /// </summary>
        public const string VelocityConditionType = "VelocityConditionType";

        /// <summary>
        /// The BrowseName for the VelocityType component.
        /// </summary>
        public const string VelocityType = "VelocityType";

        /// <summary>
        /// The BrowseName for the VersionDataType component.
        /// </summary>
        public const string VersionDataType = "VersionDataType";

        /// <summary>
        /// The BrowseName for the VibrationValueDataType component.
        /// </summary>
        public const string VibrationValueDataType = "VibrationValueDataType";

        /// <summary>
        /// The BrowseName for the ViscosityConditionType component.
        /// </summary>
        public const string ViscosityConditionType = "ViscosityConditionType";

        /// <summary>
        /// The BrowseName for the ViscosityType component.
        /// </summary>
        public const string ViscosityType = "ViscosityType";

        /// <summary>
        /// The BrowseName for the Volt_AmperageConditionType component.
        /// </summary>
        public const string Volt_AmperageConditionType = "Volt_AmperageConditionType";

        /// <summary>
        /// The BrowseName for the VoltageConditionType component.
        /// </summary>
        public const string VoltageConditionType = "VoltageConditionType";

        /// <summary>
        /// The BrowseName for the VoltageType component.
        /// </summary>
        public const string VoltageType = "VoltageType";

        /// <summary>
        /// The BrowseName for the VoltAmperageReactiveConditionType component.
        /// </summary>
        public const string VoltAmperageReactiveConditionType = "VoltAmperageReactiveConditionType";

        /// <summary>
        /// The BrowseName for the VoltAmpereReactiveType component.
        /// </summary>
        public const string VoltAmpereReactiveType = "VoltAmpereReactiveType";

        /// <summary>
        /// The BrowseName for the VoltAmpereType component.
        /// </summary>
        public const string VoltAmpereType = "VoltAmpereType";

        /// <summary>
        /// The BrowseName for the WarningLevel component.
        /// </summary>
        public const string WarningLevel = "WarningLevel";

        /// <summary>
        /// The BrowseName for the WattageConditionType component.
        /// </summary>
        public const string WattageConditionType = "WattageConditionType";

        /// <summary>
        /// The BrowseName for the WattageType component.
        /// </summary>
        public const string WattageType = "WattageType";

        /// <summary>
        /// The BrowseName for the WorkHoldingIdType component.
        /// </summary>
        public const string WorkHoldingIdType = "WorkHoldingIdType";

        /// <summary>
        /// The BrowseName for the X component.
        /// </summary>
        public const string X = "X";

        /// <summary>
        /// The BrowseName for the XLoad component.
        /// </summary>
        public const string XLoad = "XLoad";

        /// <summary>
        /// The BrowseName for the Y component.
        /// </summary>
        public const string Y = "Y";

        /// <summary>
        /// The BrowseName for the Z component.
        /// </summary>
        public const string Z = "Z";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaMTConnect namespace (.NET code namespace is 'Opc.Ua.MTConnect').
        /// </summary>
        public const string OpcUaMTConnect = "http://opcfoundation.org/UA/MTConnect/";

        /// <summary>
        /// The URI for the OpcUaMTConnectXsd namespace (.NET code namespace is 'Opc.Ua.MTConnect').
        /// </summary>
        public const string OpcUaMTConnectXsd = "http://opcfoundation.org/UA/MTConnect/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";
    }
    #endregion
}
