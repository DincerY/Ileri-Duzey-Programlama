﻿Server server = new();
if (server >> 3)
{
}

if (server << 1)
{
}

class Server
{
    private static void Download(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file downloaded");
        }
    }

    private static void Upload(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file uploaded");
        }
    }
    /// <summary>
    /// çift parametreli olmasının sebebi operatorun sağına ve soluna değişken almasıdır
    /// ayrıca oluşturulsuğu classın kendisinide parametreden almak zorundadır
    /// </summary>
    /// <param name="server"></param>
    /// <param name="fileCount"></param>
    /// <returns></returns>
    public static bool operator <<(Server server,int fileCount) 
    {
        Download(fileCount);
        return true;
    }
    public static bool operator >>(Server server,int fileCount)
    {
        Upload(fileCount);
        return true;
    }
}
