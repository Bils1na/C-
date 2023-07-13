using System.Linq;

int a = 12;
System.Console.WriteLine(a.GetType().Name);

var b = 12;
System.Console.WriteLine(b.GetType().Name);

var data = new int[] { 1, 2, 3, 4, 5 }
        .Where(e => e > 0)
        .Select(e => new { q = e, w = e + 1 });
System.Console.WriteLine(data.GetType().Name);