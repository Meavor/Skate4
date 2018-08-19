using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
	public GameObject linePrefab;

	Line activeLine;

	void Update ()
	{

	}

    void Generate ()
    {
        GameObject obj = GameObject.Instantiate(linePrefab);

    }
}
