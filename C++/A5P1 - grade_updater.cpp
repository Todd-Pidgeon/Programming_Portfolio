// Program name: grade_updater.cpp
// Programmer name: Todd Pidgeon
// Purpose: 
// Date submitted: 4/15/2016

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <conio.h>
#include <windows.h>
#include <sstream>

using namespace std;

struct student
{
	int student_number;
	char first_name[15];
	char last_name[15];
	int assignment;
	int midterm;
	int final_test;
	float overall_average;
	char letter_grade;
};

void main_menu(void);
void create_class_file(void);
void run_view_class(void);
void view_class(void);
void determine_file_size(void);
void add_student(void);
void run_view_student(void);
void view_student(void);
void update_student(void);
void update_class(void);
void grade_calc(int cur_assingment, int cur_midterm, int cur_final, float &overall, char &letter_grade, bool &value_check);

fstream class_file;

string file_name = "class_file";
int number_of_records;

student student_record[25];

void gotoxy(int x, int y)
{
	COORD coord;
	coord.X = x;  //column coordinate
	coord.Y = y;	//row coordinate
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

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

int main()
{
	main_menu();

	return 0;
}

void main_menu()
{
	int menu_y = 6;
	int menu_x = 28;
	char option;
	bool file_made = false;

	determine_file_size();

	while (true)
	{
		class_file.open(file_name + ".dat", ios::binary | ios::in);

		if (class_file.is_open())
		{
			file_made = true;
			class_file.close();
		}
		else
			// class_file.close();

		clrscr(0, 0);
		gotoxy(20, 2);
		cout << "*** Welcome to the Class Updater ***";
		gotoxy(menu_x, menu_y);
		cout << "1. Create class file.";
		gotoxy(menu_x, menu_y + 2);
		cout << "2. Add a student.";
		gotoxy(menu_x, menu_y + 4);
		cout << "3. Update class data.";
		gotoxy(menu_x, menu_y + 6);
		cout << "4. Update student data.";
		gotoxy(menu_x, menu_y + 8);
		cout << "5. View class data.";
		gotoxy(menu_x, menu_y + 10);
		cout << "6. View student data.";
		gotoxy(menu_x, menu_y + 12);
		cout << "7. Exit.";

		gotoxy(menu_x, menu_y + 15);
		cout << "Option: ";
		gotoxy(menu_x + 9, menu_y + 15);
		option = _getch();

		switch (option)
		{
		case '1':
			create_class_file();
			break;
		case '2':
			if (file_made == false)
			{
				gotoxy(menu_x + 9, menu_y + 15);
				cout << "No class file has been created.";
				Sleep(500);
				break;
			}
			else
			{
				add_student();
				break;
			}
		case '3':
			if (file_made == false)
			{
				gotoxy(menu_x + 9, menu_y + 15);
				cout << "No class file has been created.";
				Sleep(500);
				break;
			}
			else
			{
				update_class();
				break;
			}
		case '4':
			if (file_made == false)
			{
				gotoxy(menu_x + 9, menu_y + 15);
				cout << "No class file has been created.";
				Sleep(500);
				break;
			}
			else
			{
				update_student();
				break;
			}
		case '5':
			if (file_made == false)
			{
				gotoxy(menu_x + 9, menu_y + 15);
				cout << "No class file has been created.";
				Sleep(500);
				break;
			}
			else
			{
				gotoxy(menu_x + 9, menu_y + 15);
				run_view_class();
				break;
			}
		case '6':
			if (file_made == false)
			{
				gotoxy(menu_x + 9, menu_y + 15);
				cout << "No class file has been created.";
				Sleep(500);
				break;
			}
			else
			{
				run_view_student();
				break;
			}
		case '7':
			exit(1);
		}
	}
}

void create_class_file()
{
	student student_record[25] =
	{
		{ 1, "Todd", "Pidgeon", -1, -1, -1, -1, 'N' },
		{ 2, "Kerry", "Smith", -1, -1, -1, -1, 'N' },
		{ 3, "Bill", "Octorus", -1, -1, -1, -1, 'N' },
		{ 4, "Sam", "Salt", -1, -1, -1, -1, 'N' },
		{ 5, "Tom", "Flight", -1, -1, -1, -1, 'N' },
	};

	char add_exit;

	clrscr(0, 0);
	gotoxy(29, 2);
	cout << "*** CREATE NEW CLASS FILE ***";

	gotoxy(7, 12);
	cout << "Are you sure you wish to create a new class file? (y/n): ";
	while (true)
	{
		gotoxy(65, 12);
		add_exit = _getch();
		add_exit = tolower(add_exit);

		if (add_exit == 'y')
		{
			break;
		}
		if (add_exit == 'n')
		{
			main_menu();
		}
		else
		{
			gotoxy(50, 14);
			cout << "*** Invalid choice (y/n) ***";
			Sleep(500);
			clrscr(65, 12);
		}
	}

	clrscr(0, 0);

	gotoxy(25, 2);
	cout << "*** CREATE NEW CLASS FILE ***";

	gotoxy(15, 10);
	// cout << "Choose a class file name: ";
	cout << "Class file has been created.";
	gotoxy(43, 10);
	// cin >> file_name;

	class_file.open(file_name + ".dat", ios::binary | ios::out);

	for (int x = 0; x < 5; x++)
	{
		class_file.write((char *)&student_record[x], sizeof(student));
	}

	class_file.close();

	gotoxy(20, 23);
	cout << "Any key to return to main menu." << endl;
	gotoxy(0, 0);
	_getch();

	clrscr(0, 0);
	
	main_menu();
}

void view_class()
{
	int i = 0;
	
	clrscr(0, 0);
	gotoxy(1, 4);
	cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
	gotoxy(1, 5);
	cout << "| Stu |   First Name  |   Last Name   | Assig | Midterm | Final | Avg |  Ltr  |";
	gotoxy(1, 6);
	cout << "| Num |               |               |       |         | Test  |     | Grade |";
	gotoxy(1, 7);
	cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";

	class_file.open(file_name + ".dat", ios::binary | ios::in);

	if (class_file.is_open())
	{
		do
		{
			class_file.read((char *)&student_record[i], sizeof(student));
			i++;
		} while (!class_file.eof());

		class_file.close();

		for (int x = 0; x < number_of_records; x++)
		{
			gotoxy(1, 8 + x);
			cout << "|     |               |               |       |         |       |     |       |";

			gotoxy(4, 8 + x);
			cout << student_record[x].student_number;
			gotoxy(8, 8 + x);
			cout << student_record[x].first_name;
			gotoxy(24, 8 + x);
			cout << student_record[x].last_name;;

			if (student_record[x].assignment == -1)
			{
				gotoxy(42, 8 + x);
				cout << "N/A";
			}
			else
			{
				gotoxy(42, 8 + x);
				cout << student_record[x].assignment;
			}
			
			if (student_record[x].midterm == -1)
			{
				gotoxy(51, 8 + x);
				cout << "N/A";
			}
			else
			{
				gotoxy(51, 8 + x);
				cout << student_record[x].midterm;
			}

			if (student_record[x].final_test == -1)
			{
				gotoxy(60, 8 + x);
				cout << "N/A";
			}
			else
			{
				gotoxy(60, 8 + x);
				cout << student_record[x].final_test;
			}

			if (student_record[x].overall_average == -1)
			{
				gotoxy(67, 8 + x);
				cout << "N/A";
			}
			else
			{
				gotoxy(66, 8 + x);
				cout << fixed << setprecision(1) << student_record[x].overall_average;
			}

			if (student_record[x].letter_grade == 'N')
			{
				gotoxy(74, 8 + x );
				cout << "N/A";
			}
			else
			{
				gotoxy(75, 8 + x);
				cout << student_record[x].letter_grade;
			}

			gotoxy(1, 9 + x);
		}
		cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
	}
	else
		cout << "\n\n\n\t\tUnable to open file";
}

void run_view_class()
{
	view_class();

	gotoxy(29, 2);
	cout << "*** VIEW CLASS DATA ***";

	gotoxy(20, 23);
	cout << "Any key to return to main menu." << endl;
	gotoxy(0, 0);
	_getch();

	main_menu();
}

void determine_file_size()
{
	int file_size = 0;

	ifstream class_size(file_name + ".dat", ios::ate);

	clrscr(0, 0);

	if (class_size.is_open())
	{
		file_size = class_size.tellg();
	}
	else
		cout << "\n\n\n\t\tUnable to open file";

	number_of_records = file_size / sizeof(student);

	class_size.close();
}

void add_student()
{
	student student_rec;
	char letter_grade, add_exit;

	clrscr(0, 0);
	gotoxy(29, 2);
	cout << "*** ADD A NEW STUDENT ***";

	gotoxy(10, 12);
	cout << "Are you sure you wish to add a new student? (y/n): " ;
	while (true)
	{
		gotoxy(62, 12);
		add_exit = _getch();
		add_exit = tolower(add_exit);

		if (add_exit == 'y')
		{
			break;
		}
		if (add_exit == 'n')
		{
			main_menu();
		}
		else
		{
			gotoxy(50, 14);
			cout << "*** Invalid choice (y/n) ***";
			Sleep(500);
			clrscr(62, 12);
		}
	}
	class_file.open(file_name + ".dat", ios::app);

	number_of_records += 1;

	if (class_file.is_open())
	{
		clrscr(0, 0);

		gotoxy(29, 2);
		cout << "*** ADD A NEW STUDENT ***";

		gotoxy(15, 12);
		cout << "<<< Enter in student name. >>>";

		gotoxy(1, 4);
		cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
		gotoxy(1, 5);
		cout << "| Stu |   First Name  |   Last Name   | Assig | Midterm | Final | Avg |  Ltr  |";
		gotoxy(1, 6);
		cout << "| Num |               |               |       |         | Test  |     | Grade |";
		gotoxy(1, 7);
		cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
		gotoxy(1, 9);
		cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
		gotoxy(1, 8);
		cout << "|     |               |               |       |         |       |     |       |";
		
		class_file.seekp((number_of_records)* sizeof(student), ios::beg);
		gotoxy(4, 8);
		cout << number_of_records;
		student_rec.student_number = number_of_records;
				
		gotoxy(8, 8);
		cin >> student_rec.first_name;
		gotoxy(24, 8);
		cin >> student_rec.last_name;
		gotoxy(42, 8);
		cout << "N/A";
		gotoxy(51, 8);
		cout << "N/A";
		gotoxy(60, 8);
		cout << "N/A";
		gotoxy(67, 8);
		cout << "N/A";
		gotoxy(74, 8);
		cout << "N/A";

		student_rec.assignment = -1;
		student_rec.midterm = -1;
		student_rec.final_test = -1;
		student_rec.overall_average = -1;
		student_rec.letter_grade = 'N';
	
		class_file.write((char *)&student_rec, sizeof(student));
	}
	else
		cout << "\n\n\n\t\tUnable to open file";

	class_file.close();

	gotoxy(20, 23);
	cout << "Any key to return to main menu." << endl;
	gotoxy(0, 0);
	_getch();

	main_menu();
}

void view_student(int stu_num, student student_rec)
{

	class_file.open(file_name + ".dat", ios::binary | ios::in);

	if (class_file.is_open())
	{
		class_file.seekg((stu_num - 1) * sizeof(student), ios::beg);
	}
	else
		cout << "\n\n\n\t\tUnable to open file";

	class_file.read((char *)&student_rec, sizeof(student));

	class_file.close();

	clrscr(0, 0);
	gotoxy(1, 4);
	cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
	gotoxy(1, 5);
	cout << "| Stu |   First Name  |   Last Name   | Assig | Midterm | Final | Avg |  Ltr  |";
	gotoxy(1, 6);
	cout << "| Num |               |               |       |         | Test  |     | Grade |";
	gotoxy(1, 7);
	cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
	gotoxy(1, 9);
	cout << "+-----+---------------+---------------+-------+---------+-------+-----+-------+";
	gotoxy(1, 8);
	cout << "|     |               |               |       |         |       |     |       |";
	
	gotoxy(4, 8);
	cout << student_rec.student_number;
	gotoxy(8, 8);
	cout << student_rec.first_name;
	gotoxy(24, 8);
	cout << student_rec.last_name;

	if (student_rec.assignment == -1)
	{
		gotoxy(42, 8);
		cout << "N/A";
	}
	else
	{
		gotoxy(42, 8);
		cout << student_rec.assignment;
	}

	if (student_rec.midterm == -1)
	{
		gotoxy(51, 8);
		cout << "N/A";
	}
	else
	{
		gotoxy(51, 8);
		cout << student_rec.midterm;
	}

	if (student_rec.final_test == -1)
	{
		gotoxy(60, 8);
		cout << "N/A";
	}
	else
	{
		gotoxy(60, 8);
		cout << student_rec.final_test;
	}

	if (student_rec.overall_average == -1)
	{
		gotoxy(67, 8);
		cout << "N/A";
	}
	else
	{
		gotoxy(66, 8);
		cout << fixed << setprecision(1) << student_rec.overall_average;
	}

	if (student_rec.letter_grade == 'N')
	{
		gotoxy(74, 8);
		cout << "N/A";
	}
	else
	{
		gotoxy(75, 8);
		cout << student_rec.letter_grade;
	}

}

void run_view_student()
{
	student student_rec = {};
	int stu_num;

	clrscr(0, 0);

	gotoxy(29, 2);
	cout << "*** VIEW STUDENT DATA ***";

	gotoxy(15, 10);
	cout << "Student number: ";
	cin >> stu_num;

	view_student(stu_num, student_rec);

	gotoxy(29, 2);
	cout << "*** VIEW STUDENT DATA ***";

	gotoxy(20, 23);
	cout << "Any key to return to main menu." << endl;
	gotoxy(0, 0);
	_getch();

	main_menu();
}

void update_student()
{
	int stu_num;
	student student_rec = {};
	bool menu = true;
	char option;
	string user_input = "";

	float cur_overall;
	int cur_assingment, cur_midterm, cur_final;
	bool value_check;
	char letter_grade;

	clrscr(0, 0);
	gotoxy(29, 2);
	cout << "*** UPDATE STUDENT DATA ***";
	gotoxy(15, 10);
	cout << "Student number to update: ";
	cin >> stu_num;

	view_student(stu_num, student_rec);
	
	class_file.open(file_name + ".dat", ios::binary | ios::in | ios::out);

	if (class_file.is_open())
	{
		class_file.seekg((stu_num - 1) * sizeof(student), ios::beg);
		class_file.read((char *)&student_rec, sizeof(student));
	}
	else
		cout << "\n\n\n\t\tUnable to open file";
	
	gotoxy(29, 2);
	cout << "*** UPDATE STUDENT DATA ***";

	cin.ignore();

	while (menu == true)
	{
		gotoxy(45, 14);
		cout << "1. Update Assignment grade.";
		gotoxy(45, 16);
		cout << "2. Update Midterm grade.";
		gotoxy(45, 18);
		cout << "3. Update Final Test grade.";
		gotoxy(45, 20);
		cout << "4. Save and Return to main menu.";
		gotoxy(45, 22);
		cout << "Option: ";

		option = _getch();
		
		switch (option)
		{
		case '1':
			user_input = "";
			gotoxy(42, 8);
			cout << "   ";
			gotoxy(42, 8);
			
			getline(cin, user_input);

			if (user_input == "")
			{
				if (student_rec.assignment == -1)
				{
					gotoxy(42, 8);
					cout << "N/A";
				}
				else
				{
					gotoxy(42, 8);
					cout << student_rec.assignment;
				}
			}
			else
				istringstream(user_input) >> student_rec.assignment;

			value_check = false;
			cur_assingment = student_rec.assignment;
			cur_midterm = student_rec.midterm;
			cur_final = student_rec.final_test;
			cur_overall = student_rec.overall_average;
			letter_grade = student_rec.letter_grade;

			grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

			if (value_check == false)
			{
				student_rec.overall_average = cur_overall;
				student_rec.letter_grade = letter_grade;

				gotoxy(66, 8);
				cout << "   ";
				gotoxy(66, 8);
				cout << fixed << setprecision(1) << student_rec.overall_average;

				gotoxy(74, 8);
				cout << "   ";
				gotoxy(75, 8);
				cout << student_rec.letter_grade;
			}
			
			break;
		case '2':
			user_input = "";
			gotoxy(51, 8);
			cout << "   ";
			gotoxy(51, 8);
			
			getline(cin, user_input);

			if (user_input == "")
			{
				if (student_rec.midterm == -1)
				{
					gotoxy(51, 8);
					cout << "N/A";
				}
				else
				{
					gotoxy(52, 8);
					cout << student_rec.midterm;
				}
			}
			else
				istringstream(user_input) >> student_rec.midterm;

			value_check = false;
			cur_assingment = student_rec.assignment;
			cur_midterm = student_rec.midterm;
			cur_final = student_rec.final_test;
			cur_overall = student_rec.overall_average;
			letter_grade = student_rec.letter_grade;

			grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

			if (value_check == false)
			{
				student_rec.overall_average = cur_overall;
				student_rec.letter_grade = letter_grade;

				gotoxy(66, 8);
				cout << "   ";
				gotoxy(66, 8);
				cout << fixed << setprecision(1) << student_rec.overall_average;

				gotoxy(74, 8);
				cout << "   ";
				gotoxy(75, 8);
				cout << student_rec.letter_grade;
			}
			
			break;
		case '3':
			user_input = "";
			gotoxy(60, 8);
			cout << "   ";
			gotoxy(60, 8);
			
			getline(cin, user_input);

			if (user_input == "")
			{
				if (student_rec.midterm == -1)
				{
					gotoxy(60, 8);
					cout << "N/A";
				}
				else
				{
					gotoxy(61, 8);
					cout << student_rec.final_test;
				}
			}
			else
				istringstream(user_input) >> student_rec.final_test;

			value_check = false;
			cur_assingment = student_rec.assignment;
			cur_midterm = student_rec.midterm;
			cur_final = student_rec.final_test;
			cur_overall = student_rec.overall_average;
			letter_grade = student_rec.letter_grade;

			grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

			if (value_check == false)
			{
				student_rec.overall_average = cur_overall;
				student_rec.letter_grade = letter_grade;

				gotoxy(66, 8);
				cout << "   ";
				gotoxy(66, 8);
				cout << fixed << setprecision(1) << student_rec.overall_average;

				gotoxy(74, 8);
				cout << "   ";
				gotoxy(75, 8);
				cout << student_rec.letter_grade;
			}
			
			break;
		case '4':
			menu = false;
			break;
		}
	}

	if (class_file.is_open())
	{
		class_file.seekp((stu_num - 1) * sizeof(student), ios::beg);
		class_file.write((char *)&student_rec, sizeof(student));
	}
	else
		cout << "\n\n\n\t\tUnable to open file";

	class_file.close();

	main_menu();
}

void update_class()
{
	bool menu = true;
	char option;
	string user_input;

	float cur_overall;
	int cur_assingment, cur_midterm, cur_final;
	bool value_check;
	char letter_grade;

	view_class();

	gotoxy(29, 2);
	cout << "*** UPDATE CLASS DATA ***";

	while (menu == true)
	{
		gotoxy(45, 10 + number_of_records);
		cout << "1. Update Assignment grade.";
		gotoxy(45, 12 + number_of_records);
		cout << "2. Update Midterm grade.";
		gotoxy(45, 14 + number_of_records);
		cout << "3. Update Final Test grade.";
		gotoxy(45, 16 + number_of_records);
		cout << "4. Return to main menu.";
		gotoxy(45, 18 + number_of_records);
		cout << "Option: ";
		option = _getch();

		switch (option)
		{
		case '1':
			for (int i = 0; i < number_of_records; i++)
			{
				user_input = "";
				gotoxy(41, 8 + i);
				cout << "    ";
				gotoxy(42, 8 + i);

				getline(cin, user_input);

				if (user_input == "")
				{
					if (student_record[i].assignment == -1)
					{
						gotoxy(42, 8 + i);
						cout << "N/A";
					}
					else
					{
						gotoxy(42, 8 + i);
						cout << student_record[i].assignment;
					}
				}
				else
					istringstream(user_input) >> student_record[i].assignment;

				value_check = false;
				cur_assingment = student_record[i].assignment;
				cur_midterm = student_record[i].midterm;
				cur_final = student_record[i].final_test;
				cur_overall = student_record[i].overall_average;
				letter_grade = student_record[i].letter_grade;

				grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

				if (value_check == false)
				{
					student_record[i].overall_average = cur_overall;
					student_record[i].letter_grade = letter_grade;

					gotoxy(66, 8 + i);
					cout << "    ";
					gotoxy(66, 8 + i);
					cout << fixed << setprecision(1) << student_record[i].overall_average;

					gotoxy(74, 8 + i);
					cout << "   ";
					gotoxy(75, 8 + i);
					cout << student_record[i].letter_grade;
				}
			}
			break;
		case '2':
			for (int i = 0; i < number_of_records; i++)
			{
				user_input == "";
				gotoxy(51, 8 + i);
				cout << "   ";
				gotoxy(51, 8 + i);
				getline(cin, user_input);

				if (user_input == "")
				{
					if (student_record[i].midterm == -1)
					{
						gotoxy(51, 8 + i);
						cout << "N/A";
					}
					else
					{
						gotoxy(52, 8 + i);
						cout << student_record[i].midterm;
					}
				}
				else
					istringstream(user_input) >> student_record[i].midterm;

				value_check = false;
				cur_assingment = student_record[i].assignment;
				cur_midterm = student_record[i].midterm;
				cur_final = student_record[i].final_test;
				cur_overall = student_record[i].overall_average;
				letter_grade = student_record[i].letter_grade;

				grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

				if (value_check == false)
				{
					student_record[i].overall_average = cur_overall;
					student_record[i].letter_grade = letter_grade;

					gotoxy(66, 8 + i);
					cout << "   ";
					gotoxy(66, 8 + i);
					cout << fixed << setprecision(1) << student_record[i].overall_average;

					gotoxy(74, 8 + i);
					cout << "   ";
					gotoxy(75, 8 + i);
					cout << student_record[i].letter_grade;
				}
			}
			break;
			break;
		case '3':
			for (int i = 0; i < number_of_records; i++)
			{
				user_input == "";
				gotoxy(60, 8 + i);
				cout << "   ";
				gotoxy(60, 8 + i);
				getline(cin, user_input);

				if (user_input == "")
				{
					if (student_record[i].final_test == -1)
					{
						gotoxy(60, 8 + i);
						cout << "N/A";
					}
					else
					{
						gotoxy(61, 8 + i);
						cout << student_record[i].final_test;
					}
				}
				else
					istringstream(user_input) >> student_record[i].final_test;

				value_check = false;
				cur_assingment = student_record[i].assignment;
				cur_midterm = student_record[i].midterm;
				cur_final = student_record[i].final_test;
				cur_overall = student_record[i].overall_average;
				letter_grade = student_record[i].letter_grade;

				grade_calc(cur_assingment, cur_midterm, cur_final, cur_overall, letter_grade, value_check);

				if (value_check == false)
				{
					student_record[i].overall_average = cur_overall;
					student_record[i].letter_grade = letter_grade;

					gotoxy(66, 8 + i);
					cout << "   ";
					gotoxy(66, 8 + i);
					cout << fixed << setprecision(1) << student_record[i].overall_average;

					gotoxy(74, 8 + i);
					cout << "   ";
					gotoxy(75, 8 + i);
					cout << student_record[i].letter_grade;
				}
			}
			break;
		case '4':
			menu = false;
			break;
		}
	}

	class_file.open(file_name + ".dat", ios::binary | ios::out);

	for (int x = 0; x < number_of_records; x++)
	{
		class_file.write((char *)&student_record[x], sizeof(student));
	}

	class_file.close();

	main_menu();
}

void grade_calc(int cur_assingment, int cur_midterm, int cur_final, float &overall, char &letter_grade, bool &value_check)
{
	float g1, g2, g3, g4;
	float total_weight;
	bool c1 = false;
	bool c2 = false;
	bool c3 = false;

	total_weight = 1;
	if (cur_assingment == -1)
	{
		total_weight -= .2;
		g1 = 0;
		c1 = true;
	}
	else
		g1 = 0.2 * (cur_assingment);
	if (cur_midterm == -1)
	{
		total_weight -= .3;
		g2 = 0;
		c2= true;
	}
	else
		g2 = 0.3 * (cur_midterm);
	if (cur_final == -1)
	{
		total_weight -= .5;
		g3 = 0;
		c3 = true;
	}
	else
		g3 = 0.5 * (cur_final);

	if ((c1 == true) && (c2 == true) && (c3 == true))
	{
		value_check = true;
	}
	else
	{
		g4 = ((g1 + g2 + g3) / total_weight);

		overall = g4;

		if (overall >= 80)
			letter_grade = 'A';
		else if (overall >= 70)
			letter_grade = 'B';
		else if (overall >= 60)
			letter_grade = 'C';
		else if (overall >= 50)
			letter_grade = 'D';
		else
			letter_grade = 'F';
	}
}
