namespace MyRecipe.Models
{
    public class ResultOutputData<T>
    {
        public long TotalCount { get; set; }

        public T ResultSet { get; set; }
    }
}
