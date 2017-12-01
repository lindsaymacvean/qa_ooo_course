using System;

namespace Types
{
	public struct Date
	{
		private ushort day;
		private ushort month;
		private ushort year;

		public Date( ushort day, ushort month, ushort year ) {
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public ushort Day {
			get { return day; }
			set { 
				if( day >= 1 && day <= 31 ) {
					day = value;
				}
			}
		}

		public ushort Month {
			get { return month; }
			set {
				if( month >= 1 && month <= 12 ) {
					month = value;
				}
			}
		}

		public ushort Year {
			get { return year; }
			set { year = value; }
		}

		public string ToUKDate() {
			return string.Format( "{0:00}/{1:00}/{2}", day, month, year );
		}

    //public string ToUSDate() {
    //  return string.Format( "{0:00}/{1:00}/{2}", month, day, year );
    //}

#region "Pre-implemented methods"
		// --------------------------------------------------------------------//
		// The following methods have been completed for you									 //
		// --------------------------------------------------------------------//
		public void NextDay() {
			if( ++day > DaysInMonth ) {
				day = 1;
				if( ++month > 12 ) {
					month = 1;
					year++;
				}
			}
		}

		public int Compare( Date rhs ) {
			int result;
		
			result = year - rhs.year;
			
			if( result == 0 ) {
				result = month - rhs.month;

				if( result == 0 ) {
					result = day - rhs.day;
				}
			}

			return result;
		}

		public bool IsLeapYear() {
			return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
		}

		private int DaysInMonth {
			get {
				int [] numdays = {31,28,31,30,31,30,31,31,30,31,30,31};

				if( month == 2 && IsLeapYear() )
					return 29;
				else
					return numdays[month - 1];
			}
		}

#endregion

	}
}
