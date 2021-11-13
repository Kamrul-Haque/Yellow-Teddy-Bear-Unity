using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float MinForce = 3f;
        const float MaxForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);

        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinForce, MaxForce);

        GetComponent<Rigidbody2D>().AddForce(magnitude * direction, ForceMode2D.Impulse);
    }
}
