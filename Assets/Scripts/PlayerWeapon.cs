using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    private void OnFire(InputValue value)
    {
        if(value.isPressed)
        {
            Debug.Log("Shoot");
        }
    }
}
