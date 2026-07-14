using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void onMove(InputValue value)
    {
        Debug.Log("Movement: " + value.Get<Vector2>());
    }
}
