using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using TMPro;
using UnityEngine;

public class SM4EventExecute : MonoBehaviour
{
    public static SM4EventExecute instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            ErrorLogger.LogErrorInFile("Error in " + this.name);
            Destroy(gameObject);   
        }
    }

    public bool ExecuteEvent(SM4Event sm4Event)
    {
        try
        {
            ReadSubTree(sm4Event.xElement);
            return true;
        }
        catch 
        {
            ErrorLogger.LogErrorInFile("Error when Executing event" + sm4Event.eventName);
            return false;
        }
    }
    
     public void ReadSubTree(XElement xElement)
     {
         var xElementSubtree = XElement.Load(xElement.CreateNavigator().ReadSubtree());
         InterateTheSubTree(xElementSubtree);
     }

     public string lastPersonspeak = "1";

     public void InterateTheSubTree(XElement xElement)
     {
         
         
         string nodeName = xElement.Name.ToString();
         
         switch (nodeName)
         {
             case "LineBreak":
                 SM4UIMainTextfield.instance.LineBreak();
                 break;
             case "ClearTextField":
                 SM4UIMainTextfield.instance.ClearText();
                 break;
             case "BlankLine":
                 SM4UIMainTextfield.instance.BlankLine();
                 break;
             case "HideImages":
                 SM4ImageLoader.instance.ClearIntanciatedImages();
                 SM4ImageLoader.instance.ClearLayerImages();
                 break;
             case "SetImage":
                 SM4ImageLoader.instance.InstanciateRawImage(GetImageAttributes(xElement));
                 break;
             case "SetImageLayer":
                 SM4ImageLoader.instance.AddLayerImage(GetImageAttributes(xElement));
                 break;
             case "Points":
                 Debug.Log(nodeName);
                 break;
             default:
                 
                 break;
         }
         
         foreach (var node in xElement.Nodes())
         {
             if (node.NodeType == XmlNodeType.Text)
             {
                 if (xElement.Name == "AddText")
                 {
                     var formatAttributes = GetTextFormatAttributes(xElement);
                     SM4UIMainTextfield.instance.AddText(formatAttributes[0] + node.ToString() + formatAttributes[1]);
                 }
                 if (xElement.Name == "SetText")
                 {
                     SM4UIMainTextfield.instance.AddText(node.ToString());
                 }

                 if (xElement.Name == "PersonSpeak")
                 {
                     if (lastPersonspeak == node.Parent.ToString())
                     {
                         var formatAttributes = GetTextFormatAttributes(xElement);
                         SM4UIMainTextfield.instance.AddText(formatAttributes[0] + node.ToString() + formatAttributes[1]);
                     }
                     else
                     {
                         var personSpeak = new PersonSpeakAttributes();
                         var formatAttributes = GetTextFormatAttributes(xElement);
                         GetPersonSpeakAttributes(
                             personSpeak, 
                             xElement, 
                             formatAttributes[0] + node.ToString() + formatAttributes[1]);
                         SM4UIMainTextfield.instance.PersonSpeak(personSpeak);
                         lastPersonspeak = node.Parent.ToString();
                     }
                     
                 }
                 
                 
             }

             if (xElement.Name == "if")
             {
                 Debug.Log("If node always returns true");
                 // uncomment the part below to actually chec
                 // if (!CheckAttributeList(GetAttributeList(xElement)))
                 // {
                 //     continue;
                 // }
                 if (node.NodeType == XmlNodeType.Text)
                 {
                     var formatAttributes = GetTextFormatAttributes(xElement);
                     SM4UIMainTextfield.instance.AddText(formatAttributes[0] + node.ToString() + formatAttributes[1]);
                 }
             }
             
             if (node.NodeType == XmlNodeType.Element)
             {
                 ReadSubTree(XElement.Load(node.CreateNavigator().ReadSubtree()));
             }
         }
         
        
     }

     public string[] GetTextFormatAttributes(XElement xElement)
     {
         string formattingCommandsStart = "<color=#000000>";
         string formattingCommandsEnd = "</color>";
         foreach (var attribute in xElement.Attributes())
         {
             switch (attribute.Name.ToString())
             {
                 case "color":
                     formattingCommandsStart += "<color=#" + attribute.Value + ">";
                     formattingCommandsEnd = "</color>" + formattingCommandsEnd;
                     break;
                 case "alpha":
                     formattingCommandsStart += "<alpha=#" + attribute.Value + ">";
                     formattingCommandsEnd = "<alpha=#FF>" + formattingCommandsEnd;
                     break;
                 case "font":
                     Debug.Log(attribute.Value);
                     SM4UIMainTextfield.instance.textfield.font = Resources.Load<TMP_FontAsset>(attribute.Value);
                     break;
                 case "italic":
                     formattingCommandsStart += "<i>";
                     formattingCommandsEnd = "</i>" + formattingCommandsEnd;
                     break;
                 case "bold":
                     formattingCommandsStart += "<b>";
                     formattingCommandsEnd = "</b>" + formattingCommandsEnd;
                     break;
                 case "relativeFontSize":
                     formattingCommandsStart += "<size=" + attribute.Value + ">";
                     formattingCommandsEnd = "<size=100%>" + formattingCommandsEnd;
                     break;
                 case "indent":
                     formattingCommandsStart += "<indent=" + attribute.Value + ">";
                     formattingCommandsEnd = "</indent>" + formattingCommandsEnd;
                     break;
                 case "characterSpacing":
                     formattingCommandsStart += "<cspace=" + attribute.Value + ">";
                     formattingCommandsEnd = "</cspace>" + formattingCommandsEnd;
                     break;
                 case "mark":
                     formattingCommandsStart += "<mark=#" + attribute.Value + ">";
                     formattingCommandsEnd = "</mark>" + formattingCommandsEnd;
                     break;
                 case "capitalization":
                     formattingCommandsStart += "<" + attribute.Value + ">";
                     formattingCommandsEnd = "</" + attribute.Value + ">" + formattingCommandsEnd;
                     break;
                 case "subscript":
                     formattingCommandsStart += "<sub>";
                     formattingCommandsEnd = "</sub>" + formattingCommandsEnd;
                     break;
                 case "supscript":
                     formattingCommandsStart += "<sup>";
                     formattingCommandsEnd = "</sup>" + formattingCommandsEnd;
                     break;
                 case "verticalOffset":
                     formattingCommandsStart += "<voffset=" + attribute.Value + ">";
                     formattingCommandsEnd = "</voffset>" + formattingCommandsEnd;
                     break;
                 case "strikethrough":
                     formattingCommandsStart += "<s>";
                     formattingCommandsEnd = "</s>" + formattingCommandsEnd;
                     break;
                 case "underline":
                     formattingCommandsStart += "<u>";
                     formattingCommandsEnd = "</u>" + formattingCommandsEnd;
                     break;
                 case "horizontalPosition":
                     formattingCommandsStart += "<pos=" + attribute.Value + ">";
                     //formattingCommandsEnd = "</>" + formattingCommandsEnd;
                     break;
                 case "lineHeight":
                     formattingCommandsStart += "<line-height=" + attribute.Value + ">";
                     formattingCommandsEnd = "</line-height>" + formattingCommandsEnd;
                     break;
                 case "align":
                     formattingCommandsStart += "<align=" + attribute.Value + ">";
                     formattingCommandsEnd = "</align>" + formattingCommandsEnd;
                     break;
             } 
         }

         string[] formats = new string[2];
         formats[0] = formattingCommandsStart;
         formats[1] = formattingCommandsEnd;

         return formats;
     }

     public void GetPersonSpeakAttributes(PersonSpeakAttributes personSpeak, XElement xElement, string text)
     {
         personSpeak.text = text;
         foreach (var attribute in xElement.Attributes())
         {
             switch (attribute.Name.ToString())
             {
                case "person":
                    personSpeak.personName = attribute.Value;
                    break;
                case "person-ID":
                    personSpeak.personID = Int32.Parse(attribute.Value);
                    break; 
                case "colorName":
                    personSpeak.color = attribute.Value;
                    break;
                case "boldName":
                    personSpeak.bold = Convert.ToBoolean(attribute.Value);
                    break;
                case "italicName":
                    personSpeak.italic = Convert.ToBoolean(attribute.Value);
                    break;
             }
         }
         
         
     }


     public ImageAttributes GetImageAttributes(XElement xElement)
     {
         ImageAttributes imageAttributes = new ImageAttributes();
         foreach (var attribute in xElement.Attributes())
         {
             switch (attribute.Name.ToString())
             {
                 case "path":
                     imageAttributes.path = Application.streamingAssetsPath + attribute.Value;
                     break;
                 case "layer":
                     imageAttributes.layer = Int32.Parse(attribute.Value); 
                     break;
                 case "fit":
                     imageAttributes.fit = bool.Parse(attribute.Value); 
                     break;
                 case "fill":
                     imageAttributes.fill = bool.Parse(attribute.Value); 
                     break;
                 case "scaleX":
                     imageAttributes.scale.x = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "scaleY":
                     imageAttributes.scale.y = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "positionX":
                     imageAttributes.position.x = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "positionY":
                     imageAttributes.position.y = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "rotationX":
                     imageAttributes.rotation.x = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "rotationY":
                     imageAttributes.rotation.y = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "rotationZ":
                     imageAttributes.rotation.z = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "colorR":
                     imageAttributes.color.r = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "colorG":
                     imageAttributes.color.g = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "colorB":
                     imageAttributes.color.b = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
                 case "alpha":
                     imageAttributes.color.a = float.Parse(attribute.Value, CultureInfo.InvariantCulture); 
                     break;
             }
         }

         return imageAttributes;
     }
     
     
}
