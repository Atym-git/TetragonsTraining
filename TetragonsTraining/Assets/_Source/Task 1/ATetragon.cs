namespace _Source.Task_1
{
    public abstract class ATetragon
    {
        protected float A { get; private set; }
        protected float B { get; private set; }
        protected float Angle { get; set; }

        protected ATetragon(float a, float b, float angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }

        public abstract float CountPerimeter();

        public abstract float CountArea();

    }
}