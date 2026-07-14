using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
    }
}
