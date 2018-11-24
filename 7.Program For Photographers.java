import java.util.Scanner;

public class ProgramForPhotographers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter number of taken pictures: ");
            long totalPics = Long.parseLong(scanner.nextLine());
            while (totalPics < 0) {
                System.out.print("Invalid input! Negative number for pictures: ");
                totalPics = Long.parseLong(scanner.nextLine());
            }

            System.out.print("Enter time needed for filtering a single picture: ");
            long secondsFiltering = Long.parseLong(scanner.nextLine());
            while (secondsFiltering < 0) {
                System.out.print("Invalid input! Negative number for filtering time: ");
                secondsFiltering = Long.parseLong(scanner.nextLine());
            }

            //percentage of pictures that are good enough to be uploaded
            System.out.print("Enter the % of good pictures: ");
            long goodPercent = Long.parseLong(scanner.nextLine());
            while (goodPercent < 0 || goodPercent > 100) {
                System.out.print("Invalid input! Negative number for %: ");
                goodPercent = Long.parseLong(scanner.nextLine());
            }

            //amount of time needed for every filtered picture to be uploaded to storage
            System.out.print("Enter uploading time for a single picture: ");
            long secondsUpload = Long.parseLong(scanner.nextLine());
            while (secondsUpload < 0) {
                System.out.print("Invalid input! Negative number for uploading time: ");
                secondsUpload = Long.parseLong(scanner.nextLine());
            }

            long secFilterAllPics = totalPics * secondsFiltering;
            double goodPics = (goodPercent / 100.0) * totalPics;
            long goodPicsRound = (long) Math.ceil(goodPics);
            long secsUploadAllPics = goodPicsRound * secondsUpload;
            long secTotal = secFilterAllPics + secsUploadAllPics;

            long days = secTotal / 86400;
            long daysOstatak = secTotal % 86400;
            long hours = daysOstatak / 3600;
            long hoursOstatak = daysOstatak % 3600;
            long mins = hoursOstatak / 60;
            long secs = hoursOstatak % 60;

            System.out.printf("Time for getting pictures ready:%d:%02d:%02d:%02d", days, hours, mins, secs);

        } catch (Exception ex) {
            System.out.println("Invalid input! Start from the beginning!");
        }
    }
}