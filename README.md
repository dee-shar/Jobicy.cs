# Jobicy.cs
Web-API for [jobicy.com](https://jobicy.com/) which provides access to the latest remote job listings from a diverse range of industries and companies

```cs
using JobicyApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Jobicy();
            string jobs = await api.GetRemoteJobs();
            Console.WriteLine(jobs);
        }
    }
}
```
