
List<string> ToDoList = new();

Dictionary<string, char> Borders = new Dictionary<string, char>()
{
    ["Middle"] = '-',
    ["Border"] = '|',
    ["Space"] = ' '
};

char GetBorderChar(int x,int y,int MaxX,int MaxY)
{
    if (x == MaxX - 1 | x == 0)
        return Borders["Border"];
    else
        return Borders["Middle"];
}
void Flush()
{
    Console.Clear();

    int x = 0, y = ToDoList.Count + 2;

    foreach (string item in ToDoList)
    {
        if (item.Count() > x)
            x = item.Count();

    }
    x = x + 2;
    Console.WriteLine("TO DO LIST:");

    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            int id = i - 1;
            if (i > 0 && j > 0 && j != x-1 && i != y-1)
            {
                

                if( id >= 0) {
                    string message = ToDoList[id];
                    int left = x - message.Count() - 2;
                    string spacing = "";

                    for (int h = 0; h < left; h++)
                    {
                        spacing += " ";
                    }

                    Console.Write(message);
                    Console.Write(spacing + Borders["Border"]);
                    break;
                }
                else
                    Console.Write(Borders["Space"]);
            }
            else
                Console.Write(GetBorderChar(j,i,x,y));
        }
        Console.WriteLine("");
    }

}
void AddNewTask(string task)
{
    if (task != null)
        ToDoList.Add(task);
    Flush();
}

void RemoveTask(int id)
{
    ToDoList.RemoveAt(id);
    Flush();
}

//void RemoveTask(string Task)
//{
//    ToDoList.Remove(Task);
//    Flush();
//}

AddNewTask("drink water");
AddNewTask("go for a walk");
AddNewTask("feed the dog");
AddNewTask("take a shower");
AddNewTask("steal the moon");
AddNewTask("eat");

RemoveTask(1);