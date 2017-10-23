﻿using AirlineTicketOffice.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirlineTicketOffice.Main.Services.Messenger
{
    public class MessageStatus
    {
        public string MessageStatusFromFlight { get; set; }
       
    }

    public class MessageSendPassenger
    {
        public PassengerModel SendPassenger { get; set; }
    }

    public class MessageBoughtTicket
    {
        public BoughtTicketModel BoughtTicketMessage { get; set; }
    }

    public class MessageAllTicket
    {
        public AllTicketsModel AllTicketMessage { get; set; }
    }

    public class MessageFlight
    {
        public FlightModel SendFlight { get; set; }
    }

    public class MessageFlightToNewTicket
    {
        public FlightModel SendFlightFromFlightVM { get; set; }
    }

    public class MessageSendCashier
    {
        public CashierModel SendCashier { get; set; }
    }

    public class MessageCashierToNewTicket
    {
        public CashierModel SendCashierFromCashierVM { get; set; }
    }
   
    public class MessagePassengerToNewTicket
    {
        public PassengerModel SendPassengerFromPassengerVM { get; set; }
    }
}
