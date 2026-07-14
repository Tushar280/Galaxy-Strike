using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float controlSpeed = 10f;
    [SerializeField] private float xRange = 10f;
    [SerializeField] private float yRange = 15f;
    [SerializeField] private float rollingFactor = 5f;
    Vector2 movement;

    private void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }

    private void ProcessTranslation()
    {
        float xOffset = controlSpeed * Time.deltaTime * movement.x;
        float xRaw = transform.localPosition.x + xOffset;
        float xFinal = Mathf.Clamp(xRaw,-xRange,xRange);


        float yOffset = controlSpeed * Time.deltaTime * movement.y;
        float yRaw = transform.localPosition.y + yOffset;
        float yFinal = Mathf.Clamp(yRaw,-yRange,yRange);


        transform.localPosition = new Vector3(xFinal,yFinal,0f);
    }

    private void ProcessRotation()
    {
        Quaternion targetRoation = Quaternion.Euler(0f,0f,movement.x * -rollingFactor);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRoation, Time.deltaTime * controlSpeed);
    }

    private void OnMove(InputValue value)
    {
        //Debug.Log(value.Get<Vector2>());
        movement = value.Get<Vector2>();
    }
}
