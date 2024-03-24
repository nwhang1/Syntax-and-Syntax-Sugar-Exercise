namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            //changing string to var, switching to inferred typing 

            var response = (answer > 9)
             ? $"{answer} is less than 9"
             : $"{answer} is greater than 9";
        }
    }
}
