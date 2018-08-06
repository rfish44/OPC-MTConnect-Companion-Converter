#!/usr/bin/env python
# -*- coding: utf-8 -*-

"""
Created on Wed Jun 13 08:41:53 2018

@author: Ryan Fisher
@company: National Institute of Standards and Technology

This file streams data to a folder for use by the OPC-UA server. An XML file is taken in, and is parsed for
information. "Live" data is taken by continuously retrieving data from the MTConnect agent.

Information on xml.etree.ElementTree module can be found at: https://docs.python.org/2/library/xml.etree.elementtree.html

"""


import xml.etree.ElementTree as ET
import urllib.request as urllib
import xmltodict
from xml.dom import minidom     # For printing 'pretty' xml format
import time
import matplotlib.pyplot as plt
import matplotlib.animation as animation
import re
from matplotlib import style

# Function Definitions
def convert_float_to_string(data):
    '''
    This function converts float data to string data
    Input: data
    Output: data
    '''
    data_string = data
    data = []
    for i in data_string:
        value = str(i)
        data.append(value)
    return data
    
def convert_time_to_num(timevalue):
    '''
    This function converts time values to whole numbers.
    Ex. 13:30 (13 minutes, 30 seconds) converts to 13.5
    Input: timevalue
    Output: timevalue
    '''
    timeremainder = timevalue % 1
    timevalue = timevalue - timeremainder
    timeremainder = timeremainder * 5 / 3
    timevalue = timevalue + timeremainder 

    # This correction is made due to an actual time error in the simulator.
    # Remove this if your data is running according to the actual time.
    # Currently, the simulator was 17 seconds ahead. You can input how many seconds
    # ahead the simulator is as a decimal to properly reset the data.
    timevalue = timevalue - (0.17 * 5 / 3)

    return timevalue

def website_to_XML(website):
    '''
    This function takes in a website and translates it to xml.
    Input: website (url)
    Output: data
    '''
    urlOpened = False
    while urlOpened == False:
        try:
            file = urllib.urlopen(website)
            print(file)
            print('\n---------------------------------------------------\n')
            data = file.read()
            file.close()
            # print(data)
            print("Data imported")
            print('\n---------------------------------------------------\n')
            urlOpened = True
        except:
            print("Could not get data from url...")


    return data

def write_output_file(data, file_name):
    '''
    This function writes the data to a specified file location.
    Input: data, file_name
    Output: None
    '''
    fileWritten = False
    while fileWritten == False:
        try:
            # Specify the file location for data files. This file location will be used in the server.
            # Example: filelocation = ".../Python_Files/DataFiles/"
            # Example: filelocation = r"...\Python_Files\DataFiles\"
            filelocation = os.getcwd()
            f = open(filelocation + file_name, 'w+')
            if type(data) == str:
                f.write(data)
            else:
                for i in data:
                    f.write(i)
                    f.write('\n')
            f.close()
            fileWritten = True
        except:
            print("Did not output file.")
    print("File outputed...")

def get_root(data):
    '''
    Using ElementTree, this function simply finds the root of a set of data
    '''
    root = ET.fromstring(data)
    return root

####################################################################################################################################################################################

def get_current_information_all(url, root, namespace):
    '''
    This function gets select information for all devices in an MTConnect Stream file.
    Currently, only position data, rotary data, EmergencyStop, Line, Load, and Message data are streamed.
    '''

    ## Finds all the devices in the data
    device_list = []
    position_data = []
    time_data = []
    x_actual_time_data = []
    time_start = 0
    for DeviceStream in root.iter(namespace + "DeviceStream"):
            print(DeviceStream.attrib['name'])
            device = DeviceStream.attrib['name']
            device_list.append(device)
    print("Devices: ", device_list)

    ## Allows the user to select a device
    # if len(device_list) > 1:
    #     device_name = input("Please select a decive: ")
    # else:
    #     device_name = device_list[0]

    # Selects the device the user selected
    # for DeviceStream in root.iter(namespace + "DeviceStream"):
    #     device = DeviceStream.attrib['name']
    #     if device == device_name:
    #         break

    devices_position_dict = {}
    devices_time_dict = {}
    devices_SpindleSpeed_dict = {}
    devices_RotaryVelocity_dict = {}
    while True:
        for device in device_list:
            device_name = device    
            data = website_to_XML(url) # Gets the "live" data from the specified website
            root = get_root(data)

            # Finds the creation time of the data
            Header = root.find(namespace + "Header")
            creationTime = Header.attrib['creationTime']
            print("Sample was taken at: ", creationTime[14:19])

            for DeviceStream in root.iter(namespace + "DeviceStream"):
                print(DeviceStream.attrib['name'])
                if device == DeviceStream.attrib['name']:
                    break
            ### Checks the samples ###
            print("\nDevice Samples:")
            for Samples in DeviceStream.iter(namespace + "Samples"):

                # Checks for AccumulatedTime
                try:
                    AccumulatedTime = Samples.findall(namespace + "AccumulatedTime")
                    AccumulatedTime = AccumulatedTime[0]

                    if AccumulatedTime == "NO AccumulatedTime FOUND":
                        print("NO AccumulatedTime FOUND")
                    elif AccumulatedTime == []:
                        print("NO AccumulatedTime FOUND. EMPTY LIST.")
                    # else:
                        # print("dataItemID = ", AccumulatedTime.attrib["dataItemId"], " and the AccumulatedTime is ", AccumulatedTime.text)
                except:
                        AccumulatedTime = "NO AccumulatedTime FOUND"

                # Checks for AngularVelocity
                try:
                    AngularVelocity = Samples.findall(namespace + "AngularVelocity")

                    AngularVelocity = AngularVelocity[0]

                    if AngularVelocity == "NO AngularVelocity FOUND":
                        print("NO AngularVelocity FOUND")
                    elif AngularVelocity == []:
                        print("NO AngularVelocity FOUND. EMPTY LIST.")
                    # else:
                        # print("dataItemID = ", AngularVelocity.attrib["dataItemId"], " and the AngularVelocity is ", AngularVelocity.text)
                except:
                        AngularVelocity = "NO AngularVelocity FOUND"

                # Checks for Angle
                try:
                    Angle = Samples.findall(namespace + "Angle")

                    Angle = Angle[0]

                    if Angle == "NO Angle FOUND":
                        print("NO Angle FOUND")
                    elif Angle == []:
                        print("NO Angle FOUND. EMPTY LIST.")
                    #else:
                        #print("dataItemID = ", Angle.attrib["dataItemId"], " and the Angle is ", Angle.text)
                except:
                    Angle = "NO AngularVelocity FOUND"

                # Checks for AxisFeedrate
                try:
                    AxisFeedrate = Samples.findall(namespace + "AxisFeedrate")
                    AxisFeedrate = AxisFeedrate[0]

                    if AxisFeedrate == "NO AxisFeedrate FOUND":
                        print("NO AxisFeedrate FOUND")
                    elif AxisFeedrate == []:
                        print("NO AxisFeedrate FOUND. EMPTY LIST.")
                    #else:
                        #print("dataItemID = ", AxisFeedrate.attrib["dataItemId"], " and the AxisFeedrate is ", AxisFeedrate.text)
                except:
                    AxisFeedrate = "NO AxisFeedrate FOUND"


                # Checks for PathFeedrateOverride
                try:
                    PathFeedrateOverride = Samples.findall(namespace + "PathFeedrateOverride")
                    PathFeedrateOverride = PathFeedrateOverride[0]

                    if PathFeedrateOverride == "NO PathFeedrateOverride FOUND":
                        print("NO PathFeedrateOverride FOUND")
                    elif PathFeedrateOverride == []:
                        print("NO PathFeedrateOverride FOUND. EMPTY LIST.")
                    #else:
                        # print("dataItemID = ", PathFeedrateOverride.attrib["dataItemId"], " and the PathFeedrateOverride is ", PathFeedrateOverride.text)
                except:
                    PathFeedrateOverride = "NO PathFeedrateOverride FOUND"

                # Checks for PathFeedrate
                try:
                    PathFeedrate = Samples.findall(namespace + "PathFeedrate")
                    PathFeedrate = PathFeedrate[0]

                    if PathFeedrate == "NO PathFeedrate FOUND":
                        print("NO PathFeedrate FOUND")
                    elif PathFeedrate == []:
                        print("NO PathFeedrate FOUND. EMPTY LIST.")
                    #else:
                        # print("dataItemID = ", PathFeedrate.attrib["dataItemId"], " and the PathFeedrate is ", PathFeedrate.text)
                except:
                    PathFeedrate = "NO PathFeedrate FOUND"

                # Checks for PathPosition
                try:
                    PathPosition = Samples.findall(namespace + "PathPosition")
                    PathPosition = PathPosition[0]

                    if PathPosition == "NO PathPosition FOUND":
                        print("NO PathPosition FOUND")
                    elif PathPosition == []:
                        print("NO PathPosition FOUND. EMPTY LIST.")
                    #else:
                #       print("dataItemID = ", PathPosition.attrib["dataItemId"], " and the PathPosition is ", PathPosition.text)
                except:
                    PathPosition = "NO PathPosition FOUND"

                # Checks for Position
                # try:
                Positions = Samples.findall(namespace + "Position")
                for Position in Positions:
                    if Position == "NO Position FOUND":
                        print("NO Position FOUND")
                    elif Position == []:
                        print("NO Position FOUND. EMPTY LIST.")
                    
                    subType = Position.attrib["subType"]
                    print("dataItemID = ", Position.attrib["dataItemId"], " and the ", subType, " Position is ", Position.text)
                    axes_name = Position.attrib["name"]
                    file_name = "Data_" + device + '_' + axes_name + '_' + subType
                    
                    timeStamp = Position.attrib["timestamp"]
                    timevalue = timeStamp[14:19]
                    timevalue = timevalue.replace(':', '.')
                    timevalue = float(timevalue)
                    timevalue = convert_time_to_num(timevalue)

                    if file_name not in devices_time_dict:
                        devices_time_dict[file_name] = [timevalue] 
                        devices_position_dict[file_name] = [Position.text]
                    else:
                        devices_time_dict[file_name].append(timevalue)
                        devices_position_dict[file_name].append(Position.text)

                    time_string = convert_float_to_string(devices_time_dict[file_name])
                    devices_time_dict[file_name] = time_string

                    write_output_file(devices_time_dict[file_name], file_name + '_time.txt')
                    write_output_file(devices_position_dict[file_name], file_name + '_position.txt')

                # except:
                #     print("ERROR in finding Position")

                # Checks for Load
                try:
                    Load = Samples.findall(namespace + "Load")
                    Load = Load[0]

                    if Load == "NO LOAD FOUND":
                        print("NO LOAD FOUND")
                    elif Load == []:
                        print("NO LOAD FOUND. EMPTY LIST.")
                    #else:
                        # print("dataItemID = ", Load.attrib["dataItemId"], " and the Load is ", Load.text)
                except:
                    Load = None

                # Checks for RotaryVelocity
                try:
                    
                    RotaryVelocitys = Samples.findall(namespace + "RotaryVelocity")
                    print("Got here 2")
                    print("RotaryVelocitys: ",RotaryVelocitys)
                    for RotaryVelocity in RotaryVelocitys:
                        if RotaryVelocity == "NO RotaryVelocity FOUND":
                            print("NO RotaryVelocity FOUND")
                        elif RotaryVelocity == []:
                            print("NO RotaryVelocity FOUND. EMPTY LIST.")
                        print("Got here 3")
                        subType = RotaryVelocity.attrib["subType"]
                        print("dataItemID = ", RotaryVelocity.attrib["dataItemId"], " and the ", subType, " RotaryVelocity is ", RotaryVelocity.text)
                        axes_name = RotaryVelocity.attrib["name"]
                        file_name = "Data_" + device + '_' + axes_name + '_' + subType
                        
                        timeStamp = RotaryVelocity.attrib["timestamp"]
                        timevalue = timeStamp[14:19]
                        timevalue = timevalue.replace(':', '.')
                        timevalue = float(timevalue)
                        timevalue = convert_time_to_num(timevalue)
                        print("TIME VALUE IS: ", timevalue)

                        if file_name not in devices_time_dict:
                            devices_time_dict[file_name] = [timevalue] 
                            devices_RotaryVelocity_dict[file_name] = [RotaryVelocity.text]
                        else:
                            devices_time_dict[file_name].append(timevalue)
                            devices_RotaryVelocity_dict[file_name].append(RotaryVelocity.text)

                        time_string = convert_float_to_string(devices_time_dict[file_name])
                        devices_time_dict[file_name] = time_string

                        write_output_file(devices_time_dict[file_name], file_name + '_time.txt')
                        write_output_file(devices_RotaryVelocity_dict[file_name], file_name + '_rotaryspeed.txt')
                except:
                    try:
                        SpindleSpeed = Samples.findall(namespace + "SpindleSpeed")
                        print("Got here 2")
                        for SpindleSpeed in SpindleSpeeds:
                            if SpindleSpeed == "NO SpindleSpeed FOUND":
                                print("NO SpindleSpeed FOUND")
                            elif SpindleSpeed == []:
                                print("NO SpindleSpeed FOUND. EMPTY LIST.")
                            
                            subType = SpindleSpeed.attrib["subType"]
                            print("dataItemID = ", SpindleSpeed.attrib["dataItemId"], " and the ", subType, " SpindleSpeed is ", SpindleSpeed.text)
                            axes_name = SpindleSpeed.attrib["name"]
                            file_name = "Data_" + device + '_' + axes_name + '_' + subType
                            
                            timeStamp = SpindleSpeed.attrib["timestamp"]
                            timevalue = timeStamp[14:19]
                            timevalue = timevalue.replace(':', '.')
                            timevalue = float(timevalue)
                            timevalue = convert_time_to_num(timevalue)
                            print("TIME VALUE IS: ", timevalue)

                            if file_name not in devices_time_dict:
                                devices_time_dict[file_name] = [timevalue] 
                                devices_SpindleSpeed_dict[file_name] = [SpindleSpeed.text]
                            else:
                                devices_time_dict[file_name].append(timevalue)
                                devices_SpindleSpeed_dict[file_name].append(SpindleSpeed.text)

                            time_string = convert_float_to_string(devices_time_dict[file_name])
                            devices_time_dict[file_name] = time_string

                            write_output_file(devices_time_dict[file_name], file_name + '_time.txt')
                            write_output_file(devices_SpindleSpeed_dict[file_name], file_name + '_rotaryspeed.txt')
                        if SpindleSpeed == "NO Angle FOUND":
                            print("NO SpindleSpeed FOUND")
                        elif SpindleSpeed == []:
                            print("NO SpindleSpeed FOUND. EMPTY LIST.")
                        else:
                            print("dataItemID = ", SpindleSpeed.attrib["dataItemId"], " and the SpindleSpeed is ", SpindleSpeed.text)

                    except:
                        print("NO SpindleSpeed FOUND")

                # Checks for Temperature
                try:
                    Temperature = Samples.findall(namespace + "Temperature")
                    Temperature = Temperature[0]

                    if Temperature == "NO Temperature FOUND":
                        print("NO Temperature FOUND")
                    elif Temperature == []:
                        print("NO Temperature FOUND. EMPTY LIST.")
                    #else:
                        # print("dataItemID = ", Temperature.attrib["dataItemId"], " and the Temperature is ", Temperature.text)
                except:
                    Temperature = "NO Temperature FOUND"
                '''

                '''
                ### Checks the Events ###
                print("\nDevice Events:")
            for Events in DeviceStream.iter(namespace + "Events"):
                # Checks for Availability
                try:
                    Availability = Events.findall(namespace + "Availability")
                    Availability = Availability[0]

                    if Availability == "NO Availability FOUND":
                        print("NO Availability FOUND")
                    elif Availability == []:
                        print("NO Availability FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Availability.attrib["dataItemId"], " Availability is ", Availability.text)
                except:
                    Availability = "NO Availability FOUND"

                # Checks for EmergencyStop
                try:
                    EmergencyStop = Events.findall(namespace + "EmergencyStop")
                    EmergencyStop = EmergencyStop[0]

                    if EmergencyStop == "NO EmergencyStop FOUND":
                        print("NO EmergencyStop FOUND")
                    elif EmergencyStop == []:
                        print("NO EmergencyStop FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", EmergencyStop.attrib["dataItemId"], " EmergencyStop is ", EmergencyStop.text)
                    if "ARMED" in EmergencyStop.text:
                        EmergencyStopValue = "1"
                    elif "TRIGGERED" in EmergencyStop.text:
                        EmergencyStopValue = "2"
                    elif "UNAVAILABLE" in EmergencyStop.text:
                        EmergencyStopValue = "3"
                    write_output_file(EmergencyStopValue, "EmergencyStop.txt")
                except:
                    EmergencyStop = "NO EmergencyStop FOUND"

                # Checks for Message
                try:
                    Message = Events.findall(namespace + "Message")
                    Message = Message[0]

                    if Message == "NO Message FOUND":
                        print("NO Message FOUND")
                    elif Message == []:
                        print("NO Message FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Message.attrib["dataItemId"], " Message is ", Message.text)
                    write_output_file(Message.text, "Message.txt")
                except:
                    Message = "NO Message FOUND"

                # Checks for AssetChanged
                try:
                    AssetChanged = Events.findall(namespace + "AssetChanged")
                    AssetChanged = AssetChanged[0]

                    if AssetChanged == "NO AssetChanged FOUND":
                        print("NO AssetChanged FOUND")
                    elif AssetChanged == []:
                        print("NO AssetChanged FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", AssetChanged.attrib["dataItemId"], " AssetChanged is ", AssetChanged.text)
                except:
                    AssetChanged = "NO AssetChanged FOUND"

                # Checks for AssetRemoved
                try:
                    AssetRemoved = Events.findall(namespace + "AssetRemoved")
                    AssetRemoved = AssetRemoved[0]

                    if AssetRemoved == "NO AssetRemoved FOUND":
                        print("NO AssetRemoved FOUND")
                    elif AssetRemoved == []:
                        print("NO AssetRemoved FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", AssetRemoved.attrib["dataItemId"], " AssetRemoved is ", AssetRemoved.text)
                except:
                    AssetRemoved = "NO AssetRemoved FOUND"

                # Checks for PathFeedrateOverride
                try:
                    PathFeedrateOverride = Events.findall(namespace + "PathFeedrateOverride")
                    PathFeedrateOverride = PathFeedrateOverride[0]

                    if PathFeedrateOverride == "NO PathFeedrateOverride FOUND":
                        print("NO PathFeedrateOverride FOUND")
                    elif PathFeedrateOverride == []:
                        print("NO PathFeedrateOverride FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", PathFeedrateOverride.attrib["dataItemId"], " PathFeedrateOverride is ", PathFeedrateOverride.text)
                except:
                    PathFeedrateOverride = "NO PathFeedrateOverride FOUND"

                # Checks for RotaryVelocityOverride
                try:
                    RotaryVelocityOverride = Events.findall(namespace + "RotaryVelocityOverride")
                    RotaryVelocityOverride = RotaryVelocityOverride[0]

                    if RotaryVelocityOverride == "NO RotaryVelocityOverride FOUND":
                        print("NO RotaryVelocityOverride FOUND")
                    elif RotaryVelocityOverride == []:
                        print("NO RotaryVelocityOverride FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", RotaryVelocityOverride.attrib["dataItemId"], " RotaryVelocityOverride is ", RotaryVelocityOverride.text)
                except:
                    RotaryVelocityOverride = "NO RotaryVelocityOverride FOUND"

                # Checks for Execution
                try:
                    Execution = Events.findall(namespace + "Execution")
                    Execution = Execution[0]

                    if Execution == "NO Execution FOUND":
                        print("NO Execution FOUND")
                    elif Execution == []:
                        print("NO Execution FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Execution.attrib["dataItemId"], " Execution is ", Execution.text)
                except:
                    Execution = "NO Execution FOUND"

                # Checks for ControllerMode
                try:
                    ControllerMode = Events.findall(namespace + "ControllerMode")
                    ControllerMode = ControllerMode[0]

                    if ControllerMode == "NO ControllerMode FOUND":
                        print("NO ControllerMode FOUND")
                    elif ControllerMode == []:
                        print("NO ControllerMode FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ControllerMode.attrib["dataItemId"], " ControllerMode is ", ControllerMode.text)
                except:
                    ControllerMode = "NO ControllerMode FOUND"

                # Checks for PalletNumber
                try:
                    PalletNumber = Events.findall(namespace + "PalletNumber")
                    PalletNumber = PalletNumber[0]

                    if PalletNumber == "NO PalletNumber FOUND":
                        print("NO PalletNumber FOUND")
                    elif PalletNumber == []:
                        print("NO PalletNumber FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", PalletNumber.attrib["dataItemId"], " PalletNumber is ", PalletNumber.text)
                except:
                    PalletNumber = "NO PalletNumber FOUND"

                # Checks for Program
                try:
                    Program = Events.findall(namespace + "Program")
                    Program = Program[0]

                    if Program == "NO Program FOUND":
                        print("NO Program FOUND")
                    elif Program == []:
                        print("NO Program FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Program.attrib["dataItemId"], " Program is ", Program.text)
                except:
                    Program = "NO Program FOUND"

                # Checks for ProgramComment
                try:
                    ProgramComment = Events.findall(namespace + "ProgramComment")
                    ProgramComment = ProgramComment[0]

                    if ProgramComment == "NO ProgramComment FOUND":
                        print("NO ProgramComment FOUND")
                    elif ProgramComment == []:
                        print("NO ProgramComment FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ProgramComment.attrib["dataItemId"], " ProgramComment is ", ProgramComment.text)
                except:
                    ProgramComment = "NO ProgramComment FOUND"

                # Checks for Line
                try:
                    Line = Events.findall(namespace + "Line")
                    Line = Line[0]

                    if Line == "NO Line FOUND":
                        print("NO Line FOUND")
                    elif Line == []:
                        print("NO Line FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Line.attrib["dataItemId"], " Line is ", Line.text)
                    write_output_file(Line.text, "Line.txt")
                except:
                    Line = "NO Line FOUND"

                # Checks for Motion
                try:
                    Motion = Events.findall(namespace + "Motion")
                    Motion = Motion[0]

                    if Motion == "NO Motion FOUND":
                        print("NO Motion FOUND")
                    elif Motion == []:
                        print("NO Motion FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Motion.attrib["dataItemId"], " Motion is ", Motion.text)
                except:
                    Motion = "NO Motion FOUND"

                # Checks for Line
                try:
                    Line = Events.findall(namespace + "Line")
                    Line = Line[0]

                    if Line == "NO Line FOUND":
                        print("NO Line FOUND")
                    elif Line == []:
                        print("NO Line FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Line.attrib["dataItemId"], " Line is ", Line.text)
                except:
                    Line = "NO Line FOUND"

                # Checks for Program
                try:
                    Program = Events.findall(namespace + "Program")
                    Program = Program[0]

                    if Program == "NO Program FOUND":
                        print("NO Program FOUND")
                    elif Program == []:
                        print("NO Program FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Program.attrib["dataItemId"], " Program is ", Program.text)
                except:
                    Program = "NO Program FOUND"

                # Checks for ProgramEditName
                try:
                    ProgramEditName = Events.findall(namespace + "ProgramEditName")
                    ProgramEditName = ProgramEditName[0]

                    if ProgramEditName == "NO ProgramEditName FOUND":
                        print("NO ProgramEditName FOUND")
                    elif ProgramEditName == []:
                        print("NO ProgramEditName FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ProgramEditName.attrib["dataItemId"], " ProgramEditName is ", ProgramEditName.text)
                except:
                    ProgramEditName = "NO ProgramEditName FOUND"

                # Checks for PartCount
                try:
                    PartCount = Events.findall(namespace + "PartCount")
                    PartCount = PartCount[0]

                    if PartCount == "NO PartCount FOUND":
                        print("NO PartCount FOUND")
                    elif PartCount == []:
                        print("NO PartCount FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", PartCount.attrib["dataItemId"], " PartCount is ", PartCount.text)
                except:
                    PartCount = "NO PartCount FOUND"

                # Checks for PowerState
                try:
                    PowerState = Events.findall(namespace + "PowerState")
                    PowerState = PowerState[0]

                    if PowerState == "NO PowerState FOUND":
                        print("NO PowerState FOUND")
                    elif PowerState == []:
                        print("NO PowerState FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", PowerState.attrib["dataItemId"], " PowerState is ", PowerState.text)
                except:
                    PowerState = "NO PowerState FOUND"

                # Checks for SequenceNumber
                try:
                    SequenceNumber = Events.findall(namespace + "SequenceNumber")
                    SequenceNumber = SequenceNumber[0]

                    if SequenceNumber == "NO SequenceNumber FOUND":
                        print("NO SequenceNumber FOUND")
                    elif SequenceNumber == []:
                        print("NO SequenceNumber FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", SequenceNumber.attrib["dataItemId"], " SequenceNumber is ", SequenceNumber.text)
                except:
                    SequenceNumber = "NO SequenceNumber FOUND"

                # Checks for ToolAssetId
                try:
                    ToolAssetId = Events.findall(namespace + "ToolAssetId")
                    ToolAssetId = ToolAssetId[0]

                    if ToolAssetId == "NO ToolAssetId FOUND":
                        print("NO ToolAssetId FOUND")
                    elif ToolAssetId == []:
                        print("NO ToolAssetId FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ToolAssetId.attrib["dataItemId"], " ToolAssetId is ", ToolAssetId.text)
                except:
                    ToolAssetId = "NO ToolAssetId FOUND"

                # Checks for ToolNumber
                try:
                    ToolNumber = Events.findall(namespace + "ToolNumber")
                    ToolNumber = ToolNumber[0]

                    if ToolNumber == "NO ToolNumber FOUND":
                        print("NO ToolNumber FOUND")
                    elif ToolNumber == []:
                        print("NO ToolNumber FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ToolNumber.attrib["dataItemId"], " ToolNumber is ", ToolNumber.text)
                except:
                    ToolNumber = "NO ToolNumber FOUND"

                # Checks for ToolGroup
                try:
                    ToolGroup = Events.findall(namespace + "ToolGroup")
                    ToolGroup = ToolGroup[0]

                    if ToolGroup == "NO ToolGroup FOUND":
                        print("NO ToolGroup FOUND")
                    elif ToolGroup == []:
                        print("NO ToolGroup FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ToolGroup.attrib["dataItemId"], " ToolGroup is ", ToolGroup.text)
                except:
                    ToolGroup = "NO ToolGroup FOUND"

                # Checks for ToolSuffix
                try:
                    ToolSuffix = Events.findall(namespace + "ToolSuffix")
                    ToolSuffix = ToolSuffix[0]

                    if ToolSuffix == "NO ToolSuffix FOUND":
                        print("NO ToolSuffix FOUND")
                    elif ToolSuffix == []:
                        print("NO ToolSuffix FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", ToolSuffix.attrib["dataItemId"], " ToolSuffix is ", ToolSuffix.text)
                except:
                    ToolSuffix = "NO ToolSuffix FOUND"

                # Checks for Unit
                try:
                    Unit = Events.findall(namespace + "Unit")
                    Unit = Unit[0]

                    if Unit == "NO Unit FOUND":
                        print("NO Unit FOUND")
                    elif Unit == []:
                        print("NO Unit FOUND. EMPTY LIST.")
                    #else:
                    # print("dataItemID = ", Unit.attrib["dataItemId"], " Unit is ", Unit.text)
                except:
                    Unit = "NO Unit FOUND"

            ### Checks the Condition of XLoad ###
            print("\nDevice Condition:")
            for Condition in DeviceStream.iter(namespace + "Condition"):
                # Checks for Fault
                try:
                    for value in Condition:
                        if value.attrib['dataItemId'] == "Xloadc":
                            conditionvalue = re.sub(r'{.+?}', '', value.tag)
                            write_output_file(conditionvalue, "MTCurrentState.txt")
                except:
                    Fault = "NO Fault FOUND"
            delay = 0
            time.sleep(delay)


        print('---------------------------------------------------')

    print(device_list)

    return 0

### Defines URLs
url = 'http://simulator.memexoee.com/current'
#url = 'http://agent.mtconnect.org/current'

namespace = "{urn:mtconnect.org:MTConnectStreams:1.3}"

data = website_to_XML(url)
root = get_root(data)

#########################################
# Save file to an XML
xmlstr = minidom.parseString(ET.tostring(root)).toprettyxml(indent="  ")
output_file = 'mtconnect_output.xml'
with open(output_file, "wb") as f:
    f.write(xmlstr.encode('utf-8'))

print("Output file created!\n\n")
#########################################
'''
for Linear in root.iter(namespace + 'Linear'):
    for DataItem in Linear.iter(namespace + 'DataItem'):
        print(DataItem.text)
        '''

input_file = output_file
tree = ET.parse(input_file)
# root = tree.getroot()
value = get_current_information_all(url, root, namespace)