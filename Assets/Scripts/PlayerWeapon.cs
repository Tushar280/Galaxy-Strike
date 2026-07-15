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
        var emissionModule = lazer.emission;
        emissionModule.enabled = isFiring;
        
        var emissionModule1 = lazer1.emission;
        emissionModule1.enabled = isFiring;
    }
}
