using UnityEngine;

public class GridManager : MonoBehaviour
{
    //get vector location and xyz
    public Transform gridPoint;
    //get player location
    public GameObject player;

    void Start()
    {
        Vector3 positionPlayer = player.transform.position;
        Vector3 positionPoint = gridPoint.transform.position;
        
        Debug.Log($"Target position: {positionPlayer.x} {positionPlayer.y} {positionPlayer.z}");
    }
    //use xyz with the player location/10
    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, gridPoint.transform.position);
        float cellDistance = distance / 10;
    }
    //create grid
    //spawn objects on grid
}
