// void Method1()
// {
//  Console.WriteLine ("Author: ");
// }
// Method1();

//void Method2(string msg)
//{
//Console.WriteLine(msg);
//}
//("Текст сообщения: ");

//void Method2(string msg, int count)
//{
//int i = 0;
//while (i<count)
//{
// Console.WriteLine(msg);
//i++;
//}

//}
//("Текст сообщения: ", 4);

//int Method3() => DateTime.Now.Year;
//int Year = Method3();
//Console.WriteLine(Year);


string Method4(int count, string text)

    {
         int i = 0;
            string result = string.Empty;
            
            while (i < count)
            {
                result = result + text;
                i++;
            }

            return result;
        }
        string res = Method4(10, "h");
        Console.WriteLine(res);