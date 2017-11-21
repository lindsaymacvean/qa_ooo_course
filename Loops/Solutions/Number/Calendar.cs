namespace FlowControl {
	using System;

	public class Calendar {
		public static void Main() { {
				// First, declare variables for current month and leapyear flag
				byte currentMonth = 3;     // a number between 1 and 12
				bool leapYear = false;

				// Display current month
				Console.WriteLine("The current month is " + currentMonth);

				// Declare a variable to hold number of days in month
				byte daysInMonth;

				// Use switch statement to work out days in the current month
				switch (currentMonth) {
					case 1:
					case 3:
					case 5:
					case 7:
					case 8:
					case 10:
					case 12:
						daysInMonth = 31;
						break;

					case 9:
					case 4:
					case 6:
					case 11:
						daysInMonth = 30;
						break;

					case 2:
						// First attempt
						if (leapYear)
							daysInMonth = 29;
						else
							daysInMonth = 28;
						// Second attempt
						//daysInMonth = leapYear ? 29 : 28;
						break;

					default:
						// Illegal month - set error value
						daysInMonth = 0;
						break;

				}

				// Check that we got a result
				// If so, display result, otherwise display error message
				if (daysInMonth != 0)
					Console.WriteLine("There are " + daysInMonth
						+ " days in the current month");
				else
					Console.WriteLine("Illegal month specified");
			}
			/* string version
			{
				// First, declare variables for current month and leapyear flag

				string currentMonth = "March";     // English name
				bool leapYear = false;

				// Display current month

				Console.WriteLine("The current month is " + currentMonth);


				// Declare a variable to hold number of days in month

				byte daysInMonth;

				// Use switch statement to work out days in the current month

				switch (currentMonth)
				{
					case "January":
					case "March":
					case "May":
					case "July":
					case "August":
					case "October":
					case "December":
						daysInMonth = 31;
						break;

					case "September":
					case "April":
					case "June":
					case "November":
						daysInMonth = 30;
						break;

					case "February":
						// First attempt
						if (leapYear)
							daysInMonth = 29;
						else
							daysInMonth = 28;
						// Second attempt
						//daysInMonth = leapYear ? 29 : 28;
						break;

					default:
						// Illegal month - set error value
						daysInMonth = 0;
						break;

				}

				// Check that we got a result
				// If so, display result, otherwise display error message

				if (daysInMonth != 0)
					Console.WriteLine("There are " + daysInMonth
						+ " days in the current month");
				else
					Console.WriteLine("Illegal month specified");

			}
			*/
		}
	}
}