using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item: MonoBehaviour
{
    //Eşyaların türlerine göre kuşanılmasını ve kullanılmasını sağlayan kısım
    public string type;
    public int ID;
    public string description;
    public Sprite icon;
    public bool pickedUp;
    [HideInInspector]
    public bool equipped;
    
    [HideInInspector]
    public GameObject obje;

    [HideInInspector]
    public GameObject weaponManager;

    public bool playersWeapon;
    public GroundPlacementController A;

    public ObjectHolder hold;

    //Silahları tarayan ve kuşanmayı kontrol eden kısım (sanırım)
    public void Start()
    {
        weaponManager = GameObject.FindWithTag("WeaponManager");
        if (!playersWeapon)
        {
            int allWeapons = weaponManager.transform.childCount;
            for(int i = 0; i < allWeapons; i++)
            {
                if(weaponManager.transform.GetChild(i).gameObject.GetComponent<Item>().ID == ID)
                {
                    obje = weaponManager.transform.GetChild(i).gameObject;
                }
            }
        
        }
    }

    //Eşya durumuna bakan kısım giy/çıkar
    public void Update()
    {
        if (equipped)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                equipped = false;
            }
            if(equipped == false)
            {
                this.gameObject.SetActive(false);
            }

        }
        else
        {
            //for now nothing happens

        }
    }
    //Item tipine göre kuşanmaya ve kullanmaya bakan kısım
    //Silah tut,iksir iç vs...
    public void ItemUsage()
    {
        if(type == "Weapon")
        {
            obje.SetActive(true);
            obje.GetComponent<Item>().equipped = true;
            A.ChangeCurrentPlaceableObject(obje);
            //hold.ChangeItem(obje.GetComponent<Item>());
        }
    }



    

}
