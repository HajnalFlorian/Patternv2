using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSwap : MonoBehaviour
{
    public ShootControl controller;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            controller.missileType = ShootControl.MissileType.Blue_Missile;
            controller.HandleMissileType();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            controller.missileType = ShootControl.MissileType.Red_Missile;
            controller.HandleMissileType();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            controller.missileType = ShootControl.MissileType.Green_Missile;
            controller.HandleMissileType();
        }
    }
}
