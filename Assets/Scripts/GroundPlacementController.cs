using UnityEngine;
public class GroundPlacementController : MonoBehaviour
{
    [SerializeField]
    public GameObject placeableObjectPrefab;
    [SerializeField]
    private KeyCode newObjectHotkey = KeyCode.A;
    private GameObject currentPlaceableObject;
    private float mouseWheelRotation;
    private int CurrentPrefabIndex;

    private GameObject Placed;

    [HideInInspector]
    public GameObject weaponManager;

    private void Update()
    {
        HandleNewObjectHotkey();
        if (currentPlaceableObject != null && Input.GetMouseButtonDown(0))
        {
            MoveCurrentObjectToMouse();
            RotateFromMouseWheel();
            ReleaseIfClicked();
        }
    }
    private void HandleNewObjectHotkey()
    {
        //for (int i = 0; i < placeableObjectPrefabs.Length; i++)
        //{
        //}
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = Instantiate(placeableObjectPrefab);
        }
    }
    
    private void MoveCurrentObjectToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            currentPlaceableObject.transform.position = hitInfo.point;
            currentPlaceableObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }
    //SONRA GÜNCELLENECEK
    //Yere yerleştirilecek objenin baktığı yönü değiştirmek için olan kısım
    private void RotateFromMouseWheel()
    {
        mouseWheelRotation += Input.mouseScrollDelta.y;
        currentPlaceableObject.transform.Rotate(Vector3.up, mouseWheelRotation * 10f);
    }
    //Klonların yok edilmemesini sağlayan kısım
    private void ReleaseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = null;
        }
    }
    //Farklı bir objeyi seçip yere yerleştirmek için gereken kısım
    public void ChangeCurrentPlaceableObject(GameObject Placeable)
    {
        Debug.Log("Ok");
        placeableObjectPrefab = Placeable;
    }
}