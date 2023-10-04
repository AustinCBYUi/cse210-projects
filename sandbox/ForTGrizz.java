import java.util.Scanner;

public class ForTGrizz {
    public static void main(String[] args) {

                Scanner newScanner = new Scanner(System.in);
                double PI = 3.14159;
                System.out.println("Hello! Type a shape type!");
                // System.in.toString()
                String userInput = newScanner.nextLine();

                int switchAccessor = 0;
                if (userInput == "circle") {
                    switchAccessor = 1;
                }
                else if (userInput == "square") {
                    switchAccessor = 2;
                }
                else if (userInput == "rectangle") {
                    switchAccessor = 3;
                }


                switch(switchAccessor) {
                    case 1:
                        System.out.println("Radius of your circle: ");
                        double radius = Integer.valueOf(System.console().readLine());

                        double doMath = Math.pow(radius, 2);
                        double answer = PI * doMath;

                        System.out.println(answer);
                        break;

                    case 2:
                        System.out.println("Side of the square: ");
                        double side = Integer.valueOf(System.console().readLine());

                        double answerSquare = Math.pow(side, 2);

                        System.out.println(answerSquare);
                        break;

                    case 3:
                        System.out.println("Width of rectangle: ");
                        double width = Integer.valueOf(System.console().readLine());
                        System.out.println("Length of the rectangle: ");
                        double length = Integer.valueOf(System.console().readLine());

                        double answerRectangle = width * length;

                        System.out.println(answerRectangle);
                        break;
        }
    }
}
