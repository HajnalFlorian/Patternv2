using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{
    public static event Action<GameObject> onCubeCliked;

    private void OnMouseDown() => onCubeCliked?.Invoke(gameObject);
}
