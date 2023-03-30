
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private float _horizontal;
    private float _vertical;
    
    void Update()
    {
        Vector3 playerInput = new Vector3( _horizontal* Time.deltaTime, _vertical* Time.deltaTime,0);
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        transform.position= transform.position + playerInput.normalized *speed;
    
    }
}
