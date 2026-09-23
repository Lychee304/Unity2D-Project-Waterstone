// yes, its called handy because its a script for the hand... aint i funny :D

using UnityEngine;

public class handyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("handy dandy scripty loady");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bone"))
        {
            print("bone shivering");
            Destroy(this.gameObject);
        }


    }
}
