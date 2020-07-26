using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class TimeEntry
{
    private const float _billingRate = 180.00f;


    [Required]
    public string Project { get; set; }

    [Required]
    public string Task { get; set; }

    [Required]
    public string BillingArea { get; set; }

    public string EntryDate
    {
        get { return DateTime.Now.ToShortDateString(); }
        set { }
    }

    [Required]
    public IList<DateTime> AvailableTimes
    {
        get { return new List<DateTime>() { DateTime.Now } ; }
        set { }
    }

    [Required]
    public DateTime SelectedStartTime { get; set; }

    [Required]
    public DateTime SelectedEndTime { get; set; }

    public string Duration
    {
        get { return (SelectedEndTime - SelectedStartTime).ToString(); }
        set { }
    }

    [Required]
    public string Description { get; set; }

    public float BillingRate
    {
        get { return _billingRate; }
        set { }
    }

    public bool IsOutside { get; set; }
}


