using System;
using System.Collections.Generic;

class Running : Activity {
    private double distance; // in miles

// Constructor
    public Running(DateTime date, int minutes, double distance) 
        : base(date, minutes) {
        this.distance = distance;
    }
    
// Override the GetSummary method to include running-specific details
    public override double GetDistance() {
        return distance;
    }

// Override the GetSpeed method to return the speed of running
    public override double GetSpeed() {
        return (distance / Minutes) * 60; // mph
    }

// Override the GetPace method to return the pace of running
    public override double GetPace() {
        return Minutes / distance; // min per mile
    }
}