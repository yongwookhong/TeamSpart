internal class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Player
{
    int Lv = 1;
    string Job = "전사";
    float Atk = 10;
    float Def = 5;
    float Hp = 100;
    int Gold = 1500;
    float M_Hp ;
    float Exp ;
    float M_Exp ;

    public void Status()
    {
        Console.WriteLine("상태보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine("");
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