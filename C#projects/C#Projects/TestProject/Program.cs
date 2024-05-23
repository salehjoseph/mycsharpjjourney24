// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if(daysUntilExpiration==0)
// {
// Console.WriteLine("Your Subscription has expired");
// }
// else if(daysUntilExpiration ==1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if(daysUntilExpiration <=5)
// {
// Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// discountPercentage = 10;
// }
// else if(daysUntilExpiration <=10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }


// if(discountPercentage>0){
//     Console.WriteLine($"Renew Now and Save {discountPercentage}%");
// }
// Console.WriteLine($"Random number generated: {daysUntilExpiration}");

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

// string message = "Hellooo Woorldooooo!!";
// char [] message2= message.ToCharArray();
// int letterCount=0;
// foreach (var item in message2)
// {
//    if (item == 'o')
//    {
//    letterCount++;
//    } 
// }
// Console.WriteLine($"The letter 'o' appears {letterCount} times in the array.");
// Console.WriteLine(message2);

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
   else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
        
    else
        continue;

    int sumExamScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    int ExtragradedAssignments=0;

    int sumExtraCreditScores=0;
    //decimal ExtraCreditUnits =0;

    decimal AverageExtraCreditUnits=0;

    decimal ExamScore =0;

    //int ExamSum;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        
        if (gradedAssignments <= examAssignments)
        {
            sumExamScores += score;
        }  
        else
          {  //sumAssignmentScores=sumAssignmentScores + score/10;
            ExtragradedAssignments+=1;
            sumExtraCreditScores+=score;
           // AverageExtraCreditUnits =(decimal)(sumAssignmentScores + score)/10;
          }
    }
     AverageExtraCreditUnits=(decimal)(sumExtraCreditScores)/ExtragradedAssignments;
    currentStudentGrade =(decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;
        //sum of the exam score
    ExamScore=(decimal)(sumExamScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    //Console.WriteLine("Student\t\tExam Score\t\tOverall\Grade\t\tExtra Credit\n");
    Console.WriteLine($"{currentStudent}\t\t{ExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{AverageExtraCreditUnits}\t({(((decimal)sumExtraCreditScores / 10) /examAssignments)} pts)");
}
// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();