using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] lasers;
    [SerializeField] private RectTransform crosshair;
    [SerializeField] private Transform trackingTarget;
    [SerializeField] private float targetDistance = 10f;

    bool isFiring = false;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void OnFire(InputValue value)
    {
        isFiring = value.isPressed; 
    }

    private void Update()
    {
        ProcessFire();

        if (Mouse.current != null)
        {
            TrackMouseTarget();
        }
    }


    private void TrackMouseTarget()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        crosshair.position = mousePosition;

        Vector3 targetPosition = new Vector3(mousePosition.x, mousePosition.y, targetDistance);
        trackingTarget.position = Camera.main.ScreenToWorldPoint(targetPosition);
    }

    private void ProcessFire()
    { 
        foreach(ParticleSystem laser in lasers)
        {
            var emissionModule = laser.emission;
            emissionModule.enabled = isFiring;
        }

    }
}
