using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "door_001") {
            SceneManager.LoadScene("VRTemplate");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "door_001")
        {
            SceneManager.LoadScene("VRTemplate");
        }
        if (other.gameObject.name == "Door_1_Brown")
        {
            SceneManager.LoadScene("Okanemochi");
        }
    }
}
