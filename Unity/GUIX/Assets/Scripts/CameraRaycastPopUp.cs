using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRaycastPopUp : MonoBehaviour
{
    public GameObject popUp;
    public static bool popUpUI = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamRaycast();
    }

    void CamRaycast()
    {
        RaycastHit hit;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 20f))
        {
            popUp.SetActive(true);
        }
        else
        {
            popUp.SetActive(false);
        }

    }
}
