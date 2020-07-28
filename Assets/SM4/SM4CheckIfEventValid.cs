using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM4CheckIfEventValid : MonoBehaviour
{
    public SM4SlaveMaker slaveMaker = new SM4SlaveMaker();
    public List<SM4Slave> listOfSlaves = new List<SM4Slave>();
    public List<SM4Character> listOfNpcs = new List<SM4Character>();

    public static SM4CheckIfEventValid instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            ErrorLogger.LogErrorInFile("Error in " + this.name);
            Destroy(gameObject);
        }
    }

    public bool CheckIfEventValid(SM4Event sm4Event)
    {
        foreach (var attribute in sm4Event.attributes)
            if (!CheckAttribute(attribute.Key, attribute.Value))
                return false;

        return true;
    }

    // Example: <if gender = '2+'>
    // key = "gender"
    // value = "2+"
    public bool CheckAttribute(string key, string value)
    {
        string[] keyParts = key.Split('-');
        string restOfKey;
        object keyItem = null;
        //Retrieve Key Item
        switch (keyParts[0])
        {
            case "sm":
                restOfKey = key.Remove(0, keyParts[0].Length + 1);
                keyItem = this.slaveMaker.GetItemByValue(restOfKey);
                break;
            case "slave":
                SM4Slave slave = this.GetSlaveByID(keyParts[1]);
                if (slave == null)
                {
                    return false;
                }
                restOfKey = key.Remove(0, keyParts[0].Length + keyParts[1].Length + 2);
                keyItem = slave.GetItemByValue(restOfKey);
                break;
            case "npc":

                SM4Character npc = this.GetNPCByID(keyParts[1]);
                if (npc == null)
                {
                    return false;
                }
                restOfKey = key.Remove(0, keyParts[0].Length + keyParts[1].Length + 2);
                keyItem = npc.GetItemByValue(restOfKey);
                break;
            case "event":
                //CheckAttributeEvent(keyParts, value, checkIsTrue);
                break;
            case "item":
                //CheckAttributeItem(keyParts, value, checkIsTrue);
                break;
            default:
                ErrorLogger.LogErrorInFile("Key not recognized: " + key);
                break;
        }

        //If failed to retrieve key, the event is not valid.
        if (keyItem == null)
        {
            return false;
        }
        //Compare Key to Value
        return CompareKeyToValue(keyItem, value);
    }

    //Gets Slave by ID.  Returns Null on Failure because Unity doesn't handle exceptions performantly.
    private SM4Slave GetSlaveByID(string ID)
    {
        int intID;
        if (!Int32.TryParse(ID, out intID))
        {
            return null;
        }

        foreach (SM4Slave slave in this.listOfSlaves)
        {
            if (slave.slaveID == intID)
            {
                return slave;
            }
        }
        return null;
    }

    //Gets NPC by ID.  Returns Null on Failure because Unity doesn't handle exceptions performantly.
    private SM4Character GetNPCByID(string ID)
    {
        int intID;
        if (!Int32.TryParse(ID, out intID))
        {
            return null;
        }

        foreach (SM4Character npc in this.listOfNpcs)
        {
            if (npc.ID == intID)
            {
                return npc;
            }
        }
        return null;
    }

    //Compares Key to Value.  Comparison is based on the Stat comparison available (Bool compares to bool, string compares to string, numbers compare with number compare feature.
    private static bool CompareKeyToValue(object keyItem, string value)
    {
        Type keyType = keyItem.GetType();
        if (keyType == typeof(string))
        {
            return ((string)keyItem).Equals(value, StringComparison.OrdinalIgnoreCase);
        }
        if (keyType == typeof(int) || keyType == typeof(float))
        {
            int keyValue = Convert.ToInt32(keyItem);
            int numValue;
            bool greaterThan = value.EndsWith("+");
            bool lesserThan = value.EndsWith("-");
            if (greaterThan || lesserThan)
            {
                value = value.Remove(value.Length - 1, 1);
            }
            if (!Int32.TryParse(value, out numValue))
            {
                return false;
            }
            if (greaterThan)
                return keyValue >= numValue;
            else if (lesserThan)
                return keyValue <= numValue;
            else
                return keyValue == numValue;
        }
        if (keyType == typeof(bool))
        {
            if (value.Equals("true", StringComparison.OrdinalIgnoreCase) && (bool)keyItem)
            {
                return true;
            }
            if (value.Equals("false", StringComparison.OrdinalIgnoreCase) && !(bool)keyItem)
            {
                return true;
            }
            return false;
        }

        ErrorLogger.LogErrorInFile("Key Type not recognized: " + keyType);
        return false;
    }
}