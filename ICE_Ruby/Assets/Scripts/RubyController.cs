using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public int maxhealth = 5;//最大生命值
    private int currentHealth;//当前生命值
    public int speed = 4;
    // Start is called before th e first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigidbody2D = GetComponent<Rigidbody2D>();
        currentHealth = maxhealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        //玩家输入监听
        float horizontal=Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Ruby移动控制
        Vector2 position = transform.position;
        
        position.x += speed * horizontal*Time.deltaTime;
        position.y += speed * vertical*Time.deltaTime;
        //transform.position = position;
        rigidbody2D.MovePosition(position);
    }

    private void changehealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth+amount,0,maxhealth);
        Debug.Log(currentHealth + "/" + maxhealth);
    }
}
