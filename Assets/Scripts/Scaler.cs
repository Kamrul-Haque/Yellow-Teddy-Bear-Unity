using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// makes game object larger
/// </summary>
public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= 3;
        newScale.y *= 4;
        transform.localScale = newScale;
    }
}
