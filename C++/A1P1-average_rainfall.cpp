
//Program Name   : A1P1-average_rainfall
//Programmer Name: Todd Pidgeon
//Overview       : Caluculates average rainfall
//Date Written   : 16/01/2016
//Date Modified  : 19/01/2016

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
	//Variable declaration
	string months[12] {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September"
		, "October", "November", "December"};
	string run_again = "y";

	while (run_again == "y")
	{
		int rainfall[12];
		int month_counter = 0;
		int total_counter = 0;
		int highest_rainfall = 0;
		int lowest_rainfall = 0;
		float total_rainfall = 0;
		float average_rainfall = 0;
		int hi_count = 0;
		int lo_count = 0;
		int find_counter = 1;

		//Asks the user for the rainfall for each month
		while (month_counter < 12)
		{
			cout << "\n\n\t\tEnter the rain fall for the month of " << months[month_counter] << ":\t";
			cin >> rainfall[month_counter];
			month_counter++;
		}

		//Calculates the total rainfall
		while (total_counter < 12)
		{
			total_rainfall += rainfall[total_counter];
			total_counter++;
		}

		//Calculates the average rainfall
		average_rainfall = total_rainfall / 12;
		
		//Finds the highest and lowest rainfall values
		while (find_counter < 12)
		{
			highest_rainfall = rainfall[0];
			lowest_rainfall = rainfall[0];
			if (rainfall[find_counter] > highest_rainfall)
			{
				highest_rainfall = rainfall[find_counter];
			}
			if (rainfall[find_counter] < lowest_rainfall)
			{
				lowest_rainfall = rainfall[find_counter];
			}
			find_counter++;
		}

		//Outputs the total and average rainfall values
		cout << setprecision(1) << fixed;
		cout << "\n\n\t\tTotal Rainfall: " << total_rainfall;
		cout << "\n\n\t\tAverage Rainfall: " << average_rainfall;
		cout << "\n";
		//Displays a message if all rainfall values are equal
		if (highest_rainfall == lowest_rainfall)
		{
			cout << "\n\n\t\tAll months have the same amount of rainfall.";
		}
		//Finds which months are equal to the highest and lowest values and prints those months
		else
		{
			cout << "\n\n\t\tMonths with highest rainfall are";
			while (hi_count < 12)
				{
					if (rainfall[hi_count] == highest_rainfall)
					{
						cout << ", " << months[hi_count];
					}
					hi_count++;
				}

			cout << "\n\n\t\tMonths with lowest rainfall are";
			while (lo_count < 12)
				{
					if (rainfall[lo_count] == lowest_rainfall)
					{
						cout << ", " << months[lo_count];
					}
					lo_count++;
				}
		}

		//Asks user if they want to run the program again
		cout << "\n\n\n\n\t\tDo you wish to run the program again (y/n):";
		cin >> run_again;

	}
	
	//Program end 
	cin.ignore();
	cout << "\n\n\n\n\t\tPress any key to continue ";
	cin.get();

	return 0;
}