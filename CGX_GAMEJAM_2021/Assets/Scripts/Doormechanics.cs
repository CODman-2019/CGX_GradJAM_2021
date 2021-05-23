using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doormechanics : MonoBehaviour
{
    public Transform pivot;
    public float rotation, time;

    private bool isOpened, inMotion;

    // Start is called before the first frame update
    void Start()
    {
        isOpened = false;   
    }

    public void Opendoor()
    {
        inMotion = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (inMotion)
        {
            Vector3 curr = pivot.transform.position;
            if (!isOpened)
            {
                pivot.transform.Rotate(0, rotation, 0);
                isOpened = true;
            }
            else
            {
                pivot.transform.Rotate(0, -rotation, 0);
                isOpened = false;
            }
            
        }
    }
}
