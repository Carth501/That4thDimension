using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dimensions;



    // Start is called before the first frame update
    void Start()
    {
        Switch(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Switch(1);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            Switch(2);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            Switch(3);
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            Switch(4);
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            Switch(5);
        }
    }

    private void Switch(int dim)
    {
        if(dim > 5 || dim < 0)
        {
            return ;
        }
        else
        {
            foreach(GameObject element in dimensions)
            {
                element.SetActive(false);
            }
            dimensions[0].SetActive(true);
            dimensions[dim].SetActive(true);
        }
    }
}
