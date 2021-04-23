using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BalloonPhysics : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float t = Time.deltaTime;
        transform.Translate(Vector3.up*t*1.0f);
        int val = Random.Range(0, 4);
        int val1 = Random.Range(0, 10);
        if (val1 == 0)
        {
            if (val == 0)
            {
                transform.Translate(Vector3.left * t * 10f);
            }
            if (val == 1)
            {
                transform.Translate(Vector3.right * t * 10f);
            }
            if (val == 2)
            {
                transform.Translate(Vector3.up * t * 5f);
            }
            if (val == 3)
            {
                transform.Translate(Vector3.down * t * 3f);
            }
        }
    }
}
