using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Color colors,nextColors;
    public Light lightCom;
    public float changeSpeed = 2f;

    
    private float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        lightCom = GetComponent<Light>();
        if (colors == null) colors = new Color(Random.value, Random.value, Random.value);
        nextColors = new Color(1, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * changeSpeed;
        lightCom.color = Color.Lerp(colors, nextColors, t);
        if(t>1)
        {
            t = 0;
            colors = nextColors;
            nextColors = new Color(Random.value, Random.value, Random.value);
        }
            
    }
}
