using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    bool isFiring = false;

    private void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void ProcessFire()
    {
        if (isFiring)
        {
            Debug.Log("Firing");
        }
    }
}
