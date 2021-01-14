using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    private void OnEnable() => Cube.onCubeCliked += HasClickedOnCube;

    private void OnDisable() => Cube.onCubeCliked -= HasClickedOnCube;

    private void HasClickedOnCube(GameObject a)
    {
        Color couleur = new Color(Random.value, Random.value, Random.value);

        a.GetComponent<MeshRenderer>().material.color = couleur;
    }
}
