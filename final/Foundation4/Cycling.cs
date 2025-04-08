using System;
using System.Collections.Generic;

class Cycling : Activity {
    private double speed; // in mph

// Constructor to initialize date, minutes, and speed
    public Cycling(DateTime date, int minutes, double speed) 
        : base(date, minutes) {
        this.speed = speed;
    }

// Override the GetSummary method to include cycling-specific details
    public override double GetDistance() {
        return (speed * Minutes) / 60; // miles
    }

// Override the GetSpeed method to return the speed of cycling
    public override double GetSpeed() {
        return speed;
    }

// Override the GetPace method to return the pace of cycling    
    public override double GetPace() {
        return 60 / speed; // min per mile (since speed = 60 / pace)
    }
}