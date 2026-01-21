namespace _Source.Task_2
{
    public class Square : Diamond
    {
        public Square(float a, float b) : base(a, b)
        {
        }

        public override float CountArea()
        {
            return A * B;
        }
    }
}