using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatBar : MonoBehaviour
{
    public static bool BarEmpty = false;
    public Renderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player.isShooting) && (transform.localScale.x > 0))
        {
            float originalvalue = Renderer.bounds.min.x;
            transform.localScale -= new Vector3(0.005f, 0, 0);
            float newValue = Renderer.bounds.min.x;
            BarEmpty = false;

            transform.Translate(new Vector3(originalvalue - newValue, 0, 0));
        }
        else if (transform.localScale.x <= 0)
        {
            BarEmpty = true;
        }
        if ((!Player.isShooting) && (transform.localScale.x < 5))
        {
            float originalvalue = Renderer.bounds.min.x;
            transform.localScale += new Vector3(0.005f, 0, 0);
            float newValue = Renderer.bounds.min.x;
            BarEmpty = false;

            transform.Translate(new Vector3(originalvalue - newValue, 0, 0));
        }
    }
}
