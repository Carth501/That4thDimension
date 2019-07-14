using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dimensions;
    private float endTime;
    [SerializeField]
    private float delay;
    private bool won = false;
    [SerializeField]
    private string nextLevel;



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

        if(won && endTime <= Time.time)
        {
            Debug.Log("Game Won.");
            if(nextLevel != null)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }

    public void sceneWon()
    {
        won = true;
        endTime = Time.time + delay;
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
