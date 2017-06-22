//Program Name   : A4P1-Hangman
//Programmer Name: Todd Pidgeon
//Overview       : A Hangman Game
//Date Written   : 02/23/2016
//Date Modified  : 02/28/2016

#include <iostream>
#include <string>
#include <iomanip>
#include <conio.h>
#include <windows.h>
#include <limits>

using namespace std;

int hang_cnt;
int letter_match;
int choosen_cnt;
char letter_guess;

void GameMenu(string GameWords[]);
void GetLetterFromUser(string choosen_word, int word_length, string GameWords[], bool choosen_letters[]);

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

void DrawGallows()
{
	// Draws the horizontal bar of the gallows pole
	for (int hor_bar = 0; hor_bar < 9; hor_bar++)
	{
		gotoxy(46 + hor_bar, 9);
		cout << (char)220;
	}

	// Draws the vertical bar of the gallows pole
	for (int ver_bar = 0; ver_bar < 9; ver_bar++)
	{
		gotoxy(45, 17 - ver_bar);
		cout << (char)219;
	}

	// Draws the rope
	gotoxy(54, 10);
	cout << (char)179;
	// draws the base of the gallows pole
	gotoxy(44, 17);
	cout << (char)220;
	gotoxy(46, 17);
	cout << (char)220;
}

void GameOverMan(string GameWords[], string choosen_word)
{
	for (int draw_man = 1; draw_man < 5; draw_man++)
	{
		clrscr(0, 0);

		gotoxy(35, 2);
		cout << "HANGMAN!";
		gotoxy(2, 3);
		cout << "---------------------------------------------------------------------------";

		DrawGallows();

		// draw man
		gotoxy(54, 11);
		cout << (char)1;
		gotoxy(54, 12);
		cout << (char)245;

		gotoxy(54, 12 + draw_man);
		cout << (char)219;
		gotoxy(53, 12 + draw_man);
		cout << '/';
		gotoxy(55, 12 + draw_man);
		cout << '\\';
		gotoxy(53, 13 + draw_man);
		cout << '/';
		gotoxy(55, 13 + draw_man);
		cout << '\\';

		cout << '\a';

		gotoxy(32, 19);
		cout << "*** Game Over! ***";
		gotoxy(21, 20);
		cout << "*** The correct word was: " << choosen_word << " ***";
		gotoxy(12, 21);
		cout << "*** You Lose, you are hanged from your neck until dead! ***";

		Sleep(300);
	}

	clrscr(0, 0);

	gotoxy(35, 2);
	cout << "HANGMAN!";
	gotoxy(2, 3);
	cout << "---------------------------------------------------------------------------";

	DrawGallows();

	// draw man
	gotoxy(54, 11);
	cout << (char)1;
	gotoxy(54, 12);
	cout << (char)245;

	gotoxy(53, 17);
	cout << (char)220;
	gotoxy(54, 17);
	cout << (char)220;
	gotoxy(55, 17);
	cout << (char)205;
	gotoxy(56, 17);
	cout << (char)205;

	cout << '\a';
	cout << '\a';
	cout << '\a';

	gotoxy(31, 19);
	cout << "*** Oops ***";
	gotoxy(26, 21);
	cout << "*** Game Over Man! ***";

	gotoxy(6, 24);
	cout << "Press any key to return to main menu";
	_getch();
	GameMenu(GameWords);
}

void DrawHangman(string choosen_word, int word_length, string GameWords[], bool choosen_letters[])
{
	hang_cnt += 1;
	
	// Draws the hang man characters base on the counter.
	switch (hang_cnt)
	{
	case 1:
		gotoxy(54, 11);
		cout << (char)1;
		cout << '\a';
		break;
	case 2:
		gotoxy(54, 12);
		cout << (char)219;
		cout << '\a';
		break;
	case 3:
		gotoxy(53, 12);
		cout << '/';
		cout << '\a';
		break;
	case 4:
		gotoxy(55, 12);
		cout << '\\';
		cout << '\a';
		break;
	case 5:
		gotoxy(53, 13);
		cout << '/';
		cout << '\a';
		break;
	case 6:
		gotoxy(55, 13);
		cout << '\\';
		cout << '\a';
		clrscr(12, 19);
		
		// Display the full word
		
		gotoxy(32, 19);
		cout << "*** Game Over! ***";
		gotoxy(21, 20);
		cout << "*** The correct word was: " << choosen_word << " ***";
		gotoxy(12, 21);
		cout << "*** You Lose, you are hanged from your neck until dead! ***";
		gotoxy(2, 23);
		cout << "---------------------------------------------------------------------------";
		gotoxy(6, 24);
		cout << "Press any key to continue";
		_getch();

		GameOverMan(GameWords, choosen_word);
	}
	GetLetterFromUser(choosen_word, word_length, GameWords, choosen_letters);
}

void LetterMatchInWord(char letter_guess, string choosen_word, int word_length, string GameWords[], bool choosen_letters[])
{
	bool match_check = false;
	
	// Checks to see if the letter chosen is in the word
	// uses the .find() function.
	for (int match_cnt = 0; match_cnt < word_length; match_cnt++)
	{
		if (match_cnt == choosen_word.find(letter_guess, match_cnt))
		{
			gotoxy((match_cnt * 2) + 15, 11);
			cout << letter_guess;
			match_check = true;
			letter_match++;
		}
		// Original code without the .find() function.
		/*
		if (letter_guess == choosen_word[match_cnt])
		{
			gotoxy((match_cnt * 2) + 15, 11);
			cout << letter_guess;
			match_check = true;
			letter_match++;
		}
		*/
	}
	
	// If the letter is a match and is the last letter needed game is won.
	if (letter_match == word_length)
	{
		clrscr(12, 19);
		gotoxy(17, 20);
		cout << "<<< You Win! You survive... For now... >>>";
		gotoxy(2, 23);
		cout << "---------------------------------------------------------------------------";
		gotoxy(6, 24);
		cout << "Press any key to return to main menu";
		_getch();
		GameMenu(GameWords);
	}
	
	// if not a match goes to the DrawHanmgan function.
	if (match_check == false)
	{
		gotoxy(12, 21);
		cout << "*** Sorry not a match, you're one step closer to death! ***";
		DrawHangman(choosen_word, word_length, GameWords, choosen_letters);
	}
	// if is a match but not the last letter this will goto the user input function.
	else
		GetLetterFromUser(choosen_word, word_length, GameWords, choosen_letters);

}

void GetLetterFromUser(string choosen_word, int word_length, string GameWords[], bool choosen_letters[])
{
	bool letter_used;
	letter_guess = ' ';

	// Asks user for input.
	while (true)
	{
		letter_used = false;
		gotoxy(12, 19);
		cout << "Guess a letter: ";
		letter_guess = _getch();
		clrscr(28, 19);
		letter_guess = toupper(letter_guess);
		
		// Checks to see if the letter input was already used.
		// this will now have repeated correct letter not cause a hangman but incorrect letters entered twice will cause 
		if (choosen_letters[letter_guess - 65] == true)
			{
				gotoxy(29, 20);
				cout << "*** You tried that already ***";
				// Sleep(600);
				// clrscr(29, 19);
				letter_used = true;
				// maybe change this to the drawhangman() function
				// LetterMatchInWord(letter_guess, choosen_word, word_length, GameWords, choosen_letters);
				DrawHangman(choosen_word, word_length, GameWords, choosen_letters);
			}
		
		choosen_letters[letter_guess - 65] = true;
		
		// if the letter input has not yet been used it will move on to the next function.
		if (letter_used == false)
		{
			if (letter_guess >= 65 && letter_guess <= 90)
			{
				gotoxy((letter_guess - 64) * 2 + 11, 5);
				cout << ' ';
				LetterMatchInWord(letter_guess, choosen_word, word_length, GameWords, choosen_letters);
			}
			// Validates whether the char entered is a letter or not.
			else
			{
				gotoxy(29, 20);
				cout << "*** Not a letter ***";
			    // Sleep(500);
				// clrscr(29, 19);
				DrawHangman(choosen_word, word_length, GameWords, choosen_letters);
			}

		}
	}
}

void StartNewGame(string GameWords[], bool choosen_letters[])
{
	char letter;
	int random_num_1;
	string choosen_word;
	int word_length;

	clrscr(0, 0);
	gotoxy(35, 2);
	cout << "HANGMAN!";
	gotoxy(2, 3);
	cout << "---------------------------------------------------------------------------";

	// Draws the alphabet across the top of the screen.
	for (int alpha_cnt = 0; alpha_cnt < 26; alpha_cnt++)
	{
		letter = alpha_cnt + 65;
		gotoxy(13 + alpha_cnt * 2, 5);
		cout << letter;
	}

	DrawGallows();
	
	// Picks a random number to be used to select a random word.
	random_num_1 = rand() % 10;
	choosen_word = GameWords[random_num_1];
	
	// Find the length of the chosen word.
	word_length = choosen_word.length();

	// Prints the right amount of dashes to signify the missing letter for the word.
	for (int dash_cnt = 0; dash_cnt < word_length; dash_cnt++)
	{
		gotoxy(15 + dash_cnt * 2, 12);
		cout << "-";
	}

	GetLetterFromUser(choosen_word, word_length, GameWords, choosen_letters);
}

void GameMenu(string GameWords[])
{
	char play_exit = ' ';

	clrscr(0, 0);
	letter_match = 0;
	hang_cnt = 0;
	choosen_cnt = 0;
	letter_guess = ' ';
	bool choosen_letters[26] = { false, false, false, false, false, false, false, false, false, false, 
		false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

	gotoxy(35, 2);
	cout << "HANGMAN!";
	gotoxy(2, 3);
	cout << "---------------------------------------------------------------------------";

	gotoxy(30, 10);
	cout << "1. NEW GAME";
	gotoxy(30, 11);
	cout << "E. EXIT";

	gotoxy(25, 16);
	cout << "What do wish to do?: ";
	while (true)
	{
		gotoxy(46, 16);
		play_exit = _getch();
		play_exit = tolower(play_exit);

		if (play_exit == '1')
		{
			StartNewGame(GameWords, choosen_letters);
		}
		else if (play_exit == 'e')
		{
			exit(NULL);
		}
		else
		{
			gotoxy(46, 16);
			cout << "*** Invalid choice (1/E) ***";
			Sleep(500);
			clrscr(46, 16);
		}
	}
}

int main()
{

	// Seeds the random number based on the computers time.
	srand(time(NULL));

	// main program loop.
	string GameWords[10] = { "NOTES", "PACKAGE", "WOBBLY", "KANGAROO", "BEYOND", "WITHIN", "NEVERMORE", "HARBRINGER", "NEMISIS", "QUINTESSENTIAL" };
		
	// function calls
	GameMenu(GameWords);
	
	return 0;
}
