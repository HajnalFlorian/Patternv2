using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Missile : MonoBehaviour, IMissile
{
    public void Shoot()
    {
        Vector3 initialPosition = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
        GameObject bullet = Instantiate(Resources.Load("Green_MissilePrefab", typeof(GameObject))) as GameObject;
        bullet.transform.position = initialPosition;
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 20f);
    }
}
