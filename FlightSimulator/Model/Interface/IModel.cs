﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FlightSimulator.Model.Interface
{
    public interface IModel : INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        // server
        void openServer();
        void closeSever();
      
        // clients
        void connectClient();

        bool isClientConnected();
        bool isServerOpen();
        void disconnectClient();
        void sendStringCommandsWithSleep(string command, int sleepTime);
        void sendStringCommand(string command);
 

        // properties
        double Throttle { get; set; }
        double Rudder { get; set; }
        double Aileron { get; set; }
        double Elevator { get; set; }
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
}
