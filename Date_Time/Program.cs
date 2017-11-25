using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dateNow = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //var dateShort = DateTime.Now.ToShortDateString();
            //var shortTime = DateTime.Now.ToShortTimeString();

            //var dateLong = DateTime.Now.ToLongDateString();
            //var timeLong = DateTime.Now.ToLongTimeString();

            //Console.WriteLine(dateNow);
            //Console.WriteLine(dateShort);
            //Console.WriteLine(shortTime);
            //Console.WriteLine(dateLong);
            //Console.WriteLine(timeLong);

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);

            //DateTime mirekDate = DateTime.ParseExact(dateNow, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(mirekDate);


            //IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            //DateTime dt2 = DateTime.Parse(dateNow, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            //Console.WriteLine(dt2);

            // Date strings are interpreted according to the current culture.
            // If the culture is en-US, this is interpreted as "January 8, 2008",
            // but if the user's computer is fr-FR, this is interpreted as "August 1, 2008"
            string date = "01/08/2008";
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);

            // Specify exactly how to interpret the string.
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

            // Alternate choice: If the string has been input by an end user, you might 
            // want to format it according to the current culture:
            // IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            DateTime dt2 = DateTime.Parse(date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            Console.WriteLine("Year: {0}, Month: {1}, Day {2}", dt2.Year, dt2.Month, dt2.Day);

            /* Output (assuming first culture is en-US and second is fr-FR):
                Year: 2008, Month: 1, Day: 8
                Year: 2008, Month: 8, Day 1
             */


            //var mirek = IsValid(dateNow);

        }
            //======================    DateTime    =============================
            //This adds the simple validation to the date and time......

        public static bool IsValid(object value)      //"value" would be the value of the date
        {
            string[] dateFormats = { "d/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy", "d MMM yyyy", "dd/mm/yyyy" };

            DateTime dateTime;

            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                dateFormats,
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);        // Checking if the date is in the future.
        }

        // or if youd like to check the time......

        //public bool IsValid(object value)      //"value" would be the value of the date
        //{
        //    string[] timeFormats = { "HH:mm", "H:mm" };
        //    DateTime dateTime;

        //    var isValid = DateTime.TryParseExact(Convert.ToString(value),
        //        timeFormats,
        //        CultureInfo.CurrentCulture,
        //        DateTimeStyles.None,
        //        out dateTime);

        //    return (isValid);
        //}


    }
    }
