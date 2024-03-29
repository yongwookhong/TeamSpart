﻿internal class Program
{
    static void Main(string[] args)
    {
        Player.AddPlayer();
    }
}

class Item
{
    public string Name { get; set; }    
    public int price { get; set; } 
    public string Description { get; set; }
    public bool Equipped { get; set; }

    public Item(string name, int price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
        Equipped = false;   

    }
    
    }

}

class Player
{
    string Name { get; set; }
    int Lv = 1;
    string Job = "전사";
    float Atk = 10;
    float Def = 5;
    float Hp = 100;
    int Gold = 1500;
    float M_Hp ;
    float Exp ;
    float M_Exp ;
    public Player(string name, string job)
    {
        Name = name;
        Job = job;
    }
    public List<Item> playerItem = new List<Item>();

    public static void AddPlayer()
    {
        Console.WriteLine("캐릭터 이름을 입력하여 주십시오.");
        string name = Console.ReadLine();
        Console.WriteLine("직업을 입력하여 주십시오.");
        string job = Console.ReadLine();
        new Player(name, job);
    }
    public void Status()
    {
        Console.WriteLine("상태보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine("");
        Console.WriteLine($"이름. {Name}");
        Console.WriteLine($"Lv. {Lv}");
        Console.WriteLine($"Chad({Job})");
        Console.WriteLine($"공격력:{Atk}");
        Console.WriteLine($"방어력:{Def}");
        Console.WriteLine($"체력:{Hp}");
        Console.WriteLine($"Gold:{Gold}");
        Console.WriteLine("");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해 주세요.");
        Console.Write(">>");
    }
    
}

class Monster
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }

    public Monster(string name, int level, int hP, int aTK)
    {
        Name = name;
        Level = level;
        HP = hP;
        ATK = aTK;
    }
    public void addMon1()
    {
        new Monster("미니언", 2, 15, 5);
    }
    public void addMon2()
    {
        new Monster("공허충", 3, 10, 9);
    }
    public void addMon3()
    {
        new Monster("대포미니언", 5, 25, 8);
    }
}