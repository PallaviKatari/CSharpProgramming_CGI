using System;
using System.Text;


namespace AssessmentScoreCardGenerator
{

    /* 
     * Declare enum AssessmentType with named constant for types of assessments
     * assessment types with the maximum score is:
     * QUIZ - 50
     * KBA - 100
     * CALIBRATION - 150
     * HACKATHON - 200

     * the maximum score can be set as value for enum constants
     */
    public enum AssessmentType
    {
        QUIZ = 50, KBA = 100, CALIBRATION = 150, HACKATHON = 200
    }

    /*
     * Declare struct AssessmentCard
     * Structure members should be assessmentType, score and datetime
     */
    public struct AssessmentCard
    {
        public AssessmentType assessmentType;
        public int score;
        public DateTime doa;
        public void getData()
        {
            string ass_type;
        label: Console.WriteLine("Enter Assessment Type:");
            ass_type = (Console.ReadLine());
            ass_type = ass_type.ToUpper();
            switch (ass_type)
            {
                case "QUIZ": this.assessmentType = AssessmentType.QUIZ; break;
                case "KBA": this.assessmentType = AssessmentType.KBA; break;
                case "CALIBRATION": this.assessmentType = AssessmentType.CALIBRATION; break;
                case "HACKATHON": this.assessmentType = AssessmentType.HACKATHON; break;
                default: Console.WriteLine("Enter correct value."); goto label;

            }
        label1: Console.WriteLine("Enter Score Secured By The Candidate:");
            this.score = Convert.ToInt32(Console.ReadLine());
            if (this.score < 0 || this.score > (int)this.assessmentType)
            {
                Console.WriteLine("Enter correct marks.");
                goto label1;
            }
        label2: Console.WriteLine("Enter Date Of Assessment In Format YYYY-MM-DD or DD-MM-YYYY :");
            try
            {
                this.doa = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter Date Df Assessment In Proper Format.Ex-05-09-1999 or 1999-09-05 or 5-9-99.");
                goto label2;
            }
            this.doa = this.doa.Date;

        }

    }



    public class Program
    {
        static void Main(string[] args)
        {

            // this code is optional here however it wil help 
            // you to understand the requirements better    
            AssessmentCard[] a = new AssessmentCard[4];
            for (int i = 0; i < 4; i++)
            {
                a[i].getData();
            }
            string name; int no;
            Console.WriteLine("Enter cadet's name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter cadet's number:");
            no = Convert.ToInt32(Console.ReadLine());
            int per = GetOverallScore(a);
            Console.WriteLine(GenerateScoreCard(no, name, a, per));

        }
        // this method accepts assessment cards and calculates total percentage
        public static int GetOverallScore(AssessmentCard[] a)
        {
            // the logic put here should use foreach loop to read 
            // card data and calculate percentage as mentioned.
            // the maximum score value for each assessment type can be retrieve
            // from enum constant
            int sum1 = 0, sum2 = 0;
            foreach (var i in a)
            {
                sum1 += i.score;
                sum2 += (int)i.assessmentType;

            }

            return (int)(sum1 * 100 / sum2);

        }

        // this method should generate score card from the details provided
        public static string GenerateScoreCard(int no, string name, AssessmentCard[] a, int per)
        {
            // the code here should build string with contents such as
            // cadet no, cadet name, calibration type, score obtained

            // the built string should be returned as string and not as StringBuilder

            StringBuilder s = new StringBuilder();
            s.Append("\n\nCadet's number: " + no + "\tCadet's name: " + name + "\n\n");
            for (int i = 0; i < 4; i++)
                s.Append("Assessment type: " + a[i].assessmentType + "\nDate of assessment: " + a[i].doa + "\nMarks scored: " + a[i].score + "\nTotal Marks: " + (int)a[i].assessmentType + "\n\n");
            s.Append("Percentage:   " + per + "%");
            return s.ToString();

        }
    }

}
