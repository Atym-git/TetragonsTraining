namespace _Source.Task_2
{
    public class Rectangle : Parallelogram
    {
        public Rectangle(float a, float b) : base(a, b, 0)
        {
        }

        public override float CountArea()
        {
            return A * B;
        }
    }
}