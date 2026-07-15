using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] lasers;
    [SerializeField] private RectTransform crosshair;
    [SerializeField] private Transform trackingTarget;
    [SerializeField] private float targetDistance;

    
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
            crosshair.position = Mouse.current.position.ReadValue();
        }

        Vector3 targetPosition = new Vector3(Mouse.current.position.x, Mouse.current.position.y,targetDistance);
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
