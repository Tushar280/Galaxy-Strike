using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float controlSpeed = 10f;
    [SerializeField] private float xRange = 10f;
    [SerializeField] private float yRange = 15f;
    Vector2 movement;

    private void Update()
    {
        ProcessTranslation();
    }

    private void ProcessTranslation()
    {
        float xOffset = controlSpeed * Time.deltaTime * movement.x;
        float xRaw = transform.localPosition.x + xOffset;
        float xFinal = Mathf.Clamp(xRaw,-xRange,xRange);


        float yOffset = controlSpeed * Time.deltaTime * movement.y;
        float yRaw = transform.localPositon.y + yOffset;
        float yFinal = Mathf.Clamp(yRaw,-yRange,yRange);


        transform.localPosition = new Vector3(xFinal,yFinal,0f);
    }
    
    private void OnMove(InputValue value)
    {
        //Debug.Log(value.Get<Vector2>());
        movement = value.Get<Vector2>();
    }
}
