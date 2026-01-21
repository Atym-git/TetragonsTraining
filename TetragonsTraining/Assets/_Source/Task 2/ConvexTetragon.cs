using UnityEngine;

namespace _Source.Task_2
{
    public class ConvexTetragon : ATetragon
    {
        private float _c;
        private float _d;
        
        public ConvexTetragon(float a, float b, float c, float d, float angle) : base(a, b, angle)
        {
            _c = c;
            _d = d;
        }

        public override float CountPerimeter()
        {
            return A + B + _c + _d; 
        }

        public override float CountArea()
        {
            return Mathf.Abs(A * B * Mathf.Sin(Angle) / 2);
        }
    }
}