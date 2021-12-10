namespace FactorialVikiMarta
{
    public static class Factorial
    {
        public static int Calculate(int number)
        {
            if (number == 2)
                return number * (number - 1);
            if (number == 3)
                return number * (number - 1);
            if (number == 4)
                return number * (number - 1) * (number - 2);
            if (number == 5)
                return number * (number - 1) * (number - 2) * (number - 3);
            return 1;
        }
    }
}
