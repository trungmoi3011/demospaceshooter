using UnityEngine;
namespace game
{

    public class PlayerMovement : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            Debug.Log(Input.mousePosition);
            var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPoint.z = 0;
            transform.position = worldPoint;



        }
    }
}