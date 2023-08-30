using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Skor");
        _text.text = skor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float skor = 0;
    public TextMeshProUGUI _text;

    private void OnCollisionEnter(Collision col)
    {
        string temp;
        if (col.gameObject.tag == "Engel")
        {
            skor--;
            PlayerPrefs.SetFloat("Skor", skor);
        }

        print(PlayerPrefs.GetFloat("Skor"));
        temp = skor.ToString();
        _text.text = temp;
    }

}
