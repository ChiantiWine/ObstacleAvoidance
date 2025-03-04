
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public float mouseSensitivity = 400f;
   
    // 추가 할 사항 화면이 좌우로 이동 시 Player도 함께 그 방향으로 바라보기
    // new InputSystem 사용 하기기

   float MouseX;
   float MouseY;

    void Update()
    {
        ScreenRotate();
    }
     void ScreenRotate()
    {
        MouseX += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        MouseY = Mathf.Clamp(MouseY, -90f, 90f);

       transform.localRotation = Quaternion.Euler(0f, MouseX, 0f);

    }

}
