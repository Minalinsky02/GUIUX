using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Camera playerCamera; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ShootingStuff();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletP = Instantiate(bullet);
            bulletP.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletP.transform.forward = playerCamera.transform.forward;
        }
    }

    
  

}
