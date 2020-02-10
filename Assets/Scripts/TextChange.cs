using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{

    public Font[] misFuentes;
    public TMP_FontAsset[] misFuentes2;
    public Text texto;
    public Slider fontSizeS;
    public InputField miTexto;
    private int contador;
    public TextMeshPro textoTemplate;




    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        texto.font = misFuentes[contador];
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            contador += 1;
            texto.font = misFuentes[contador];
            textoTemplate.font=misFuentes2[contador];
            if (contador >= 4)
            {
                contador = 0;
                texto.font = misFuentes[contador];
                textoTemplate.font=misFuentes2[contador];
            }
        }
        texto.text=miTexto.text;
        texto.fontSize=(int)fontSizeS.value;
        textoTemplate.text=texto.text;
        textoTemplate.fontSize=(int)fontSizeS.value-10;

    }
}
