
using UnityEngine;

public class MiniCamScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position = player.position + offset;

        Vector3 rot = new Vector3(90, player.eulerAngles.y, 0);
        transform.rotation= Quaternion.Euler(rot);
    }
}
