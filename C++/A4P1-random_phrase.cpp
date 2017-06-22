//Program Name   : A4P1-random_phrase
//Programmer Name: Todd Pidgeon
//Overview       : Creates 5 random phrases based on string arrays
//Date Written   : 02/23/2016
//Date Modified  : 02/26/2016

#include <iostream>
#include <string>
#include <iomanip>
#include <conio.h>
#include <windows.h>
#include <limits>

using namespace std;

//Function to use Goto X Y.
void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;  //column coordinate
	coord.Y = y;	//row coordinate
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

//Function to use Goto X Y.
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

void print_phrase(string phrase[])
{
	cout << "\n\n\n\t\t\t  Random Phrase Generator\n";
	cout << "  ---------------------------------------------------------------------------";
	for (int f = 0; f < 5; f++)
	{
		cout << "\n\n\t\t" + phrase[f];
	}

}

void create_phrase(string noun[], string verb_adj[])
{
	string phrase[5];
	int random_num_1;
	int random_num_2;
	int random_num_3;
	string full_phrase;
	string upper_case;
	string part_1;

	for (int phrase_cnt = 0; phrase_cnt < 5; phrase_cnt++)
	{
		random_num_1 = rand() % 6;
		random_num_2 = rand() % 3;

		while (true)
		{
			random_num_3 = rand() % 6;

			if (!(random_num_3 == random_num_1))
				break;
		}

		part_1 = noun[random_num_1];
		part_1[0] = toupper(part_1[0]);

		full_phrase = part_1 + " " + verb_adj[random_num_2] + " " + noun[random_num_3] + ".";

		phrase[phrase_cnt] = full_phrase;
	}

	print_phrase(phrase);
}

int main()
{
	char run_again = 'y';

	// Seeds the random number based on the computers time.
	srand(time(NULL));

	// main program loop.
	while (run_again == 'y')
	{
		string noun[6] = { "programmers", "snowboarders", "drummers", "networkers", "bass players", "engineers" };
		string verb_adj[3] = { "are tougher than", "are not as cool as", "are more popular than" };
		bool done = false;

		// function calls
		create_phrase(noun, verb_adj);

		// Asks user if they want to run the program again. Limited to one charater input, followed by enter.
		while (true)
		{
			char ent_return = ' ';
			gotoxy(2, 21);
			cout << "---------------------------------------------------------------------------";
			gotoxy(6, 22);
			cout << "Run the program again? (y/n): ";
			run_again = _getch();
			cout << run_again;
			run_again = tolower(run_again);

			while (ent_return != '\r')
			{
				ent_return = _getch();
			}

			// determines what to do based on users input.
			// 'y' will re-run the program.
			if (run_again == 'y')
			{
				clrscr(0, 0);
				break;
			}
			// 'n' will exit the main program loop.
			else if (run_again == 'n')
			{
				break;
			}
			// any other input will result in an error message.
			else
			{
				gotoxy(36, 22);
				cout << "*** Invalid choice (y/n) ***";
				Sleep(500);
				clrscr(36, 22);
			}
		}
	}


	// Program ends and waits for the user to hit any key to close the program
	gotoxy(2, 23);
	cout << "---------------------------------------------------------------------------";
	gotoxy(6, 24);
	cout << "Press any key to exit";
	_getch();

	return 0;
}
