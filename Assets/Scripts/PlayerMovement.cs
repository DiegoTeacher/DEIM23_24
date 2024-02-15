using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float vel = 5f;
    public float gravityForce = -9.81f;
    public float jumpForce = 20f;
    private float playerYVelocity;

    public float maxVel;
    public float acceleration;
    private CharacterController controller;
    private Animator animator;
    private string filePath;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        filePath =  Application.persistentDataPath + "/savedData.json";
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        Save();
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if ((x != 0 || z != 0) && vel < maxVel)
        {
            vel += acceleration * Time.deltaTime;
        }
        else
        {
            vel -= acceleration * Time.deltaTime * 2;
            if(vel < 0)
                vel = 0;
        }

        //else
        //{
        //    vel = orVel;
        //}

        animator.SetFloat("vel", vel/maxVel);

        // RIGID BODY
        //rb.velocity = 
        //    transform.forward * vel * z + 
        //    transform.right * vel * x + 
        //    transform.up * rb.velocity.y;
        Vector3 movementVector = transform.forward * vel * z +
            transform.right * vel * x +
            transform.up * gravityForce;

        playerYVelocity += gravityForce;

        if(Input.GetKey(KeyCode.Space) && controller.isGrounded)
        {
            playerYVelocity = jumpForce;
        }
        movementVector += transform.up * playerYVelocity;
        controller.Move(movementVector * Time.deltaTime);
        
        Load();
    }

    void Save()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Data data = new Data();
            data.pos = transform.position;
            data.rot = transform.rotation;

            StreamWriter streamWriter = new StreamWriter(filePath);
            string json = JsonUtility.ToJson(data);
            streamWriter.Write(json);
            streamWriter.Close();
        }
    }

    void Load()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(File.Exists(filePath))
            {
                StreamReader streamReader = new StreamReader(filePath);
                string fileContent = streamReader.ReadToEnd();
                Data data = JsonUtility.FromJson<Data>(fileContent);
                transform.position = data.pos;
                transform.rotation = data.rot;

                streamReader.Close();
            }
        }
    }
}

[System.Serializable]
public struct Data
{
    public Quaternion rot;
    public Vector3 pos;
}
