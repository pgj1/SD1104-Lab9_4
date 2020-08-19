using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lab9_4_DynamicHTML
{
    class Header
    {
        public const string h1open = "<h1 style = 'color: darkblue'>";
        public const string h1close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(h1open, text, h1close, "\n");
            return header;
        }
    }

    class Body
    {
        public const string bOpen = "< title > Lab 9.5 </ title > \n <body> \n";
        public const string bClose = "</body> \n";

        public string OpenBody(string text)
        {
            string body = String.Concat(bOpen, text, "\n");
            return body;
        }
    }

    class List
    {
        public const string liOpen = "<li style = 'font-size: 12pt'>";
        public const string liClose = "</li> \n";
        public const string ulOpen = "<ul>";
        public const string ulClose = "</ul> \n";
        public const string olOpen = "<ol>";
        public const string olClose = "</ol> \n";

        public string CreateListItem(string text)
        {
            string listItem = String.Concat(liOpen, text, liClose, "\n");
            return listItem;
        }

        
        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            //sb.Append("< title > Lab 9.5 </ title >");
            sb.Append(ulOpen);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(ulClose);

            return sb;
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string filename = @"D:\_ACT\ACT_Web-App_Dev\SD1104-A\_Source\Lab9_4_DynamicHTML.html";
            Header header = new Header();
            List list = new List();
            StringBuilder sb = new StringBuilder();


            //input/create h1 text
            Console.Write("Enter text for HTML header: ");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine(i + ") Type in an item to add to an unordered list: ");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append("<body style = 'background-color: aliceblue'> \n");
            sb.Append(headerElement);
            sb.Append(listElement.ToString() + "\n");
            sb.Append("</body> \n");

            File.AppendAllText(filename, sb.ToString());


                     
/* Hide broken/unused code **********************************
            // create the HTML File.

            StringBuilder htmlText = new StringBuilder();
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string pOpen = "<p>";
            string pClose = "</p>";
            Console.WriteLine("Input something for HTML file:");
            string user = Console.ReadLine();

            htmlText.Append(bodyOpen);
            htmlText.Append(pOpen);
            htmlText.Append(user);
            htmlText.Append(pClose);
            htmlText.Append(bodyClose);
            // FileWriter create = new CreateHTML();
            // CreateHTML create = new CreateHtml();
            // create.CreateHTML(htmlText);
            // fileWriter.CreateHTML(htmlText);
          
********************************************************************/ 




        }
    }
}

