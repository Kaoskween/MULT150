using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    int health = 0;
    // Start is called before the first frame update
    void Start()
    {
        UsePotion(healthpoints);
        print(healthpoints);
        UsePotion(healthpoints);
        print(healthpoints);
        UsePotion(healthpoints);
        print(healthpoints);
        UsePotion(healthpoints);
        print(healthpoints);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int UsePotion (int healthpoints = 3992)
    {
        for (int health = 0; health <= 1600; health += 400)
        {
            healthpoints += health;
        }
        return healthpoints += health;
    }
}
