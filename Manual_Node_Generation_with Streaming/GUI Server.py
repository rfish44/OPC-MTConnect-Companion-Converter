'''
Information:

@author: Ryan Fisher
@company: National Institute of Standards and Technology

The following code was generated mainly through open source code. Below is the link to find tutorials on how
to manipulate Dash by Plotly. These videos were used to guide the production of this GUI.

url: https://pythonprogramming.net/data-visualization-application-dash-python-tutorial-introduction/

This code produces a GUI that generates on graph based on a CSV file input.
Note: the "get_data" function is not used in this GUI
'''

import dash
from dash.dependencies import Output, Event
import dash_core_components as dcc
import dash_html_components as html
import plotly
import random
import plotly.graph_objs as go
from collections import deque
import csv

app = dash.Dash(__name__)

app.layout = html.Div(children=[
    html.H1(children='Plotting data from Server'),
    dcc.Graph(id='live-graph', animate = True),
    dcc.Interval(
        id='graph-update',
        interval = 1000
    ),
    ])
@app.callback(Output('live-graph', 'figure'),
              events = [Event('graph-update','interval')])


def update_graph():

    x,y = get_csv_data()

    data = go.Scatter(
        x = x,
        y = y,
        name = 'Scatter',
        mode = 'lines+markers'
        )

    return {'data':[data],'layout':go.Layout(xaxis = dict(range=[min(x),max(x)]),
                                             yaxis=dict(range=[min(y), max(y)]),)}
def get_data():
    '''
    This function takes in two text files filled with 'x' and 'y' values to be plotted.
    The files are continually opened to search for new data.

    The 'x' and 'y' values are returned as lists.
    '''
    fx = open(r'filepath and file', 'r')
    fy = open(r'filepath and file', 'r')
    if fx.mode == 'r':
        contentx = fx.readlines()
        contentxnew = []
        for i in contentx:
            contentxnew.append(float(i.replace('\n', ''))) # converts the string values to floats
        print("Content x: ",contentxnew)
    if fy.mode == 'r':
        contenty = fy.readlines()
        contentynew = []
        for i in contenty:
            contentynew.append(float(i.replace('\n', ''))) # converts the string values to floats
        print("Content y: ", contentynew)
    fx.close()
    fy.close()

    return (contentxnew,contentynew)
def get_csv_data():
    with open('DataLogger.csv') as csvfile:
        readCSV = csv.reader(csvfile, delimiter=',')
        values1 = []
        values2 = []
        for row in readCSV:
            if row[-1] != 'ServerTimeStamp':
                time = row[-1][14:19]
                time = time.replace(':', '.')
                timevalue = float(time)
                timeremainder = timevalue % 1
                timevalue = timevalue - timeremainder
                timeremainder = timeremainder * 5 / 3
                timevalue = timevalue + timeremainder
                values2.append(timevalue)
                print("THE TIME IS: ", timevalue)

            if row[2] != 'Value':
                values1.append(float(row[2]))
                print("The position is: ", row[2])

        y = values1
        x = values2

    csvfile.close()
    return (x,y)

if __name__ == '__main__':
    app.run_server(debug=True, port=8040)