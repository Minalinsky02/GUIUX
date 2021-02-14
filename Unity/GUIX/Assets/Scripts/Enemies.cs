using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemies : MonoBehaviour
{
    public int scoreValue = 1;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Score.ScorePT += scoreValue;
  
    }
  
}
