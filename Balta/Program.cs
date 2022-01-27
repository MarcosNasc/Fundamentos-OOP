using Balta.ContentContext;
using Balta.ContentContext.Enums;
using Balta.SubscriptionContext;

namespace Balta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigos sobre C#", "Artigos-csharp"));
            articles.Add(new Article("Artigos sobre OOP", "Artigos-oop"));
            articles.Add(new Article("Artigos sobre .NET", "Artigos-dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp", EContentLevel.Beginner);
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop", EContentLevel.Fundamental);
            var courseAspnet = new Course("Fundamentos .NET", "fundamentos-dotnet", EContentLevel.Intermediary);

            courses.Add(courseCsharp);
            courses.Add(courseOOP);
            courses.Add(courseAspnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Desenvolvedor .NET Backend", "desenvolvedor-net");
            var careerItem2 = new CareerItem(2, "Fundamentos da OOP", "curso de oop", courseOOP);
            var careerItem1 = new CareerItem(1, "Fundamentos do C#", "curso csharp", null);
            var careerItem3 = new CareerItem(3, "Fundamentos ASP.NET", "curso asp.net", courseAspnet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(i => i.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title}");
                    Console.WriteLine($"{item.Course?.Level}");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }

                    var payPalSubscription = new PayPalSubscription();
                    var student = new Student();
                    student.CreateSubscriptions(payPalSubscription);
                }
            }
        }

    }
}
