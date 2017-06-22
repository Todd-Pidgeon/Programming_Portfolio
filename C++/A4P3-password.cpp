//Program Name   : A4P3-password
//Programmer Name: Todd Pidgeon
//Overview       : password Program
//Date Written   : 03/06/2016
//Date Modified  : 03/06/2016

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

void GetUsername(char name_input[])
{
	int name_cnt = 0;
	system("Color 0F");
	gotoxy(2, 2);
	cout << "----------------------------------------------------------------------------";
	gotoxy(18, 3);
	cout << "--- Top Secret Security Access Terminal ---";
	gotoxy(2, 4);
	cout << "----------------------------------------------------------------------------";
	clrscr(0, 5);
	gotoxy(15, 10);
	cout << "Username: ";

	while (true)
	{
		name_input[name_cnt] = _getche();

		if (name_input[name_cnt] == '\b' && name_cnt == 0)
		{
			_putch(' ');
			name_cnt--;
		}

		if (name_input[name_cnt] == '\r')
		{
			name_input[name_cnt] = '\0';
			break;
		}
		else if (name_input[name_cnt] == '\b')
		{
			_putch(' ');
			_putch('\b');
			name_cnt -= 2;
		}
		else if (name_cnt == 10)
		{
			cout << '\a';
			_putch('\b');
			_putch(' ');
			_putch('\b');
			name_cnt--;
		}
		name_cnt++;
	}
}

void GetPassword(char input_psw[])
{
	int psw_cnt = 0;
	bool bksp_check;

	gotoxy(15, 12);
	cout << "Password: ";

	while (true)
	{
		bksp_check = false;
		input_psw[psw_cnt] = _getch();
		
		if (input_psw[psw_cnt] == '\b' && psw_cnt == 0)
		{
			_putch(' ');
			_putch('\b');
			bksp_check = true;
			psw_cnt--;
		}
		
		if (input_psw[psw_cnt] == '\r')
		{
			input_psw[psw_cnt] = '\0';
			break;
		}
		else if (input_psw[psw_cnt] == '\b')
		{
			_putch('\b');
			_putch(' ');
			_putch('\b');
			psw_cnt -= 2;
		}
		else if (psw_cnt == 10)
		{
			cout << '\a';
			_putch(' ');
			_putch('\b');
			psw_cnt--;
		}
		else if (bksp_check == false)
		{
			_putch('*');
		}

		psw_cnt++;
	}
}

void CheckValidity(char name_input[], char input_psw[], string username[], string password[], int &attempts)
{
	bool name_match = false;
	bool pwd_match = false;
	int pwd_cnt = 0;
	char run_again;

	attempts++;

	for (int vname_cnt = 0; vname_cnt < 10; vname_cnt++)
	{
		if (name_input == username[vname_cnt])
		{
			name_match = true;
			pwd_cnt = vname_cnt;
			break;
		}
	}
	
	if (input_psw == password[pwd_cnt])
		{
			pwd_match = true;
		}

	if (name_match == true && pwd_match == true)
	{
		clrscr(0, 5);
		system("Color 2F");
		gotoxy(15, 10);
		cout << "\a\a\a\aYou have gained access.";

		while (true)
		{
			gotoxy(2, 21);
			cout << "------------------------------------------------------------------------------";
			gotoxy(6, 22);
			cout << "Run the program again? (y/n): ";
			cin >> run_again;
			run_again = tolower(run_again);

			// determines what to do based on users input.
			// 'y' will re-run the program.
			if (run_again == 'y')
			{
				attempts = 0;
				return;
			}
			else if (run_again == 'n')
			{
				exit(NULL);
			}
			else
			{
				cin.clear();
				cin.ignore();
				gotoxy(36, 22);
				cout << "*** Invalid choice (y/n) ***";
				Sleep(500);
				clrscr(36, 22);
			}
		}
	}
	else if (attempts == 3)
	{
		clrscr(0, 5);
		cout << "\a";
		system("Color 4F");
		gotoxy(15, 10);
		cout << "You are now locked out.";
		Sleep(1500);
		cout << "\a";
		system("Color F4");
		clrscr(0, 5);
		gotoxy(15, 10);
		cout << "You will never get in.";
		Sleep(1500);
		cout << "\a";
		system("Color 4F");
		cout << "\a";
		clrscr(0, 5);
		gotoxy(15, 10);
		cout << "We have traced your IP.";
		gotoxy(15, 12);
		cout << "Agents are on their way to apprehend you.";
		cout << "\a";

		gotoxy(2, 23);
		cout << "---------------------------------------------------------------------------";
		gotoxy(6, 24);
		cout << "Press any key to exit";
		_getch();
		exit(NULL);
	}
	else
	{
		clrscr(0, 5);
		gotoxy(15, 10);
		cout << "\aInvalid username or password";
		gotoxy(2, 23);
		cout << "---------------------------------------------------------------------------";
		gotoxy(6, 24);
		cout << "Press any key to continue";
		_getch();
	}
}

int main()
{
	
	char name_input[11];
	char input_psw[11];
	string username[10] = { "username0", "username1", "username2", "username3", "username4", "username5", "username6", "username7", "username8", "username9" };
	string password[10] = { "password0", "password1", "password2", "password3", "password4", "password5", "password6", "password7", "password8", "password9" };
	int attempts = 0;

	while (true)
	{
		GetUsername(name_input);
		GetPassword(input_psw);
		CheckValidity(name_input, input_psw, username, password, attempts);
	}
	

	string one = "Programming";
	string two = "in C++";
	string three = "is fun";

	two.replace(0, 3, two.substr(4, 4));

	cout << two;

	_getch();

	return 0;
}
