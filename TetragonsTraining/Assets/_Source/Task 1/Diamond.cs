namespace _Source.Task_1
{
    public class Diamond : Parallelogram
    {
        public Diamond(float a, float b) : base(a, b, 0)
        {
        }

        public override float CountPerimeter()
        {
            return A * 4;
        }
        
        public override float CountArea()
        {
            return A * B / 2;
        }
    }
}