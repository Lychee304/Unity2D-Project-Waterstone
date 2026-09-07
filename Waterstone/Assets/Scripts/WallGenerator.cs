using UnityEngine;

public class WallGenerator : MonoBehaviour
{

    public GameObject Wall1;
    public GameObject Wall2;  // vertical wall
    public GameObject Player;
    public GameObject TargetObjectN; // north
    public GameObject TargetObjectW; // west
    public GameObject TargetObjectS; // south
    public GameObject TargetObjectE; // east
    public GameObject TargetObjectP; // player
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Wall2, TargetObjectW.transform.position, Quaternion.identity);
        Instantiate(Wall2, TargetObjectE.transform.position, Quaternion.identity);
        Instantiate(Wall1, TargetObjectN.transform.position, Quaternion.identity);
        Instantiate(Wall1, TargetObjectS.transform.position, Quaternion.identity);
        Instantiate(Player, TargetObjectP.transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
