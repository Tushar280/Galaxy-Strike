using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    bool isFiring = false;

    private void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
        Debug.Log("Firing: " + isFiring);
    }
}
