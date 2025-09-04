using UnityEngine;

public class GridManager
{
    //gameobject for the grid
    public GameObject gridCellPrefab;
    
    public int gridSizeX = 10;
    public int gridSizeY = 10;
    public int gridSizeZ = 10;

//Array to store grids
    private GameObject[] gridCells;
    public void Start()
    {
        GridCreation();
    }
    public void GridCreation()
    {
        gridCells = new GameObject(gridSizeX, gridSizeY, gridSizeZ);

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                for (int z = 0; z < gridSizeZ; z++)
                {
                    Vector3 position = new Vector3(x, y, z);

                    GameObject cell = Instantiate(gridCellPrefab, position, Quaternion.identity);

                    cell.name = $"Cell_{x}_{y}_{z}";
                    gridCells[x,y,z] = cell;
                }
            }
        }
    }
}
