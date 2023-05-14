/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, которая будет использовать XML файл из предыдущего примера
выводить всю информации о данном файле на консоль.
*/


using System.Xml;

XmlDocument document = new XmlDocument();
document.Load("");

// Показ содержимого XML.
Console.WriteLine(document.InnerText);

// Оттеняем вывод
Console.WriteLine(new string('-', 20));

// Показ кода XML документа.
Console.WriteLine(document.InnerXml);