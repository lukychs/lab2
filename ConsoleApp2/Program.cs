public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Информация об ученике(ах):");
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Ученик {i + 1}:");
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
            Console.WriteLine();
        }
    }
}

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Учится");
    }

    public virtual void Read()
    {
        Console.WriteLine("Читает");
    }

    public virtual void Write()
    {
        Console.WriteLine("Пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Отдыхает");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отлично учится");
    }

    public override void Read()
    {
        Console.WriteLine("Много читает");
    }

    public override void Write()
    {
        Console.WriteLine("Много пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Мало отдыхает");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошо учится");
    }

    public override void Read()
    {
        Console.WriteLine("Читает книги");
    }

    public override void Write()
    {
        Console.WriteLine("Часто пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Иногда отдыхает");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Плохо учится");
    }

    public override void Read()
    {
        Console.WriteLine("Мало читает");
    }

    public override void Write()
    {
        Console.WriteLine("Не хочет писать");
    }

    public override void Relax()
    {
        Console.WriteLine("Много отдыхает");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new Pupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.PrintInfo();
    }
}