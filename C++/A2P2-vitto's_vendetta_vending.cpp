//Program Name   : A2P2-vitto's_vendetta_vending
//Programmer Name: Todd Pidgeon
//Overview       : Simulates a vending machine
//Date Written   : 02/02/2016
//Date Modified  : 02/07/2016

#include <iostream>
#include <string>
#include <iomanip>
#include <conio.h>
#include <windows.h>

using namespace std;

//Function to use Goto X Y 
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;  //column coordinate
	coord.Y = y;	//row coordinate
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

//Function to use Goto X Y 
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

// Opening welcome screen with 2 second timed delay.
void greetings()
{
	gotoxy(30, 10);
	cout << "Welcome to Vitto's!";
	gotoxy(30, 14);
	cout << "Mangiare, Mangiare!";
	Sleep(2000);
}

// Function to display the amount of items purchased.
void thanks_for_shopping(int purchases)
{
	clrscr(0, 4);
	gotoxy(15, 8);
	cout << "You have purchased " << purchases << " item(s).";
	gotoxy(15, 10);
	cout << "Thank You for Shopping at Vitto's!";
}

// Function that displays the menu and allows for selections.
void updat_vending(string choice_array[], string item_name_array[], string price_array[], int qty_array[])
{
	// Variable declairations
	int x_co1 = 7;
	int y_co1 = 4;
	int x_co2 = 17;
	int x_co3 = 39;
	int x_co4 = 51;
	char selection = ' ';
	int purchases = 0;
	int selection_control;
	int y_co_control;

	// Displays the menu
	clrscr(0, 0);
	gotoxy(17, 2);
	cout << "VITTO'S VENDETTA VENDING";
	gotoxy(2, 3);
	cout << "======================================================";
	gotoxy(5, 4);
	cout << "CHOICE       ITEM NAME            PRICE      QTY";
	gotoxy(2, 5);
	cout << "======================================================";

	for (int cnt1 = 0; cnt1 < 8; cnt1++)
	{
		y_co1 += 2;
		gotoxy(x_co1, y_co1);
		cout << choice_array[cnt1] << ".";
		gotoxy(x_co2, y_co1);
		cout << item_name_array[cnt1];
		gotoxy(x_co3, y_co1);
		if (cnt1 < 7)
		{
			cout << "$" << price_array[cnt1];
			gotoxy(x_co4, y_co1);
			cout << qty_array[cnt1];
		}
	}

	// Sets the prompt for user input
	gotoxy(20, 23);
	cout << "Select an item:";

	// User only need to hit the desired selection and the action takes place
	while (selection != 'e')
	{
		gotoxy(36, 23);
		selection = _getch();
		selection = tolower(selection);
		selection_control = selection - 49;
		y_co_control = selection_control * 2 + 6;

		if (qty_array[selection_control] < 1)
		{
			gotoxy(37, 23);
			cout << "SOLD OUT";
			Sleep(500);
			clrscr(37, 23);
		}
		else if (qty_array[selection_control] == 1)
		{
			purchases += 1;
			gotoxy(50, y_co_control);
			cout << "OUT";
			qty_array[selection_control] --;
		}
		else
		{
			// Switch to determine the remaining quantity
			switch (selection)
			{
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
				if (qty_array[selection_control] < 6 && qty_array[selection_control] > 0)
				{
					qty_array[selection_control] --;
					gotoxy(51, y_co_control);
					cout << qty_array[selection_control];
					purchases += 1;
					break;
				}

			case 'e':
				break;
			default:
				gotoxy(37, 23);
				cout << "Invalid selection.";
				Sleep(500);
				clrscr(37, 23);
				break;
			}
		}
	}
		

	thanks_for_shopping(purchases);
}

int main()
{
	char run_again = 'y';

	greetings();

	while (run_again == 'y')
	{
		// Variable declarations
		bool done = false;
		string choice_array[8] = { "1", "2", "3", "4", "5", "6", "7", "E" };
		string item_name_array[8] = { "Soprano Soup", "Godfather Pasta", "Gotti Gum", "Capone Crisps", "Gambino Pie", "Luciano Lunch", "Mafia Muffin", "No More Purchases" };
		string price_array[7] = { "4.75", "5.85", "2.50", "3.00", "6.75", "8.50", "1.75" };
		int qty_array[7] = { 5, 5, 5, 5, 5, 5, 5 };

		updat_vending(choice_array, item_name_array, price_array, qty_array);

		// Asks user if they want to run the program again
		while (done != true)
		{
			gotoxy(2, 16);
			cout << "======================================================";
			gotoxy(6, 17);
			cout << "Run the program again? (y/n): ";
			cin >> run_again;
			run_again = tolower(run_again);

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
				gotoxy(36, 17);
				cout << "Invalid choice (y/n)";
				Sleep(500);
				clrscr(36, 17);
				break;
			}
		}
	}

	// Program end 
	cin.ignore();
	gotoxy(2, 18);
	cout << "======================================================";
	gotoxy(6, 20);
	cout << "I made you an offer you couldn't refuse.";
	gotoxy(6, 21);
	cout << "Press any key to exit";
	cin.get();

	return 0;
}