using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int itemCount = 10;
    public Vector3 startPosition;
    public float spacing;
    // Start is called before the first frame update
    void Start()
    {
        for (itemCount = 10; itemCount > 0; itemCount--)
        {
            Vector3 currentPosition = startPosition + Vector3.right * (itemCount * spacing);
            GameObject newObject = Instantiate(prefab, currentPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
