
//Program Name   : A1P3-savings_account_balance
//Programmer Name: Todd Pidgeon
//Overview       : Caluculate intrests rates
//Date Written   : 16/01/2016
//Date Modified  : 19/01/2016

#include <iostream>
#include <string>
#include <cmath>
#include <iomanip>

using namespace std;

int main()
{
	//Variable declaration
	string run_again = "y";
	float principal = 0;
	float intrest_rate = 0;
	float times_compounded = 0;
	float interest_amount = 0;
	float total_savings = 0;

	while (run_again == "y")
	{
		//Asks user for input
		cout << "\n\n\t\tWhat is the principal?..................: $";
		cin >> principal;

		cout << "\n\n\t\tWhat is the intrest rate?...............: ";
		cin >> intrest_rate;

		cout << "\n\n\t\tHow many times is the intrest compunded?: ";
		cin >> times_compounded;

		//Calculate
		interest_amount = principal * pow(1 + (intrest_rate / 100) / times_compounded, times_compounded) - principal;

		total_savings = principal + interest_amount;

		cout << setprecision(2) << fixed;
		cout << "\n\n\t\tIntrest Rate.....: " << setw(25) << right << intrest_rate << "%";
		cout << "\n\n\t\tTimes Compounded.:  " << setw(25) << right << times_compounded;
		cout << "\n\n\t\tPrincipal........: $" << setw(25) << right << principal;
		cout << "\n\n\t\tInterest.........: $" << setw(25) << right << interest_amount;
		cout << "\n\n\t\tAmount in Savings: $" << setw(25) << right << total_savings;

		cout << "\n\n\n\n\t\tDo you wish to run the program again (y/n):";
		cin >> run_again;
	}

	cin.ignore();
	cout << "\n\n\n\n\t\tPress any ket to continue ";
	cin.get();

	return 0;
}
