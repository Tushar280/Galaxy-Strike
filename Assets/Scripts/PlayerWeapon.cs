using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private ParticleSystem lazer;
    [SerializeField] private ParticleSystem lazer1;

    
    bool isFiring = false;

    private void OnFire(InputValue value)
    {
        isFiring = value.isPressed; 
    }

    private void Update()
    {
        ProcessFire();
    }

    private void ProcessFire()
    {
        if (isFiring)
        {
            lazer.Play();
            lazer1.Play();
        }
        else
        {
            lazer.Stop();
            lazer1.Stop();
        }
    }
}
