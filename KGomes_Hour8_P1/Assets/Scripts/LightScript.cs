using UnityEngine;

public class LightScript : MonoBehaviour
{
    public float intensity_one = 2f;
    public float intensity_two = 0f;
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            myLight.intensity = 0;
        else
            myLight.intensity = 2;
    }
}
