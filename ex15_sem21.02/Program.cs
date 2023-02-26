//string url = "https://gb.ru/lessons/304680"
//string html = new HttpClient().GetStringAsync(url).Result;
//File.WriteAllText("ggekbrains.html", html);

string GetHtml(string url, string path)
{
  string html = String.Empty;
  if (!File.Exists(path))
  {
    html = new HttpClient().GetStringAsync(url).Result;
    File.WriteAllText(path, html);
  }
  else
  {
    html = File.ReadAllText(path);
  }
  return html;
}

string url = "https://m.vk.com";
string localPath = "vkcom.html";

string html = GetHtml(url, localPath); //скачали или создали файл с кодом с сайта

//System.Console.WriteLine(html);
//s.IndexOf находим позицию начального символа текста в числовом выражении
 //s.Substring // находим кусок текста определенной длины от точки положения начального символа текста.
 string s = File.ReadAllText(localPath);
 
 string start = "<title>";
 string finish = "</title>";

 System.Console.WriteLine(s.IndexOf(start));
System.Console.WriteLine(s.IndexOf(finish));

 
 int size = start.Length;

 System.Console.WriteLine(s.Substring(1801+size, 45-size));