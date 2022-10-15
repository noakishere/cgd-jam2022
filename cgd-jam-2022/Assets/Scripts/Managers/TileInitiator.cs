using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInitiator : SingletonMonoBehaviour<TileInitiator>
{
    [SerializeField] private GameObject grid;
    [SerializeField] private List<GridBehaviour> grids;
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
            for (int j = -4; j <= 4; j++)
            {
                Instantiate(grid, new Vector3(j * 2.0f, i * 2.0f, 0), Quaternion.identity);
            }
        }
    }

    // This could be refactored for performance with events and such
    public void PopulateList(GridBehaviour newGrid)
    {
        grids.Add(newGrid);
    }


}
