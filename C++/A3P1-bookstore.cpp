//Program Name   : A3P1-bookstore.
//Programmer Name: Todd Pidgeon
//Overview       : Simulates a bookstore POS
//Date Written   : 02/09/2016
//Date Modified  : 02/10/2016

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

// Displays the Menu and titles.
void menu_display()
{
	gotoxy(2, 2);
	cout << " ISBN                Title                 Price          QTY         Total" << endl;
	cout << " ------------------------------------------------------------------------------";
}

// Calculates and then Displays totals.
void output_totals(double book_total[])
{
	double pretax_total = 0.0;
	const double hst = 0.13;
	double hst_total = 0.0;
	double final_total = 0.0;

	// totals all the books sold.
	for (int i = 0; i < 5; i++)
	{
		pretax_total += book_total[i];
	}

	// calculates the hst.
	hst_total = pretax_total * hst;

	// calculates the total with hst .
	final_total = pretax_total + hst_total;

	// outputs total to the screen.
	gotoxy(51, 17);
	cout << "PreTax Total   : $ " << pretax_total;
	gotoxy(51, 18);
	cout << "HST(13%)       : $ " << hst_total;
	gotoxy(51, 19);
	cout << "After Tax Total: $ " << final_total;
}

// captures users input, validates the input then outputs cosponsoring info. 
void input(const string isbn[], const string book_title[], const double retail[])
{
	// Variables.
	int input_cnt = 0;
	string isbn_input;
	int x_isbn_input = 2;
	int x_book = 14;
	int x_retail = 44;
	int x_qty_input = 60;
	int x_total = 70;
	int y_co1 = 5;
	int qty = 0;
	double book_total[5] = { 0.0, 0.0, 0.0, 0.0, 0.0 };
	bool isbn_used[5] = { false, false, false, false, false };
	char cont_or_total;

	// main input loop, ends once 5 books are processed or the user enters a 't' after processing a book.
	while (input_cnt < 5)
	{
		bool valid_isnb = true;
		int valid_isbn_cnt = 0;

		// wait for user to enter a valid ISBN.
		clrscr(0, y_co1);
		gotoxy(x_isbn_input, y_co1);
		cin >> isbn_input;

		// loop to validate the ISBN that has been entered.
		while (valid_isnb == true)
		{
			// this loop goes thought the valid ISBN array to see if the user entered ISBN matches any of the valid ones.
			while (valid_isbn_cnt < 5)
			{
				if (isbn_input == isbn[valid_isbn_cnt])
				{
					// this checks to see if the ISBN has already been entered and used. If it has an error is output.
					if (isbn_used[valid_isbn_cnt] == true)
					{
						gotoxy(x_isbn_input + 5, y_co1 + 2);
						cout << "*** ISBN Number already used. Hit any key to try again. ***";
						_getch();
						valid_isnb = false;
						break;
					}

					// this sets an corresponding array value to true to indicate that the ISBN has now been used.
					isbn_used[valid_isbn_cnt] = true;

					// output the book title and retail values.
					gotoxy(x_book, y_co1);
					cout << book_title[valid_isbn_cnt];
					gotoxy(x_retail, y_co1);
					cout << retail[valid_isbn_cnt];
					
					// this loop validates the users quantity input. if the entry is not a number an error is output.
					while (true)
					{
						gotoxy(x_qty_input, y_co1);
						cin >> qty;

						// if the input is valid continue with program.
						if (cin.good())
						{
							break;
						}

						// if the input is invalid(not a number) output error and restart loop.
						else
						{
							cin.clear();
							cin.ignore();
							gotoxy(x_qty_input - 35, y_co1 + 2);
							cout << "*** Enter a number. Hit any key to try again. ***";
							_getch();
							clrscr(x_qty_input, y_co1);
						}
					}

					// calculates the total sales price for all the books of this type purchased
					book_total[valid_isbn_cnt] = retail[valid_isbn_cnt] * qty;

					// outputs book total
					gotoxy(x_total, y_co1);
					cout << setprecision(2) << fixed;
					cout << book_total[valid_isbn_cnt];

					// wait for user to input a character. If a 't' is entered all of the current functions loops are broken 
					// and a call to the final totals function is made, any other character will prompt for the next ISBN.
					cont_or_total = _getch();
					if (cont_or_total == 't')
					{
						break;
					}

					// if a 't' is not entered a valid ISBN has been entered affecting a counter and breaking the validation loop. 
					// The program will then wait for another ISBN to be entered.
					y_co1 += 2;
					input_cnt += 1;
					valid_isnb = false;
					break;
				}
				valid_isbn_cnt++;
			}

			// if an invalid ISBN number is entered an error will be displayed .
			if (cont_or_total == 't')
			{
				break;
			}
			else if (valid_isnb == true)
			{
				gotoxy(x_isbn_input + 5, y_co1 + 2);
				cout << "*** Invalid ISBN Number. Hit any key to try again. ***";
				_getch();
				clrscr(0, y_co1);
				break;
			}
		}
		if (cont_or_total == 't')
		{
			break;
		}
	}

	// once 5 valid ISBNs have been entered or the user hits 't' the final total function is called.
	output_totals(book_total);
}

int main()
{
	char run_again = 'y';

	// main program loop.
	while (run_again == 'y')
	{
		const string isbn[5] = { "11110", "12221", "13332", "24443", "25554" };
		const string book_title[5] = { "Binary Kibbles and Bits", "Underwater Googles", "Vitamin C++", "Surf and Turf the Web", "Jave-lin: Olympic Favourite" };
		const double retail[5] = { 155.95, 116.75, 126.50, 125.75, 138.99 };
		bool done = false;

		// function calls
		menu_display();
		input(isbn, book_title, retail);

		// Asks user if they want to run the program again.
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
				cin.clear();
				cin.ignore();
				gotoxy(36, 22);
				cout << "*** Invalid choice (y/n) ***";
				Sleep(500);
				clrscr(36, 22);
			}
		}
	}


	// Program ends and waits for the user to hit any key to close the program
	gotoxy(2, 23);
	cout << "------------------------------------------------------------------------------";
	gotoxy(6, 24);
	cout << "Press any key to exit";
	_getch();

	return 0;
}
