using UnityEngine;

namespace _Source.Task_1
{
    public class Parallelogram : ATetragon
    {
        public Parallelogram(float a, float b, float angle) : base(a, b, angle)
        {
        }

        public override float CountPerimeter()
        {
            return (A + B) * 2;
        }

        public override float CountArea()
        {
            return Mathf.Abs(A * B * Mathf.Sin(Angle));
        }
    }
}