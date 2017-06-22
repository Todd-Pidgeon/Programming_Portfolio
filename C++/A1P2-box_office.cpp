
//Program Name   : A1P2-box_office
//Programmer Name: Todd Pidgeon
//Overview       : Caluculates box offices sales
//Date Written   : 19/01/2016
//Date Modified  : 19/01/2016

#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
	string run_again = "y";
	
	while (run_again == "y")
	{
		string movie_name;
		int adult_tickets_sold = 0;
		int child_tickets_sold = 0;
		float gross_profit = 0;
		float net_profit = 0;
		float paid_distributor = 0;
		float adult_price = 22.00;
		float child_price = 15.00;
		float theater_take = 0.45;
	
		cout << "\n\n\t\tMovie Name?................: ";
		getline (cin, movie_name);

		cout << "\n\n\t\tNumber of adult tickets?...: ";
		cin >> adult_tickets_sold;

		cout << "\n\n\t\tNumber of childens tickets?: ";
		cin >> child_tickets_sold;

		gross_profit = (adult_tickets_sold * adult_price) + (child_tickets_sold * child_price);

		net_profit = gross_profit * theater_take;

		paid_distributor = gross_profit - net_profit;

		cout << setprecision(2) << fixed;
		cout << "\n\n\t\tMovie Name..................:  " << setw(25) << right << movie_name;
		cout << "\n\n\t\tNumber of Adult Tickets Sold:  " << setw(25) << right << adult_tickets_sold;
		cout << "\n\n\t\tNumber of Child Tickets Sold:  " << setw(25) << right << child_tickets_sold;
		cout << "\n\n\t\tGross Box Office Profit.....: $" << setw(25) << right << gross_profit;
		cout << "\n\n\t\tNet Box Office Profit.......: $" << setw(25) << right << net_profit;
		cout << "\n\n\t\tAmount Paid to Distributor..: $" << setw(25) << right << paid_distributor;

		cout << "\n\n\n\n\t\tDo you wish to run the program again (y/n):";
		cin >> run_again;
		// This was need to make the loop run correctly
		if (run_again == "y")
		{
			cin.ignore();
		}
	}

	cin.ignore();
	cout << "\n\n\n\n\t\tPress any ket to continue ";
	cin.get();

	return 0;
}