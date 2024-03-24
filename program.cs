 private void DateTimeSinifi()
 {
     Console.WriteLine(DateTime.Now);
     Console.WriteLine(DateTime.Now.Date);
     Console.WriteLine(DateTime.Now.Day);
     Console.WriteLine(DateTime.Now.Month);
     Console.WriteLine(DateTime.Now.Year);



     Console.WriteLine(DateTime.Now.Hour);
     Console.WriteLine(DateTime.Now.Minute);
     Console.WriteLine(DateTime.Now.Second);
     Console.WriteLine(DateTime.Now.Millisecond);

     Console.WriteLine();

     //DayOfWeek
     Console.WriteLine("DayOfWeek: "+DateTime.Now.DayOfWeek);
     Console.WriteLine("DayOfYear: " + DateTime.Now.DayOfYear);

     Console.WriteLine();

     Console.WriteLine("ToLongDateString: "+DateTime.Now.ToLongDateString());
     Console.WriteLine("ToShortDateString: " + DateTime.Now.ToShortDateString());

     Console.WriteLine();

     Console.WriteLine("ToLongTimeString: " + DateTime.Now.ToLongTimeString());
     Console.WriteLine("ToShortTimeString: " + DateTime.Now.ToShortTimeString());

     Console.WriteLine();

     //Add metodları
     Console.WriteLine("AddYears(1): " + DateTime.Now.AddYears(1));
     Console.WriteLine("AddMonths(1): " + DateTime.Now.AddMonths(1));
     Console.WriteLine("AddDays(1): " + DateTime.Now.AddDays(1));
     Console.WriteLine("AddHours(1): " + DateTime.Now.AddHours(1));
     Console.WriteLine("AddMinutes(1): " + DateTime.Now.AddMinutes(1));
     Console.WriteLine("AddSeconds(1): " + DateTime.Now.AddSeconds(1));
     Console.WriteLine("AddMilliseconds(1): " + DateTime.Now.AddMilliseconds(1));
     Console.WriteLine();
     Console.WriteLine();

     //DateTime Format
     //Gün ay yıl olarak getirmek 
     Console.WriteLine("dd: "+DateTime.Now.ToString("dd"));//24
     Console.WriteLine("ddd: " + DateTime.Now.ToString("ddd"));//Pzt
     Console.WriteLine("dddd: " + DateTime.Now.ToString("dddd"));//Pazartesi

     Console.WriteLine();

     Console.WriteLine("MM: " + DateTime.Now.ToString("MM"));//03
     Console.WriteLine("MMM: " + DateTime.Now.ToString("MMM"));//Mar
     Console.WriteLine("MMMM: " + DateTime.Now.ToString("MMMM"));//Mart
     
     Console.WriteLine();

     Console.WriteLine("yy: " + DateTime.Now.ToString("yy"));//24
     Console.WriteLine("yyyy: " + DateTime.Now.ToString("yyyy"));//2024
     
     Console.WriteLine();


 }

 private void MathSinifi()
 {
     Console.WriteLine();
     Console.WriteLine("Math Kütüphanesi");
     Console.WriteLine();

     Console.WriteLine("Abs mutlak değer: "+Math.Abs(-25));

     Console.WriteLine();

     Console.WriteLine("Sinus: "+Math.Sin(30));
     Console.WriteLine("Cosinus: "+Math.Cos(30));
     Console.WriteLine("Tan: "+Math.Tan(30));

     Console.WriteLine();
     Console.WriteLine("Ceiling 20.3: "+Math.Ceiling(20.3));
     Console.WriteLine("Round 20.3: " + Math.Round(20.3));
     Console.WriteLine("Round 20.7: " + Math.Round(20.7));
     Console.WriteLine("Floor 20.9: " + Math.Floor(20.9));
     
     Console.WriteLine();

     Console.WriteLine("Max 2-6: " + Math.Max(2, 6));
     Console.WriteLine("Min 2-6: " + Math.Min(2, 6));

     Console.WriteLine();

     Console.WriteLine("2 Pow 3: " + Math.Pow(2,3));
     Console.WriteLine("Sqrt 4: " + Math.Sqrt(4));
     Console.WriteLine("Log9: " + Math.Log(9));
     Console.WriteLine("e uzeri 3: " + Math.Exp(3));
     Console.WriteLine("log 10 tabanında 1000: " + Math.Log10(1000));

 }
