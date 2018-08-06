# -*- coding: utf-8 -*-
"""
Created on Wed Jun 13 08:41:53 2018

@author: Ryan Fisher
@company: National Institute of Standards and Technology

This file probes an MTConnect file and produces an OPC-UA/MTConnect Companion format that can be
uploaded to a server. An XML output is generated, but a model compiler is executed on the
XML file to create .uanodes. These nodes are automatically sent to the structure library for
the server.

Information on xml.etree.ElementTree module can be found at: https://docs.python.org/2/library/xml.etree.elementtree.html

"""

import os
import shutil
import socket
import xml.etree.ElementTree as ET
from xml.etree.ElementTree import Element
from xml.etree.ElementTree import ElementTree
import urllib.request as urllib
import xmltodict
from xml.dom import minidom     # For printing 'pretty' xml format
import time
import subprocess

### Functions
def move_files():
    # Copies the files, created from the converter, to the server folder.
    # Overwrites files already there to update nodes
    # Set the file source and destination:
    # The source should be: root_src_dir = r"...\UA-ModelCompiler-master\Published\MTConnect"
    # The destination should be: root_dst_dir = r"...\UA-.NETStandard-master\SampleApplications\Workshop\Boiler\Server"
    root_src_dir = os.getcwd()  # Source
    root_dst_dir = os.getcwd()  # Destination
    try:
        for src_dir, dirs, files in os.walk(root_src_dir):
            dst_dir = src_dir.replace(root_src_dir, root_dst_dir, 1)
            if not os.path.exists(dst_dir):
                os.makedirs(dst_dir)
            for file_ in files:
                src_file = os.path.join(src_dir, file_)
                dst_file = os.path.join(dst_dir, file_)
                if os.path.exists(dst_file):
                    os.remove(dst_file)
                shutil.move(src_file, dst_dir)
        print("-------------- Copy complete --------------")
    except:
        print("An error occured while copying")

def execute_batch():
    # The batch file to converts the XML to .uanodes
    # Set the file path to ".../UA-ModelCompiler-master/"
    filepath = root_dst_dir
    p = subprocess.Popen("BuildStandardTypes.bat", cwd=filepath)
    stdout, stderr = p.communicate()
    print("Batch file executed...")

def website_to_XML(website):
    '''
        <summary>
        Gets the XML data from a website.
        Input: website (or url)
        Output: data 
        <summary>
    '''
    file = urllib.urlopen(website)
    print(file)
    print('\n---------------------------------------------------\n')

    data = file.read()
    file.close()
    # (data)
    print("Data imported")
    print('\n---------------------------------------------------\n')


    return data

def save_file_xml(root, output_file):
    #########################################
    '''
    Save file to an XML
    Input: root, output_file (location)
    Output: output_file (location)
    '''
    xmlstr = minidom.parseString(ET.tostring(root)).toprettyxml(indent="  ")
    with open(output_file, "wb") as f:
        f.write(xmlstr.encode('utf-8'))

    print("\nOutput file created!\n")
    #########################################
    return output_file

def get_root(data):
    ''' 
    <summary>
    This function finds the root of a data set.
    Input: data
    Output: root
    <summary> 
    '''

    root = ET.fromstring(data)
    return root

def get_namespace(root):
    '''
        <summary>
        This function gets the namespace for the MTConnect file.
        Input: root
        Output: namespace
        <summary>
    '''
    namespace = root.tag
    namespace = namespace.replace('}MTConnectDevices','}')
    return namespace

def search_with_findall(parent_element, child_name, namespace):
    '''
    Returns a list of the children of an element
    Input: parent_element, child_name, namespace
    Output: child_name
    '''
    child_name = parent_element.findall(namespace + child_name)
    return child_name

def search_with_iter(parent_element, child_name, namespace):
    '''
    Returns a list of all elements with a certain name
    Input: parent_element, child_name, namespace
    Output: child_name
    '''
    child_list = parent_element.iter(namespace + child_name)
    return child_list

def set_standard_namespace_attributes(root):
    '''
    Sets the namespace for the XML Companion document
    Input: root
    Output: root
    '''
    root.set('xmlns:uax',"http://opcfoundation.org/UA/2008/02/Types.xsd")
    root.set('xmlns:xsi',"http://www.w3.org/2001/XMLSchema-instance")
    root.set('xmlns:ua',"http://opcfoundation.org/UA/")
    root.set('xmlns:opc',"http://opcfoundation.org/UA/ModelDesign.xsd")
    root.set('xmlns:xsd',"http://www.w3.org/2001/XMLSchema")
    root.set('xmlns',"http://opcfoundation.org/UA/MTConnect/")
    root.set('TargetNamespace',"http://opcfoundation.org/UA/MTConnect/")
    root.set('TargetXmlNamespace',"http://opcfoundation.org/UA/MTConnect/Types.xsd")
    root.set('TargetVersion',"1.00")
    root.set('TargetPublicationDate',"2013-12-31T00:00:00Z")

    return root

def create_object(root_in, root_out, parent, SymbolicName, TypeDef):
    ''' 
    Creates an object in the XML Companion format 
    Input: root_in, root_out, parent, SymbolicName, TypeDef
    Output: None
    '''
    Object = Element(namespace2 + "Object")
    Object.set("SymbolicName",SymbolicName)
    Object.set("TypeDefinition", TypeDef)
    References = Element(namespace2 + "References")

    # Reference One
    Reference = Element(namespace2 + "Reference")
    Reference.set("IsInverse","true")
    ReferenceType = Element(namespace2 + "ReferenceType")
    ReferenceType.text = namespace3 + "Organizes"
    TargetId = Element(namespace2 + "TargetId")
    TargetId.text = parent
    Reference.append(ReferenceType)
    Reference.append(TargetId)
    References.append(Reference)

    # Reference Two
    Reference = Element(namespace2 + "Reference")
    Reference.set("IsInverse", "true")
    ReferenceType = Element(namespace2 + "ReferenceType")
    ReferenceType.text = namespace3 + "HasNotifier"
    TargetId = Element(namespace2 + "TargetId")
    TargetId.text = namespace3 + "Server"
    Reference.append(ReferenceType)
    Reference.append(TargetId)
    References.append(Reference)

    Object.append(References)
    root_out.append(Object)

def create_variable(root_in, root_out, parent, SymbolicName, TypeDef, DataType):
    ''' 
    Creates a variable in the XML Companion format 
    Input: root_in, root_out, parent, SymbolicName, TypeDef, DataType
    Output: None
    '''
    Variable = Element(namespace2 + "Variable")
    Variable.set("SymbolicName", SymbolicName)
    Variable.set("TypeDefinition", TypeDef)
    Variable.set("DataType", namespace3 + DataType)
    References = Element(namespace2 + "References")

    # Reference One
    Reference = Element(namespace2 + "Reference")
    Reference.set("IsInverse", "true")
    ReferenceType = Element(namespace2 + "ReferenceType")
    ReferenceType.text = namespace3 + "Organizes"
    TargetId = Element(namespace2 + "TargetId")
    TargetId.text = parent
    Reference.append(ReferenceType)
    Reference.append(TargetId)
    References.append(Reference)

    # Reference Two
    Reference = Element(namespace2 + "Reference")
    Reference.set("IsInverse", "true")
    ReferenceType = Element(namespace2 + "ReferenceType")
    ReferenceType.text = namespace3 + "HasNotifier"
    TargetId = Element(namespace2 + "TargetId")
    TargetId.text = namespace3 + "Server"
    Reference.append(ReferenceType)
    Reference.append(TargetId)
    References.append(Reference)

    Variable.append(References)
    root_out.append(Variable)

### The following function set specific attributes or elements of the document:
def set_SymbolicName_and_BaseType(element, symbolicName, baseType):
    element.set("SymbolicName", symbolicName)
    element.set("BaseType", baseType)
    return element

def set_SymbolicName_DataType_and_ModellingRule(element, symbolicName, dataType, ModellingRule):
    element.set("SymbolicName", symbolicName)
    element.set("DataType", dataType)
    element.set("ModellingRule", ModellingRule)

def set_SymbolicName_TypeDefinition_and_ModellingRule(element, symbolicName, TypeDefinition, ModellingRule):
    element.set("SymbolicName", symbolicName)
    element.set("TypeDefinition", TypeDefinition)
    element.set("ModellingRule", ModellingRule)
    return element

def set_CoordinateSystem(root_in, root_out, Property):
    set_SymbolicName_DataType_and_ModellingRule(Property,"CoordinateSystem", "CoordinateSystemTypeEnum", "Optional")
    return Property

def set_NativeUnits(root_in, root_out, Property):
    set_SymbolicName_DataType_and_ModellingRule(Property,"NativeUnits", namespace3 + "EUInformation", "Optional")
    return Property

def set_NativeScale(root_in, root_out, Property):
    set_SymbolicName_DataType_and_ModellingRule(Property, "NativeScale", namespace3 + "Float", "Optional")
    return Property

def set_MTConnect_Version(root_in, root_out, Variable):
    # Finds and sets the version
    try:    
        # Finds data in input_file
        Header = search_with_findall(root_in, 'Header', namespace)
        Header = Header[0]
        MTConnect_version = Header.attrib['version']

        # Sets data in output
        #Variable.text = MTConnect_version
        set_SymbolicName_DataType_and_ModellingRule(Variable,"MTConnectVersion",namespace3 + "String","Optional")

    except:
        set_SymbolicName_DataType_and_ModellingRule(Variable,"MTConnectVersion",namespace3 + "String","Optional")

def set_OPCUAMappingData(root_in, root_out, Variable):
    # Finds and sets the creationTime to the OPCUAMappingDate
    try:    
        # Finds data in input_file
        Header = search_with_findall(root_in, 'Header', namespace)
        Header = Header[0]
        creationTime = Header.attrib['creationTime']

        # Sets data in output
        #Variable.text = creationTime
        set_SymbolicName_DataType_and_ModellingRule(Variable,"OPCUAMappingDate",namespace3 + "DateTime","Optional")
        

    except:
        set_SymbolicName_DataType_and_ModellingRule(Variable,"OPCUAMappingDate",namespace3 + "DateTime","Optional")

def set_OPCUAVersion(root_in, root_out, Variable):
    # Finds and sets the OPCUAVersion
    try:    
        # Finds data in input_file
        Namespace = root_out.iter(namespace2 + 'Namespace')
        if Namespace == []:
            print("No Namespace Found")
        for i in Namespace:
            if 'Version' in i.attrib:
                version = i.attrib['Version']

        # Sets data in output
        #Variable.text = version
        set_SymbolicName_DataType_and_ModellingRule(Variable,"OPCUAVersion",namespace3 + "String","Optional")
        

    except:
        set_SymbolicName_DataType_and_ModellingRule(Variable,"OPCUAVersion",namespace3 + "String","Optional")

def set_Availability(root_in, root_out, Variable):
    # Finds and sets the Availability
    try:    
        # Finds data in input_file
        DataItem = root_in.iter(namespace + 'DataItem')
        if DataItem == []:
            print("No DataItem Found")
        for i in DataItem:
            if i.attrib['category'] == 'EVENT' and i.attrib['type'] == 'AVAILABILITY':
                availability = i.text

        # Sets data in output
        #Variable.text = availability
        set_SymbolicName_DataType_and_ModellingRule(Variable,"Availability",namespace3 + "String","Mandatory")
        Variable.set("TypeDefinition", namespace3 + "DataItemType")

    except:
        set_SymbolicName_DataType_and_ModellingRule(Variable,"Availability",namespace3 + "String","Mandatory")
        Variable.set("TypeDefinition", namespace3 + "DataItemType")

def set_Manufacturer(root_in, root_out, Property):
    # Finds and sets the Manufacturer
    try:    
        # Finds data in input_file
        Description = root_in.iter(namespace + 'Description')
        if Description == []:
            print("No Description Found")
        for i in Description:
            if 'manufacturer' in i.attrib:
                manufacturer = i.attrib['manufacturer']

        # Sets data in output
        #Property.text = manufacturer
        set_SymbolicName_DataType_and_ModellingRule(Property,"Manufacturer",namespace3 + "String","Mandatory")

    except:
        set_SymbolicName_DataType_and_ModellingRule(Property,"Manufacturer",namespace3 + "String","Mandatory")

def set_SerialNumber(root_in, root_out, Property, device):
    # Finds and sets the SerialNumber
    try:    
        # Finds data in input_file
        Device = root_in.iter(namespace + 'Device')
        for i in Device:
            if i.attrib['name'] == device:
                Description = i.findall(namespace + 'Description')
                Description = Description[0]
                if 'serialNumber' in Description.attrib:
                    serialNumber = Description.attrib['serialNumber']
                else:
                    print("No serial number found for", device)
                    serialNumber = '0'

        
        # Sets data in output
        #Property.text = serialNumber
        set_SymbolicName_DataType_and_ModellingRule(Property,"SerialNumber",namespace3 + "String","Mandatory")

    except:
        print("Error occured in set_SerialNumber")
        set_SymbolicName_DataType_and_ModellingRule(Property,"SerialNumber",namespace3 + "String","Mandatory")

def set_Configuration(root_in, root_out, Property):

    pass

def set_SampleInterval(root_in, root_out, Property, device=''):
    # Finds and sets the SampleInterval
    try:    
        # Finds data in input_file
        
        Device = root_in.iter(namespace + 'Device')
        if Device == []:
            print("No Device Found")
        for i in Device:
            if 'sampleInterval' in i.attrib and i.attrib["name"] == device:
                sampleInterval = i.attrib['sampleInterval']

        # Sets data in output
        #Property.text = sampleInterval
        set_SymbolicName_DataType_and_ModellingRule(Property,"SampleInterval",namespace3 + "Duration","Optional")
    except:
        set_SymbolicName_DataType_and_ModellingRule(Property,"SampleInterval",namespace3 + "Duration","Optional")

def set_Model(root_in, root_out, Property, device):
    # Finds and sets the Manufacturer
    try:    
        # Finds data in input_file
        Description = root_in.iter(namespace + 'Description')
        if Description == []:
            print("No Description Found")
        for i in Description:
            if 'model' in i.attrib:
                model = i.attrib['model']

        # Sets data in output
        Property.text = model
        set_SymbolicName_DataType_and_ModellingRule(Property,"Model",namespace3 + "String","Optional")

    except:
        set_SymbolicName_DataType_and_ModellingRule(Property,"Model",namespace3 + "String","Optional")



######################################################################################################################

### SETUP ### ### SETUP ### ### SETUP ### ### SETUP ### ### SETUP ### ### SETUP ###

### Defines URLs
url = 'http://simulator.memexoee.com/'
# url = 'http://agent.mtconnect.org/'

# # Gets data from websites
# Uncomment this section to probe a website
data = website_to_XML(url)
root_in = get_root(data)


# # Gets data from external file
## Uncomment this section to probe an xml file
# input_file1 = 'two_devices.xml'
# input_file1 = 'sample_from_website.xml'
# input_file1 = 'nist_sample_from_website.xml'
# # Parsing the input data into a Tree Element:
# input_tree = ET.parse(input_file1) # gets the tree from a file
# root_in = input_tree.getroot() # gets the root from the tree

print("The input root is: ", root_in, '\n')

# Sets the namespace for the output file
namespace = get_namespace(root_in)
namespace2 = "opc:"
namespace3 = "ua:"
print("The namespace is: ", namespace, '\n')


# ---------------------------------------------------------------------------------------------------------------------
######## Converting the data ########----------------------------------------------------------------------------------
# ---------------------------------------------------------------------------------------------------------------------

### Creating new tree
root_out = Element(namespace2 + "ModelDesign")
root_out = set_standard_namespace_attributes(root_out)

### Defines Namespaces
Namespaces = Element(namespace2 + "Namespaces")
Namespace = Element(namespace2 + "Namespace")
Namespace.set("Name","OpcUaMTConnect")
Namespace.set("Prefix","Opc.Ua.MTConnect")
Namespace.set("XmlNamespace","http://opcfoundation.org/UA/MTConnect/Types.xsd")
Namespace.set("XmlPrefix","DI")
Namespace.text = ("http://opcfoundation.org/UA/MTConnect/")
Namespaces.append(Namespace)
Namespace = Element(namespace2 + "Namespace")
Namespace.set("Name", "OpcUa") 
Namespace.set("Version", "1.03") 
Namespace.set("PublicationDate","2013-12-02T00:00:00Z")
Namespace.set("Prefix","Opc.Ua")
Namespace.set("InternalPrefix","Opc.Ua.Server")
Namespace.set("XmlNamespac","http://opcfoundation.org/UA/2008/02/Types.xsd")
Namespace.set("XmlPrefix","OpcUa")
Namespace.text = ("http://opcfoundation.org/UA/")
Namespaces.append(Namespace)
root_out.append(Namespaces)


# Finds the number of devices
all_devices = []
try:    
    # Finds data in input_file
    Device = root_in.iter(namespace + 'Device')
    if Device == []:
        print("No Device Found")
    for i in Device:
        if 'name' in i.attrib:
            device_name = i.attrib['name']
            device_name = device_name.replace("-","_")
            all_devices.append(device_name)
except:
    print("No Devices Found!!!!")
print(all_devices)


# Sets parsed device count to zero
CuttingToolTypeCount = 0
EDMToolCount = 0
CNCToolCount= 0
axes_label = 1001
### Searches devices and creates XML models for each in companion specification format 
for device in all_devices: # Creates node sets for each device
    ### Checks for Cutting tools
    # Creates CuttingTool Object for each Device
    if ("Memex_3Axis" in device or "Mazak" in device ):
        ### Creates first Object   :    Lines 56-67 in MTConnectModel.xml
        # This is standard for every MTConnect file
        deviceType = "CuttingTool"
        Object = Element(namespace2 + "Object")
        Object.set("SymbolicName", device)
        Object.set("TypeDefinition", deviceType + "Type")
        Object.set("EventNotifier","SubscribeToEvents")
        References = Element(namespace2 + "References")
        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "Organizes"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "ObjectsFolder"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)

        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "HasNotifier"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "Server"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)
        Object.append(References)
        root_out.append(Object)

        '''
        ### Creates a variable for each axes
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]
        # Finds the axes branch
        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        old_axes_name = ''
        
        try:
            # Finds linear components
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear:
                Property = Element(namespace2 + "Property")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'] + i.attrib['id'][-1], 
                        namespace3 +  "DataItemType", 
                        "Double")
                else:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'], 
                        namespace3 +  "DataItemType",
                        "Double")
                old_axes_name = axes_name

        except:
            pass

        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Property = Element(namespace2 + "Property")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        new_name, 
                        namespace3 +  "DataItemType", 
                        "Double")

                else:
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        i.attrib['name'], 
                        namespace3 +  "DataItemType", 
                        "Double")
                old_rotary_name = rotary_name
        except:
            pass
        '''
        axes_label = axes_label + 1000
    # Defines a CuttingToolType
    if ("Memex_3Axis" in device or "Mazak" in device) and CuttingToolTypeCount < 1:
        ### Creates ObjectType
        deviceType = "CuttingTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "sType", namespace3 + 'FolderType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_MTConnect_Version(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAMappingData(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAVersion(root_in, root_out, Variable)
        Children.append(Variable)

        ObjectType.append(Children)
        root_out.append(ObjectType)
    

        ### Creates ObjectType   :    Lines 69-80 in MTConnectModel.xml

        deviceType = "CuttingTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "Type", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_Availability(root_in, root_out, Variable)
        Children.append(Variable)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_Manufacturer(root_in, root_out, Property)
        Children.append(Property)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SerialNumber(root_in, root_out, Property, device)
        Children.append(Property)

        # Finds and sets the Configuration
        # This is temporarily Empyty

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SampleInterval(root_in, root_out, Property, device)
        Children.append(Property)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object,"DataItems",namespace3 + "FolderType","Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object,"Components",namespace3 + "FolderType","Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object,"Conditions",namespace3 + "FolderType","Optional")
        Children.append(Object)

        # Makes the axes object
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Axes", deviceType + "AxesType", "Mandatory")
        Children.append(Object)
        
        # Makes Controller
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Controller", "ControllerType", "Mandatory")
        Children.append(Object)

        ObjectType.append(Children)
        root_out.append(ObjectType)


        ### Creates ObjectType   :    Lines 82-87 in MTConnectModel.xml
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]

        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"ComponentType",namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Makes Model element
        Property = Element(namespace2 + "Property")
        #set_Model(root_in, root_out, Property, device)
        set_SymbolicName_DataType_and_ModellingRule(Property,"Model",namespace3+"String","Optional")
        Children.append(Property)
        # Makes Station element
        Property = Element(namespace2 + "Property")
        set_SymbolicName_DataType_and_ModellingRule(Property,"Station",namespace3+"Duration","Optional")
        Children.append(Property)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 89-98 in MTConnectModel.xml
        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"AxesType", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Finds component first
        Devices = root_in.iter(namespace + 'Device')
        # Finds device elment

        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + 'Components')
        Components = Components[0]
        for j in Components:
            component = j.attrib['name']
            component_list.append(component)

        # Finds the axes branch
        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        old_axes_name = ''

        try:
            # Finds linear components
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear: # Searches branches called Linear
                Variable = Element(namespace2 + "Variable")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'] + i.attrib['id'][-1],
                                                                 namespace3+"Double", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "Double",
                                                                 "Mandatory")
                old_axes_name = axes_name
                Children.append(Variable)

            if Linear == "NO Position FOUND":
                print("NO Position FOUND")
            elif Linear == []:
                print("NO Position FOUND. EMPTY LIST.")
        except:
            pass

        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Variable = Element(namespace2 + "Variable")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    set_SymbolicName_DataType_and_ModellingRule(Variable, new_name, namespace3 + "Double", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "Double",
                                                                 "Mandatory")
                old_rotary_name = rotary_name

                Children.append(Variable)

            if Rotary == "NO Position FOUND":
                print("NO RotaryPosition FOUND")
            elif Rotary == []:
                print("NO RotaryPosition FOUND. EMPTY LIST.")

        except:
            Position = "NO Rotary Position FOUND"

        # Adds a loading condition for the x-axes, under the Axes object
        Object = Element(namespace2 + "Object")
        Object.set("SymbolicName","XLoad")
        Object.set("TypeDefinition","LoadConditionType")
        Children.append(Object)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        #### Creates ObjectType for Controller
        ObjectType = Element(namespace2 + "ObjectType")
        Children = Element(namespace2 + "Children")
        set_SymbolicName_TypeDefinition_and_ModellingRule(ObjectType, "ControllerType", "ua:BaseObjectType","Mandatory")

        Variable = Element(namespace2+"Variable")
        Variable.attrib['SymbolicName'] = "EmergencyStop"
        Variable.attrib['TypeDefinition'] = "EmergencyStopType"        
        Children.append(Variable)

        Variable = Element(namespace2+"Variable")
        Variable.attrib['SymbolicName'] = "Message"
        Variable.attrib['TypeDefinition'] = "MessageType"
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        Variable.attrib['SymbolicName'] = "Line"
        Variable.attrib['TypeDefinition'] = "LineType"
        Children.append(Variable)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        CuttingToolTypeCount +=1

    ### Checks for EDM Tools
    # Creates EDMTool Object for each Device
    if ("GFAgie" in device):
        ### Creates first Object   :    Lines 56-67 in MTConnectModel.xml
        # This is standard for every MTConnect file
        deviceType = "EDMTool"
        Object = Element(namespace2 + "Object")
        Object.set("SymbolicName", device)
        Object.set("TypeDefinition", deviceType + "Type")
        References = Element(namespace2 + "References")
        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "Organizes"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "ObjectsFolder"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)

        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "HasNotifier"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "Server"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)
        Object.append(References)
        root_out.append(Object)

        '''
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]
        # Finds the axes branch
        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        old_axes_name = ''
        
        try:
            # Finds linear components
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear:
                Property = Element(namespace2 + "Property")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'] + i.attrib['id'][-1], 
                        namespace3 +  "DataItemType", 
                        "Double")
                else:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'], 
                        namespace3 +  "DataItemType",
                        "Double")
                old_axes_name = axes_name

        except:
            pass
        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Property = Element(namespace2 + "Property")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        new_name, 
                        namespace3 +  "DataItemType", 
                        "Double")

                else:
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        i.attrib['name'], 
                        namespace3 +  "DataItemType", 
                        "Double")
                old_rotary_name = rotary_name
        except:
            pass
        '''
        axes_label = axes_label + 1000
    # Defines an EDMToolType
    if ("GFAgie" in device) and EDMToolCount < 1:
        deviceType = "EDMTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "sType", namespace3 + 'FolderType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_MTConnect_Version(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAMappingData(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAVersion(root_in, root_out, Variable)
        Children.append(Variable)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 69-80 in MTConnectModel.xml

        deviceType = "EDMTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "Type", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_Availability(root_in, root_out, Variable)
        Children.append(Variable)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_Manufacturer(root_in, root_out, Property)
        Children.append(Property)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SerialNumber(root_in, root_out, Property, device)
        Children.append(Property)

        # Finds and sets the Configuration
        # This is temporarily Empyty

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SampleInterval(root_in, root_out, Property, device)
        Children.append(Property)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "DataItems", namespace3 + "FolderType", "Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Components", namespace3 + "FolderType", "Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Conditions", namespace3 + "FolderType", "Optional")
        Children.append(Object)

        # Makes the axes object
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Axes", deviceType + "AxesType", "Mandatory")
        Children.append(Object)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 82-87 in MTConnectModel.xml
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]

        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"ComponentType", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Makes Model element
        Property = Element(namespace2 + "Property")
        # set_Model(root_in, root_out, Property, device)
        set_SymbolicName_DataType_and_ModellingRule(Property, "Model", namespace3 + "String", "Optional")
        Children.append(Property)
        # Makes Station element
        Property = Element(namespace2 + "Property")
        set_SymbolicName_DataType_and_ModellingRule(Property, "Station", namespace3 + "Duration", "Optional")
        Children.append(Property)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 89-98 in MTConnectModel.xml
        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"AxesType", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Finds component first
        Devices = root_in.iter(namespace + 'Device')
        # Finds device elment

        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + 'Components')
        Components = Components[0]
        for j in Components:
            component = j.attrib['name']
            component_list.append(component)

        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        
        old_axes_name = ''
        try:
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear:
                Variable = Element(namespace2 + "Variable")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'] + i.attrib['id'][-1],
                                                                 namespace3+"String", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "String",
                                                                 "Mandatory")
                old_axes_name = axes_name
                Children.append(Variable)

            if Linear == "NO Position FOUND":
                print("NO Position FOUND")
            elif Linear == []:
                print("NO Position FOUND. EMPTY LIST.")
        except:
            pass

        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Variable = Element(namespace2 + "Variable")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    set_SymbolicName_DataType_and_ModellingRule(Variable, new_name, namespace3 + "String", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "String",
                                                                 "Mandatory")
                old_rotary_name = rotary_name
                Children.append(Variable)

            if Rotary == "NO Position FOUND":
                print("NO RotaryPosition FOUND")
            elif Rotary == []:
                print("NO RotaryPosition FOUND. EMPTY LIST.")

        except:
            Position = "NO Rotary Position FOUND"

        ObjectType.append(Children)
        root_out.append(ObjectType)
        EDMToolCount += 1

    ### Checks for CNC Tools
    # Creates CNCTool Object for each Device
    if ("Hurco" in device):
        ### Creates first Object   :    Lines 56-67 in MTConnectModel.xml
        # This is standard for every MTConnect file
        deviceType = "CNCTool"
        Object = Element(namespace2 + "Object")
        Object.set("SymbolicName", device)
        Object.set("TypeDefinition", deviceType + "Type")
        References = Element(namespace2 + "References")
        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "Organizes"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "ObjectsFolder"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)

        Reference = Element(namespace2 + "Reference")
        Reference.set("IsInverse", "true")
        ReferenceType = Element(namespace2 + "ReferenceType")
        ReferenceType.text = namespace3 + "HasNotifier"
        TargetId = Element(namespace2 + "TargetId")
        TargetId.text = namespace3 + "Server"

        Reference.append(ReferenceType)
        Reference.append(TargetId)
        References.append(Reference)
        Object.append(References)
        root_out.append(Object)

        '''
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]
        # Finds the axes branch
        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        old_axes_name = ''
        
        try:
            # Finds linear components
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear:
                Property = Element(namespace2 + "Property")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'] + i.attrib['id'][-1], 
                        namespace3 +  "DataItemType", 
                        "Double")
                else:
                    create_variable(root_in, root_out,
                        "Axes"+ str(axes_label), 
                        i.attrib['name'], 
                        namespace3 +  "DataItemType",
                        "Double")
                old_axes_name = axes_name

        except:
            pass
        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Property = Element(namespace2 + "Property")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        new_name, 
                        namespace3 +  "DataItemType", 
                        "Double")

                else:
                    create_variable(root_in,root_out,
                        "Axes"+ str(axes_label),
                        i.attrib['name'], 
                        namespace3 +  "DataItemType", 
                        "Double")
                old_rotary_name = rotary_name
        except:
            pass
        '''
        axes_label = axes_label + 1000
    # Defines a CNCToolType
    if ("Hurco" in device) and CNCToolCount < 1:
        deviceType = "CNCTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "sType", namespace3 + 'FolderType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_MTConnect_Version(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAMappingData(root_in, root_out, Variable)
        Children.append(Variable)

        Variable = Element(namespace2 + "Variable")
        set_OPCUAVersion(root_in, root_out, Variable)
        Children.append(Variable)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 69-80 in MTConnectModel.xml

        deviceType = "CNCTool"
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, deviceType + "Type", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")

        # Makes the variables
        Variable = Element(namespace2 + "Variable")
        set_Availability(root_in, root_out, Variable)
        Children.append(Variable)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_Manufacturer(root_in, root_out, Property)
        Children.append(Property)

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SerialNumber(root_in, root_out, Property, device)
        Children.append(Property)

        # Finds and sets the Configuration
        # This is temporarily Empyty

        # Makes the variables
        Property = Element(namespace2 + "Property")
        set_SampleInterval(root_in, root_out, Property, device)
        Children.append(Property)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "DataItems", namespace3 + "FolderType",
                                                           "Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Components", namespace3 + "FolderType",
                                                           "Mandatory")
        Children.append(Object)

        # Makes the variables
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Conditions", namespace3 + "FolderType",
                                                           "Optional")
        Children.append(Object)

        # Makes the axes object
        Object = Element(namespace2 + "Object")
        set_SymbolicName_TypeDefinition_and_ModellingRule(Object, "Axes", deviceType + "AxesType", "Mandatory")
        Children.append(Object)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 82-87 in MTConnectModel.xml
        # Finds different components
        Devices = root_in.iter(namespace + 'Device')
        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + "Components")
        Components = Components[0]

        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"ComponentType", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Makes Model element
        Property = Element(namespace2 + "Property")
        # set_Model(root_in, root_out, Property, device)
        set_SymbolicName_DataType_and_ModellingRule(Property, "Model", namespace3 + "String", "Optional")
        Children.append(Property)
        # Makes Station element
        Property = Element(namespace2 + "Property")
        set_SymbolicName_DataType_and_ModellingRule(Property, "Station", namespace3 + "Duration", "Optional")
        Children.append(Property)

        ObjectType.append(Children)
        root_out.append(ObjectType)

        ### Creates ObjectType   :    Lines 89-98 in MTConnectModel.xml
        ObjectType = Element(namespace2 + "ObjectType")
        set_SymbolicName_and_BaseType(ObjectType, deviceType+"AxesType", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")
        # Finds component first
        Devices = root_in.iter(namespace + 'Device')
        # Finds device elment

        component_list = []
        device_elments_list = []
        for device_elments in Devices:
            if device_elments.attrib['name'] == device:
                break
        Components = device_elments.findall(namespace + 'Components')
        Components = Components[0]
        for j in Components:
            component = j.attrib['name']
            component_list.append(component)

        Axes = Components.findall(namespace + "Axes")
        Axes = Axes[0]
        old_axes_name = ''
        try:
            Linear = Axes.iter(namespace + "Linear")
            for i in Linear:
                Variable = Element(namespace2 + "Variable")
                axes_name = i.attrib['name']
                # Checks to see if there is another axes in the same orientation
                if axes_name == old_axes_name:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'] + i.attrib['id'][-1],
                                                                 namespace3+"String", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "String",
                                                                 "Mandatory")
                old_axes_name = axes_name
                Children.append(Variable)

            if Linear == "NO Position FOUND":
                print("NO Position FOUND")
            elif Linear == []:
                print("NO Position FOUND. EMPTY LIST.")
        except:
            pass

        old_rotary_name = ''
        try:
            Rotary = Axes.iter(namespace + "Rotary")
            for i in Rotary:
                Variable = Element(namespace2 + "Variable")
                rotary_name = i.attrib['name']
                # Checks to see if there is another rotary in the same orientation
                if rotary_name == old_rotary_name:
                    new_name = i.attrib['name'] + i.attrib['id'][-1]
                    set_SymbolicName_DataType_and_ModellingRule(Variable, new_name, namespace3 + "String", "Mandatory")
                else:
                    set_SymbolicName_DataType_and_ModellingRule(Variable, i.attrib['name'], namespace3 + "String",
                                                                 "Mandatory")
                old_rotary_name = rotary_name
                Children.append(Variable)

            if Rotary == "NO Position FOUND":
                print("NO RotaryPosition FOUND")
            elif Rotary == []:
                print("NO RotaryPosition FOUND. EMPTY LIST.")
        
        except:
            Position = "NO Rotary Position FOUND"
        
        ObjectType.append(Children)
        root_out.append(ObjectType)
        CNCToolCount += 1


#### Set Location of the MTConnectModel ---------------------------------------------------------
''' Currently it is the same folder as the nodeset generator. If it is not, specify the path. '''
input_file1 = 'MTConnectModel.xml'
#             or
# input_file1 = 'file path here'

# Parsing the input data into a Tree Element:
input_tree = ET.parse(input_file1) # gets the tree from a file
root_in = input_tree.getroot() # gets the root from the tree

print("The input root is: ", root_in, '\n')

### Adds VariableTypes, DataTypes, and ObjectTypes to the tree from the model.
for i in root_in.iter("{http://opcfoundation.org/UA/ModelDesign.xsd}VariableType"):
    root_out.append(i)
for i in root_in.iter("{http://opcfoundation.org/UA/ModelDesign.xsd}DataType"):
    root_out.append(i)
for i in root_in.iter("{http://opcfoundation.org/UA/ModelDesign.xsd}ObjectType"):
    if "Condition" in i.attrib['SymbolicName']: # Adds only Condition ObjectTypes
        root_out.append(i)

#### Output File ---------------------------------------------------------
# Set the file path to ".../UA-ModelCompiler-master/ModelCompiler/Design/"
filepath = os.getcwd()
filename = "MTConnectDeviceCompanion_NodeSet.xml"
output_file = filepath + filename
save_file_xml(root_out, output_file)

filename = "MTConnectModel.xml"
output_file = filepath + filename
save_file_xml(root_out, output_file)


### Executes Batch File
execute_batch()

#### Move Files
move_files()

print(os.getcwd())
print('______________________________________________________')

