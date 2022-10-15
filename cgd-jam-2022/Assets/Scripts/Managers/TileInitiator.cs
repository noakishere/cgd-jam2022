using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInitiator : MonoBehaviour
{
    [SerializeField] private GameObject testMe;
    public int gridNum;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO");
        MakeGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MakeGrid()
    {
        for (int i = -2; i <= 2; i++)
        {
            Debug.Log($"<color=green>Row {i} is now</color>");
            //Instantiate(testMe, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
            for (int j = -4; j <= 4; j++)
            {
                Debug.Log($"{j} is numebr J");
                // Debug.Log($"Column {j}");
                Instantiate(testMe, new Vector3(j * 2.0f, i * 2.0f, 0), Quaternion.identity);
            }
        }
    }


}
