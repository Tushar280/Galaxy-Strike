using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] lasers;
    [SerializeField] private RectTransform crosshair;

    
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
