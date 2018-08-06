'''
Information:

@author: Ryan Fisher
@company: National Institute of Standards and Technology

The following code was generated mainly through open source code. Below is the link to find tutorials on how
to manipulate Dash by Plotly. These videos were used to guide the production of this GUI.

url: https://pythonprogramming.net/data-visualization-application-dash-python-tutorial-introduction/

This code produces a GUI that generates on graph based on text file inputs and a single CSV file.

'''

import dash
from dash.dependencies import Output, Event
import dash_core_components as dcc
import dash_html_components as html
import plotly
import random
import plotly.graph_objs as go
from collections import deque
import time
from collections import deque
import csv
import glob, os

def get_data():
    '''
        This function takes in text files filled withvalues to be plotted.
        The files are continually opened to search for new data.

        The  position and time  values are returned as dictionaries.
    '''

    # Finds files in a directory
    # Set "filepath" to the location of the data files
    # Ex: filepath = ".../DataFiles/"
    filepath = "file path"
    
    os.chdir(filepath)
    list_files = [] #######
    data_dict = {}  # Creates dictionaries lists to store the files
    time_dict = {}  #######
    keywords = ['position', 'rotaryspeed','spindlespeed'] # Sets keywords that determine data

    # Makes a list of files
    for file in glob.glob("*.txt"):
        list_files.append(file)

    # Filters through the files and inserts data into the dictionaries
    for filename in list_files:
        file = open(filename)
        # Finds time files
        if file.mode == 'r' and ('time' in filename):
            contentx = file.readlines()
            contentxnew = []
            for i in contentx:
                contentxnew.append(float(i.replace('\n', ''))) # converts the string values to floats
            time_dict[filename] = contentxnew
        # Finds files not related to time
        if file.mode == 'r' and ('time' not in filename):
            for keyword in keywords:
                if keyword in filename:
                    contenty = file.readlines()
                    contentynew = []
                    for i in contenty:
                        try:
                            #print("i value is: " , i)
                            contentynew.append(float(i.replace('\n', '')))# converts the string values to floats
                        except:
                            pass
                    data_dict[filename] = contentynew
        file.close()
    return (time_dict,data_dict)

def get_csv_data():
    # This funciton retrieves CSV data and returns "X" and "Y" values from the file
    # These X and Y values normally represent a position and time.
    # Set "filepath" to the location of the DataLogger.csv file
    # Ex: filepath = ".../DataFiles/"
    filepath = "file path"

    with open(filepath + "DataLogger.csv") as csvfile:
        readCSV = csv.reader(csvfile, delimiter=',')
        values1 = []
        values2 = []
        for row in readCSV:
            if row[-1] != 'ServerTimeStamp':
                time = row[-1][14:19]
                time = time.replace(':', '.')
                time = float(time)
                values2.append(time)

            if row[2] != 'Value':
                values1.append(float(row[2]))
        y = values1
        x = values2
    csvfile.close()
    return (x,y)

# Retrieves the data to start
time_dict, data_dict = get_data()
print("The Data Dict keys are is: ", data_dict.keys())
time_server, value_server= get_csv_data()
serverName = "Server Data"
time_dict[serverName] = time_server
data_dict[serverName] = value_server



app = dash.Dash(__name__) # Calls the DASH app

### app.layout determines the layout of the app
# Tutorials for understanding this format can be found at "https://dash.plot.ly/"
app.layout = html.Div(children=[
    html.H1(children='Plotting data from machine before the server'),
    dcc.Dropdown(id='machine-data-name', options=[{'label': s, 'value': s}
                                                  for s in data_dict.keys()],
                 value = [],
                 multi=True
                 ),
    html.Div(children=html.Div(id='graphs'), className = 'row'),
    dcc.Interval(
        id='graph-update',
        interval = 100),
    ],className = "container",style={'width':'98%','margin-left':10,'margin-right':10,'max-width':50000})

@app.callback(dash.dependencies.Output('graphs', 'children'),
              [dash.dependencies.Input('machine-data-name','value')],
              events = [dash.dependencies.Event('graph-update','interval')]
              )

def update_graph(data_names):
    graphs = []
    keywords = ['position', 'rotaryspeed','spindlespeed', 'Server']
    time_dict, data_dict = get_data()
    print("This is the data names: ", data_names)
    serverName = "Server Data"
    time_server, value_server  = get_csv_data()
    time_dict[serverName] = time_server
    data_dict[serverName] = value_server

    #print("Time Web:", time_website[-1], "     VAL:", value_website[-1])
    print("Time Server:", time_server[-1], "     VAL:", value_server[-1])
    '''
    if len(data_names) > 2:
        class_choice = 'col s12 m6 l4'
    elif len(data_names) == 2:
        class_choice = 'col s12 m6 l6'
    else:
        class_choice = 'col s12 m6 8'
    '''
    for data_name in data_names:
        for keyword in keywords:
            if keyword in data_name:
                if keyword == "Server":
                    time_name = "Server Data"
                    break
                else:
                    time_name = data_name.replace('_' + keyword, '_time') # Sets a variable to find the time file
                    break
        data = go.Scatter(
            x=list(time_dict[time_name]),
            y=list(data_dict[data_name]),
            name='Scatter',
            mode='lines+markers',
        )

        graphs.append(html.Div(dcc.Graph(
            id=data_name,
            animate=True,
            figure={'data': [data], 'layout': go.Layout(xaxis=dict(range=[min(time_dict[time_name]), max(time_dict[time_name])]
                                                                    ),
                                                        yaxis=dict(range=[min(data_dict[data_name]),
                                                                          max(data_dict[data_name])])
                                                        )},
        ),
            #className=class_choice
        ))

    return graphs



if __name__ == '__main__':
    app.run_server(debug=True,
                   port=8050)