using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball(5);
        print("Player health:" + x);
        int y = TakeDamageFromFireball(25);
        print("Player health:" + y);
        int z = TakeDamageFromFireball(30, 50);
        print("Player health:" + z);
    }

    //Method call with a value of 5
    private global::System.Int32 GetTakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    int TakeDamageFromFireball(int damage = 25)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    int TakeDamageFromFireball(int damage = 30, int playerHealth = 50)
    {
            return playerHealth - damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
