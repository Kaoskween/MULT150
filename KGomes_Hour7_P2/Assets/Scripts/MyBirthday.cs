using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                for (int count = 1; count <= 31; count++)
        {
            if (count == 7)
            {
                print("Its my birthday!");
            }
            else if (count <= 31)
            {
                print(count);
            }
        }
          }

    // Update is called once per frame
    void Update()
    {
        
    }
}
