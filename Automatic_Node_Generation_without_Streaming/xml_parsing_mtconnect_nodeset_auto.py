
# -*- coding: utf-8 -*-
"""
Created on Wed Jun 13 08:41:53 2018

@author: Ryan Fisher

This file probes an MTConnect file and automatically produces an OPC-UA/MTConnect Companion format that can be
uploaded to a server. An XML output is generated, but a model compiler is executed on the
XML file to create .uanodes. These nodes are automatically sent to the structure library for
the server. This node generator should create objects and variables for all items in the MTConnect file.

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

### Basic Functions
def move_files():
    # Copies the files, created from the converter, to the server folder.
    # Overwrites files already there to update nodes
    # Set the file source and destination:
    # The source should be "...\UA-ModelCompiler-master\Published\MTConnect"
    # The destination should be "...\UA-.NETStandard-master\SampleApplications\Workshop\Boiler\Server"
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

### The following functions are used to recursively generate nodes
### by identifying components and data items as objects and variables.
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

    parent.append(Object)
    return parent

def create_variable(root_in, root_out, Object, SymbolicName, DataType):
    ''' 
    Creates a variable in the XML Companion format 
    Input: root_in, root_out, parent, SymbolicName, TypeDef, DataType
    Output: None
    '''
    Variable = Element(namespace2 + "Variable")
    Variable.set("SymbolicName", SymbolicName)
    Variable.set("ModellingRule", "Mandatory")
    Variable.set("DataType", namespace3 + DataType)

    Object.append(Variable)
    return Object

def create_objectType(object, root_out):
    '''
        <summary>
        Creates an object type and appends it to the root.
        Input: object, root_out
        Output:  None
        <summary>
    '''
    object_name = object.tag.replace(namespace, '')
    object_name = object_name_filter(object_name, object)

    print("object_name is this: ", object_name)
    object_names = object_name

    if type(object_names) != type(list()):
        object_names = [object_names]

    for object_name in object_names:
        ObjectType = Element(namespace2 + "ObjectType")
        ObjectType = set_SymbolicName_and_BaseType(ObjectType, object_name + "Type", namespace3 + 'BaseObjectType')
        Children = Element(namespace2 + "Children")

        print("The object is: " , object.tag.replace(namespace, ''))
        for child in object:
            if child.tag.replace(namespace, '') == "Components":
                for i in child:
                    Children = make_children_objects(i, Children)
            else:
                Children = make_children_objects(child, Children)

            
        ObjectType.append(Children)
        root_out.append(ObjectType)

def object_name_filter(object_name, object):
    '''
        <summary>
        Takes an objects name as a string and filters it for 
        characters that the model compiler or server rejects.
        Input: object_name, object
        Output:  object_name
        <summary>
    '''
    if "Device" in object_name:
        object_name = object.attrib['id']
        object_name = object_name.replace("-","_")
        object_name = object_name.replace("#", "num")
    elif "Components" in object_name:
        objectlisttemp = []
        for i in object:
            object_name = i.tag.replace(namespace, '')
            objectlisttemp.append(object_name)
        object_name = objectlisttemp
    else:
        try:
            object_name = object_name + object.attrib['id']
            object_name = object_name.replace("-", "_")
            object_name = object_name.replace("#", "num")
        except:
            object_name = object.tag.replace(namespace, '')
    return object_name

def variable_name_filter(SymbolicName, DataItem):
    '''
        <summary>
        Takes an objects name as a string and filters it for 
        characters that the model compiler or server rejects.
        Input: SymbolicName, DataItem
        Output:  SymbolicName
        <summary>
    '''
    if SymbolicName == "PATH_FEEDRATE":
            SymbolicName = SymbolicName + "_" + DataItem.attrib['units']
    if ":" in SymbolicName:
        SymbolicName = SymbolicName.replace(":","")
    if "/" in SymbolicName:
        SymbolicName = SymbolicName.replace("/","_PER_")
    if "#" in SymbolicName:
        SymbolicName = SymbolicName.replace("#","num")

    return SymbolicName        
def make_children_objects(child, Children):
    '''
        <summary>
        Makes children into their respective items. If the child
        is a component, it is translated to an object. If the child
        is a Description, it is made into a variable. If the child 
        is a DataItem, variables are created for them. 
        Input: child, Children
        Output:  Children
        <summary>
    '''
    object_name = child.tag.replace(namespace, '')
    print("OBJECT_name is : ", object_name)
    object_name = object_name_filter(object_name, child)
    print("THE OBJECT NAME IS NOW: ", object_name)
    print("The child of object is: ", child.tag.replace(namespace,''))
    if child.tag == namespace + "DataItems":
        print("child is this: ", child.tag)
        Children = get_data_items(child, Children)
    elif child.tag == namespace + "Description":
        objectText = child.text
        objectText = objectText.replace(" ", "_")
        objectText = objectText.replace("-", "_")
        objectText = objectText.replace("#", "num")
        SymbolicName = "Description_" + objectText
        create_variable(root_in, root_out, Children, SymbolicName, "String")
    else:
        Children = create_object(root_in,root_out, Children, object_name, object_name + "Type")

    return Children

def find_more_children(parent, object_list):
    '''
        <summary>
        This function finds all the children of a component, and if
        there is a component, it is appended to the object list. If
        it is a DataItem or Description, the child IS NOT added to 
        the object list, since these translate as variables. This 
        function is recursive, finding all objects.
        Input: child, Children
        Output:  Children
        <summary>
    '''
    for child in parent:
        if child.tag == namespace + "DataItems" or child.tag == namespace + "Description":
            pass
        else:
            object_list.append(child)
            find_more_children(child, object_list)

def get_data_items(DataItems, Children):
    '''
        <summary>
        This function finds all "DataItem"s for a "DataItems" parent.
        The data items are then turned into variables and appended
        to the the Children tag.
        Input: DataItems, Children
        Output:  Children
        <summary>
    '''
    for DataItem in DataItems:
        ### Establish a SymbolicName for each variable
        try:
            SymbolicName = DataItem.attrib['name']
        except:
            SymbolicName = DataItem.attrib['type']

        ### Renames the variable to conform to Model Compiler
        SymbolicName = variable_name_filter(SymbolicName, DataItem)

        ### Establishes a DataType for each Variable
        DataItemCategory = DataItem.attrib['category']
        if DataItemCategory == "SAMPLE":
            DataType = "Double"
        elif DataItemCategory =="CONDITION":
            DataType = "String"
        else:
            DataType = "String"
        Children = create_variable(root_in, root_out, Children, SymbolicName, DataType)
    return Children


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
# url = 'http://simulator.memexoee.com/'
url = 'http://agent.mtconnect.org/probe'

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
runThrough = 0
for device in all_devices: # Creates node sets for each device
    ### Checks for tools
    # Creates an Object for each Device
    deviceType = device
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

    if runThrough == 0:
        ### Creates ObjectTypes, Objects, and Variables
        #################################################
        Devices = root_in.iter(namespace + 'Device')
        device = []
        object_list = []
        runThrough += 1

        # Finds all objects and their children
        for device_elements in root_in:
            find_more_children(device_elements, object_list)

        #################################################
        print("Devices is :::", Devices)
        device_children = device_elements

        print("Object list is: " , object_list)

        # Makes an object type for each object in the list
        for object in object_list:
            # Ensures a bypass occurs on "Component" tags
            if object.tag.replace(namespace, '') != "Components":
                create_objectType(object, root_out)

        print("Completed the XML Companion generation successfully")


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

