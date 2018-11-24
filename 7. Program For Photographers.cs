using System;
namespace ProgramForPhotographers
{
    class ProgramForPhotographers
    {
        public static void Main(string[] args)
        {
            try {
                Console.Write("Enter number of taken pictures: ");
                long totalPics = long.Parse(Console.ReadLine());
                while (totalPics < 0)
                {
                    Console.Write("Invalid input! Negative number for pictures: ");
                    totalPics = long.Parse(Console.ReadLine());
                }

                Console.Write("Enter time needed for filtering a single picture: ");
                long secondsFiltering = long.Parse(Console.ReadLine());
                while (secondsFiltering < 0)
                {
                    Console.Write("Invalid input! Negative number for filtering time: ");
                    secondsFiltering = long.Parse(Console.ReadLine());
                }

                //percentage of pictures that are good enough to be uploaded
                Console.Write("Enter the % of good pictures: ");
                long goodPercent = long.Parse(Console.ReadLine());
                while (goodPercent < 0 || goodPercent > 100)
                {
                    Console.Write("Invalid input! Negative number for %: ");
                    goodPercent = long.Parse(Console.ReadLine());
                }

                //amount of time needed for every filtered picture to be uploaded to storage
                Console.Write("Enter uploading time for a single picture: ");
                long secondsUpload = long.Parse(Console.ReadLine());
                while (secondsUpload < 0)
                {
                    Console.Write("Invalid input! Negative number for uploading time: ");
                    secondsUpload = long.Parse(Console.ReadLine());
                }

                long secFilterAllPics = totalPics * secondsFiltering;
                double goodPics = (goodPercent / 100.0) * totalPics;
                long goodPicsRound = (long)Math.Ceiling(goodPics);
                long secsUploadAllPics = goodPicsRound * secondsUpload;
                long secTotal = secFilterAllPics + secsUploadAllPics;

                long days = secTotal / 86400;
                long daysOstatak = secTotal % 86400;
                long hours = daysOstatak / 3600;
                long hoursOstatak = daysOstatak % 3600;
                long mins = hoursOstatak / 60;
                long secs = hoursOstatak % 60;

                Console.WriteLine($"Time for getting pictures ready:{days:D2}:{hours:D2}:{mins:D2}:{secs:D2}");

            }
            catch
            {
                Console.WriteLine("Invalid input! Start from the beginning!");
            }
            }
    }
}