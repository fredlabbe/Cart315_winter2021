using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject prefab;

    int delay = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            delay += 1; 
            if(delay >= 15) {
                delay = 0;
                Ray clickRay = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit result;
                if (Physics.Raycast(clickRay, out result))
                {
                    GameObject.Instantiate(prefab, result.point, Quaternion.identity);
                }
            } 
                       
        }
        else
        {
            delay = 15;
        }
    }
}
