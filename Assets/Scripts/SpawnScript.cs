using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSpawning());
    }

    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(4);

        for (int i=0; i<3; i++)
        {
            Instantiate(objects[i], points[i].position, Quaternion.identity);
        }
        StartCoroutine(startSpawning());
    }
}
