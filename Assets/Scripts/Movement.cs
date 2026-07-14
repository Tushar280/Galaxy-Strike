using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float controlSpeed = 10f;
    Vector2 movement;

    private void Update()
    {
        float xOffset = controlSpeed * Time.deltaTime;
        transform.localPosition = new Vector3(transform.localPosition.x + xOffset,0f,0f);
    }


    private void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
        movement = value.Get<Vector2>();
    }
}
