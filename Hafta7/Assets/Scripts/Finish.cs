using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject FinishPanel;
    public GameObject RetryPanel;

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "FinishLine")
        {
            FinishPanel.gameObject.SetActive(true);
        }

        if(PlayerPrefs.GetFloat("Skor") < 0)
        {
            RetryPanel.gameObject.SetActive(true);
        }
    }
}
