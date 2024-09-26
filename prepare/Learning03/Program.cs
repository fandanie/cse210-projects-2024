using System;
class Job {
    public string _jobTitle;
    public string _jobCompany;
}
public class Program
{
	public static void Main()
	{		
		Job myJob = new Job();
		myJob._jobTitle = "Agent";
		myJob._jobCompany = "TP";
		
		Console.WriteLine("The name of the company is: " + (myJob._jobCompany));
		Console.WriteLine("My job title is: " + (myJob._jobTitle));
	}
}