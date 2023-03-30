
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private float _horizontal;
    private float _vertical;
    private Animator _anim;
    private static readonly int IsRunning = Animator.StringToHash("isRunning");
    private bool _isfacingRight; 

    void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        Vector3 playerInput = new Vector3( _horizontal* Time.deltaTime, _vertical* Time.deltaTime,0);
        transform.position= transform.position + playerInput.normalized *speed;

        if (_horizontal < 0 && !_isfacingRight)
        {
            _anim.SetBool(IsRunning, true);
            Flip();
        }
        if (_horizontal > 0 && _isfacingRight)
        {
            _anim.SetBool(IsRunning, true);
            Flip();
        }
        if (_horizontal != 0 )
        {
            _anim.SetBool(IsRunning, true);
           
        }

        if (_horizontal == 0)
        {
            _anim.SetBool(IsRunning, false);
        }
        if (_vertical > 0 || _vertical <0)
        {
            _anim.SetBool(IsRunning, true);
        }
        
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        _isfacingRight = !_isfacingRight;
    }
}
