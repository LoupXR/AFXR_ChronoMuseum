using UnityEngine;

public class InverseActivation : MonoBehaviour
{

    public GameObject[] gosActivate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        foreach (GameObject go in gosActivate)
        {
            go.SetActive(false);
        }
    }

    void OnDisable()
    {
        foreach (GameObject go in gosActivate)
        {
            go.SetActive(true);
        }
    }
}
