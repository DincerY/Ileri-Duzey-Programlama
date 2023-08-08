Server server = new();
if (server >> 3)
{
}

if (server << 1)
{
}

class Server
{
    public static void Download(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file downloaded");
        }
    }

    public static void Upload(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file uploaded");
        }
    }

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
