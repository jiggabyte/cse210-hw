
using System;
using System.Collections.Generic;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    protected override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
