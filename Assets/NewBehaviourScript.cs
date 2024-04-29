using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject NewCard;
    private bool arrastrao = false;


    public void arrastrable()
    {
        arrastrao=true;
        
    }

    public void inarrastrable()
    {
        arrastrao =false;

    }








    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arrastrao)
        {
            transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
    }
}
