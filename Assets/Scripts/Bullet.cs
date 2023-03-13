using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;

    static public int bulletDamage = 1;
    static public string gunMode = "normal";
    static public string curItem = "normal";

    Vector2 movementLeftUp;
    Vector2 movementRightUp;
    Vector2 movementLeftDown;
    Vector2 movementRightDown;

    bool shootLeftUp = false;
    bool shootRightUp = false;
    bool shootLeftDown = false;
    bool shootRightDown = false;

    void Awake()
    {
        FindObjectOfType<AudioManager>().Play("ShootGun");
    }

    // Start is called before the first frame update
    void Start()
    {
        SetDirectionBullet();
    }

    void Update()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        if (shootLeftUp)
        {
            rb.MovePosition(rb.position + movementLeftUp * 12.0f * Time.fixedDeltaTime);
        }
        else if (shootRightUp)
        {
            rb.MovePosition(rb.position + movementRightUp * 12.0f * Time.fixedDeltaTime);
        }
        else if (shootLeftDown)
        {
            rb.MovePosition(rb.position + movementLeftDown * 12.0f * Time.fixedDeltaTime);
        }
        else if (shootRightDown)
        {
            rb.MovePosition(rb.position + movementRightDown * 12.0f * Time.fixedDeltaTime);
        }
    }
    void SetDirectionBullet()
    {
        if (PlayerVirtualController.m_FireLeft && PlayerVirtualController.m_FireUp && gunMode == "normal")
        {
            movementLeftUp.x = -1;
            movementLeftUp.y = 1;
            shootLeftUp = true;
        }
        else if (PlayerVirtualController.m_FireRight && PlayerVirtualController.m_FireUp && gunMode == "normal")
        {
            movementRightUp.x = 1;
            movementRightUp.y = 1;
            shootRightUp = true;
        }
        else if (PlayerVirtualController.m_FireLeft && PlayerVirtualController.m_FireDown && gunMode == "normal")
        {
            movementLeftDown.x = -1;
            movementLeftDown.y = -1;
            shootLeftDown = true;
        }
        else if (PlayerVirtualController.m_FireRight && PlayerVirtualController.m_FireDown && gunMode == "normal")
        {
            movementRightDown.x = 1;
            movementRightDown.y = -1;
            shootRightDown = true;
        }
        else if (PlayerVirtualController.m_FireLeft)
        {
            rb.velocity = -transform.right * speed;
        }
        else if (PlayerVirtualController.m_FireRight)
        {
            rb.velocity = transform.right * speed;
        }
        else if (PlayerVirtualController.m_FireUp)
        {
            rb.velocity = transform.up * speed;
        }
        else if (PlayerVirtualController.m_FireDown)
        {
            rb.velocity = -transform.up * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("collision name = " + hitInfo.gameObject.name);
        if (hitInfo.gameObject.name == "Tilemap_SolidBlock")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (1)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (2)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (3)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (4)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (5)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (6)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (7)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (8)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (9)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (10)")
        {
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.name == "Block (11)")
        {
            Destroy(gameObject);
        }
    }
}
