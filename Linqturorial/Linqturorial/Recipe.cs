namespace Linqturorial
{
class Recipe{
 public int Id { get; set; }
 public string Name { get; set; }

}
class Review{
    public int Recipeid { get; set; }   
    public string ReviewText { get; set; }
}
}
