using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Missile : MonoBehaviour, IMissile
{
    public void Shoot()
    {
        Vector3 initialPosition = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
        GameObject Red_Missile = Instantiate(Resources.Load("Red_MissilePrefab", typeof(GameObject))) as GameObject;
        //GameObject Red_Missile = Resources.Load("Red_MissilePrefab", typeof(GameObject)) as GameObject;
        //Instantiate(Red_Missile);
        /*if(Red_Missile == null)
        {
            Debug.Log("Y'a R");
        }*/
        Red_Missile.transform.position = initialPosition;
        Red_Missile.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 20f);
    }
}
