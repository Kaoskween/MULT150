using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UsePotion(3992);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int UsePotion(int health = 0)
    {
        while (health <= 1600)
        {
            health += 400;
        }
        return 3992 + health;
    }
}
