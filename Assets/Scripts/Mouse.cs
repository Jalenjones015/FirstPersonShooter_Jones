using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
  [SerializeField] Transform PlayerCam = null;
    [SerializeField] float sensitivity = 1;
    public bool locked = true;
    float Camx = 0f;

    void Start()
    {
        if (locked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        moving();
    }

     public void moving()
    {
        Vector2 mousemoving = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Camx -= mousemoving.y * sensitivity;
        Camx = Mathf.Clamp(Camx, -90f, 90f);

        PlayerCam.localEulerAngles = Vector3.left * Camx;

        transform.Rotate(Vector3.up * mousemoving.x * sensitivity);
    }
}
