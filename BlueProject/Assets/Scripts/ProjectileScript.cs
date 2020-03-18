using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public static bool flipX = false;
    public static float speed = 30;
    bool DirectionChosen = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!flipX)
            DirectionChosen = false;
        else
            DirectionChosen = true;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (!DirectionChosen)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if ((transform.position.x > 8) || (transform.position.x < -8))
            {
                Destroy(gameObject);
            }
        

    }
}
