List<int> grades = new List<int>()
{
    73,
    67,
    38,
    33
};

List<int> result = Result.GradingStudents(grades);

Console.WriteLine(String.Join("\n", result));

class Result
{
    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */
    public static List<int> GradingStudents(List<int> grades)
    {
        var roundedGrades = new List<int>();

        foreach (var grade in grades)
        {
            if (grade < 38)
            {
                roundedGrades.Add(grade);
                continue;
            }

            if (grade % 5 == 0)
            {
                roundedGrades.Add(grade);
                continue;
            }

            var roundedGrade = grade;
            for (int i = 1; i <= 2; i++)
            {
                if ((grade + i) % 5 == 0)
                {
                    roundedGrade = grade + i;
                    break;
                }
            }

            roundedGrades.Add(roundedGrade);
        }

        return roundedGrades;
    }
}
