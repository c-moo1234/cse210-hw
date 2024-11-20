using System;

class Program
{
    static void Main(string[] args)
    {
        Job myJob = new Job();
        myJob._company = "Tche";
        myJob._jobTitle = "Gaucho";
        myJob._startYear = 2023;
        myJob._endYear = 2024;
        // myJob.Display();

        Job myJob2 = new Job();
        myJob2._company = "Cinamark";
        myJob2._jobTitle = "Cashier";
        myJob2._startYear = 2015;
        myJob2._endYear = 2020;

        Job myJob3 = new Job();
        myJob3._company = "Delta";
        myJob3._jobTitle = "Baggage Handler";
        myJob3._startYear = 2020;
        myJob3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Cyrus";
        myResume._jobs.Add(myJob);
        myResume._jobs.Add(myJob2);
        myResume._jobs.Add(myJob3);
        myResume.Display();
    }
}