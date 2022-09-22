namespace ConsoleApp1
{
    public class GridFormatter<T>
    {
        public GridFormatter(IEnumerable<T> data)
        {
            //this.Data = data;
        }

        private IList<T> Data { get; }
    }
}
