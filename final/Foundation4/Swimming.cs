using System;
using System.Collections.Generic;


class Swimming : Activity {
    private int laps; // 50 meters per lap

// Constructor to initialize date, minutes, and laps
    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes) {
        this.laps = laps;
    }

// Override the GetSummary method to include swimming-specific details
    public override double GetDistance() {
        double meters = laps * 50;
        return (meters / 1000) * 0.62; // Convert to miles (1 km = 0.62 miles)
    }

    public override double GetSpeed() {
        return (GetDistance() / Minutes) * 60; // mph
    }

    public override double GetPace() {
        return Minutes / GetDistance(); // min per mile
    }
}
