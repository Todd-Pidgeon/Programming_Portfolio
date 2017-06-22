
//Program Name   : A2P1-average_rainfall_v2
//Programmer Name: Todd Pidgeon
//Overview       : Calculates average rainfall
//Date Written   : 26/01/2016
//Date Modified  : 01/02/2016

#include <iostream>
#include <string>
#include <iomanip>
#include <conio.h>
#include <windows.h>

using namespace std;

// Function to use Goto X Y
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;  //column coordinate
	coord.Y = y;	//row coordinate
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

// Function to use Goto X Y
void clrscr(int x, int y)
{
	COORD                       coordScreen = { x, y };
	DWORD                       cCharsWritten;
	CONSOLE_SCREEN_BUFFER_INFO  csbi;
	DWORD                       dwConSize;
	HANDLE                      hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	GetConsoleScreenBufferInfo(hConsole, &csbi);
	dwConSize = csbi.dwSize.X * csbi.dwSize.Y;
	FillConsoleOutputCharacter(hConsole, TEXT(' '),
		dwConSize, coordScreen, &cCharsWritten);
	GetConsoleScreenBufferInfo(hConsole, &csbi);
	FillConsoleOutputAttribute(hConsole, csbi.wAttributes,
		dwConSize, coordScreen, &cCharsWritten);
	SetConsoleCursorPosition(hConsole, coordScreen);
}

// Asks the user for the rainfall for each month
void input_rainfall_data(string months[], int rainfall[])
{
	int month_counter = 0;
	int entry_counter = 0;
	int x_co1 = 20;
	int y_co1 = 4;
	int x_co2 = 40;
	int y_co2 = 4;

	gotoxy(25, 1);
	cout << "Rainfall Statistics";
	gotoxy(4, 2);
	cout << "===========================================================";

	gotoxy(21, 3);
	cout << "Month          Rainfall (mm)";

	while (month_counter < 12)
	{
		gotoxy(x_co1, y_co1);
		cout << months[month_counter] << ":";
		y_co1 += 1;
		month_counter++;
	}

	while (entry_counter < 12)
	{
		gotoxy(x_co2, y_co2);
		cin >> rainfall[entry_counter];
		y_co2 += 1;
		entry_counter++;
	}
			
}

// Process input data
void calculate_total_and_average_rainfall(int rainfall[],  float &total_rainfall, float &average_rainfall)
{
	int total_counter = 0;
	
	// Calculates the total rainfall
	while (total_counter < 12)
	{
		total_rainfall += rainfall[total_counter];
		total_counter++;
	}

	// Calculates the average rainfall
	average_rainfall = total_rainfall / 12;
}

// Finds the highest and lowest rainfall values
void determine_min_max_rainfall(int rainfall[], int &highest_rainfall, int &lowest_rainfall)
{
	int find_counter = 0;
	highest_rainfall = rainfall[0];
	lowest_rainfall = rainfall[0];
	
	while (find_counter < 12)
	{
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
}

// Outputs data
void output_rainfall_report(int rainfall[], string months[], float total_rainfall, float average_rainfall, int highest_rainfall, int lowest_rainfall)
{
	int hi_count = 0;
	int lo_count = 0;
	int out_x_co1 = 7;
	
	// Outputs the total and average rainfall values
	cout << setprecision(1) << fixed;
	gotoxy(out_x_co1, 18);
	cout << "Total Rainfall:  " << total_rainfall << " mm";
	gotoxy(out_x_co1, 19);
	cout << "Average Rainfall: " << average_rainfall << " mm";
	
	// Displays a message if all rainfall values are equal
	if (highest_rainfall == lowest_rainfall)
	{
		gotoxy(out_x_co1, 20);
		cout << "All months have the same amount of rainfall.";
	}
	// Finds which months are equal to the highest and lowest values and prints those months
	else
	{
		gotoxy(out_x_co1, 20);
		cout << "Month(s) with highest rainfall";
		while (hi_count < 12)
		{
			if (rainfall[hi_count] == highest_rainfall)
			{
				cout << ", " << months[hi_count];
			}
			hi_count++;
		}
		gotoxy(out_x_co1, 21);
		cout << "Month(s) with lowest rainfall";
		while (lo_count < 12)
		{
			if (rainfall[lo_count] == lowest_rainfall)
			{
				cout << ", " << months[lo_count];
			}
			lo_count++;
		}
	}
}

int main()
{	
	string months[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September"
		, "October", "November", "December"};
	char run_again = 'y';

	while (run_again == 'y')
	{
		int rainfall[12];
		float total_rainfall = 0.0;
		float average_rainfall = 0.0;
		int highest_rainfall = 0;
		int lowest_rainfall = 0;
		bool done = false;

		// Function calls
		input_rainfall_data(months, rainfall);
		calculate_total_and_average_rainfall(rainfall, total_rainfall, average_rainfall);
		determine_min_max_rainfall(rainfall, highest_rainfall, lowest_rainfall);
		output_rainfall_report(rainfall, months, total_rainfall, average_rainfall, highest_rainfall, lowest_rainfall);
		
		
		// Asks user if they want to run the program again
		while (done != true)
		{
			gotoxy(7, 23);
			cout << "Run the program again? (y/n): ";
			cin >> run_again;

			switch (run_again)
			{
			case 'y':
				clrscr(0, 0);
				done = true;
				break;
			case 'n':
				done = true;
				break;
			default:
				gotoxy(38, 23);
				cout << "Enter a valid choice (y/n)";
				Sleep(500);
				clrscr(38, 16);
				break;
			}
		}
	}
	
	// Program end 
	cin.ignore();
	gotoxy(7, 24);
	cout << "Press any key to exit";
	cin.get();

	return 0;
}