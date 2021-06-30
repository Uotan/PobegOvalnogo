using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WALK : MonoBehaviour
{
    [Header("Speeds")]
    public float JumpForce;
    private MoveState _moveState;



    private Rigidbody2D _rigidbody;
    private Animator _animatorController;
    string MSS;
    public AudioSource sound;
    public AudioClip[] audioClips = new AudioClip[2];
    public BoxCollider2D CALL;
    public GameObject Del;
    public GameObject Del2;
	
    public ForText script1;
    public bool isGrounded;

    //int add;

    private void Start()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
        _animatorController = GetComponent<Animator>();
        script1 = GameObject.Find("Text").GetComponent<ForText>();
    }

    public void Jump()
    {
        
        _rigidbody.velocity = (Vector2.up * JumpForce);
        sound.Play();
    }
    public void Walk()
    {
        _moveState = MoveState.Walk;
        _animatorController.Play("Walk");
    }


    private void Update()
    {
        MSS = _moveState.ToString();

        if (_moveState != MoveState.Dead&& isGrounded == true)
        {
            if (_moveState == MoveState.Walk)
            {
                CALL.size = new Vector2(0.19f, 0.28f);
                CALL.offset = new Vector2(0f, 0.14f);
                Walk();
                if (Input.GetKey(KeyCode.Space))
                {
                    Jump();
                }
                //if (ArrowUP.ispressed == true)
                //{
                //    Jump();
                //}
            }
            if (_moveState!= MoveState.Down)
            {
                _moveState = MoveState.Walk;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                _moveState = MoveState.Down;
                CALL.size = new Vector2(0.17f, 0.24f);
                CALL.offset = new Vector2(0f, 0.12f);
                _animatorController.Play("down_run");
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                _moveState = MoveState.Walk;
            }


        }
        if (isGrounded == false && _moveState != MoveState.Dead)
        {
            _moveState = MoveState.Jump;
            _animatorController.Play("Jump");
            CALL.size = new Vector2(0.28f, 0.26f);
            CALL.offset = new Vector2(0f, 0.13f);
        }

    }
    public enum MoveState
    {
        Walk,
        Jump,
        Dead,
        Down
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

        if (collision.gameObject.tag=="Enemy")
        {
            
            sound.clip = audioClips[1];
            sound.Play();
            _animatorController.enabled = false;
            _moveState = MoveState.Dead;
            _rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            Destroy(Del);
            Destroy(Del2);
            script1.Dead = false;

            var objs = GameObject.FindGameObjectsWithTag("Enemy"); 
            for (int i = 0; i < objs.Length; i++)
            {
                objs[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }

            var CLD = GameObject.FindGameObjectsWithTag("Cloud");
            for (int i = 0; i < CLD.Length; i++)
            {
                CLD[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
            PlayerPrefs.SetString("firstrun?","false"); //нужна, чтобы после проигрыша не показывалась подсказка
            Invoke("Ret", 1f);
        }

    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            isGrounded = false;
        }
    }
    private void Ret()
    {
        SceneManager.LoadScene(1);
    }
}
