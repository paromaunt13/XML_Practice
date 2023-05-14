/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте XML файл, который соответствовал бы
следующим требованиям:
1. имя файла: TelephoneBook.xml
2. корневой элемент: “MyContacts”
3. тег “Contact”, и в нем должно быть записано имя контакта и атрибут
“TelephoneNumber”
со значением номера телефона.
(* использовать программное создание XML файла)
*/
using System.Xml;
using System.Xml.Linq;

#region Создание файла
XDocument telephoneBook = new XDocument( 
    new XElement("MyContacts",
    new XElement("Contact",
        new XElement("Name", "Roman"),
        new XElement("PhoneNumber", "0997731914"))));
telephoneBook.Save("TelephoneBook.xml");

Console.WriteLine("Файл успешно создан");
#endregion

Console.WriteLine(new string('-', 40));

#region Отображение содержимого файла
XmlDocument document = new XmlDocument();
document.Load("TelephoneBook.xml");
Console.WriteLine("Содержимое файла:");
Console.WriteLine(document.DocumentElement.Name);
Console.WriteLine(document.DocumentElement.InnerText);
Console.WriteLine(document.DocumentElement.InnerXml);
#endregion

Console.WriteLine(new string('-', 40));

#region Отображение только номера телефона
var doc = XDocument.Load("TelephoneBook.xml");
var phoneNumber = doc.Element("MyContacts")
                 .Element("Contact")
                 .Element("PhoneNumber");
Console.WriteLine("Номер телефона: " + phoneNumber.Value); 
#endregion


