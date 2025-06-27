using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAround : MonoBehaviour
{
    private float timer = 0;
    private float t = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=1)
        {
            timer = 0;
            Vector3 currentPos = transform.position;
           
            Vector3 nextPos = new Vector3(currentPos.x, currentPos.y + 1, currentPos.z);
            transform.position = Vector3.Lerp(currentPos,nextPos, t);
            t += 1;
        }
    }
}
