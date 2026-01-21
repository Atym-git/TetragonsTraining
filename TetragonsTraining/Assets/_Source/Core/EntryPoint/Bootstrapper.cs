using _Source.Task_1;
using UnityEngine;

namespace _Source.Core.EntryPoint
{
    public class Bootstrapper : MonoBehaviour
    {

        private void Start()
        {
            #region Task_1
        
            ConvexTetragon convexTetragon = new ConvexTetragon(10, 10, 10, 20, 30);
            
            Debug.Log(convexTetragon.CountPerimeter());
            Debug.Log(convexTetragon.CountArea());

            #endregion
        }
        
    }
}