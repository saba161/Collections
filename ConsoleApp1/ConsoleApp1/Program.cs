using ConsoleApp1;

MyList<string> list = new MyList<string>();
list.AddItem("1");
list.AddItem("2");
list.AddItem("3");
list.AddItem("4");
list.AddItem("5");
list.AddItem("6");
list.AddItem("7");
list.AddItem("8");

foreach (var item in list)
{

}

Console.WriteLine(list.First());