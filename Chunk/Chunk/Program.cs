using Chunk;

var p = Repo.LoadEmployees();
var a = p.Chunk(2).ToList();
for (int i = 0; i < a.Count; i++)
{
    a[i].Print($"Chunk #{i + 1}");
}
