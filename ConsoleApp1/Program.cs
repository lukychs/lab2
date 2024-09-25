public class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument() {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

public class ProDocumentWorker:DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отреактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }

}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}


class Progam
{
    static void Main(string[] args)
    {
        string key;
        Console.Write("Введите номер ключа доступа (pro/exp): ");
        key = Console.ReadLine();

        DocumentWorker documentWorker;

        switch (key)
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument(); 
    }
}