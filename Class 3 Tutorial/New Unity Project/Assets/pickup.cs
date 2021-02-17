using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public string pickupTag;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag(pickupTag))
        {
            Debug.Log("Collision detected with tag");
            Destroy(collision.collider.gameObject); 

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
