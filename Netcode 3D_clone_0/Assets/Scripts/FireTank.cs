using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTank : MonoBehaviour
{
    [Header("Parts")]
    public Rigidbody projectile;
    public Transform barrelEnd;
    public Transform Bullets;
    public Camera tankCam;
    [Header("Missiles")]
    public float cooldown = 3.5f;
    public float bulletSpeed = 350f;

    private bool fireReady;
    void Start()
    {
        //InvokeRepeating("Fire", 2, 2);
        fireReady = true;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && fireReady == true)
        {
            Fire();
        }
        AimWithMouse();
    }
    private void AimWithMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        Ray ray = tankCam.ScreenPointToRay(mousePos);
    }
    
    void Fire()
    {
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation, Bullets);
        projectileInstance.AddForce(barrelEnd.forward * bulletSpeed);
        fireReady = false;
        StartCoroutine(Cooldown());
    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        fireReady = true;
    }
}