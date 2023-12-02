// Written by Jason Tran

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    private PlayerInputs playerInput;
    private PlayerInputs.OnFootActions onFoot;

    private PlayerMotor motor;
    private PlayerLook look;
    
    // Shooting
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletPrefabLifeTime = 1f;
    public bool isShooting;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInputs();
        onFoot = playerInput.OnFoot;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        onFoot.Jump.performed += ctx => motor.Jump();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateShooting();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Tell the playermotor to move using the value from our movement action
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnFireWeaponPressedPerformed(InputAction.CallbackContext value)
    {
        Debug.Log("shooting");
        isShooting = true;
    }

    private void OnFireWeaponPressedCanceled(InputAction.CallbackContext value)
    {
        Debug.Log("stopped shooting");
        isShooting = false;
    }

    private void CalculateShooting()
    {
        if (isShooting)
        {
            FireWeapon();
          
        }

    }

    public void FireWeapon()
    {
        
        // Spawning the bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

        // Shooting the bullet
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);

        // Destroy the bullet
        StartCoroutine(DestroyBulletAfterTime(bullet, bulletPrefabLifeTime));


    }

    private IEnumerator DestroyBulletAfterTime(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

    private void OnEnable()
    {
        onFoot.Enable();
        onFoot.FireWeaponPressed.performed += OnFireWeaponPressedPerformed;
        onFoot.FireWeaponPressed.canceled += OnFireWeaponPressedCanceled;
    }

    private void OnDisable()
    {
        onFoot.Disable();
        onFoot.FireWeaponPressed.performed -= OnFireWeaponPressedPerformed;
        onFoot.FireWeaponPressed.canceled -= OnFireWeaponPressedCanceled;
    }

}
