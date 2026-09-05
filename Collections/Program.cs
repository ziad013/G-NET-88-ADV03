namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager

            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine($"Grades: {string.Join(", ", grades)}");
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Element: {grades[0]}");
            //Console.WriteLine($"Last Element: {grades[^1]}");
            //grades.Sort();
            //Console.WriteLine($"Grades After Sorted: {string.Join(", ", grades)}");
            //List<int> above90 = grades.FindAll( x => x > 90 );
            //Console.WriteLine($"Grades Greater Than 90: {string.Join(", ", above90)}");
            //List<int> failingGrades = grades.FindAll(x => x < 75);
            //Console.WriteLine($"Grades Less Than 75: {string.Join(", ", failingGrades)}");
            //grades.RemoveAll(x => x < 75);
            //Console.WriteLine(grades.Contains(100));
            //List<string> strinList = grades.ConvertAll(x => $"Grade: {x}");
            //Console.WriteLine($"Grades As Strings: {string.Join(", ", strinList)}");

            #endregion
            #region Exercise 2: Leaderboard

            //SortedList<int, string> scores = new SortedList<int, string>();

            //scores.Add(500, "Ahmed");
            //scores.Add(200, "Sara");
            //scores.Add(800, "Ali");
            //scores.Add(350, "Mona");

            //foreach (KeyValuePair<int, string> pair in scores)
            //{
            //    Console.WriteLine($"[{pair.Key}] : {pair.Value}");
            //}

            //Console.WriteLine($"First Key: {scores.Keys[0]} , First Value: {scores.Values[0]}");

            //Console.WriteLine(scores.ContainsKey(500));

            //if (scores.TryGetValue(999, out string value))
            //{
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}


            //scores.Remove(200);

            //Console.WriteLine("---List After Remove---");
            //foreach (KeyValuePair<int, string> pair in scores)
            //{
            //    Console.WriteLine($"[{pair.Key}] : {pair.Value}");
            //}

            #endregion
            #region Exercise 3: Phone Book

            //Dictionary<string,int> contacts = new Dictionary<string, int>(4);

            //contacts["Ziad"] = 123456789;
            //contacts["Ali"] =  287387638;
            //contacts["Sama"] = 624368738;
            //contacts["Mona"] = 733683155;
            //try
            //{
            //    contacts.Add("Ziad", 123456789);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //if (contacts.TryAdd("Ziad", 123456789))
            //{
            //    Console.WriteLine("Added Successfully");
            //}

            //Console.WriteLine(contacts.GetValueOrDefault("Ahmed"));

            // if (contacts.TryGetValue("Ahmed", out int value))
            // {
            //     Console.WriteLine(value);
            // }
            // else
            // {
            //     Console.WriteLine("Not found");
            // }

            // string result = contacts.GetValueOrDefault("Ahmed").ToString();

            // if (result == "0")
            // {
            //     result = "Not Found";
            // }

            //Console.WriteLine(result);

            //Console.WriteLine(string.Join(" ", contacts.Keys));
            //Console.WriteLine(string.Join(" ", contacts.Values));
            #endregion
            #region Exercise 4: Unique Email Validator

            //HashSet<string> names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //names.Add("ahmed@test.com");
            //names.Add("AHMED@test.com");
            //names.Add("sara@test.com");
            //names.Add("Sara@Test.Com");
            //Console.WriteLine($"Count: {names.Count}");
            ////2 because Not count(the same name with different in ubber or lower case) 

            //HashSet<int> SetA = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //    HashSet<int> SetB = new HashSet<int>() { 4, 5, 6, 7, 8 };

            //    HashSet<int> union = new HashSet<int>(SetA);
            //    union.UnionWith(SetB);

            //    HashSet<int> intersection = new HashSet<int>(SetA);
            //    intersection.IntersectWith(SetB);

            //    HashSet<int> except = new HashSet<int>(SetA);
            //    except.ExceptWith(SetB);

            //    Console.WriteLine($"Union: {string.Join(", ", union)}");
            //    Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
            //    Console.WriteLine($"Except: {string.Join(", ", except)}");

            //    HashSet<int> SetC = new HashSet<int>() { 1, 2 };

            //    Console.WriteLine($"IsSubset: {SetC.IsSubsetOf(SetA)}");

            #endregion
            #region Exercise 5: Print Queue Simulator

            //Queue<string> documents = new Queue<string>();

            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.docx");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.jpg");

            ////foreach (string document in documents) 
            ////{
            ////    Console.WriteLine(document);
            ////}
            ////Console.WriteLine($"Count: {documents.Count}");
            ////Console.WriteLine($"Peek: {documents.Peek()}");
            //while (documents.Count > 0)
            //{
            //    string document = documents.Dequeue();
            //    Console.WriteLine($"Printing: {document}");
            //}

            //if (documents.TryDequeue(out string value))
            //{
            //    Console.WriteLine(value); 
            //}else
            //{
            //    Console.WriteLine("Queue is empty");
            //}
            #endregion
            #region Exercise 6: Browser History (Undo)
            //Stack<string> URLs = new Stack<string>();

            //URLs.Push("google.com");
            //URLs.Push("github.com");
            //URLs.Push("stackoverflow.com");
            //URLs.Push("youtube.com");
            //URLs.Push("claude.ai");

            //Console.WriteLine($"Peek: {URLs.Peek()}");

            //Console.WriteLine($"Leave From: {URLs.Pop()}");
            //Console.WriteLine($"Leave From: {URLs.Pop()}");
            //Console.WriteLine($"Leave From: {URLs.Pop()}");

            //Console.WriteLine($"Peek: {URLs.Peek()}");

            //if (URLs.TryPop(out string value))
            //{
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty");
            //}
            #endregion
        }
    }
}
