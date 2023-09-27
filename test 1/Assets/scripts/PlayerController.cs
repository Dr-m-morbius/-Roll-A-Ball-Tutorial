using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI CountText;
    public GameObject WinText;
    public GameObject Trapdoor1a;
    public GameObject Trapdoor1b;
    public GameObject Trapdoor2;
    public GameObject Trapdoor3;
    public GameObject Trapdoor4;
    public GameObject Trapdoor5;
    public GameObject Trapdoor6;
    public GameObject Trapdoor7;

    public float Speed = 10f;

    private float _horozontalinput;
    private float _forwardinput;
    private int _count;

    private Rigidbody _PlayerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _PlayerRigidbody = GetComponent<Rigidbody>();
        _count = 0;
        CountText.text = "count: " + _count.ToString();
        WinText.gameObject.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        _horozontalinput = Input.GetAxis("Horizontal");
        _forwardinput = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_horozontalinput, 0.0f, _forwardinput);

        _PlayerRigidbody.AddForce(movement * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 1;
            CountText.text = "Count: " + _count.ToString();

            if(_count >= 8)
            {
                WinText.gameObject.SetActive(true);
            }
            if(_count >= 1) 
            {
                Trapdoor1a.gameObject.SetActive(false);
            }
            if (_count >= 1)
            {
                Trapdoor1b.gameObject.SetActive(false);
            }
            if (_count >= 2)
            {
                Trapdoor2.gameObject.SetActive(false);
            }
            if (_count >= 3) 
            {
                Trapdoor3.gameObject.SetActive(false);
            }
            if (_count >= 4)
            {
                Trapdoor4.gameObject.SetActive(false);
            }
            if (_count >= 5)
            {
                Trapdoor5.gameObject.SetActive(false);
            }
            if (_count >= 6)
            {
                Trapdoor6.gameObject.SetActive(false);
            }
            if (_count >= 7)
            {
                Trapdoor7.gameObject.SetActive(false);
            }

        }
    }
}

