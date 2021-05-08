using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHolder : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GroundPlacementController control;
    public Item x;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_Item(Item it)
    {
        int i = 0;
        int ID = it.ID;
        switch (ID)
        {
            case 0:
                //nothing happens
                break;
            case 1:
                control.ChangeCurrentPlaceableObject(obj1);
                break;
            //case 2:

            //    break;
            //case 3:

            //    break;
            //case 4:

            //    break;
            //case 5:

            //    break;
            //case 6:

            //    break;
            //case 7:

            //    break;
            //case 8:

            //    break;
            //case 9:

            //    break;
            //case 10:

            //    break;
            //case 11:

            //    break;
            //case 12:

            //    break;
        }
            




    }

}
