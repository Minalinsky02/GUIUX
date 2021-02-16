using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Loader", 7f);
    }

    // Update is called once per frame
    void Loader()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
