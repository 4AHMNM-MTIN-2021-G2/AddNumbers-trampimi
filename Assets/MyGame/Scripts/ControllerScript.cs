using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour
{

    public InputField Wert_1;
    public InputField Wert_2;
    public Text Ergebnis;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addieren()
    {
        var Wert_1_t = int.Parse(Wert_1.text);

        var Wert_2_t = int.Parse(Wert_2.text);

        var Wert_gesamt = Wert_1_t + Wert_2_t;

        Ergebnis.text = Wert_gesamt.ToString();

        Debug.Log(Wert_gesamt);

    }
}
