using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    public enum MissileType
    {
        Red_Missile,
        Blue_Missile,
        Green_Missile

    }

    public MissileType missileType;
    private IMissile imissile;

    public void HandleMissileType()
    {
        Component m = gameObject.GetComponent<IMissile>() as Component;

        if (m != null)
            Destroy(m);

        switch (missileType)
        {
            case MissileType.Blue_Missile:
                imissile = gameObject.AddComponent<Blue_Missile>();
                break;
            case MissileType.Red_Missile:
                imissile = gameObject.AddComponent<Red_Missile>();
                break;
            case MissileType.Green_Missile:
                imissile = gameObject.AddComponent<Green_Missile>();
                break;
            default:
                imissile = gameObject.AddComponent<Blue_Missile>();
                break;
        }
    }

    public void Fire()
    {
        imissile.Shoot();
    }
    // Start is called before the first frame update
    void Start()
    {
        HandleMissileType();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }   
    }
}
