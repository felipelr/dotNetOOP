using System;
using System.Collections.Generic;
using ProjetoOOP.ContentContext;

namespace ProjetoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "artigo-oop"));
            articles.Add(new Article("Artigo sobre C#", "artigo-chsarp"));
            articles.Add(new Article("Artigo sobre .NET", "artigo-dotnet"));

            var courseOOP = new Course("Curso OOP", "curso-oop");
            var courseCsharp = new Course("Curso C#", "curso-csharp");
            var courseDotNet = new Course("Curso .NET", "curso-dotnet");

            var carrerOOP = new Carrer("Carreira OOP", "carreira-oop");
            var carrerCsharp = new Carrer("Carreira C#", "carreira-csharp");
            var carrerDotNet = new Carrer("Carreira .NET", "carreira-dotnet");

            var carrerItem1 = new CarrerItem("Comece por aqui", "", 1, courseCsharp);
            var carrerItem2 = new CarrerItem("Aprenda OOP", "", 2, courseOOP);
            var carrerItem3 = new CarrerItem("Aprenda .NET", "", 3, courseDotNet);

            carrerDotNet.Items.Add(carrerItem2);
            carrerDotNet.Items.Add(carrerItem3);
            carrerDotNet.Items.Add(carrerItem1);

            var carrers = new List<Carrer>();
            carrers.Add(carrerDotNet);
        }
    }
}
