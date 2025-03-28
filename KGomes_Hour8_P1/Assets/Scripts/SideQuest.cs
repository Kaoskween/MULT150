using UnityEngine;
public class SideQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    int TakeDamage(int damageAmount)
    {
        int health = 100;
        return health - damageAmount;
    }
    /*Method name is TakeDamage */
    /*Variable that is returned is health - damageAmount */
    /*One parameter and it is int damageAmount */
    /*The code is int health = 100, return health - damageAmount */

    // Update is called once per frame
    void Update()
    {

    }
}